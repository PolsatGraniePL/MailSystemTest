using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSystemTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Panel> panels = new List<Panel>();
        private void button1_Click(object sender, EventArgs e)
        {
            NewPanelCreator();


            //teksty[5].Text = teksty[4].Text;
            //teksty[4].Text = teksty[3].Text;
            //teksty[3].Text = teksty[2].Text;
            //teksty[2].Text = teksty[1].Text;

            //teksty[1].Text = teksty[4].Text;

            //label5.Text = label4.Text;
            //label4.Text = label3.Text;
            //label3.Text = label2.Text;
            //label2.Text = label1.Text;
            //label1.Text = textBox1.Text;


        }

        private void NewPanelCreator()
        {

            int index = 0;
            foreach (var test in panels)
            {
                panels[index].Location = new Point(353, panels[index].Location.Y + 50);
                index++;
            }
            var newPanel = new Panel();
            newPanel.BackColor = Color.Silver;
            newPanel.Location = new Point(353, 12);
            newPanel.Size = new Size(907, 34);
            Controls.Add(newPanel);

            panels.Add(newPanel);

            var labelNew = new Label();
            labelNew.Location = new Point(0, 8);
            labelNew.Size = new Size(240, 16);
            labelNew.Font = new Font("Arial", 9, FontStyle.Bold);
            labelNew.Text = textBox1.Text;
            newPanel.Controls.Add(labelNew);

            var labelNew2 = new Label();
            labelNew2.Location = new Point(238, 9);
            labelNew2.Size = new Size(115, 15);
            labelNew2.Font = new Font("Arial", 9);
            labelNew2.Text = textBox2.Text + " | " + textBox3.Text;
            newPanel.Controls.Add(labelNew2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panels[4].BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
