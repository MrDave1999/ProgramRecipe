using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;

namespace ProgramRecipe
{
    static class ConnectionBD
    {
        public static OleDbConnection Connection { get; set; }

        public static string getConectionString()
        {
            var provider = ConfigurationManager.ConnectionStrings["Recipe"].ProviderName;
            var csSetting = ConfigurationManager.ConnectionStrings["Recipe"].ConnectionString;
            return "Provider =" + provider + "Data Source = " + csSetting; 
        }

		public static bool Open()
		{
			try
			{
                Connection = new OleDbConnection();
                Connection.ConnectionString = getConectionString();
                Connection.Open();
                //Console.Write("Conexión satisfactoria!");
			}
			catch (Exception e)
			{
                MessageBox.Show("Error: " + e.Message);
                return true;
			}
            return false;   
		}
	}
}
