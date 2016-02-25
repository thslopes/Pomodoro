namespace Pomodoro
{
    partial class FrmPomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPomodoro));
            this.Label = new System.Windows.Forms.Label();
            this.btnStSt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(111, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "label1";
            // 
            // btnStSt
            // 
            this.btnStSt.BackgroundImage = global::Pomodoro.Properties.Resources.Play_pause_button_play_stop_blue_pause;
            this.btnStSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStSt.Location = new System.Drawing.Point(155, 9);
            this.btnStSt.Name = "btnStSt";
            this.btnStSt.Size = new System.Drawing.Size(25, 25);
            this.btnStSt.TabIndex = 1;
            this.btnStSt.UseVisualStyleBackColor = true;
            this.btnStSt.Click += new System.EventHandler(this.btnStSt_Click);
            // 
            // FrmPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 43);
            this.Controls.Add(this.btnStSt);
            this.Controls.Add(this.Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPomodoro";
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.FrmPomodoro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btnStSt;
    }
}

