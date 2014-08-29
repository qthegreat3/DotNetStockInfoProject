namespace StockTickerDisplay
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
            this.downloadStockInfoThread = new System.ComponentModel.BackgroundWorker();
            this.parseAndShowStockInfoThread = new System.ComponentModel.BackgroundWorker();
            this.userEnteredTicker = new System.Windows.Forms.TextBox();
            this.enterSymbol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.getStockInformationBtn = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.eps = new System.Windows.Forms.TextBox();
            this.avgVol = new System.Windows.Forms.TextBox();
            this.peRatio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            //Download Stock Info Thread Settings
            this.downloadStockInfoThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadStockInfo);
            // 
            //Parse Stock Info Thread Settings
            this.parseAndShowStockInfoThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.parseStockInfo);
            // userEnteredTicker
            // 
            this.userEnteredTicker.Location = new System.Drawing.Point(13, 22);
            this.userEnteredTicker.Name = "userEnteredTicker";
            this.userEnteredTicker.Size = new System.Drawing.Size(100, 20);
            this.userEnteredTicker.TabIndex = 0;
            // 
            // enterSymbol
            // 
            this.enterSymbol.AutoSize = true;
            this.enterSymbol.Location = new System.Drawing.Point(173, 22);
            this.enterSymbol.Name = "enterSymbol";
            this.enterSymbol.Size = new System.Drawing.Size(10, 13);
            this.enterSymbol.TabIndex = 1;
            this.enterSymbol.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Ticker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "EPS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Avg Vol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "P/E";
            // 
            // getStockInformationBtn
            // 
            this.getStockInformationBtn.Location = new System.Drawing.Point(12, 200);
            this.getStockInformationBtn.Name = "getStockInformationBtn";
            this.getStockInformationBtn.Size = new System.Drawing.Size(260, 23);
            this.getStockInformationBtn.TabIndex = 7;
            this.getStockInformationBtn.Text = "Get Stock Info!";
            this.getStockInformationBtn.UseVisualStyleBackColor = true;
            this.getStockInformationBtn.Click += new System.EventHandler(this.getStockInformationBtn_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(13, 140);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(41, 20);
            this.price.TabIndex = 8;
            // 
            // eps
            // 
            this.eps.Location = new System.Drawing.Point(81, 140);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(47, 20);
            this.eps.TabIndex = 9;
            // 
            // avgVol
            // 
            this.avgVol.Location = new System.Drawing.Point(167, 140);
            this.avgVol.Name = "avgVol";
            this.avgVol.Size = new System.Drawing.Size(41, 20);
            this.avgVol.TabIndex = 10;
            // 
            // peRatio
            // 
            this.peRatio.Location = new System.Drawing.Point(231, 140);
            this.peRatio.Name = "peRatio";
            this.peRatio.Size = new System.Drawing.Size(41, 20);
            this.peRatio.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.peRatio);
            this.Controls.Add(this.avgVol);
            this.Controls.Add(this.eps);
            this.Controls.Add(this.price);
            this.Controls.Add(this.getStockInformationBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterSymbol);
            this.Controls.Add(this.userEnteredTicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userEnteredTicker;
        private System.Windows.Forms.Label enterSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getStockInformationBtn;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox eps;
        private System.Windows.Forms.TextBox avgVol;
        private System.Windows.Forms.TextBox peRatio;

        private System.ComponentModel.BackgroundWorker downloadStockInfoThread;
        private System.ComponentModel.BackgroundWorker parseAndShowStockInfoThread;

        private volatile string stockInfoResult;
    }
}

