namespace ViragShopGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            addVirag = new Button();
            listViragok = new Button();
            addViragKat = new Button();
            addErtekesites = new Button();
            listErtekesites = new Button();
            addVevo = new Button();
            SuspendLayout();
            // 
            // addVirag
            // 
            addVirag.BackgroundImage = (Image)resources.GetObject("addVirag.BackgroundImage");
            addVirag.BackgroundImageLayout = ImageLayout.Stretch;
            addVirag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addVirag.Location = new Point(17, 24);
            addVirag.Margin = new Padding(4);
            addVirag.Name = "addVirag";
            addVirag.Size = new Size(356, 283);
            addVirag.TabIndex = 0;
            addVirag.Text = "Virág hozzáadása";
            addVirag.TextAlign = ContentAlignment.TopCenter;
            addVirag.UseVisualStyleBackColor = true;
            addVirag.Click += addVirag_Click;
            // 
            // listViragok
            // 
            listViragok.BackColor = Color.White;
            listViragok.BackgroundImage = (Image)resources.GetObject("listViragok.BackgroundImage");
            listViragok.BackgroundImageLayout = ImageLayout.Stretch;
            listViragok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViragok.Location = new Point(394, 315);
            listViragok.Margin = new Padding(4);
            listViragok.Name = "listViragok";
            listViragok.Size = new Size(356, 293);
            listViragok.TabIndex = 4;
            listViragok.Text = "Virágok kilistázása";
            listViragok.TextAlign = ContentAlignment.TopCenter;
            listViragok.UseVisualStyleBackColor = false;
            listViragok.Click += listViragok_Click;
            // 
            // addViragKat
            // 
            addViragKat.BackgroundImage = (Image)resources.GetObject("addViragKat.BackgroundImage");
            addViragKat.BackgroundImageLayout = ImageLayout.Stretch;
            addViragKat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addViragKat.Location = new Point(770, 24);
            addViragKat.Margin = new Padding(4);
            addViragKat.Name = "addViragKat";
            addViragKat.Size = new Size(356, 283);
            addViragKat.TabIndex = 2;
            addViragKat.Text = "Virágkategória hozzáadása";
            addViragKat.TextAlign = ContentAlignment.TopCenter;
            addViragKat.UseVisualStyleBackColor = true;
            addViragKat.Click += addViragKat_Click;
            // 
            // addErtekesites
            // 
            addErtekesites.BackColor = Color.White;
            addErtekesites.BackgroundImage = (Image)resources.GetObject("addErtekesites.BackgroundImage");
            addErtekesites.BackgroundImageLayout = ImageLayout.Stretch;
            addErtekesites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addErtekesites.Location = new Point(17, 315);
            addErtekesites.Margin = new Padding(4);
            addErtekesites.Name = "addErtekesites";
            addErtekesites.Size = new Size(356, 293);
            addErtekesites.TabIndex = 3;
            addErtekesites.Text = "Értékesités hozzáadása";
            addErtekesites.TextAlign = ContentAlignment.TopCenter;
            addErtekesites.UseVisualStyleBackColor = false;
            addErtekesites.Click += addErtekesites_Click;
            // 
            // listErtekesites
            // 
            listErtekesites.BackColor = Color.White;
            listErtekesites.BackgroundImage = (Image)resources.GetObject("listErtekesites.BackgroundImage");
            listErtekesites.BackgroundImageLayout = ImageLayout.Stretch;
            listErtekesites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listErtekesites.Location = new Point(770, 315);
            listErtekesites.Margin = new Padding(4);
            listErtekesites.Name = "listErtekesites";
            listErtekesites.Size = new Size(356, 283);
            listErtekesites.TabIndex = 5;
            listErtekesites.Text = "Értékesitések kilistázása";
            listErtekesites.TextAlign = ContentAlignment.TopCenter;
            listErtekesites.UseVisualStyleBackColor = false;
            listErtekesites.Click += listErtekesites_Click;
            // 
            // addVevo
            // 
            addVevo.BackColor = Color.White;
            addVevo.BackgroundImage = (Image)resources.GetObject("addVevo.BackgroundImage");
            addVevo.BackgroundImageLayout = ImageLayout.Stretch;
            addVevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addVevo.Location = new Point(394, 24);
            addVevo.Margin = new Padding(4);
            addVevo.Name = "addVevo";
            addVevo.Size = new Size(356, 283);
            addVevo.TabIndex = 1;
            addVevo.Text = "Vevő hozzáadása";
            addVevo.TextAlign = ContentAlignment.TopCenter;
            addVevo.UseVisualStyleBackColor = false;
            addVevo.Click += addVevo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1143, 630);
            Controls.Add(listErtekesites);
            Controls.Add(addVevo);
            Controls.Add(addErtekesites);
            Controls.Add(addViragKat);
            Controls.Add(listViragok);
            Controls.Add(addVirag);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Virábolt kezelő";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addVirag;
        private Button listViragok;
        private Button addViragKat;
        private Button addErtekesites;
        private Button listErtekesites;
        private Button addVevo;
    }
}