using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Driver_Info.xaml
    /// </summary>
    public partial class Driver_Info : Window
    {
        public Driver_Info()
        {
            InitializeComponent();
            //ConnectionViewModel vm = new ConnectionViewModel();
            //DataContext = vm;
        }


        //private void submiting_Click(object sender, RoutedEventArgs e)
        //{
        //    Max_Verstappen mv = new Max_Verstappen();
        //    Charles_Leclerc cl = new Charles_Leclerc();
        //    Carlos_Sainz cs = new Carlos_Sainz();
        //    Pierre_Gasly pg = new Pierre_Gasly();
        //    Lewis_Hamilton lh = new Lewis_Hamilton();
        //    Daniel_Ricciardo dr = new Daniel_Ricciardo();
        //    SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC03\LOCALHOST; Initial Catalog=projectme; Integrated Security=True");

        //    try
        //    {
        //        sqlCon.Open();
        //        string query = $"Select * from DriverInfo where Driver_lastName = {comboBox.Text}";
        //        SqlCommand cmd = new SqlCommand(query, sqlCon);
        //        cmd.ExecuteNonQuery();
        //        SqlDataReader reader = cmd.ExecuteReader();



        //        if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
        //        {
        //            while (reader.Read())
        //            {

        //                mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
        //                mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
        //                mv.maxbirthdayblock.Text = reader["DOB"].ToString();
        //                mv.maxcountryblock.Text = reader["Country"].ToString();
        //                mv.maxheightblock.Text = reader["Height"].ToString();
        //                mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
        //                mv.maxteamblock.Text = reader["TeamName"].ToString();
        //                mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
        //                mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
        //                mv.maxsalaryblock.Text = reader["Salary"].ToString();

        //            }

        //        }

        //        mv.Show();

        //        //sqlCon.Open();

        //        //string query = " select * from DriverInfo where Driver_last+Name = '" + (comboBox.Items.Count - 6) + "'";

        //        //SqlCommand cmd = new SqlCommand(query, sqlCon);

        //        //SqlDataReader reader = cmd.ExecuteReader();


        //        if (comboBox.SelectedIndex == comboBox.Items.Count - 6)
        //        {
        //            mv.Show();
        //            this.Close();

        //        }
        //        else if (comboBox.SelectedIndex == comboBox.Items.Count - 5)
        //        {
        //            cl.Show();
        //            this.Close();
        //        }
        //        else if (comboBox.SelectedIndex == comboBox.Items.Count - 4)
        //        {
        //            cs.Show();
        //            this.Close();

        //        }
        //        else if (comboBox.SelectedIndex == comboBox.Items.Count - 3)
        //        {
        //            pg.Show();
        //            this.Close();

        //        }
        //        else if (comboBox.SelectedIndex == comboBox.Items.Count - 2)
        //        {
        //            lh.Show();
        //            this.Close();

        //        }
        //        else if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
        //        {
        //            dr.Show();
        //            this.Close();
        //        }

        //        //while (reader.Read())
        //        //{
        //        //    if (comboBox.SelectedIndex == comboBox.Items.Count - 6)
        //        //    {
                        

        //        //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
        //        //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
        //        //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
        //        //        mv.maxcountryblock.Text = reader["Country"].ToString();
        //        //        mv.maxheightblock.Text = reader["Height"].ToString();
        //        //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
        //        //        mv.maxteamblock.Text = reader["TeamName"].ToString();
        //        //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
        //        //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
        //        //        mv.maxsalaryblock.Text = reader["Salary"].ToString();

        //        //    }
        //        //    else if (comboBox.SelectedIndex == comboBox.Items.Count - 5)
        //        //    {
        //        //        cl.Show();
        //        //        this.Close();
        //        //    }
        //        //    else if (comboBox.SelectedIndex == comboBox.Items.Count - 4)
        //        //    {
        //        //        cs.Show();
        //        //        this.Close();

        //        //    }
        //        //    else if (comboBox.SelectedIndex == comboBox.Items.Count - 3)
        //        //    {
        //        //        pg.Show();
        //        //        this.Close();

        //        //    }
        //        //    else if (comboBox.SelectedIndex == comboBox.Items.Count - 2)
        //        //    {
        //        //        lh.Show();
        //        //        this.Close();

        //        //    }
        //        //    else if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
        //        //    {
        //        //        dr.Show();
        //        //        this.Close();
        //        //    }

        //        //}

        //    }

        //    catch (Exception ex)

        //    {

        //        MessageBox.Show(ex.Message);

        //    }

        //    finally

        //    {

        //        sqlCon.Close();

        //    }
            
            
        //}

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void DriverBack_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Max_Verstappen mv = new Max_Verstappen();
            
            //SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC03\LOCALHOST; Initial Catalog=projectme; Integrated Security=True");

            //try
            //{
            //    sqlCon.Open();
            //    string query = "Select * from DriverInfo where Driver_lastName = '"+comboBox.Text+"'";
            //    SqlCommand cmd = new SqlCommand(query, sqlCon);
            //    cmd.ExecuteNonQuery();
            //    SqlDataReader reader = cmd.ExecuteReader();



            //        while (reader.Read())
            //        {


            //            mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
            //            mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
            //            mv.maxbirthdayblock.Text = reader["DOB"].ToString();
            //            mv.maxcountryblock.Text = reader["Country"].ToString();
            //            mv.maxheightblock.Text = reader["Height"].ToString();
            //            mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
            //            mv.maxteamblock.Text = reader["TeamName"].ToString();
            //            mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
            //            mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
            //            mv.maxsalaryblock.Text = reader["Salary"].ToString();
            //        mv.Show();

            //    }
                    

                

                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 5)
                //{
                //    while (reader.Read())
                //    {


                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();
                        
                //    }
                //    mv.Show();
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 4)
                //{
                //    while (reader.Read())
                //    {


                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();
                        
                //    }
                //    mv.Show();
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 3)
                //{
                //    while (reader.Read())
                //    {


                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();
                        
                //    }
                //    mv.Show();
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 2)
                //{
                //    while (reader.Read())
                //    {


                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();
                //        mv.Show();
                //    }
                    
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
                //{
                //    while (reader.Read())
                //    {


                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();
                        
                //    }
                //    mv.Show();
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 4)
                //{
                //    while (reader.Read())
                //    {

                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();

                //    }
                //    mv.Show();
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 3)
                //{
                //    reader.Read();


                //    mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //    mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //    mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //    mv.maxcountryblock.Text = reader["Country"].ToString();
                //    mv.maxheightblock.Text = reader["Height"].ToString();
                //    mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //    mv.maxteamblock.Text = reader["TeamName"].ToString();
                //    mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //    mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //    mv.maxsalaryblock.Text = reader["Salary"].ToString();


                //    mv.Show();
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 2)
                //{
                //    while (reader.Read())
                //    {

                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();

                //    }
                //    mv.Show();
                //}
                //else if (comboBox.SelectedIndex == comboBox.Items.Count - 1)
                //{
                //    while (reader.Read())
                //    {

                //        mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                //        mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                //        mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                //        mv.maxcountryblock.Text = reader["Country"].ToString();
                //        mv.maxheightblock.Text = reader["Height"].ToString();
                //        mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                //        mv.maxteamblock.Text = reader["TeamName"].ToString();
                //        mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                //        mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                //        mv.maxsalaryblock.Text = reader["Salary"].ToString();

                //    }
                //    mv.Show();
                //}
            }

        private void submiting_Click(object sender, RoutedEventArgs e)
        {
            Max_Verstappen mv = new Max_Verstappen();

            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC03\LOCALHOST; Initial Catalog=projectme; Integrated Security=True");

            try
            {
                sqlCon.Open();
                string query = "Select * from DriverInfo where Driver_lastName = '" + comboBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {


                    mv.maxfirstNameblock.Text = reader["Driver_firstName"].ToString();
                    mv.maxlastNameblock.Text = reader["Driver_lastname"].ToString();
                    mv.maxbirthdayblock.Text = reader["DOB"].ToString();
                    mv.maxcountryblock.Text = reader["Country"].ToString();
                    mv.maxheightblock.Text = reader["Height"].ToString();
                    mv.maxyearsexperienceblock.Text = reader["YExperience"].ToString();
                    mv.maxteamblock.Text = reader["TeamName"].ToString();
                    mv.maxdrivernumberblock.Text = reader["DriverNumber"].ToString();
                    mv.maxworldcpblock.Text = reader["WorldChampionship_N"].ToString();
                    mv.maxsalaryblock.Text = reader["Salary"].ToString();
                    mv.Show();

                }
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

    }

    
    