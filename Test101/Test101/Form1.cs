using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Windows.Forms;

namespace Test101
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbDept.Items.Add("SEAITE");
            cbDept.Items.Add("SABH");
            cbDept.Items.Add("SEAS");
            cbDept.Items.Add("SHAS");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Department");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddrecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFname.Text) && string.IsNullOrEmpty(txtLname.Text) && cbDept == null)
            {
                MessageBox.Show("All input fields are required");
            }
            else
            {
                dt.Rows.Add(txtFname.Text, txtLname.Text, cbDept.SelectedItem);
                dgRecord.DataSource = dt;
            }
        }

        private void excelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Open Excel";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "All files (*.*)|*.*|ExcelFile (*.xlsx)|.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + openFileDialog1.FileName + "; Extended Properties='Excel 12.0 Xml; HDR=Yes'");
                conn.Open();
                string query = "select * from [" + openFileDialog1.FileName + "$]";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);
                dgRecord.DataSource = dt;
            }
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Text";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + openFileDialog1.FileName + "; Extended Properties='Excel 12.0 Xml; HDR=Yes'");
                conn.Open();
                string query = "select * from [" + openFileDialog1.FileName + "$]";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);
                dgRecord.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            { 
                this.Close();   
            }
            
        }
    }
}
