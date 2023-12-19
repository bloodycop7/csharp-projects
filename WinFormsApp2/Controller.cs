using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{

    public class Controller
    {
        public string? lang { get; set; }
        public string? darkTheme { get; set; }
        public static string[] ThemeChange()
        {
            using (SqlConnection connection = new SqlConnection(Program.con))
            {
                int isDarkTheme = 0;
                string lang = "eng";
                string[] settings = {"0", "eng"};

                SqlCommand command = new SqlCommand("SELECT darkTheme, lang FROM [Settings]", connection);
                    command.Parameters.AddWithValue("@darkTheme", isDarkTheme);
                    command.Parameters.AddWithValue("@lang", lang);
                   
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                   
                    if (reader.HasRows)
                    {
                        reader.Read();
                        isDarkTheme = reader.GetInt32(0);
                        lang = reader.GetString(1);     
                    }
                connection.Close();

                settings[0] = isDarkTheme.ToString();
                settings[1] = lang;
                
                return settings;                 
            }
        }
        string[] Sentences = {};
        public static string[] AddQuestion(string question, string correctA, string wrongA1, string wrongA2)
        {
            return null;
        }
    }
}
