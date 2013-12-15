using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Coinbase_Investment_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // date and time is retrieved for logging
            DateTime dateAndTime = DateTime.Now;
            p_access.completeDate = dateAndTime.ToString("d");

            // the file name of the log file is stored
            p_access.fileName = "CoinbaseInvestmentLog.txt";

            // if the log file does not exist then it is created
            if (!File.Exists(p_access.fileName))
            {
                var fileToClose = File.Create(p_access.fileName);
                fileToClose.Close();
            }

            // investment information is retrieved from the log file
            GetInvestmentsFromFile();
            UpdateUI();
        }

        // this function reads in the information from the log file and stores it in a list
        private void GetInvestmentsFromFile()
        {
            using (StreamReader sr = new StreamReader(p_access.fileName))
            {
                while (sr.Peek() >= 0) // while there are more characters
                {
                    string tmpStr;
                    tmpStr = sr.ReadLine(); // read in a line

                    string[] tmpStrArray = tmpStr.Split(new char[] { '\t' }); // split by \t into array

                    // information from array is added to the list
                    i_investment c_investment = new i_investment();
                    Double.TryParse(tmpStrArray[0], out c_investment.bitcoinAmount);
                    Double.TryParse(tmpStrArray[1], out c_investment.dollarAmount);
                    c_investment.date = tmpStrArray[2];
                    p_access.investments.Add(c_investment);
                }
            }
        }

        // this function updates the different aspects of the UI
        private void UpdateUI()
        {
            double totalDollarInvested = 0.0;
            double totalBtcPurchased = 0.0;
            double totalPotentialSell = 0.0;

            // clears all rows to prevent errors
            GridInvestments.Rows.Clear();

            // fills in the grid
            // numbers are rounded to make grid easier to view
            for (int i = 0; i < p_access.investments.Count; i++)
            {
                GetCoinbaseSellPrice();
                
                GridInvestments.Rows.Add();

                GridInvestments.Rows[i].Cells[0].Value = i + 1;

                GridInvestments.Rows[i].Cells[1].Value = Math.Round(p_access.investments[i].bitcoinAmount, 5);
                totalBtcPurchased += p_access.investments[i].bitcoinAmount;

                GridInvestments.Rows[i].Cells[2].Value = Math.Round(p_access.investments[i].dollarAmount, 2);
                totalDollarInvested += p_access.investments[i].dollarAmount;

                GridInvestments.Rows[i].Cells[3].Value = p_access.investments[i].date;

                double change = p_access.investments[i].bitcoinAmount * (p_access.coinbaseTotalSell - p_access.coinbaseBankFee) + p_access.coinbaseBankFee
                    - p_access.investments[i].dollarAmount;
                GridInvestments.Rows[i].Cells[4].Value = Math.Round(change, 2);

                double currentSell = Math.Round(p_access.investments[i].bitcoinAmount * (p_access.coinbaseTotalSell - p_access.coinbaseBankFee)
                    + p_access.coinbaseBankFee, 2);
                GridInvestments.Rows[i].Cells[5].Value = Math.Round(currentSell, 2);
                totalPotentialSell += currentSell - p_access.coinbaseBankFee;
            }

            totalPotentialSell += p_access.coinbaseBankFee;

            // labels are updated
            LabelTotalInvested.Text = "USD Invested: $" + Math.Round(totalDollarInvested, 2);
            LabelTotalBTC.Text = "BTC Owned: " + Math.Round(totalBtcPurchased, 5);
            LabelTotalSell.Text = "Total Sell Value: $" + Math.Round(totalPotentialSell, 2);
        }

        // pings Coinbase and updates the selling info
        private void GetCoinbaseSellPrice()
        {
            WebClient webClient = new WebClient();
            string coinbaseString = webClient.DownloadString(p_access.coinbaseSellURL);
            CoinbaseApiSellClass coinbaseSellInfo = JsonConvert.DeserializeObject<CoinbaseApiSellClass>(coinbaseString);

            Double.TryParse(coinbaseSellInfo.subtotal.amount, out p_access.coinbaseSubtotal);
            Double.TryParse(coinbaseSellInfo.fees[0].coinbase.amount, out p_access.coinbaseSellFee);
            Double.TryParse(coinbaseSellInfo.fees[1].bank.amount, out p_access.coinbaseBankFee);
            p_access.coinbaseTotalSell = p_access.coinbaseSubtotal - p_access.coinbaseSellFee - p_access.coinbaseBankFee;
        }

        // saves changed made to the list to the log file
        private void SaveChanges()
        {
            using (System.IO.StreamWriter fout = new System.IO.StreamWriter(p_access.fileName))
            {
                for (int i = 0; i < p_access.investments.Count; i++)
                {
                    fout.WriteLine(p_access.investments[i].bitcoinAmount + "\t" + p_access.investments[i].dollarAmount
                        + "\t" + p_access.investments[i].date);
                }
            }
        }

        // submits the information from the submission textboxes to the list, saves the changes, and updates the UI
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            double btc = 0.0;
            double dollars = 0.0;
            Double.TryParse(TextboxBitcoinAmount.Text, out btc);
            Double.TryParse(TextboxDollarAmount.Text, out dollars);

            // textboxes are cleared
            TextboxBitcoinAmount.Text = "";
            TextboxDollarAmount.Text = "";

            // if the input is negative then it is made positive
            if (btc < 0.0) btc = btc * -1.0;
            if (dollars < 0.0) dollars = dollars * -1.0;

            i_investment c_investment = new i_investment();
            c_investment.bitcoinAmount = btc;
            c_investment.dollarAmount = dollars;
            c_investment.date = p_access.completeDate;
            p_access.investments.Add(c_investment);

            SaveChanges();
            UpdateUI();
        }

        // this function will delete the row the user has selected if they press the delete key
        private void GridInvestments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int rowToDelete = GridInvestments.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (rowToDelete > 0)
                {
                    p_access.investments.RemoveAt(GridInvestments.SelectedRows[0].Index);

                    GridInvestments.Rows.RemoveAt(GridInvestments.SelectedRows[0].Index);
                }
            }

            SaveChanges();
            UpdateUI();
        }

        // will update when called by the timer event handler
        private void TimerTick(object sender, EventArgs e)
        {
            UpdateUI();
        }
        
        // sets up the timer and will call the TimerTick to update the UI every 15 seconds
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 15 * 1000; // 15 seconds
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        // public files that can be used with all functions
        public static class p_access
        {
            public static List<i_investment> investments = new List<i_investment>();
            public static string fileName;
            public static string completeDate;

            public static string coinbaseSellURL = "https://coinbase.com/api/v1/prices/sell";
            public static double coinbaseBankFee = 0.0;
            public static double coinbaseSellFee = 0.0;
            public static double coinbaseSubtotal = 0.0;
            public static double coinbaseTotalSell = 0.0;
        }

        // class for individual investments
        public class i_investment
        {
            public double bitcoinAmount;
            public double dollarAmount;
            public string date;
        }

        // classes below are for the Coinbase API response
        public class Subtotal
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Coinbase
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Bank
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Fee
        {
            public Coinbase coinbase { get; set; }
            public Bank bank { get; set; }
        }

        public class Total
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class CoinbaseApiSellClass
        {
            public Subtotal subtotal { get; set; }
            public List<Fee> fees { get; set; }
            public Total total { get; set; }
            public string amount { get; set; }
            public string currency { get; set; }
        }
    }
}
