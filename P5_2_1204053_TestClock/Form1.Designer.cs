namespace P5_2_1204053_TestClock
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.UniversalTimeLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.digitalClock1 = new P5_2_1204053.DigitalClock();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Time";
            // 
            // UniversalTimeLabel
            // 
            this.UniversalTimeLabel.AutoSize = true;
            this.UniversalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversalTimeLabel.Location = new System.Drawing.Point(49, 158);
            this.UniversalTimeLabel.Name = "UniversalTimeLabel";
            this.UniversalTimeLabel.Size = new System.Drawing.Size(144, 22);
            this.UniversalTimeLabel.TabIndex = 4;
            this.UniversalTimeLabel.Text = "Universal Time";
            this.UniversalTimeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(373, 226);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(107, 45);
            this.StartStopButton.TabIndex = 5;
            this.StartStopButton.Text = "Start / Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // digitalClock1
            // 
            this.digitalClock1.LocalTimeLabel_BackColor = System.Drawing.SystemColors.ControlLight;
            this.digitalClock1.Location = new System.Drawing.Point(250, 60);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(275, 69);
            this.digitalClock1.TabIndex = 3;
            this.digitalClock1.Timer1_Enabled = true;
            this.digitalClock1.RaiseTimer1_Tick += new System.EventHandler(this.digital1Clock_RaiseTimer1_Tick);
            this.digitalClock1.Load += new System.EventHandler(this.digitalClock2_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 382);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.UniversalTimeLabel);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private P5_2_1204053.DigitalClock digitalClock1;
        private System.Windows.Forms.Label UniversalTimeLabel;
        private System.Windows.Forms.Button StartStopButton;
    }
}

