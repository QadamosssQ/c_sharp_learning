using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Threading;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_test_login
{

    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        string data1 , data2 ;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data1 = login.Text;
            data2 = pass.Text;







            const string connection = "SERVER=localhost;DATABASE=table1;UID=root;PASSWORD=;";

            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();

            string query = "SELECT name FROM `users` WHERE login='"+data1+"' AND password= '"+data2+"'";






            try
            {

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader();

   

                if (read.Read())
                {
                    data_login.Text = (string)read["name"];

                    //to_hide.Visibility = Visibility.Collapsed;
                    
                }
                else
                {
                    
                }


            }

            catch (Exception ex)
            {
                data_pass.Text = "nie ma kogoœ takiego";
                
            }

           




        }
    }
}



//  <Grid Height="350" Width="625" Background="#FFD1F9EE">

//       </ Grid >