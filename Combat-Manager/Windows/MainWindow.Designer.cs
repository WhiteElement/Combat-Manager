namespace Combat_Manager
{
    partial class MainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNpc = new System.Windows.Forms.Button();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Fight\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNpc
            // 
            this.buttonNpc.Location = new System.Drawing.Point(308, 300);
            this.buttonNpc.Name = "buttonNpc";
            this.buttonNpc.Size = new System.Drawing.Size(167, 42);
            this.buttonNpc.TabIndex = 1;
            this.buttonNpc.Text = "NPCs";
            this.buttonNpc.UseVisualStyleBackColor = true;
            this.buttonNpc.Click += new System.EventHandler(this.buttonNpc_Click);
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.Location = new System.Drawing.Point(308, 252);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(167, 42);
            this.buttonPlayer.TabIndex = 2;
            this.buttonPlayer.Text = "Players";
            this.buttonPlayer.UseVisualStyleBackColor = true;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPlayer);
            this.Controls.Add(this.buttonNpc);
            this.Controls.Add(this.button1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonNpc;
        private System.Windows.Forms.Button buttonPlayer;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}