namespace ViragShopGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addVirag_Click(object sender, EventArgs e)
        {
            AddVirag addVirag = new AddVirag();
            addVirag.ShowDialog();
        }
        private void addVevo_Click(object sender, EventArgs e)
        {
            AddVevo addVevo = new AddVevo();
            addVevo.ShowDialog();

        }

        private void addErtekesites_Click(object sender, EventArgs e)
        {
            AddErtekesites addErtekesites = new AddErtekesites();
            addErtekesites.ShowDialog();
        }

        private void addViragKat_Click(object sender, EventArgs e)
        {
            AddViragKategoria addViragKategoria = new AddViragKategoria();
            addViragKategoria.ShowDialog();
        }

        private void listViragok_Click(object sender, EventArgs e)
        {
            ListViragok listViragok = new ListViragok();
            listViragok.ShowDialog();
        }

        private void listErtekesites_Click(object sender, EventArgs e)
        {
            ListErtekesitesek listErtekesitesek = new ListErtekesitesek();
            listErtekesitesek.ShowDialog();
        }
    }
}