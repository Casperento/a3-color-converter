using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string hexValue = txtBoxHexTit.Text;
            if (Regex.IsMatch(hexValue, @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{8})$"))
            {
                int iR = (hexValue.Length < 8) ? 1 : 3;
                int iG = (hexValue.Length < 8) ? 3 : 5;
                int iB = (hexValue.Length < 8) ? 5 : 7;

                decimal alpha = (hexValue.Length < 8) ? 255 : int.Parse(hexValue.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                decimal red = int.Parse(hexValue.Substring(iR, 2), System.Globalization.NumberStyles.HexNumber);
                decimal green = int.Parse(hexValue.Substring(iG, 2), System.Globalization.NumberStyles.HexNumber);
                decimal blue = int.Parse(hexValue.Substring(iB, 2), System.Globalization.NumberStyles.HexNumber);

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
            else
            {
                MessageBox.Show("Invalid Color...");
            }
        }

        private void btnHtoA2_Click(object sender, EventArgs e)
        {
            string hexValue = txtBoxHexBg.Text;
            if (Regex.IsMatch(hexValue, @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{8})$"))
            {
                int iR = (hexValue.Length < 8) ? 1 : 3;
                int iG = (hexValue.Length < 8) ? 3 : 5;
                int iB = (hexValue.Length < 8) ? 5 : 7;

                decimal alpha = (hexValue.Length < 8) ? 255 : int.Parse(hexValue.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                decimal red = int.Parse(hexValue.Substring(iR, 2), System.Globalization.NumberStyles.HexNumber);
                decimal green = int.Parse(hexValue.Substring(iG, 2), System.Globalization.NumberStyles.HexNumber);
                decimal blue = int.Parse(hexValue.Substring(iB, 2), System.Globalization.NumberStyles.HexNumber);

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
            else
            {
                MessageBox.Show("Invalid Color...");
            }
        }

        private void btnPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AnyColor = false;
            colorDialog.FullOpen = true;
            colorDialog.AllowFullOpen = true;
            if (txtBoxAcolorTit.Text != "") {
                colorDialog.Color = lblTit.ForeColor;
            }

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
            if (txtBoxAcolorBg.Text != "")
            {
                colorDialog.Color = colorPanel.BackColor;
            }

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

        private void btnAtoH1_Click(object sender, EventArgs e)
        {
            string armaColor = txtBoxAcolorTit.Text;
            if (Regex.IsMatch(armaColor, @"^\{((([0]|[0]\.\d*)|([1]|[1]\.[0]*))\,){3}(([0]|[0]\.\d*)|([1]|[1]\.[0]*))\}$"))
            {
                armaColor = Regex.Replace(armaColor, @"^.*?\{(.*?)\}.*?$", "$1");
                string[] arr = armaColor.Split(',');

                int r = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[0], CultureInfo.InvariantCulture))));
                int g = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[1], CultureInfo.InvariantCulture))));
                int b = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[2], CultureInfo.InvariantCulture))));
                int a = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[3], CultureInfo.InvariantCulture))));

                string red = ($"{r:X}".Length < 2) ? $"0{r:X}" : $"{r:X}";
                string green = ($"{g:X}".Length < 2) ? $"0{g:X}" : $"{g:X}";
                string blue = ($"{b:X}".Length < 2) ? $"0{b:X}" : $"{b:X}";
                string alpha = ($"{a:X}".Length < 2) ? $"0{a:X}" : $"{a:X}";

                string hexValue = String.Format((a == 255) ? $"#{red}{green}{blue}" : $"#{alpha}{red}{green}{blue}");
                txtBoxHexTit.Text = hexValue;
                lblTit.ForeColor = ColorTranslator.FromHtml(hexValue);
            }
            else {
                MessageBox.Show("Invalid color...");
            }
        }

        private void btnAtoH2_Click(object sender, EventArgs e)
        {
            string armaColor = txtBoxAcolorBg.Text;
            if (Regex.IsMatch(armaColor, @"^\{((([0]|[0]\.\d*)|([1]|[1]\.[0]*))\,){3}(([0]|[0]\.\d*)|([1]|[1]\.[0]*))\}$"))
            {
                armaColor = Regex.Replace(armaColor, @"^.*?\{(.*?)\}.*?$", "$1");
                string[] arr = armaColor.Split(',');

                int r = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[0], CultureInfo.InvariantCulture))));
                int g = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[1], CultureInfo.InvariantCulture))));
                int b = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[2], CultureInfo.InvariantCulture))));
                int a = Convert.ToInt32(Math.Round(Decimal.Multiply(255m, Decimal.Parse(arr[3], CultureInfo.InvariantCulture))));

                string red = ($"{r:X}".Length < 2) ? $"0{r:X}" : $"{r:X}";
                string green = ($"{g:X}".Length < 2) ? $"0{g:X}" : $"{g:X}";
                string blue = ($"{b:X}".Length < 2) ? $"0{b:X}" : $"{b:X}";
                string alpha = ($"{a:X}".Length < 2) ? $"0{a:X}" : $"{a:X}";

                string hexValue = String.Format((a == 255) ? $"#{red}{green}{blue}" : $"#{alpha}{red}{green}{blue}");
                txtBoxHexBg.Text = hexValue;
                colorPanel.BackColor = ColorTranslator.FromHtml(hexValue);
            }
            else
            {
                MessageBox.Show("Invalid color...");
            }
        }


        private void txtBoxHexTit_KeyPress(object sender, KeyPressEventArgs e) {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^#0-9A-Fa-f\u0008\cC\cV\cA\cX]"))
            {
                e.Handled = true;
            }
        }

        private void txtBoxAcolorTit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^.,0-9\{\}\u0008\cC\cV\cA\cX]"))
            {
                e.Handled = true;
            }
        }


        private void txtBoxHexBg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^#0-9A-Fa-f\u0008\cC\cV\cA\cX]"))
            {
                e.Handled = true;
            }
        }

        private void txtBoxAcolorBg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^.,0-9\{\}\u0008\cC\cV\cA\cX]"))
            {
                e.Handled = true;
            }
        }
    }
}
