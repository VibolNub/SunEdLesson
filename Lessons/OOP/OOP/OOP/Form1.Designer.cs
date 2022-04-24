namespace OOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qtyLbl = new System.Windows.Forms.Label();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.uPriceTxt = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.uPriceLbl = new System.Windows.Forms.Label();
            this.calBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Location = new System.Drawing.Point(88, 109);
            this.qtyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(24, 15);
            this.qtyLbl.TabIndex = 0;
            this.qtyLbl.Text = "Qty";
            // 
            // qtyTxt
            // 
            this.qtyTxt.Location = new System.Drawing.Point(144, 106);
            this.qtyTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(163, 20);
            this.qtyTxt.TabIndex = 1;
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(144, 187);
            this.totalTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(163, 20);
            this.totalTxt.TabIndex = 2;
            // 
            // uPriceTxt
            // 
            this.uPriceTxt.Location = new System.Drawing.Point(144, 147);
            this.uPriceTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uPriceTxt.Name = "uPriceTxt";
            this.uPriceTxt.Size = new System.Drawing.Size(163, 20);
            this.uPriceTxt.TabIndex = 3;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(88, 189);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(34, 15);
            this.totalLbl.TabIndex = 4;
            this.totalLbl.Text = "Total";
            // 
            // uPriceLbl
            // 
            this.uPriceLbl.AutoSize = true;
            this.uPriceLbl.Location = new System.Drawing.Point(88, 150);
            this.uPriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uPriceLbl.Name = "uPriceLbl";
            this.uPriceLbl.Size = new System.Drawing.Size(60, 15);
            this.uPriceLbl.TabIndex = 5;
            this.uPriceLbl.Text = "Unit Price";
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(394, 127);
            this.calBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(117, 58);
            this.calBtn.TabIndex = 6;
            this.calBtn.Text = "Calculate...";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 332);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.uPriceLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.uPriceTxt);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.qtyTxt);
            this.Controls.Add(this.qtyLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.TextBox uPriceTxt;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label uPriceLbl;
        private System.Windows.Forms.Button calBtn;
    }
}

