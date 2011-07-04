﻿namespace SirenOfShame
{
    partial class TimeboxEnforcer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._duration = new System.Windows.Forms.TrackBar();
            this._durationText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._timeboxAudio = new System.Windows.Forms.ComboBox();
            this._timeboxLights = new System.Windows.Forms.ComboBox();
            this._start = new System.Windows.Forms.Button();
            this._countdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._duration)).BeginInit();
            this.SuspendLayout();
            // 
            // _close
            // 
            this._close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._close.Location = new System.Drawing.Point(554, 180);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(75, 23);
            this._close.TabIndex = 0;
            this._close.Text = "Close";
            this._close.UseVisualStyleBackColor = true;
            this._close.Click += new System.EventHandler(this.CloseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duration";
            // 
            // _duration
            // 
            this._duration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._duration.Location = new System.Drawing.Point(65, 16);
            this._duration.Maximum = 60;
            this._duration.Minimum = 1;
            this._duration.Name = "_duration";
            this._duration.Size = new System.Drawing.Size(564, 45);
            this._duration.TabIndex = 3;
            this._duration.Value = 5;
            this._duration.ValueChanged += new System.EventHandler(this.DurationValueChanged);
            // 
            // _durationText
            // 
            this._durationText.AutoSize = true;
            this._durationText.Location = new System.Drawing.Point(62, 48);
            this._durationText.Name = "_durationText";
            this._durationText.Size = new System.Drawing.Size(54, 13);
            this._durationText.TabIndex = 4;
            this._durationText.Text = "X Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do What";
            // 
            // _timeboxAudio
            // 
            this._timeboxAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._timeboxAudio.FormattingEnabled = true;
            this._timeboxAudio.Location = new System.Drawing.Point(195, 75);
            this._timeboxAudio.Name = "_timeboxAudio";
            this._timeboxAudio.Size = new System.Drawing.Size(121, 21);
            this._timeboxAudio.TabIndex = 12;
            // 
            // _timeboxLights
            // 
            this._timeboxLights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._timeboxLights.FormattingEnabled = true;
            this._timeboxLights.Location = new System.Drawing.Point(68, 75);
            this._timeboxLights.Name = "_timeboxLights";
            this._timeboxLights.Size = new System.Drawing.Size(121, 21);
            this._timeboxLights.TabIndex = 11;
            // 
            // _start
            // 
            this._start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._start.Location = new System.Drawing.Point(473, 180);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(75, 23);
            this._start.TabIndex = 13;
            this._start.Text = "Start";
            this._start.UseVisualStyleBackColor = true;
            this._start.Click += new System.EventHandler(this.StartClick);
            // 
            // _countdown
            // 
            this._countdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._countdown.AutoSize = true;
            this._countdown.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._countdown.Location = new System.Drawing.Point(12, 131);
            this._countdown.Name = "_countdown";
            this._countdown.Size = new System.Drawing.Size(161, 75);
            this._countdown.TabIndex = 14;
            this._countdown.Text = "0:00";
            // 
            // TimeboxEnforcer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 215);
            this.Controls.Add(this._countdown);
            this.Controls.Add(this._start);
            this.Controls.Add(this._timeboxAudio);
            this.Controls.Add(this._timeboxLights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._durationText);
            this.Controls.Add(this._duration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._close);
            this.Name = "TimeboxEnforcer";
            this.Text = "Timebox Enforcer";
            ((System.ComponentModel.ISupportInitialize)(this._duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar _duration;
        private System.Windows.Forms.Label _durationText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _timeboxAudio;
        private System.Windows.Forms.ComboBox _timeboxLights;
        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Label _countdown;
    }
}