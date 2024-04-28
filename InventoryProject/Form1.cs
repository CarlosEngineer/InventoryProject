using System.Data;

namespace InventoryProject
{
    public partial class Form1 : Form
    {
        DataTable inventario = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Txt_Item.Text = "";
            Txt_Nome.Text = "";
            Txt_Descricao.Text = "";
            Txt_Preco.Text = "";
            Txt_Quantidade.Text = "";
            CmB_Categoria.SelectedIndex = -1;


        }

        private void Dtgv_Inventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Txt_Item.Text = inventario.Rows[Dtgv_Inventory.CurrentCell.RowIndex].ItemArray[0].ToString();
                Txt_Nome.Text = inventario.Rows[Dtgv_Inventory.CurrentCell.RowIndex].ItemArray[1].ToString();
                Txt_Preco.Text = inventario.Rows[Dtgv_Inventory.CurrentCell.RowIndex].ItemArray[3].ToString();
                Txt_Descricao.Text = inventario.Rows[Dtgv_Inventory.CurrentCell.RowIndex].ItemArray[4].ToString();
                Txt_Quantidade.Text = inventario.Rows[Dtgv_Inventory.CurrentCell.RowIndex].ItemArray[5].ToString();

                string itemprocurado = inventario.Rows[Dtgv_Inventory.CurrentCell.RowIndex].ItemArray[2].ToString();
                CmB_Categoria.SelectedIndex = CmB_Categoria.Items.IndexOf(itemprocurado);


            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error" + err);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventario.Columns.Add("Item");
            inventario.Columns.Add("Name");
            inventario.Columns.Add("Categoria");
            inventario.Columns.Add("Preco");
            inventario.Columns.Add("Descricao");
            inventario.Columns.Add("Quantidade");

            Dtgv_Inventory.DataSource = inventario;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            // salva os valores do campo das variaveis

            String item = Txt_Item.Text;
            String nome = Txt_Nome.Text;
            String descricao = Txt_Descricao.Text;
            String preco = Txt_Preco.Text;
            String quantidade = Txt_Quantidade.Text;

            string categoria = (string)CmB_Categoria.SelectedItem;

            // Adicionar valores 
            inventario.Rows.Add(item, nome, categoria, preco, descricao, quantidade);

            // limpa os valores dpois de salvar 
            Btn_New_Click(sender, e);

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                inventario.Rows[Dtgv_Inventory.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error" + err);
            }
        }

        private void Txt_Item_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
