using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViragShopGUI.Models;

namespace ViragShopGUI
{
    public partial class ListErtekesitesek : Form
    {
        public ListErtekesitesek()
        {
            InitializeComponent();
        }

        private async void ListErtekesitesek_Load(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://localhost:7294/api/View/vertekesites");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                    List<v_ertekesitesek> vertekesitesek = JsonConvert.DeserializeObject<List<v_ertekesitesek>>("" + apiResponse.Data);
                    vErtekesitesGridView.DataSource = vertekesitesek;
                    vErtekesitesGridView.AutoGenerateColumns = true;
                }
                else
                {
                    // Handle the error response
                }
            }
        }
    }
}
