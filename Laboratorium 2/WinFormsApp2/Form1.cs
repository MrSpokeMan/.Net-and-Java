using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Common;
using System.Security.Policy;
using System.Text.Json;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string token = "74038a81b7bb4d2f9fd976e3dd8caa9d";
        private HttpClient client;
        private string url_req;
        private ExchangeStock exchangeStock;

        private Currency currency;

        public Form1()
        {
            InitializeComponent();
            exchangeStock = new ExchangeStock();
            client = new HttpClient();
            url_req = $"https://openexchangerates.org/api/latest.json?app_id={token}";
            textBox1.KeyPress += textBox1_KeyPress;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            if (exchangeStock.IsEmpty())
            {
                DownloadButton_Click(null, null);
            }

            AddToComboboxes();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = exchangeStock.CurrencyDB.Where(x => x.Currency == comboBox2.SelectedItem.ToString()).FirstOrDefault().Value;
            result = Math.Round(result, 2);
            textBox2.Text = $"{result} USD";
        }

        private async void AddToComboboxes()
        {
            var currencies = await exchangeStock.CurrencyDB.ToListAsync();
            foreach (var currency in currencies)
            {
                comboBox1.Items.Add(currency.Currency);
                comboBox2.Items.Add(currency.Currency);
            }
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            var curr = await exchangeStock.CurrencyDB.ToListAsync();
            exchangeStock.CurrencyDB.RemoveRange(curr);
            await exchangeStock.SaveChangesAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string responseString = "";
            try
            {
                responseString = await client.GetStringAsync(url_req);
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine("\nException Caught! " + exception);
            }

            Currency? exchangeRates = JsonSerializer.Deserialize<Currency>(responseString, options);

            foreach (var rate in exchangeRates.Rates)
            {
                var currencies = new CurrencyDB() { Currency = rate.Key, Value = rate.Value };
                await exchangeStock.CurrencyDB.AddAsync(currencies);
            }
            await exchangeStock.SaveChangesAsync();
            AddToComboboxes();
            TextBoxDisplayData.Text = "Data downloaded";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                var value = decimal.Parse(textBox1.Text);
                var currency1 = comboBox1.SelectedItem.ToString();
                var currency2 = comboBox2.SelectedItem.ToString();

                var currency1Value = exchangeStock.CurrencyDB.Where(x => x.Currency == currency1).FirstOrDefault().Value;
                var currency2Value = exchangeStock.CurrencyDB.Where(x => x.Currency == currency2).FirstOrDefault().Value;

                var result = value * currency1Value / currency2Value;
                result = Math.Round(result, 2);
                TextBoxDisplayData.Text = $"{result} {currency2}";
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
