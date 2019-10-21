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
    public partial class Home : UserControl
    {
        DataTable data;

        private static Home _home;

        public static Home Instance
        {
            get
            {
                if (_home == null)
                {
                    _home = new Home();
                }
                return _home;

            }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Excel Files | *.xlsx; *.xls; *.xlsm";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOpen.Text = openDialog.FileName;
                }
                String connstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtOpen.Text +
                        @";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';";

                OleDbConnection conn = new OleDbConnection(connstr);
                conn.Open();

                //MessageBox.Show("Connection opened successfully.");
                cmbSheet.DataSource = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                cmbSheet.DisplayMember = "TABLE_NAME";
                cmbSheet.ValueMember = "TABLE_NAME";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            data = getDatabase();

                foreach (DataRow row in data.Rows)
                {
                    dataGridView.DataSource = data;
                }
        }


        private DataTable getDatabase()
        {
            try
            {
                String connstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtOpen.Text +
                        @";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';";
                OleDbConnection conn = new OleDbConnection(connstr);

                OleDbDataAdapter sda = new OleDbDataAdapter("Select * from [" + cmbSheet.SelectedValue + "]", conn);

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
    }
}
