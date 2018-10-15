using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
namespace SampleAdo
{
    /// <summary>
    /// Interaction logic for SearchandUpdate.xaml
    /// </summary>
    public partial class SearchandUpdate : Window
    {
        public SearchandUpdate()
        {
            InitializeComponent();
        }

        private void btn_searchEmp_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conObj = new SqlConnection(@"Data Source=ndamssql\sqlilearn;Initial Catalog=Sep19CHN;User ID=sqluser;Password=sqluser");
            SqlCommand searchCmd = new SqlCommand("Geetha.usp_SearchEmployee", conObj);
            searchCmd.CommandType = CommandType.StoredProcedure;
            searchCmd.Parameters.AddWithValue("@eId", txt_empId.Text);
            SqlDataReader rdr = null;
            conObj.Open();
            rdr = searchCmd.ExecuteReader();
            DataTable dtEmp = new DataTable();
            
            if (rdr.HasRows)
            {
                dtEmp.Load(rdr);
                stpnl_Emp.Visibility = Visibility.Visible;
                txt_eName.Text = dtEmp.Rows[0][1].ToString();
                txt_eLoc.Text = dtEmp.Rows[0][2].ToString();
                txt_ePh.Text = dtEmp.Rows[0][3].ToString();

            }
            else MessageBox.Show("No records found");
           

            rdr.Close();
            conObj.Close();
        }

        private void btn_updateEmp_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conObj = new SqlConnection(@"Data Source=ndamssql\sqlilearn;Initial Catalog=Sep19CHN;User ID=sqluser;Password=sqluser");
            SqlCommand cmdObj = new SqlCommand("Geetha.usp_EditEmployee", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;//@eName,@eLoc,@ePh
            cmdObj.Parameters.AddWithValue("@eName", txt_eName.Text);
            cmdObj.Parameters.AddWithValue("@eLoc", txt_eLoc.Text);
            cmdObj.Parameters.AddWithValue("@ePh", txt_ePh.Text);
            cmdObj.Parameters.AddWithValue("@eId", txt_empId.Text);
            conObj.Open();
            int rowsAffected = cmdObj.ExecuteNonQuery(); // 
            conObj.Close();
            if (rowsAffected >= 1) MessageBox.Show("Record Updated!!");
        }

        private void btn_DisplayEmp_Click(object sender, RoutedEventArgs e)
        {
            EmpDetails winObj = new SampleAdo.EmpDetails();
            winObj.Show();


        }
    }
}
