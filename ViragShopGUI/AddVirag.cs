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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ViragShopGUI
{
    public partial class AddVirag : Form
    {
        public AddVirag()
        {
            InitializeComponent();
        }

        private void AddVirag_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
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
                    var requestData = new Viragok
                    {
                        nev = txbName.Text,
                        kategoriaId = (int)CmbKategoria.SelectedValue,
                        szin = txbSzin.Text,
                        egysegar = double.Parse(txbEgysegar.Text),
                        mennyiseg = int.Parse(txbMennyiseg.Text)

                    };

                    // serialize the object as JSON
                    var requestDataJson = JsonConvert.SerializeObject(requestData);

                    // create a StringContent object with the JSON data
                    var content = new StringContent(requestDataJson, Encoding.UTF8, "application/json");


                    var response = await httpClient.PostAsync("https://localhost:7294/api/Viragok", content);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                        MessageBox.Show(apiResponse.Message, "Infó", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbName.Text = "";
                        CmbKategoria.SelectedValue = 1;
                        txbSzin.Text = "";
                        txbEgysegar.Text = "" + 0;
                        txbMennyiseg.Text = "" + 0;
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

        private async void AddVirag_Load(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:7294/api/ViragKategoria");
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                        List<ViragKategoria> viragKategoriak = JsonConvert.DeserializeObject<List<ViragKategoria>>("" + apiResponse.Data);
                        CmbKategoria.DataSource = viragKategoriak;
                        CmbKategoria.DisplayMember = "nev";
                        CmbKategoria.ValueMember = "id";
                        txbEgysegar.Text = "" + 0;
                        txbMennyiseg.Text = "" + 0;
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
