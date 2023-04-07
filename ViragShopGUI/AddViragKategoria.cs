using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViragShopGUI.Models;

namespace ViragShopGUI
{
    public partial class AddViragKategoria : Form
    {
        public AddViragKategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // create an object to serialize as JSON
                    var requestData = new ViragKategoria
                    {
                        nev = txbName.Text,
                        megjegyzes = txbDecsription.Text,

                    };

                    // serialize the object as JSON
                    var requestDataJson = JsonConvert.SerializeObject(requestData);

                    // create a StringContent object with the JSON data
                    var content = new StringContent(requestDataJson, Encoding.UTF8, "application/json");


                    var response = await httpClient.PostAsync("https://localhost:7294/api/ViragKategoria", content);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                        MessageBox.Show(apiResponse.Message, "Infó", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Valami hiba adótott mentés közben.\n Nézd újra át az adataid!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
