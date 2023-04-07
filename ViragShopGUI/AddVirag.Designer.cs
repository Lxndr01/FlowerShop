namespace ViragShopGUI
{
    partial class AddVirag
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
            CmbKategoria = new ComboBox();
            btnSave = new Button();
            label2 = new Label();
            txbEgysegar = new TextBox();
            txbName = new TextBox();
            txbSzin = new TextBox();
            txbMennyiseg = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // CmbKategoria
            // 
            CmbKategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbKategoria.FormattingEnabled = true;
            CmbKategoria.Location = new Point(293, 164);
            CmbKategoria.Name = "CmbKategoria";
            CmbKategoria.Size = new Size(160, 23);
            CmbKategoria.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(330, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(296, 96);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 9;
            label2.Text = "Virág neve:";
            label2.Click += label2_Click;
            // 
            // txbEgysegar
            // 
            txbEgysegar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbEgysegar.Location = new Point(293, 298);
            txbEgysegar.Name = "txbEgysegar";
            txbEgysegar.Size = new Size(160, 23);
            txbEgysegar.TabIndex = 7;
            // 
            // txbName
            // 
            txbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbName.Location = new Point(293, 114);
            txbName.Name = "txbName";
            txbName.Size = new Size(160, 23);
            txbName.TabIndex = 6;
            txbName.TextChanged += txbName_TextChanged;
            // 
            // txbSzin
            // 
            txbSzin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSzin.Location = new Point(293, 211);
            txbSzin.Name = "txbSzin";
            txbSzin.Size = new Size(160, 23);
            txbSzin.TabIndex = 12;
            // 
            // txbMennyiseg
            // 
            txbMennyiseg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbMennyiseg.Location = new Point(293, 252);
            txbMennyiseg.Name = "txbMennyiseg";
            txbMennyiseg.Size = new Size(160, 23);
            txbMennyiseg.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(293, 146);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 14;
            label4.Text = "Kategória neve:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(293, 193);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 15;
            label5.Text = "Szín:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(293, 237);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 16;
            label6.Text = "Mennyiség:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(293, 280);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 17;
            label7.Text = "Egységár:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(266, 36);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 8;
            label3.Text = "Virág hozzáadása";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddVirag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txbMennyiseg);
            Controls.Add(txbSzin);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txbEgysegar);
            Controls.Add(txbName);
            Controls.Add(CmbKategoria);
            Name = "AddVirag";
            Text = "AddVirag";
            FormClosing += AddVirag_FormClosing;
            Load += AddVirag_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbKategoria;
        private Button btnSave;
        private Label label2;
        private TextBox txbEgysegar;
        private TextBox txbName;
        private TextBox txbSzin;
        private TextBox txbMennyiseg;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label3;
    }
}