using System.Windows.Forms;

namespace A3ColorConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxHexTit = new System.Windows.Forms.TextBox();
            this.txtBoxAcolorTit = new System.Windows.Forms.TextBox();
            this.lblTypeHex = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnHtoA1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPicker1 = new System.Windows.Forms.Button();
            this.btnAtoH1 = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.lblTit = new System.Windows.Forms.Label();
            this.btnPicker2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAcolorBg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxHexBg = new System.Windows.Forms.TextBox();
            this.btnAtoH2 = new System.Windows.Forms.Button();
            this.btnHtoA2 = new System.Windows.Forms.Button();
            this.colorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(44, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(441, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Type some HEX value to convert to Arma\'s #RGB or #ARGB:";
            // 
            // txtBoxHexTit
            // 
            this.txtBoxHexTit.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxHexTit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxHexTit.ForeColor = System.Drawing.Color.Black;
            this.txtBoxHexTit.Location = new System.Drawing.Point(46, 98);
            this.txtBoxHexTit.Name = "txtBoxHexTit";
            this.txtBoxHexTit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxHexTit.Size = new System.Drawing.Size(196, 26);
            this.txtBoxHexTit.TabIndex = 2;
            this.txtBoxHexTit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxHexTit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxHexTit_KeyPress);
            // 
            // txtBoxAcolorTit
            // 
            this.txtBoxAcolorTit.Location = new System.Drawing.Point(46, 253);
            this.txtBoxAcolorTit.Name = "txtBoxAcolorTit";
            this.txtBoxAcolorTit.Size = new System.Drawing.Size(196, 26);
            this.txtBoxAcolorTit.TabIndex = 3;
            this.txtBoxAcolorTit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAcolorTit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAcolorTit_KeyPress);
            // 
            // lblTypeHex
            // 
            this.lblTypeHex.AutoSize = true;
            this.lblTypeHex.Location = new System.Drawing.Point(44, 75);
            this.lblTypeHex.Name = "lblTypeHex";
            this.lblTypeHex.Size = new System.Drawing.Size(122, 20);
            this.lblTypeHex.TabIndex = 4;
            this.lblTypeHex.Text = "Text HEX Color:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(44, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(84, 20);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Text Color:";
            // 
            // btnHtoA1
            // 
            this.btnHtoA1.Location = new System.Drawing.Point(78, 151);
            this.btnHtoA1.Name = "btnHtoA1";
            this.btnHtoA1.Size = new System.Drawing.Size(31, 49);
            this.btnHtoA1.TabIndex = 6;
            this.btnHtoA1.Text = "V";
            this.btnHtoA1.UseVisualStyleBackColor = true;
            this.btnHtoA1.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // btnPicker1
            // 
            this.btnPicker1.Location = new System.Drawing.Point(46, 294);
            this.btnPicker1.Name = "btnPicker1";
            this.btnPicker1.Size = new System.Drawing.Size(196, 32);
            this.btnPicker1.TabIndex = 8;
            this.btnPicker1.Text = "Picker";
            this.btnPicker1.UseVisualStyleBackColor = true;
            this.btnPicker1.Click += new System.EventHandler(this.btnPicker_Click);
            // 
            // btnAtoH1
            // 
            this.btnAtoH1.Location = new System.Drawing.Point(115, 151);
            this.btnAtoH1.Name = "btnAtoH1";
            this.btnAtoH1.Size = new System.Drawing.Size(31, 50);
            this.btnAtoH1.TabIndex = 10;
            this.btnAtoH1.Text = "Ʌ";
            this.btnAtoH1.UseVisualStyleBackColor = true;
            this.btnAtoH1.Click += new System.EventHandler(this.btnAtoH1_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Controls.Add(this.lblTit);
            this.colorPanel.Location = new System.Drawing.Point(162, 151);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(206, 49);
            this.colorPanel.TabIndex = 11;
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.Location = new System.Drawing.Point(38, 9);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(130, 29);
            this.lblTit.TabIndex = 12;
            this.lblTit.Text = "Some Text";
            // 
            // btnPicker2
            // 
            this.btnPicker2.Location = new System.Drawing.Point(276, 294);
            this.btnPicker2.Name = "btnPicker2";
            this.btnPicker2.Size = new System.Drawing.Size(196, 32);
            this.btnPicker2.TabIndex = 14;
            this.btnPicker2.Text = "Picker";
            this.btnPicker2.UseVisualStyleBackColor = true;
            this.btnPicker2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Background Color:";
            // 
            // txtBoxAcolorBg
            // 
            this.txtBoxAcolorBg.Location = new System.Drawing.Point(276, 253);
            this.txtBoxAcolorBg.Name = "txtBoxAcolorBg";
            this.txtBoxAcolorBg.Size = new System.Drawing.Size(196, 26);
            this.txtBoxAcolorBg.TabIndex = 12;
            this.txtBoxAcolorBg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAcolorBg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAcolorBg_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Background HEX Color:";
            // 
            // txtBoxHexBg
            // 
            this.txtBoxHexBg.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxHexBg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxHexBg.ForeColor = System.Drawing.Color.Black;
            this.txtBoxHexBg.Location = new System.Drawing.Point(276, 98);
            this.txtBoxHexBg.Name = "txtBoxHexBg";
            this.txtBoxHexBg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxHexBg.Size = new System.Drawing.Size(196, 26);
            this.txtBoxHexBg.TabIndex = 15;
            this.txtBoxHexBg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxHexBg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxHexBg_KeyPress);
            // 
            // btnAtoH2
            // 
            this.btnAtoH2.Location = new System.Drawing.Point(420, 151);
            this.btnAtoH2.Name = "btnAtoH2";
            this.btnAtoH2.Size = new System.Drawing.Size(31, 49);
            this.btnAtoH2.TabIndex = 18;
            this.btnAtoH2.Text = "Ʌ";
            this.btnAtoH2.UseVisualStyleBackColor = true;
            this.btnAtoH2.Click += new System.EventHandler(this.btnAtoH2_Click);
            // 
            // btnHtoA2
            // 
            this.btnHtoA2.Location = new System.Drawing.Point(383, 151);
            this.btnHtoA2.Name = "btnHtoA2";
            this.btnHtoA2.Size = new System.Drawing.Size(31, 49);
            this.btnHtoA2.TabIndex = 17;
            this.btnHtoA2.Text = "V";
            this.btnHtoA2.UseVisualStyleBackColor = true;
            this.btnHtoA2.Click += new System.EventHandler(this.btnHtoA2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 354);
            this.Controls.Add(this.btnAtoH2);
            this.Controls.Add(this.btnHtoA2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxHexBg);
            this.Controls.Add(this.btnPicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAcolorBg);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.btnAtoH1);
            this.Controls.Add(this.btnPicker1);
            this.Controls.Add(this.btnHtoA1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTypeHex);
            this.Controls.Add(this.txtBoxAcolorTit);
            this.Controls.Add(this.txtBoxHexTit);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A3CC v1.0.0 by Casperento";
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxHexTit;
        private System.Windows.Forms.TextBox txtBoxAcolorTit;
        private System.Windows.Forms.Label lblTypeHex;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnHtoA1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnPicker1;
        private System.Windows.Forms.Button btnAtoH1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.Button btnPicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAcolorBg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxHexBg;
        private System.Windows.Forms.Button btnAtoH2;
        private System.Windows.Forms.Button btnHtoA2;
    }
}

