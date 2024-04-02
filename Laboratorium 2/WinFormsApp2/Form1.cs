using ConsoleApp2;
using Microsoft.VisualBasic.ApplicationServices;
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
            TextBoxDisplayData.KeyPress += TextBoxDisplayData_KeyPress;

            if (exchangeStock != null)
            {
                // Prepare data for combobox to chooose currency
                var currencies = exchangeStock.CurrencyDB.ToList().OrderBy(s => s.Id).Reverse().First();
                foreach (var rate in currencies.Rates)
                {
                    TextBoxDisplayData.Text = rate.Key;
                }
            }
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
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

            var currencies = new CurrencyDB() { Disclaimer = exchangeRates.Disclaimer, License = exchangeRates.License, Base = exchangeRates.Base, Timestamp = exchangeRates.Timestamp };
            foreach (var rate in exchangeRates.Rates)
            {
                currencies.Rates.Add(rate.Key, rate.Value);
            }
            exchangeStock.CurrencyDB.Add(currencies);
            exchangeStock.SaveChanges();
        }

        private void TextBoxDisplayData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
