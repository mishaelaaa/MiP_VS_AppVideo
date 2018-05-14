namespace MiP_Computr_vision_V0._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Coose_File = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Mute = new System.Windows.Forms.Button();
            this.Graphics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 154);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(651, 386);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(21, 30);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(85, 45);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(110, 28);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(78, 45);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(194, 28);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(80, 45);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Coose_File
            // 
            this.Coose_File.Location = new System.Drawing.Point(498, 114);
            this.Coose_File.Name = "Coose_File";
            this.Coose_File.Size = new System.Drawing.Size(125, 23);
            this.Coose_File.TabIndex = 4;
            this.Coose_File.Text = "Choose File";
            this.Coose_File.UseVisualStyleBackColor = true;
            this.Coose_File.Click += new System.EventHandler(this.Coose_File_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Mute
            // 
            this.Mute.Location = new System.Drawing.Point(280, 28);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(85, 45);
            this.Mute.TabIndex = 6;
            this.Mute.Text = "Mute";
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Graphics
            // 
            this.Graphics.Location = new System.Drawing.Point(541, 31);
            this.Graphics.Name = "Graphics";
            this.Graphics.Size = new System.Drawing.Size(82, 42);
            this.Graphics.TabIndex = 7;
            this.Graphics.Text = "Graphics";
            this.Graphics.UseVisualStyleBackColor = true;
            this.Graphics.Click += new System.EventHandler(this.Graphics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 552);
            this.Controls.Add(this.Graphics);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Coose_File);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Coose_File;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Mute;
        private System.Windows.Forms.Button Graphics;
    }
}

