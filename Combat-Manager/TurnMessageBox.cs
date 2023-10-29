using System;
using System.Drawing;
using System.Windows.Forms;

namespace Combat_Manager
{
    public partial class TurnMessageBox : Form
    {
        Label message = new Label();
        Button b1 = new Button();
        Button b2 = new Button();
        private bool shouldRun = true;
        
        public TurnMessageBox(string title, string message)
        {
            ClientSize = new System.Drawing.Size(490, 150);
            Text = title;

            b1.Location = new System.Drawing.Point(411, 112);
            b1.Size = new System.Drawing.Size(75, 23);
            b1.Text = "weiter";
            b1.BackColor = Control.DefaultBackColor;
            b1.Click += new System.EventHandler(this.button1_Click);

            b2.Location = new System.Drawing.Point(311, 112);
            b2.Size = new System.Drawing.Size(75, 23);
            b2.Text = "Kampf beenden"; 
            b2.BackColor = Control.DefaultBackColor;
            b2.Click += new System.EventHandler(this.button2_Click);

            BackColor = Color.White;
            ShowIcon = false;

            this.message.Text = message;
            
            Controls.Add(b1);
            Controls.Add(b2);
            Controls.Add(this.message);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shouldRun = false;
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ShouldAbort()
        {
            return !shouldRun;
        }
    }
}