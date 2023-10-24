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
        Button pozadi;
        Button text;
        NumericUpDown x;
        NumericUpDown y;
        Button nastavFont;
        Font f = null;
        Color backcolor = Color.White;
        Color forecolor = Color.Black;
        ComboBox umistenitextu;

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            f2 = new Form();

            f2.ShowIcon = false;
            f2.Text = " ";
            f2.Size = new Size(300, 380);

            umistenitextu = new ComboBox();
            Button uloz = new Button();
            Button zrus = new Button();
            nastavFont = new Button();
            testovaci = new Button();
            textbox1 = new TextBox();
             x = new NumericUpDown();
             y = new NumericUpDown();
            Label napistest = new Label();
            Label napisrozmery = new Label();
            Label napisvyska = new Label();
            Label napissrika = new Label();

            pozadi = new Button();
            text = new Button();

            List<string> polozky = new List<string>
            {
                "TopLeft","TopCenter", "TopRight", "MiddleLeft", "MiddleCenter", "MiddleRight", "BottomLeft", "BottomCenter", "BottomRight"
            };

            umistenitextu.DataSource = polozky;
            x.Value = 100;
            y.Value = 100;
            textbox1.Text = "Nastav text";
            umistenitextu.Text = "Vyber";
            napistest.Text = "Klikni pro zkoušku:";
            napisrozmery.Text = "Nastav rozměry:";
            uloz.Text = "Ulož";
            nastavFont.Text = "Nastav Font";
            zrus.Text = "Zruš";
            testovaci.Text = "Test";
            text.Text = "Barva textu";
            pozadi.Text = "Barva pozadí";
            napissrika.Text = "Šírka:";
            napisvyska.Text = "Výška:";

            y.Maximum = 120;
            y.Minimum = 20;
            x.Maximum = 160;
            x.Minimum = 20;

            testovaci.Size = new Size(50, 50);
            nastavFont.Size = new Size(50, 50);
            uloz.Size = new Size(50, 50);
            pozadi.Size = new Size(50, 50);
            text.Size = new Size(50, 50);
            zrus.Size = new Size(50, 50);
            textbox1.Size = new Size(100, 200);
            umistenitextu.Size = new Size(80, 70);

            napistest.Location = new Point(110, 10);
            testovaci.Location = new Point(120, 30);
            nastavFont.Location = new Point(10, 120);
            napisrozmery.Location = new Point(10, 190);
            napisvyska.Location = new Point(10, 215);
            y.Location = new Point(10, 230);
            napissrika.Location = new Point(10, 255);
            x.Location = new Point(10, 270);
            uloz.Location = new Point(10, 10);
            zrus.Location = new Point(10, 60);
            textbox1.Location = new Point(150, 270);
            umistenitextu.Location = new Point(95,300);

            pozadi.Location = new Point(150,210);
            text.Location = new Point(200, 210);
             
            f2.Controls.Add(uloz);
            f2.Controls.Add(zrus);
            f2.Controls.Add(textbox1);
            f2.Controls.Add(testovaci);
            f2.Controls.Add(nastavFont);
            f2.Controls.Add(x);
            f2.Controls.Add(y);
            f2.Controls.Add(napistest);
            f2.Controls.Add(napisrozmery);
            f2.Controls.Add(napisvyska);
            f2.Controls.Add(napissrika);
            f2.Controls.Add(pozadi);
            f2.Controls.Add(text);
            f2.Controls.Add(umistenitextu);

            uloz.DialogResult = DialogResult.OK;
            zrus.DialogResult = DialogResult.Cancel;

            pozadi.Click+= pozadi_Click;
            text.Click += text_Click;
            zrus.Click += zrus_Click;
            uloz.Click += uloz_Click;
            testovaci.Click += testovaci_Click;
            nastavFont.Click+=nastavFont_Click;

            if (f2.DialogResult == DialogResult.OK)
            {
                uloz.Click += uloz_Click;
            }

            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.ShowDialog();

        }
        private void zrus_Click(object sender, EventArgs e)
        {
            f2.Close();
        }
        private void uloz_Click(object sender, EventArgs e)
        {
            button1.Text = textbox1.Text;
            button1.Size = new Size(Convert.ToInt32(x.Value), Convert.ToInt32(y.Value));
            button1.Font = f;
            button1.BackColor = backcolor;
            button1.ForeColor = forecolor;
            switch (umistenitextu.Text)
            {
                case "MiddleLeft":
                {
                    button1.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                }
                case "MiddleCenter":
                {
                    button1.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                }
                case "MiddleRight":
                {
                    button1.TextAlign = ContentAlignment.MiddleRight;
                    break;
                }
                case "BottomLeft":
                {
                    button1.TextAlign = ContentAlignment.BottomLeft;
                    break;
                }
                case "BottomCenter":
                {
                    button1.TextAlign = ContentAlignment.BottomCenter;
                    break;
                }
                case "BottomRight":
                {
                    button1.TextAlign = ContentAlignment.BottomRight;
                    break;
                }
                case "TopLeft":
                {
                    button1.TextAlign = ContentAlignment.TopLeft;
                    break;
                }
                case "TopCenter":
                {
                    button1.TextAlign = ContentAlignment.TopCenter;
                    break;
                }
                case "TopRight":
                {
                    button1.TextAlign = ContentAlignment.TopRight;
                    break;
                }
            }
            f2.Close();
        }
        private void testovaci_Click(object sender, EventArgs e)
        {
            testovaci.Text = textbox1.Text;
            testovaci.Size = new Size(Convert.ToInt32(x.Value), Convert.ToInt32(y.Value));
            testovaci.Font = f;
            testovaci.BackColor = backcolor;
            testovaci.ForeColor = forecolor;
            switch (umistenitextu.Text)
            {
                case "MiddleLeft":
                {
                    testovaci.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                }
                case "MiddleCenter":
                {
                    testovaci.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                }
                case "MiddleRight":
                {
                    testovaci.TextAlign = ContentAlignment.MiddleRight;
                    break;
                }
                case "BottomLeft":
                {
                    testovaci.TextAlign = ContentAlignment.BottomLeft;
                    break;
                }
                case "BottomCenter":
                {
                    testovaci.TextAlign = ContentAlignment.BottomCenter;
                    break;
                }
                case "BottomRight":
                {
                    testovaci.TextAlign = ContentAlignment.BottomRight;
                    break;
                }
                case "TopLeft":
                {
                    testovaci.TextAlign = ContentAlignment.TopLeft;
                    break;
                }
                case "TopCenter":
                {
                    testovaci.TextAlign = ContentAlignment.TopCenter;
                    break;
                }
                case "TopRight":
                {
                    testovaci.TextAlign = ContentAlignment.TopRight;
                    break;
                }
            }
        }
        private void nastavFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                f = fontDialog.Font;
            }
        }
        private void pozadi_Click(object sender, EventArgs e)
        {
            ColorDialog colord = new ColorDialog();
            if (colord.ShowDialog() == DialogResult.OK)
            {
                backcolor = colord.Color;
            }
        }
        private void text_Click(object sender, EventArgs e)
        {
            ColorDialog colord = new ColorDialog();
            if (colord.ShowDialog() == DialogResult.OK)
            {
                forecolor = colord.Color;
            }
        }
    }
}
