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


        List<Panel> panele = new List<Panel>();
        private void button1_Click(object sender, EventArgs e)
        {
            PanelNormalnyCreator();


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

        private void PanelNormalnyCreator()
        {

            int index = 0;
            foreach (var test in panele)
            {
                panele[index].Location = new Point(353, panele[index].Location.Y + 50);
                index++;
            }
            var PanelNormalny = new Panel();
            PanelNormalny.BackColor = Color.Silver;
            PanelNormalny.Location = new Point(353, 12);
            PanelNormalny.Size = new Size(936, 40);
            Controls.Add(PanelNormalny);

            panele.Add(PanelNormalny);

            var LabelMail = new Label();
            LabelMail.Location = new Point(0, 8);
            LabelMail.Size = new Size(240, 16);
            LabelMail.Font = new Font("Arial", 9, FontStyle.Bold);
            LabelMail.Text = textBox1.Text;
            PanelNormalny.Controls.Add(LabelMail);

            var labelTIME = new Label();
            labelTIME.Location = new Point(800, 13);
            labelTIME.Size = new Size(170, 15);
            labelTIME.Font = new Font("Arial", 9, FontStyle.Bold);
            DateTime localDate = DateTime.Now;
            labelTIME.Text = "("+localDate.ToString("MM/dd/yyyy HH:mm:ss")+")";
            PanelNormalny.Controls.Add(labelTIME);

            string text3 = textBox3.Text.Replace(Environment.NewLine, " ");

            var LabelTekst = new Label();
            LabelTekst.Location = new Point(238, 9);
            LabelTekst.Size = new Size(100, 15);
            LabelTekst.Font = new Font("Arial", 9);
            LabelTekst.Text = textBox2.Text + " - " + text3?[0..Math.Min(text3.Length, 100)];
            PanelNormalny.Controls.Add(LabelTekst);
        }
    }
}
