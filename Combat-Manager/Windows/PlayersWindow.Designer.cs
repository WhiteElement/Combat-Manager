using System.ComponentModel;

namespace Combat_Manager
{
    partial class PlayersWindow
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

        private void InitializeComponent()
{
    this.label6 = new System.Windows.Forms.Label();
    this.groupBox1 = new System.Windows.Forms.GroupBox();
    this.newNpcButton = new System.Windows.Forms.Button();
    this.label4 = new System.Windows.Forms.Label();
    this.initiativeBox = new System.Windows.Forms.TextBox();
    this.label1 = new System.Windows.Forms.Label();
    this.nameBox = new System.Windows.Forms.TextBox();
    this.treeView1 = new System.Windows.Forms.TreeView();
    this.label8 = new System.Windows.Forms.Label();
    this.groupBox1.SuspendLayout();
    this.SuspendLayout();
    // 
    // label6
    // 
    this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label6.Location = new System.Drawing.Point(431, 9);
    this.label6.Name = "label6";
    this.label6.Size = new System.Drawing.Size(182, 48);
    this.label6.TabIndex = 16;
    this.label6.Text = "Players";
    // 
    // groupBox1
    // 
    this.groupBox1.Controls.Add(this.label8);
    this.groupBox1.Controls.Add(this.newNpcButton);
    this.groupBox1.Controls.Add(this.label4);
    this.groupBox1.Controls.Add(this.initiativeBox);
    this.groupBox1.Controls.Add(this.label1);
    this.groupBox1.Controls.Add(this.nameBox);
    this.groupBox1.Location = new System.Drawing.Point(39, 265);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new System.Drawing.Size(287, 175);
    this.groupBox1.TabIndex = 15;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "neuer Player";
    // 
    // newNpcButton
    // 
    this.newNpcButton.Location = new System.Drawing.Point(16, 120);
    this.newNpcButton.Name = "newNpcButton";
    this.newNpcButton.Size = new System.Drawing.Size(130, 32);
    this.newNpcButton.TabIndex = 0;
    this.newNpcButton.Text = "anlegen";
    this.newNpcButton.UseVisualStyleBackColor = true;
    this.newNpcButton.Click += new System.EventHandler(this.newNpcButton_Click);
    // 
    // label4
    // 
    this.label4.Location = new System.Drawing.Point(20, 68);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(55, 15);
    this.label4.TabIndex = 8;
    this.label4.Text = "Initiative *";
    // 
    // initiativeBox
    // 
    this.initiativeBox.Location = new System.Drawing.Point(16, 83);
    this.initiativeBox.Name = "initiativeBox";
    this.initiativeBox.Size = new System.Drawing.Size(147, 20);
    this.initiativeBox.TabIndex = 7;
    // 
    // label1
    // 
    this.label1.Location = new System.Drawing.Point(20, 30);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(46, 15);
    this.label1.TabIndex = 2;
    this.label1.Text = "Name *";
    // 
    // nameBox
    // 
    this.nameBox.Location = new System.Drawing.Point(16, 45);
    this.nameBox.Name = "nameBox";
    this.nameBox.Size = new System.Drawing.Size(147, 20);
    this.nameBox.TabIndex = 1;
    // 
    // treeView1
    // 
    this.treeView1.Location = new System.Drawing.Point(431, 60);
    this.treeView1.Name = "treeView1";
    this.treeView1.Size = new System.Drawing.Size(331, 364);
    this.treeView1.TabIndex = 14;
    // 
    // label8
    // 
    this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label8.Location = new System.Drawing.Point(211, 160);
    this.label8.Name = "label8";
    this.label8.Size = new System.Drawing.Size(70, 12);
    this.label8.TabIndex = 14;
    this.label8.Text = "* = Plfichtfeld";
    // 
    // PlayersWindow
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(800, 450);
    this.Controls.Add(this.label6);
    this.Controls.Add(this.groupBox1);
    this.Controls.Add(this.treeView1);
    this.Name = "PlayersWindow";
    this.Text = "PnP Combat-Manager";
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.ResumeLayout(false);
}

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newNpcButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initiativeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TreeView treeView1;

        #endregion
    }
}