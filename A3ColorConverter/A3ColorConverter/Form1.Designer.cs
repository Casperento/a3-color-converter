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
            this.txtBoxHexValue = new System.Windows.Forms.TextBox();
            this.txtBoxResultValue = new System.Windows.Forms.TextBox();
            this.lblTypeHex = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(41, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Convert HEX colors to Arma 3 RGB format";
            // 
            // txtBoxHexValue
            // 
            this.txtBoxHexValue.Location = new System.Drawing.Point(31, 64);
            this.txtBoxHexValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxHexValue.Name = "txtBoxHexValue";
            this.txtBoxHexValue.Size = new System.Drawing.Size(239, 20);
            this.txtBoxHexValue.TabIndex = 2;
            // 
            // txtBoxResultValue
            // 
            this.txtBoxResultValue.Location = new System.Drawing.Point(31, 120);
            this.txtBoxResultValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxResultValue.Name = "txtBoxResultValue";
            this.txtBoxResultValue.ReadOnly = true;
            this.txtBoxResultValue.Size = new System.Drawing.Size(239, 20);
            this.txtBoxResultValue.TabIndex = 3;
            // 
            // lblTypeHex
            // 
            this.lblTypeHex.AutoSize = true;
            this.lblTypeHex.Location = new System.Drawing.Point(29, 49);
            this.lblTypeHex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeHex.Name = "lblTypeHex";
            this.lblTypeHex.Size = new System.Drawing.Size(97, 13);
            this.lblTypeHex.TabIndex = 4;
            this.lblTypeHex.Text = "Type a HEX value:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 105);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(63, 159);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(67, 21);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(167, 159);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(67, 21);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 197);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTypeHex);
            this.Controls.Add(this.txtBoxResultValue);
            this.Controls.Add(this.txtBoxHexValue);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arma 3 Color Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxHexValue;
        private System.Windows.Forms.TextBox txtBoxResultValue;
        private System.Windows.Forms.Label lblTypeHex;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCopy;
    }
}

