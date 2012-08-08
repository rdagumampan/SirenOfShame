﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SirenOfShame.Lib.Settings;
using SirenOfShame.Lib.Watcher;
using SirenOfShame.Lib.Helpers;

namespace SirenOfShame
{
    public partial class ViewBuilds : UserControl
    {
        private class BuildStatusDtoAndControl
        {
            public BuildStatusDto BuildStatusDto { get; set; }
            public ViewBuildBase Control { get; set; }
        }

        private SirenOfShameSettings _settings;

        public ViewBuilds()
        {
            InitializeComponent();

            _prettyDateTimer.Interval = 20000;
            _prettyDateTimer.Tick += PrettyDateTimerOnTick;
            _prettyDateTimer.Start();
        }

        private void PrettyDateTimerOnTick(object sender, EventArgs eventArgs)
        {
            GetViewBuilds().ToList().ForEach(i => i.RecalculatePrettyDate());
        }

        private readonly Timer _prettyDateTimer = new Timer();

        public void RefreshBuildStatuses(RefreshStatusEventArgs args)
        {
            var buildStatusDtos = args.BuildStatusDtos.ToList();
            var buildStatusDtosAndControl = GetBuildStatusDtoAndControls(buildStatusDtos).ToList();
            RemoveAllChildControlsIfBuildCountOrBuildNamesChanged(buildStatusDtosAndControl, buildStatusDtos);
            if (NoChildControlsExist)
            {
                CreateControlsAndAddToPanels(buildStatusDtos);
            }
            else
            {
                UpdateDetailsInExistingControls(buildStatusDtosAndControl);
            }
            InitializeDisplayModes();
        }

        private void InitializeDisplayModes()
        {
            int smallControlCount = GetIdealSmallControlCount();
            var controls = GetViewBuilds().ToList();
            for (int i = 0; i < controls.Count; i++)
            {
                var control = controls[i];
                var mode = i < smallControlCount ? ViewBuildDisplayMode.Normal : ViewBuildDisplayMode.Tiny;
                control.SetDisplayMode(mode);
            }
        }

        private void RemoveAllChildControlsIfBuildCountOrBuildNamesChanged(List<BuildStatusDtoAndControl> buildStatusDtosAndControl, List<BuildStatusDto> buildStatusDtos)
        {
            bool numberOfBuildsChanged = ViewBuildsCount != 0 && ViewBuildsCount != buildStatusDtos.Count();
            var anyBuildNameChanged = buildStatusDtosAndControl.Count != buildStatusDtos.Count;
            if (numberOfBuildsChanged || anyBuildNameChanged)
            {
                RemoveAllChildControls();
            }
        }

        private bool NoChildControlsExist
        {
            get { return ViewBuildsCount == 0; }
        }

        private void RemoveAllChildControls()
        {
            _mainFlowLayoutPanel.ClearAndDispose();
        }

        private IEnumerable<BuildStatusDtoAndControl> GetBuildStatusDtoAndControls(IEnumerable<BuildStatusDto> buildStatusDtos)
        {
            return from control in GetViewBuilds()
                   join buildStatusDto in buildStatusDtos on control.BuildName equals buildStatusDto.Name
                   orderby buildStatusDto.LocalStartTime descending 
                   select new BuildStatusDtoAndControl { Control = control, BuildStatusDto = buildStatusDto };
        }

        private void UpdateDetailsInExistingControls(List<BuildStatusDtoAndControl> buildStatusDtosAndControl)
        {
            for (int i = 0; i < buildStatusDtosAndControl.Count; i++)
            {
                var buildStatusAndControl = buildStatusDtosAndControl[i];
                buildStatusAndControl.Control.UpdateListItem(buildStatusAndControl.BuildStatusDto);
                _mainFlowLayoutPanel.Controls.SetChildIndex(buildStatusAndControl.Control, i);
            }
        }

        private void CreateControlsAndAddToPanels(IEnumerable<BuildStatusDto> buildStatusDtos)
        {
            var buildsOrdered = buildStatusDtos
                .OrderByDescending(i => i.LocalStartTime)
                .ToList();

            buildsOrdered
                .Select(i => new ViewBuildSmall(i, _settings))
                .ToList()
                .ForEach(i => _mainFlowLayoutPanel.Controls.Add(i));
        }

        private int GetIdealSmallControlCount()
        {
            const int margin = 4;
            return ((_mainFlowLayoutPanel.Width) / (margin + ViewBuildSmall.WIDTH + margin) * 2);
        }

        private void ViewBuildsResize(object sender, EventArgs e)
        {
            InitializeDisplayModes();
        }
        
        private int ViewBuildsCount
        {
            get { return _mainFlowLayoutPanel.Controls.Count; }
        }

        private IEnumerable<ViewBuildSmall> GetViewBuilds()
        {
            return _mainFlowLayoutPanel.Controls.Cast<ViewBuildSmall>();
        }

        public void Initialize(SirenOfShameSettings settings)
        {
            _settings = settings;
        }
    }
}
