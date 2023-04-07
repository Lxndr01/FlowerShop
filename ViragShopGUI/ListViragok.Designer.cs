namespace ViragShopGUI
{
    partial class ListViragok
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
            vviragDGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)vviragDGrid).BeginInit();
            SuspendLayout();
            // 
            // vviragDGrid
            // 
            vviragDGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vviragDGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vviragDGrid.Location = new Point(12, 12);
            vviragDGrid.Name = "vviragDGrid";
            vviragDGrid.RowTemplate.Height = 25;
            vviragDGrid.Size = new Size(785, 426);
            vviragDGrid.TabIndex = 0;
            // 
            // ListViragok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vviragDGrid);
            Name = "ListViragok";
            Text = "ListViragok";
            Load += ListViragok_Load;
            ((System.ComponentModel.ISupportInitialize)vviragDGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vviragDGrid;
    }
}