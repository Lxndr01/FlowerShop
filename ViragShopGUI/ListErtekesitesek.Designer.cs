namespace ViragShopGUI
{
    partial class ListErtekesitesek
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
            vErtekesitesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)vErtekesitesGridView).BeginInit();
            SuspendLayout();
            // 
            // vErtekesitesGridView
            // 
            vErtekesitesGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vErtekesitesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vErtekesitesGridView.Location = new Point(12, 12);
            vErtekesitesGridView.Name = "vErtekesitesGridView";
            vErtekesitesGridView.RowTemplate.Height = 25;
            vErtekesitesGridView.Size = new Size(776, 426);
            vErtekesitesGridView.TabIndex = 0;
            // 
            // ListErtekesitesek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vErtekesitesGridView);
            Name = "ListErtekesitesek";
            Text = "ListErtekesitesek";
            Load += ListErtekesitesek_Load;
            ((System.ComponentModel.ISupportInitialize)vErtekesitesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vErtekesitesGridView;
    }
}