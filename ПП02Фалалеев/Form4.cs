using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПП02Фалалеев
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7Q0SKM1\\SQLEXPRESS;Initial Catalog=ПП02Фалалеев;Integrated Security=True");

            con.Open();
            SqlCommand cons = new SqlCommand($"SELECT * FROM Продажи", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cons);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            con.Close();
        }
    }
}
