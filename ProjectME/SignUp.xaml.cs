using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ProjectME
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void SignUpGo_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC03\LOCALHOST; Initial Catalog=projectme; Integrated Security=True");

            try
            {


                //opening the connection to the db 

                sqlCon.Open();

                //Build our actual query 

                string query = "INSERT INTO Signup1(Username, [First Name], [Last Name], Email, Password, [Repeat Password]) values('" + this.txtusername.Text + "', '" + this.txtfirstname.Text + "', '" + this.txtlastname.Text + "', '" + this.txtemail.Text + "','" + this.psspassword.Password + "', '" + this.pssreppassword.Password + "')";

                //Establish a sql command

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                LogIn gf = new LogIn();
                gf.Show();
                this.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlCon.Close();

            }
        }

        //private void SignUpGo_Click(object sender, RoutedEventArgs e)
        //{
        //    SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC03\LOCALHOST; Initial Catalog=projectme; Integrated Security=True");

        //    try
        //    {
        //        if (sqlCon.State == ConnectionState.Closed)
        //        {
        //            sqlCon.Open();
        //        }

        //        string query = "Insert into Signup123 (FirstName, LastName, Username, Password, Email) values('" + this.txtFirstName.Text + "', '" + this.txtLastName.Text + "', '" + this.txtUsername.Text + "', '" + this.passwordbox.Password + "','" + this.txtEmail.Text + "')";

        //        SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
        //        sqlCommand.ExecuteNonQuery(); //Use this method when only parsing data one way
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
