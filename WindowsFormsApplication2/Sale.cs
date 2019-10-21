using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Sale : UserControl
    {
        DataTable data;

        private static Sale _sale;

        private static List<Product> ProductList = new List<Product>();


        //Create instance for UserControl
        public static Sale Instance
        {
            get
            {
                if (_sale == null)
                {
                    _sale = new Sale();
                }
                return _sale;

            }
        }

        public Sale()
        {
            InitializeComponent();
            ProductList = new List<Product>();


        }

        private void btOpenProduct_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Excel Files | *.xlsx; *.xls; *.xlsm";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOpenProduct.Text = openDialog.FileName;
                }
                String connstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtOpenProduct.Text +
                        @";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';";

                OleDbConnection conn = new OleDbConnection(connstr);
                conn.Open();

                MessageBox.Show("Connection opened successfully.");

                cmbSheetProduct.DataSource = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                cmbSheetProduct.DisplayMember = "TABLE_NAME";
                cmbSheetProduct.ValueMember = "TABLE_NAME";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoadProduct_Click(object sender, EventArgs e)
        {
            data = getDatabase();


            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow drow = data.Rows[i];

                int _code = Int32.Parse(drow["code"].ToString());
                String _product = drow["product"].ToString();
                int  _quantity = Int32.Parse(drow["quantity"].ToString());


                ListViewItem item = new ListViewItem(_code.ToString());
                item.SubItems.Add(_product);
                item.SubItems.Add(_quantity.ToString());
                

                listViewProduct.Items.Add(item);
                
                ProductList.Add(new Product() { code = (int)_code, product = _product, quantity = (int)_quantity });
          }

        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            listViewProduct.Items.Clear(); //Clear all the Data in the ListView

            foreach (DataRow drow in data.Rows)

            {
                try
                {
                    if (drow["product"].ToString().ToLower().StartsWith(txtSearch.Text.ToLower())) //If the cell value is start with the value in the TextBox

                    {

                        ListViewItem item = new ListViewItem(drow["code"].ToString());
                        item.SubItems.Add(drow["product"].ToString());
                        item.SubItems.Add(drow["quantity"].ToString());

                        listViewProduct.Items.Add(item); //Add this row to the ListView

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }  
        }

        private DataTable getDatabase()
        {
            try
            {
                String connstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtOpenProduct.Text +
                        @";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';";
                OleDbConnection conn = new OleDbConnection(connstr);

                OleDbDataAdapter sda = new OleDbDataAdapter("Select * from [" + cmbSheetProduct.SelectedValue + "]", conn);

                data = new DataTable();
                sda.Fill(data);

                conn.Close();
                return data;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return data;
            }
        }

        private void btAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                int _quantity = 0;
                ListView.SelectedIndexCollection indices = listViewProduct.SelectedIndices;
                if (indices.Count > 0)
                {
                    int _code = ProductList[indices[0]].code;
                    String _product = ProductList[indices[0]].product;
                    

                    ListViewItem item = new ListViewItem(_code.ToString());
                    item.SubItems.Add(_product);
                    item.SubItems.Add((++_quantity).ToString());

                    listViewCart.Items.Add(item);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("(Add to cart) Error: ", ex.Message);
            }
        }
    }
}
