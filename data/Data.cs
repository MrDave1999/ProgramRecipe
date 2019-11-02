using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProgramRecipe
{
    static class Data
    {
        public static OleDbCommand Cmd { get; set; }

        static Data()
        {
            Cmd = new OleDbCommand();
        }

        public static bool InsertCommand(string command)
        { /* Comandos como UPDATE, DELETE, INSERT. */
            if (ConnectionBD.Open())
                return true;
            bool err = false;
            try
            {
                Cmd.Connection = ConnectionBD.Connection;
                Cmd.CommandText = command;
                Cmd.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Error: " + e.Message);
                err = true;
            }
            ConnectionBD.Connection.Close();
            return err;
        }

        public static bool Read(string command, ref OleDbDataReader dr)
        { /* Solo para SELECT. */
            try
            {
                 Cmd.Connection = ConnectionBD.Connection;
                 Cmd.CommandText = command;
                 dr = Cmd.ExecuteReader();
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Error: " + e.Message);
                return true;
            }
            return false;
        }
    }
}
