using System.ComponentModel;

namespace Combat_Manager
{
    partial class CombatSelectionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.playerBox = new System.Windows.Forms.CheckedListBox();
            this.npcBox = new System.Windows.Forms.CheckedListBox();
            this.buttonStartCombat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerBox
            // 
            this.playerBox.FormattingEnabled = true;
            this.playerBox.Location = new System.Drawing.Point(40, 61);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(256, 304);
            this.playerBox.TabIndex = 0;
            // 
            // npcBox
            // 
            this.npcBox.FormattingEnabled = true;
            this.npcBox.Location = new System.Drawing.Point(490, 61);
            this.npcBox.Name = "npcBox";
            this.npcBox.Size = new System.Drawing.Size(256, 304);
            this.npcBox.TabIndex = 1;
            // 
            // buttonStartCombat
            // 
            this.buttonStartCombat.Location = new System.Drawing.Point(326, 380);
            this.buttonStartCombat.Name = "buttonStartCombat";
            this.buttonStartCombat.Size = new System.Drawing.Size(132, 40);
            this.buttonStartCombat.TabIndex = 2;
            this.buttonStartCombat.Text = "Zum Kampf";
            this.buttonStartCombat.UseVisualStyleBackColor = true;
            this.buttonStartCombat.Click += new System.EventHandler(this.buttonStartCombat_Click);
            // 
            // PnP Combat-Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartCombat);
            this.Controls.Add(this.npcBox);
            this.Controls.Add(this.playerBox);
            this.Name = "PnP Combat-Manager";
            this.Text = "PnP Combat-Manager";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonStartCombat;

        private System.Windows.Forms.CheckedListBox npcBox;

        private System.Windows.Forms.CheckedListBox playerBox;

        #endregion
    }
}