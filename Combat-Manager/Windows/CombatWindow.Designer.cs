using System.ComponentModel;

namespace Combat_Manager
{
    partial class CombatWindow
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeViewPlayer = new System.Windows.Forms.TreeView();
            this.treeViewNpcs = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartContinueCombat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(135, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 667);
            this.listBox1.TabIndex = 0;
            // 
            // treeViewPlayer
            // 
            this.treeViewPlayer.Location = new System.Drawing.Point(12, 26);
            this.treeViewPlayer.Name = "treeViewPlayer";
            this.treeViewPlayer.Size = new System.Drawing.Size(117, 216);
            this.treeViewPlayer.TabIndex = 1;
            // 
            // treeViewNpcs
            // 
            this.treeViewNpcs.Location = new System.Drawing.Point(457, 26);
            this.treeViewNpcs.Name = "treeViewNpcs";
            this.treeViewNpcs.Size = new System.Drawing.Size(117, 216);
            this.treeViewNpcs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(457, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "NPCs";
            // 
            // buttonStartContinueCombat
            // 
            this.buttonStartContinueCombat.Location = new System.Drawing.Point(135, 711);
            this.buttonStartContinueCombat.Name = "buttonStartContinueCombat";
            this.buttonStartContinueCombat.Size = new System.Drawing.Size(315, 39);
            this.buttonStartContinueCombat.TabIndex = 5;
            this.buttonStartContinueCombat.Text = "Start";
            this.buttonStartContinueCombat.UseVisualStyleBackColor = true;
            this.buttonStartContinueCombat.Click += new System.EventHandler(this.buttonStartContinueCombat_Click);
            // 
            // CombatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.buttonStartContinueCombat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewNpcs);
            this.Controls.Add(this.treeViewPlayer);
            this.Controls.Add(this.listBox1);
            this.Name = "CombatWindow";
            this.Text = "CombatWindow";
            this.Shown += new System.EventHandler(this.CombatWindow_Shown);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonStartContinueCombat;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TreeView treeViewPlayer;
        private System.Windows.Forms.TreeView treeViewNpcs;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}