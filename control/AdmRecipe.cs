using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using sCompare;

namespace ProgramRecipe
{
    class AdmRecipe
    {
        public static List<Recipe> ListRecipe { get; set; }

        static AdmRecipe()
        {
            ListRecipe = new List<Recipe>();
        }

        public static string CardPatient { get; set; }

        public static bool Save(string drug, string prescrip, DateTime dateDest)
        {
            bool error;
            string cmd;
            cmd = "INSERT INTO tableRecipe(Farmaco,Preescripcion,Cedula,FechaInicio,FechaDestino) VALUES(?,?,?,Date(),?)";
            Data.Cmd.Parameters.AddWithValue("?", drug);
            Data.Cmd.Parameters.AddWithValue("?", prescrip);
            Data.Cmd.Parameters.AddWithValue("?", CardPatient);
            Data.Cmd.Parameters.AddWithValue("?", dateDest.ToString());
            error = Data.InsertCommand(cmd);
            Data.Cmd.Parameters.Clear();
            return error;
        }

        public static bool Read()
        {
            SCompare txt = new SCompare(CardPatient);
            string cmd;
            Recipe rp;
            bool error;
            OleDbDataReader dr = null;
            if (ConnectionBD.Open())
                return true;
            cmd = "SELECT * FROM tableRecipe WHERE Cedula = ?";
            Data.Cmd.Parameters.AddWithValue("?", CardPatient);
            if (!(error = Data.Read(cmd, ref dr)))
            {
                while (dr.Read())
                {
                    if (txt == dr.GetString(3))
                    {
                        rp = new Recipe();
                        rp.Drugs = dr.GetString(1);
                        rp.Prescription = dr.GetString(2);
                        rp.DateBegin = dr.GetDateTime(4);
                        rp.DateDest = dr.GetDateTime(5);
                        ListRecipe.Add(rp);
                    }
                }
            }
            if(dr != null)
                dr.Close();
            ConnectionBD.Connection.Close();
            Data.Cmd.Parameters.Clear();
            return error;
        }

        public static bool Delete(string drug)
        {
            bool error;
            string cmd = "DELETE FROM tableRecipe WHERE Cedula = ? and Farmaco = ?";
            Data.Cmd.Parameters.AddWithValue("?", CardPatient);
            Data.Cmd.Parameters.AddWithValue("?", drug);
            error = Data.InsertCommand(cmd);
            Data.Cmd.Parameters.Clear();
            return error;
        }

        public static bool Update(string prescrip, DateTime dateDest, string drugSelect)
        {
            string cmd;
            bool error;
            cmd = "UPDATE tableRecipe SET Preescripcion = ?, FechaDestino = ? WHERE Cedula = ? and Farmaco = ?";
            Data.Cmd.Parameters.AddWithValue("?", prescrip);
            Data.Cmd.Parameters.AddWithValue("?", dateDest.ToString());
            Data.Cmd.Parameters.AddWithValue("?", CardPatient);
            Data.Cmd.Parameters.AddWithValue("?", drugSelect);
            error = Data.InsertCommand(cmd);
            Data.Cmd.Parameters.Clear();
            return error;
        }
    }
}
