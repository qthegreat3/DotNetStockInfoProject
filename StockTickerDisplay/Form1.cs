using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTickerDisplay
{
    public partial class Form1 : Form
    {
        private const string YAHOO_FINANCE_URL_START = "http://download.finance.yahoo.com/d/quotes.csv?s=";
        private const string YAHOO_FINANCE_URL_END = "&f=nl1e0a2r0&e.csv";

        private WindowsFormsSynchronizationContext context;

        private System.Threading.AutoResetEvent ar1 = new System.Threading.AutoResetEvent(false);

        public Form1()
        {
            InitializeComponent();

            if (context == null)
            {
                context = new WindowsFormsSynchronizationContext();
            }
        }

        private void getStockInformationBtn_Click(object sender, EventArgs e)
        {
            //Launch 2 Background Tasks
            //1st To go download the information
            label3.Text = "";
            price.Text = "";
            eps.Text = "";
            avgVol.Text = "";
            peRatio.Text = "";

            downloadStockInfoThread.RunWorkerAsync();
            parseAndShowStockInfoThread.RunWorkerAsync();
            //2nd to go parse the information
        }

        private void downloadStockInfo(object sender, DoWorkEventArgs e)
        {
            System.Net.WebClient wc = new System.Net.WebClient();

            string url = YAHOO_FINANCE_URL_START + this.userEnteredTicker.Text + YAHOO_FINANCE_URL_END;

            byte[] raw = null;

            try
            {
                raw = wc.DownloadData(url);
            }
            catch (Exception exp)
            {
                Console.Write(exp.StackTrace);
            }

            this.stockInfoResult = System.Text.Encoding.UTF8.GetString(raw);

            ar1.Set();
        }

        private void parseStockInfo(object sender, DoWorkEventArgs e)
        {
            ar1.WaitOne();

            int infoIndex = 0;

            Console.Write(this.stockInfoResult);

            while ((this.stockInfoResult.ElementAt(infoIndex) != ',') && (infoIndex < this.stockInfoResult.Length))
            {
                context.Send(new SendOrPostCallback((s) =>
                    label3.Text += this.stockInfoResult.ElementAt(infoIndex)), null);

                infoIndex++;
            }
            infoIndex++;
            while ((this.stockInfoResult.ElementAt(infoIndex) != ',') && (infoIndex < this.stockInfoResult.Length))
            {
                context.Send(new SendOrPostCallback((t) =>
                    price.Text += this.stockInfoResult.ElementAt(infoIndex)), null);

                infoIndex++;
            }
            infoIndex++;
            while ((this.stockInfoResult.ElementAt(infoIndex) != ',') && (infoIndex < this.stockInfoResult.Length))
            {
                context.Send(new SendOrPostCallback((p) =>
                    eps.Text += this.stockInfoResult.ElementAt(infoIndex)), null);

                infoIndex++;
            }
            infoIndex++;
            while ((this.stockInfoResult.ElementAt(infoIndex) != ',') && (infoIndex < this.stockInfoResult.Length))
            {
                context.Send(new SendOrPostCallback((c) =>
                    avgVol.Text += this.stockInfoResult.ElementAt(infoIndex)), null);

                infoIndex++;
            }
            infoIndex++;
            while ((infoIndex < this.stockInfoResult.Length) && (this.stockInfoResult.ElementAt(infoIndex) != ','))
            {
                context.Send(new SendOrPostCallback((d) =>
                    peRatio.Text += this.stockInfoResult.ElementAt(infoIndex)), null);

                infoIndex++;
            }
        }
    }
}
