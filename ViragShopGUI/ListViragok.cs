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
    public partial class ListViragok : Form
    {
        public ListViragok()
        {
            InitializeComponent();
        }

        private async void ListViragok_Load(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:7294/api/View/vviragok");
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                        List<v_viragok> vviragok = JsonConvert.DeserializeObject<List<v_viragok>>("" + apiResponse.Data);
                        vviragDGrid.DataSource = vviragok;
                        vviragDGrid.AutoGenerateColumns = true;
                    }
                    else
                    {
                        MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
