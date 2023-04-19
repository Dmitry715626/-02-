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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ПП02Фалалеев
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7Q0SKM1\\SQLEXPRESS;Initial Catalog=ПП02Фалалеев;Integrated Security=True");
          
            con.Open();
            SqlCommand cons = new SqlCommand($"SELECT Агенты = [Наименование агента] FROM агенты", con);
            SqlDataReader read = cons.ExecuteReader();
            while(read.Read())
            {
                listBox1.Items.Add(read["Агенты"].ToString());
            }
            
            con.Close();
        }
    }
}
