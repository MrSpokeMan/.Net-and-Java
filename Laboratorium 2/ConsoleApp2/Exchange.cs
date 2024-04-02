using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("WinFormsApp2")]

namespace ConsoleApp2
{
    internal class Exchange
    {
        private string token = "74038a81b7bb4d2f9fd976e3dd8caa9d";
        private string url_req;
        public Exchange()
        {
            url_req = $"https://openexchangerates.org/api/latest.json?app_id={token}";
        }

        private HttpClient client = new HttpClient();
    }
}
