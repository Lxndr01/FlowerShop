namespace ViragShopGUI
{
    partial class AddViragKategoria
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
            txbName = new TextBox();
            txbDecsription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txbName
            // 
            txbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbName.Location = new Point(310, 86);
            txbName.Name = "txbName";
            txbName.Size = new Size(160, 23);
            txbName.TabIndex = 0;
            // 
            // txbDecsription
            // 
            txbDecsription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbDecsription.Location = new Point(289, 168);
            txbDecsription.Name = "txbDecsription";
            txbDecsription.Size = new Size(210, 23);
            txbDecsription.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 2;
            label1.Text = "Virágkategória hozzáadása";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(310, 68);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Kategória neve:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(289, 150);
            label3.Name = "label3";
            label3.Size = new Size(210, 15);
            label3.TabIndex = 4;
            label3.Text = "Kategória megjegyzés (nem kötelező ):";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(360, 214);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddViragKategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbDecsription);
            Controls.Add(txbName);
            Name = "AddViragKategoria";
            Text = "AddViragKategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbName;
        private TextBox txbDecsription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
    }
}