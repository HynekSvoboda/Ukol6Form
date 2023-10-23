using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UkolForm6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        Form f2;
        TextBox textbox1;
        Button testovaci;
        NumericUpDown x;
        NumericUpDown y;

        private void button1_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();
            f2 = new Form();

            f2.ShowIcon = false;
            f2.Text = " ";

            Label napistest = new Label();
            Button uloz = new Button();
            Button zrus = new Button();
            Button nastavFont = new Button();
            testovaci = new Button();
            textbox1 = new TextBox();
             x = new NumericUpDown();
             y = new NumericUpDown();

            x.Value = 50;
            y.Value = 50;
            textbox1.Text = "Nastav text";
            napistest.Text = "Klikni pro zkoušku:";
            uloz.Text = "Ulož";
            nastavFont.Text = "Nastav Font";
            zrus.Text = "Zruš";
            testovaci.Text = "Test";

            testovaci.Size = new Size(50, 50);
            nastavFont.Size = new Size(50, 50);
            uloz.Size = new Size(50, 50);
            zrus.Size = new Size(50, 50);
            textbox1.Size = new Size(100, 200);

            napistest.Location = new Point(110, 10);
            y.Location = new Point(10, 180);
            x.Location = new Point(10, 210);
            testovaci.Location = new Point(120, 30);
            nastavFont.Location = new Point(10, 120);
            uloz.Location = new Point(10, 10);
            zrus.Location = new Point(10, 60);
            textbox1.Location = new Point(100, 100);

            f2.Controls.Add(uloz);
            f2.Controls.Add(zrus);
            f2.Controls.Add(textbox1);
            f2.Controls.Add(testovaci);
            f2.Controls.Add(nastavFont);
            f2.Controls.Add(x);
            f2.Controls.Add(y);
            f2.Controls.Add(napistest);


            uloz.DialogResult = DialogResult.OK;
            zrus.DialogResult = DialogResult.Cancel;

            zrus.Click += zrus_Click;
            uloz.Click += uloz_Click;
            testovaci.Click += testovaci_Click;

            if (f2.DialogResult == DialogResult.OK)
            {
                uloz.Click += uloz_Click;
            }

            f2.ShowDialog();

        }

        private void zrus_Click(object sender, EventArgs e)
        {
            f2.Close();
        }

        private void uloz_Click(object sender, EventArgs e)
        {
            button1.Text = textbox1.Text;
            f2.Close();
        }
        private void testovaci_Click(object sender, EventArgs e)
        {
            testovaci.Text = textbox1.Text;
           // testovaci.Size = new Size(Convert.ToInt32(x),Convert.ToInt32(y));
        }
    }
}
