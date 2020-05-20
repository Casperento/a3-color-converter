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
            String convertedValue;
            String hexValue = txtBoxHexValue.Text;

            decimal red = int.Parse(hexValue.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            decimal green = int.Parse(hexValue.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            decimal blue = int.Parse(hexValue.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);

            decimal r = Math.Round((red / 255) * 1000) / 1000;
            decimal g = Math.Round((green / 255) * 1000) / 1000;
            decimal b = Math.Round((blue / 255) * 1000) / 1000;

            convertedValue = String.Format("{0}, {1}, {2}, 1", r.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture), g.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture), b.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture));
            txtBoxResultValue.Text = "{" + convertedValue + "}";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxResultValue.Text);
        }
    }
}
