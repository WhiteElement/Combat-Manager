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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newNpcButton
            // 
            this.newNpcButton.Location = new System.Drawing.Point(14, 225);
            this.newNpcButton.Name = "newNpcButton";
            this.newNpcButton.Size = new System.Drawing.Size(130, 32);
            this.newNpcButton.TabIndex = 0;
            this.newNpcButton.Text = "anlegen";
            this.newNpcButton.UseVisualStyleBackColor = true;
            this.newNpcButton.Click += new System.EventHandler(this.newNpcButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(14, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "HP";
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(14, 78);
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(147, 20);
            this.hpBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parade";
            // 
            // parryBox
            // 
            this.parryBox.Location = new System.Drawing.Point(14, 116);
            this.parryBox.Name = "parryBox";
            this.parryBox.Size = new System.Drawing.Size(147, 20);
            this.parryBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Initiative";
            // 
            // initiativeBox
            // 
            this.initiativeBox.Location = new System.Drawing.Point(14, 154);
            this.initiativeBox.Name = "initiativeBox";
            this.initiativeBox.Size = new System.Drawing.Size(147, 20);
            this.initiativeBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kommentar";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(14, 192);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(262, 20);
            this.commentBox.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(419, 43);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(331, 379);
            this.treeView1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.commentBox);
            this.groupBox1.Controls.Add(this.newNpcButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.initiativeBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.parryBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hpBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(27, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 273);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "neuer NPC";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "NPCs";
            // 
            // NpcsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "NpcsWindow";
            this.Text = "NpcsWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TreeView treeView1;

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