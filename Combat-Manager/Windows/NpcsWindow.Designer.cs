using System.ComponentModel;

namespace Combat_Manager
{
    partial class NpcsWindow
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
            this.newNpcButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hpBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parryBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.initiativeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newNpcButton
            // 
            this.newNpcButton.Location = new System.Drawing.Point(38, 160);
            this.newNpcButton.Name = "newNpcButton";
            this.newNpcButton.Size = new System.Drawing.Size(148, 42);
            this.newNpcButton.TabIndex = 0;
            this.newNpcButton.Text = "neuer NPC";
            this.newNpcButton.UseVisualStyleBackColor = true;
            this.newNpcButton.Click += new System.EventHandler(this.newNpcButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(38, 240);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "HP";
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(38, 278);
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(147, 20);
            this.hpBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(42, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parade";
            // 
            // parryBox
            // 
            this.parryBox.Location = new System.Drawing.Point(38, 316);
            this.parryBox.Name = "parryBox";
            this.parryBox.Size = new System.Drawing.Size(147, 20);
            this.parryBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Initiative";
            // 
            // initiativeBox
            // 
            this.initiativeBox.Location = new System.Drawing.Point(38, 354);
            this.initiativeBox.Name = "initiativeBox";
            this.initiativeBox.Size = new System.Drawing.Size(147, 20);
            this.initiativeBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(42, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kommentar";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(38, 392);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(262, 20);
            this.commentBox.TabIndex = 9;
            // 
            // NpcsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initiativeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hpBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.newNpcButton);
            this.Name = "NpcsWindow";
            this.Text = "NpcsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initiativeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox commentBox;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parryBox;

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hpBox;

        private System.Windows.Forms.Button newNpcButton;

        #endregion
    }
}