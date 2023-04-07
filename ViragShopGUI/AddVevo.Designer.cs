namespace ViragShopGUI
{
    partial class AddVevo
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txbMennyiseg = new TextBox();
            txbSzin = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            txbEgysegar = new TextBox();
            txbName = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(316, 234);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 29;
            label7.Text = "Egységár:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(316, 191);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 28;
            label6.Text = "Mennyiség:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(316, 147);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 27;
            label5.Text = "Szín:";
            // 
            // txbMennyiseg
            // 
            txbMennyiseg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbMennyiseg.Location = new Point(316, 206);
            txbMennyiseg.Name = "txbMennyiseg";
            txbMennyiseg.Size = new Size(160, 23);
            txbMennyiseg.TabIndex = 25;
            // 
            // txbSzin
            // 
            txbSzin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSzin.Location = new Point(316, 165);
            txbSzin.Name = "txbSzin";
            txbSzin.Size = new Size(160, 23);
            txbSzin.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(353, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 23;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(319, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 22;
            label2.Text = "Vevő neve:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(289, 40);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 21;
            label3.Text = "Vevő hozzáadása";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txbEgysegar
            // 
            txbEgysegar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbEgysegar.Location = new Point(316, 252);
            txbEgysegar.Name = "txbEgysegar";
            txbEgysegar.Size = new Size(160, 23);
            txbEgysegar.TabIndex = 20;
            // 
            // txbName
            // 
            txbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbName.Location = new Point(316, 118);
            txbName.Name = "txbName";
            txbName.Size = new Size(160, 23);
            txbName.TabIndex = 19;
            // 
            // AddVevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txbMennyiseg);
            Controls.Add(txbSzin);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txbEgysegar);
            Controls.Add(txbName);
            Name = "AddVevo";
            Text = "AddVevo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txbMennyiseg;
        private TextBox txbSzin;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private TextBox txbEgysegar;
        private TextBox txbName;
    }
}