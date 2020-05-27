using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3ColorConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtBoxHexTit.Text == "") {
                MessageBox.Show("You need to type something to convert...");
            } else if (!txtBoxHexTit.Text.Contains('#') || txtBoxHexTit.Text.Length < 7)
            {
                MessageBox.Show("Invalid Color...");
            } else {
                String hexValue = txtBoxHexTit.Text;
                decimal alpha, red, green, blue;

                if (hexValue.Length < 8)
                {
                    alpha = 255;
                    red = int.Parse(hexValue.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                    green = int.Parse(hexValue.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                    blue = int.Parse(hexValue.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                } else
                {
                    alpha = int.Parse(hexValue.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                    red = int.Parse(hexValue.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                    green = int.Parse(hexValue.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                    blue = int.Parse(hexValue.Substring(7, 2), System.Globalization.NumberStyles.HexNumber);
                }

                decimal a = Math.Round((alpha / 255) * 1000) / 1000;
                decimal r = Math.Round((red / 255) * 1000) / 1000;
                decimal g = Math.Round((green / 255) * 1000) / 1000;
                decimal b = Math.Round((blue / 255) * 1000) / 1000;

                txtBoxAcolorTit.Text = "{" + String.Format("{0}, {1}, {2}, {3}",
                    r.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    g.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    b.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    a.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture)
                ) + "}";


                lblTit.ForeColor = ColorTranslator.FromHtml(hexValue);
            }
        }

        private void btnPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AnyColor = false;
            colorDialog.FullOpen = true;
            colorDialog.AllowFullOpen = true;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblTit.ForeColor = colorDialog.Color;

                var argbArr = BitConverter.GetBytes(colorDialog.Color.ToArgb()).Reverse().ToArray();

                decimal a = Math.Round(( (decimal) argbArr[0] / 255) * 1000) / 1000;
                decimal r = Math.Round(( (decimal) argbArr[1] / 255) * 1000) / 1000;
                decimal g = Math.Round(( (decimal)argbArr[2] / 255) * 1000) / 1000;
                decimal b = Math.Round(( (decimal)argbArr[3] / 255) * 1000) / 1000;

                txtBoxAcolorTit.Text = "{" + String.Format("{0}, {1}, {2}, {3}",
                    r.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    g.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    b.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    a.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture)
                ) + "}";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AnyColor = false;
            colorDialog.FullOpen = true;
            colorDialog.AllowFullOpen = true;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog.Color;

                var argbArr = BitConverter.GetBytes(colorDialog.Color.ToArgb()).Reverse().ToArray();

                decimal a = Math.Round(((decimal)argbArr[0] / 255) * 1000) / 1000;
                decimal r = Math.Round(((decimal)argbArr[1] / 255) * 1000) / 1000;
                decimal g = Math.Round(((decimal)argbArr[2] / 255) * 1000) / 1000;
                decimal b = Math.Round(((decimal)argbArr[3] / 255) * 1000) / 1000;

                txtBoxAcolorBg.Text = "{" + String.Format("{0}, {1}, {2}, {3}",
                    r.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    g.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    b.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    a.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture)
                ) + "}";

            }
        }

        private void btnHtoA2_Click(object sender, EventArgs e)
        {
            if (txtBoxHexBg.Text == "")
            {
                MessageBox.Show("You need to type something to convert...");
            }
            else if (!txtBoxHexBg.Text.Contains('#') || txtBoxHexBg.Text.Length < 7)
            {
                MessageBox.Show("Invalid Color...");
            }
            else
            {
                String hexValue = txtBoxHexBg.Text;
                decimal alpha, red, green, blue;

                if (hexValue.Length < 8)
                {
                    alpha = 255;
                    red = int.Parse(hexValue.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                    green = int.Parse(hexValue.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                    blue = int.Parse(hexValue.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    alpha = int.Parse(hexValue.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                    red = int.Parse(hexValue.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                    green = int.Parse(hexValue.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                    blue = int.Parse(hexValue.Substring(7, 2), System.Globalization.NumberStyles.HexNumber);
                }

                decimal a = Math.Round((alpha / 255) * 1000) / 1000;
                decimal r = Math.Round((red / 255) * 1000) / 1000;
                decimal g = Math.Round((green / 255) * 1000) / 1000;
                decimal b = Math.Round((blue / 255) * 1000) / 1000;

                txtBoxAcolorBg.Text = "{" + String.Format("{0}, {1}, {2}, {3}",
                    r.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    g.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    b.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture),
                    a.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture)
                ) + "}";


                colorPanel.BackColor = ColorTranslator.FromHtml(hexValue);
            }
        }

        private void btnAtoH1_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnAtoH2_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
