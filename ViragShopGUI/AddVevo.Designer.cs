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
            label5 = new Label();
            txbEmail = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            txbIranyitoszam = new TextBox();
            txbName = new TextBox();
            txbTelepules = new TextBox();
            txbCim = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(319, 191);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 29;
            label7.Text = "Vevő lakcíme:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(316, 147);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 27;
            label5.Text = "Vevő email címe:";
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbEmail.Location = new Point(316, 165);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(160, 23);
            txbEmail.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(358, 368);
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
            // txbIranyitoszam
            // 
            txbIranyitoszam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbIranyitoszam.Location = new Point(316, 231);
            txbIranyitoszam.Name = "txbIranyitoszam";
            txbIranyitoszam.Size = new Size(160, 23);
            txbIranyitoszam.TabIndex = 20;
            // 
            // txbName
            // 
            txbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbName.Location = new Point(316, 118);
            txbName.Name = "txbName";
            txbName.Size = new Size(160, 23);
            txbName.TabIndex = 19;
            // 
            // txbTelepules
            // 
            txbTelepules.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbTelepules.Location = new Point(316, 279);
            txbTelepules.Name = "txbTelepules";
            txbTelepules.Size = new Size(160, 23);
            txbTelepules.TabIndex = 30;
            // 
            // txbCim
            // 
            txbCim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbCim.Location = new Point(316, 327);
            txbCim.Name = "txbCim";
            txbCim.Size = new Size(160, 23);
            txbCim.TabIndex = 31;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(316, 213);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 32;
            label1.Text = "Irányítószám:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(316, 261);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 33;
            label4.Text = "Település:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(316, 309);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 34;
            label6.Text = "Cím:";
            // 
            // AddVevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txbCim);
            Controls.Add(txbTelepules);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txbEmail);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txbIranyitoszam);
            Controls.Add(txbName);
            Name = "AddVevo";
            Text = "AddVevo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private TextBox txbEmail;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private TextBox txbIranyitoszam;
        private TextBox txbName;
        private TextBox txbTelepules;
        private TextBox txbCim;
        private Label label1;
        private Label label4;
        private Label label6;
    }
}