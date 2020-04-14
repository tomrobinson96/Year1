using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.database1DataSet.students);

        }

        private void addAnother_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::DataTable.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "insert into students (Id, student name) values("+textID.Text+", '"+textName.Text+"')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Add new record done", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.studentsTableAdapter.Fill(this.database1DataSet.students);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            finally
            {
                cn.Close();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.database1DataSet.students);
        }
    }
}
