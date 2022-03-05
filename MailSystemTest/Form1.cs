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

        int y = 50;
        int ilosc = 0;
        List<Panel> panels = new List<Panel>();
        List<Label> teksty = new List<Label>();
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
            var newPanel = new Panel();
            newPanel.BackColor = Color.Gray;
            newPanel.Location = new Point(400, y);
            newPanel.Size = new Size(400, 40);
            newPanel.Name = "panelX" + ilosc.ToString();
            Controls.Add(newPanel);

            panels.Add(newPanel);
            y += 50;
            ilosc++;

            var labelNew = new Label();
            labelNew.Location = new Point(0, 0);
            labelNew.Size = new Size(667, 15);
            labelNew.Text = textBox1.Text;
            newPanel.Controls.Add(labelNew);
            teksty.Add(labelNew);

            label1.Text = "";
            int index = 0;
            foreach (var test in teksty)
            {
                if (teksty.Count == index + 1)
                {
                    return;
                }
                label1.Text += "\n(" + teksty.Count + " | " + index + ") " + test.Text;
                teksty[index].Text = teksty[index + 1].Text;
                index++;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panels[4].BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int index = 0;
            foreach (var test in teksty)
            {
                if (teksty.Count == index + 1)
                {
                    return;
                }
                label1.Text += "\n(" + teksty.Count + " | " + index + ") " + test.Text;
                teksty[index].Text = teksty[index+1].Text;
                index++;
            }
        }
    }
}
