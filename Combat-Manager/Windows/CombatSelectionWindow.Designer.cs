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
            // CombatSelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerBox);
            this.Name = "CombatSelectionWindow";
            this.Text = "CombatSelectionWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckedListBox playerBox;

        #endregion
    }
}