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

        public static bool Save(string drug, string prescrip, string dateDest, string dateBegin)
        {
            string cmd;
            cmd = "INSERT INTO tableRecipe(Farmaco,Preescripcion,Cedula,FechaInicio,FechaDestino) VALUES('" + drug + "','" + prescrip + "','" + CardPatient + "','" + dateBegin + "','" + dateDest + "')";
            return Data.InsertCommand(cmd);
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
            cmd = "SELECT * FROM tableRecipe WHERE Cedula = '" + CardPatient + "'";
            if (!(error = Data.Read(cmd, ref dr)))
            {
                while (dr.Read())
                {
                    if (txt == dr.GetString(3))
                    {
                        rp = new Recipe();
                        rp.Drugs = dr.GetString(1);
                        rp.Prescription = dr.GetString(2);
                        rp.DateBegin = dr.GetString(4);
                        rp.DateDest = dr.GetString(5);
                        ListRecipe.Add(rp);
                    }
                }
            }
            if(dr != null)
                dr.Close();
            ConnectionBD.Connection.Close();
            return error;
        }

        public static bool Delete(string drug)
        {
            string cmd = "DELETE FROM tableRecipe WHERE Cedula = '" + CardPatient + "' and Farmaco = '" + drug + "'";
            return Data.InsertCommand(cmd);
        }

        public static bool Update(string prescrip, string dateDest, string drugSelect)
        {
            string cmd;
            cmd = "UPDATE tableRecipe SET Preescripcion = '" + prescrip + "',FechaDestino = '" + dateDest + "' WHERE Cedula = '" + CardPatient + "' and Farmaco = '" + drugSelect + "'";
            return Data.InsertCommand(cmd);
        }
    }
}
