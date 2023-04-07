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
using System.Xml.Linq;
using ViragShopGUI.Models;

namespace ViragShopGUI
{
    public partial class AddErtekesites : Form
    {
        public AddErtekesites()
        {
            InitializeComponent();
        }

        private async void AddErtekesites_Load(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:7294/api/Viragok");
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                        List<Viragok> viragok = JsonConvert.DeserializeObject<List<Viragok>>("" + apiResponse.Data);
                        CmbViragNeve.DataSource = viragok;
                        CmbViragNeve.DisplayMember = "nev";
                        CmbViragNeve.ValueMember = "id";
                        txbMennyiseg.Text = "" + 0;
                    }
                    else
                    {
                        MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:7294/api/Vevok");
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                        List<Vevok> vevok = JsonConvert.DeserializeObject<List<Vevok>>("" + apiResponse.Data);
                        CmbEmail.DataSource = vevok;
                        CmbEmail.DisplayMember = "email";
                        CmbEmail.ValueMember = "email";
                    }
                    else
                    {
                        MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // create an object to serialize as JSON
                    var requestData = new Ertekesites
                    {
                        email = (string)CmbEmail.SelectedValue,
                        viragid = (int)CmbViragNeve.SelectedValue,
                        mennyiseg = int.Parse(txbMennyiseg.Text)

                    };

                    // serialize the object as JSON
                    var requestDataJson = JsonConvert.SerializeObject(requestData);

                    // create a StringContent object with the JSON data
                    var content = new StringContent(requestDataJson, Encoding.UTF8, "application/json");


                    var response = await httpClient.PostAsync("https://localhost:7294/api/Ertekesites", content);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                        MessageBox.Show(apiResponse.Message, "Infó", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbMennyiseg.Text = "" + 0;
                        CmbViragNeve.SelectedValue = 1;
                    }
                    else
                    {
                        MessageBox.Show("Valami hiba adótott mentés közben.\n Nézd újra át az adataid!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valami hiba adótott mentés közben.\n", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
