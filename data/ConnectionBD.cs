using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProgramRecipe
{
    static class ConnectionBD
    {
        public static OleDbConnection Connection { get; set; }
		public static bool Open()
		{
			try
			{
                Connection = new OleDbConnection();
                Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dave\Documents\dateRecipe.accdb";
                Connection.Open();
                Console.Write("Conexión satisfactoria!");
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
