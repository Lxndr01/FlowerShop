namespace ViragShopGUI
{
    partial class AddErtekesites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label4 = new Label();
            txbMennyiseg = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            CmbEmail = new ComboBox();
            CmbViragNeve = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(324, 231);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 28;
            label6.Text = "Mennyiség:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(321, 178);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 26;
            label4.Text = "Virág neve:";
            // 
            // txbMennyiseg
            // 
            txbMennyiseg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbMennyiseg.Location = new Point(321, 249);
            txbMennyiseg.Name = "txbMennyiseg";
            txbMennyiseg.Size = new Size(160, 23);
            txbMennyiseg.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(357, 293);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 23;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(324, 128);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 22;
            label2.Text = "Vásárló email címe:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(276, 66);
            label3.Name = "label3";
            label3.Size = new Size(275, 32);
            label3.TabIndex = 21;
            label3.Text = "Értékesítés hozzáadása";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // CmbEmail
            // 
            CmbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbEmail.FormattingEnabled = true;
            CmbEmail.Location = new Point(321, 146);
            CmbEmail.Name = "CmbEmail";
            CmbEmail.Size = new Size(160, 23);
            CmbEmail.TabIndex = 18;
            // 
            // CmbViragNeve
            // 
            CmbViragNeve.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbViragNeve.FormattingEnabled = true;
            CmbViragNeve.Location = new Point(321, 199);
            CmbViragNeve.Name = "CmbViragNeve";
            CmbViragNeve.Size = new Size(160, 23);
            CmbViragNeve.TabIndex = 30;
            // 
            // AddErtekesites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmbViragNeve);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txbMennyiseg);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(CmbEmail);
            Name = "AddErtekesites";
            Text = "AddErtekesites";
            Load += AddErtekesites_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txbMennyiseg;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private TextBox txbEgysegar;
        private ComboBox CmbKategoria;
        private ComboBox comboBox1;
        private ComboBox CmbEmail;
        private ComboBox CmbViragNeve;
    }
}