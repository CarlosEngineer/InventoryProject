namespace InventoryProject
{
    partial class Form1
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
            Lbl_Title = new Label();
            Txt_Item = new TextBox();
            Txt_Preco = new TextBox();
            Txt_Nome = new TextBox();
            Txt_Descricao = new TextBox();
            Txt_Quantidade = new TextBox();
            Dtgv_Inventory = new DataGridView();
            Btn_New = new Button();
            Btn_Save = new Button();
            Btn_Delete = new Button();
            CmB_Categoria = new ComboBox();
            Lbl_Item = new Label();
            Lbl_Nome = new Label();
            Lbl_categoria = new Label();
            Lbl_preco = new Label();
            Lbl_Descricao = new Label();
            Lbl_Quantidade = new Label();
            ((System.ComponentModel.ISupportInitialize)Dtgv_Inventory).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Title
            // 
            Lbl_Title.Font = new Font("Myanmar Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Title.Location = new Point(12, 9);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new Size(652, 50);
            Lbl_Title.TabIndex = 0;
            Lbl_Title.Text = "Management  System Of Inventory 1.0";
            Lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Title.Click += label1_Click;
            // 
            // Txt_Item
            // 
            Txt_Item.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Item.ForeColor = Color.Black;
            Txt_Item.Location = new Point(12, 86);
            Txt_Item.Name = "Txt_Item";
            Txt_Item.PlaceholderText = "Digite o item";
            Txt_Item.Size = new Size(215, 23);
            Txt_Item.TabIndex = 1;
            Txt_Item.TextChanged += Txt_Item_TextChanged;
            // 
            // Txt_Preco
            // 
            Txt_Preco.Location = new Point(12, 133);
            Txt_Preco.Name = "Txt_Preco";
            Txt_Preco.Size = new Size(215, 23);
            Txt_Preco.TabIndex = 2;
            // 
            // Txt_Nome
            // 
            Txt_Nome.ForeColor = Color.Black;
            Txt_Nome.Location = new Point(246, 86);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(215, 23);
            Txt_Nome.TabIndex = 3;
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.Location = new Point(246, 133);
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.Size = new Size(215, 23);
            Txt_Descricao.TabIndex = 4;
            // 
            // Txt_Quantidade
            // 
            Txt_Quantidade.Location = new Point(467, 133);
            Txt_Quantidade.Name = "Txt_Quantidade";
            Txt_Quantidade.Size = new Size(215, 23);
            Txt_Quantidade.TabIndex = 5;
            // 
            // Dtgv_Inventory
            // 
            Dtgv_Inventory.BackgroundColor = Color.White;
            Dtgv_Inventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtgv_Inventory.Location = new Point(11, 189);
            Dtgv_Inventory.Name = "Dtgv_Inventory";
            Dtgv_Inventory.ReadOnly = true;
            Dtgv_Inventory.RowTemplate.Height = 25;
            Dtgv_Inventory.Size = new Size(668, 132);
            Dtgv_Inventory.TabIndex = 7;
            Dtgv_Inventory.CellDoubleClick += Dtgv_Inventory_CellDoubleClick;
            // 
            // Btn_New
            // 
            Btn_New.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_New.ForeColor = Color.Black;
            Btn_New.Location = new Point(12, 162);
            Btn_New.Name = "Btn_New";
            Btn_New.Size = new Size(215, 21);
            Btn_New.TabIndex = 8;
            Btn_New.Text = "Novo";
            Btn_New.UseVisualStyleBackColor = true;
            Btn_New.Click += Btn_New_Click;
            // 
            // Btn_Save
            // 
            Btn_Save.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Save.ForeColor = Color.Black;
            Btn_Save.Location = new Point(246, 162);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(215, 21);
            Btn_Save.TabIndex = 9;
            Btn_Save.Text = "Salvar";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Delete.ForeColor = Color.Black;
            Btn_Delete.Location = new Point(467, 162);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(215, 21);
            Btn_Delete.TabIndex = 10;
            Btn_Delete.Text = "Delete";
            Btn_Delete.UseVisualStyleBackColor = true;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // CmB_Categoria
            // 
            CmB_Categoria.FormattingEnabled = true;
            CmB_Categoria.Items.AddRange(new object[] { "Medicina", "Comida", "Roupa", "Moveis", "Feira" });
            CmB_Categoria.Location = new Point(467, 86);
            CmB_Categoria.Name = "CmB_Categoria";
            CmB_Categoria.Size = new Size(213, 23);
            CmB_Categoria.TabIndex = 11;
            // 
            // Lbl_Item
            // 
            Lbl_Item.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Item.ForeColor = Color.White;
            Lbl_Item.Location = new Point(12, 68);
            Lbl_Item.Name = "Lbl_Item";
            Lbl_Item.Size = new Size(207, 15);
            Lbl_Item.TabIndex = 12;
            Lbl_Item.Text = "Item";
            Lbl_Item.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Nome.ForeColor = Color.White;
            Lbl_Nome.Location = new Point(246, 68);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(207, 15);
            Lbl_Nome.TabIndex = 13;
            Lbl_Nome.Text = "Nome";
            Lbl_Nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_categoria
            // 
            Lbl_categoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_categoria.ForeColor = Color.White;
            Lbl_categoria.Location = new Point(467, 68);
            Lbl_categoria.Name = "Lbl_categoria";
            Lbl_categoria.Size = new Size(207, 15);
            Lbl_categoria.TabIndex = 14;
            Lbl_categoria.Text = "Categoria";
            Lbl_categoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_preco
            // 
            Lbl_preco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_preco.ForeColor = Color.White;
            Lbl_preco.Location = new Point(12, 115);
            Lbl_preco.Name = "Lbl_preco";
            Lbl_preco.Size = new Size(207, 15);
            Lbl_preco.TabIndex = 15;
            Lbl_preco.Text = "Preco";
            Lbl_preco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Descricao
            // 
            Lbl_Descricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Descricao.ForeColor = Color.White;
            Lbl_Descricao.Location = new Point(246, 115);
            Lbl_Descricao.Name = "Lbl_Descricao";
            Lbl_Descricao.Size = new Size(207, 15);
            Lbl_Descricao.TabIndex = 16;
            Lbl_Descricao.Text = "Descricao";
            Lbl_Descricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Quantidade
            // 
            Lbl_Quantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Quantidade.ForeColor = Color.White;
            Lbl_Quantidade.Location = new Point(467, 115);
            Lbl_Quantidade.Name = "Lbl_Quantidade";
            Lbl_Quantidade.Size = new Size(207, 15);
            Lbl_Quantidade.TabIndex = 17;
            Lbl_Quantidade.Text = "Quantidade";
            Lbl_Quantidade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(692, 333);
            Controls.Add(Lbl_Quantidade);
            Controls.Add(Lbl_Descricao);
            Controls.Add(Lbl_preco);
            Controls.Add(Lbl_categoria);
            Controls.Add(Lbl_Nome);
            Controls.Add(Lbl_Item);
            Controls.Add(CmB_Categoria);
            Controls.Add(Btn_Delete);
            Controls.Add(Btn_Save);
            Controls.Add(Btn_New);
            Controls.Add(Dtgv_Inventory);
            Controls.Add(Txt_Quantidade);
            Controls.Add(Txt_Descricao);
            Controls.Add(Txt_Nome);
            Controls.Add(Txt_Preco);
            Controls.Add(Txt_Item);
            Controls.Add(Lbl_Title);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Inventory Management Studio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Dtgv_Inventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Title;
        private TextBox Txt_Item;
        private TextBox Txt_Preco;
        private TextBox Txt_Nome;
        private TextBox Txt_Descricao;
        private TextBox Txt_Quantidade;
        private DataGridView Dtgv_Inventory;
        private Button Btn_New;
        private Button Btn_Save;
        private Button Btn_Delete;
        private ComboBox CmB_Categoria;
        private Label Lbl_Item;
        private Label Lbl_Nome;
        private Label Lbl_categoria;
        private Label Lbl_preco;
        private Label Lbl_Descricao;
        private Label Lbl_Quantidade;
    }
}
