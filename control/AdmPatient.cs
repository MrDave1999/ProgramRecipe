using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using sCompare;

namespace ProgramRecipe
{
    static class AdmPatient
    {
        public static List<Patient> ListPatient { get; set; }
        static AdmPatient()
        {
            ListPatient = new List<Patient>();
        }

        public static bool IsRepeatData(string nameTable, string nameCampus, string data)
        {
            OleDbDataReader dr = null;
            bool error = false;
            string cmd = "SELECT * FROM " + nameTable + " WHERE " + nameCampus + " = ?";
            if (ConnectionBD.Open()) 
                return true;
            Data.Cmd.Parameters.AddWithValue("?", data);
            if (Data.Read(cmd, ref dr) || dr.Read())
                error = true;
            if(dr != null)
                dr.Close();
            Data.Cmd.Parameters.Clear();
            ConnectionBD.Connection.Close();
            return error;
        }
        
        public static bool Save(string[] txt)
        {
            bool error;
            string cmd = "INSERT INTO tablePatient(Nombre,Apellido,Cedula,Edad) VALUES(?,?,?,?)";
            foreach(string campus in txt)
                Data.Cmd.Parameters.AddWithValue("?", campus);
            error = Data.InsertCommand(cmd);
            Data.Cmd.Parameters.Clear();
            return error;
        }

        public static bool Read(string typeSearch, string txt, int index)
        {
            SCompare txtEntry = new SCompare(txt);
            OleDbDataReader dr = null;
            Patient pt;
            string cmd = "";
            bool error;
            if (ConnectionBD.Open())
                return true;
            cmd = "SELECT * FROM tablePatient WHERE " + typeSearch + " = ?";
            Data.Cmd.Parameters.AddWithValue("?", txt);
            if (!(error = Data.Read(cmd, ref dr)))
            {
                while (dr.Read())
                {
                    if (txtEntry == dr.GetString(index))
                    {
                        pt = new Patient();
                        pt.Name = dr.GetString(1);
                        pt.Surname = dr.GetString(2);
                        pt.Idcard = dr.GetString(3);
                        pt.Age = dr.GetString(4);
                        ListPatient.Add(pt);
                    }
                }
            }
            if(dr != null)
                dr.Close();
            ConnectionBD.Connection.Close();
            Data.Cmd.Parameters.Clear();
            return error;
        }


        public static bool ReadAll()
        {
            OleDbDataReader dr = null;
            Patient pt;
            bool error;
            if (ConnectionBD.Open())
                return true;
            if (!(error = Data.Read("SELECT * FROM tablePatient", ref dr)))
            {
                while (dr.Read())
                {
                    pt = new Patient();
                    pt.Name = dr.GetString(1);
                    pt.Surname = dr.GetString(2);
                    pt.Idcard = dr.GetString(3);
                    pt.Age = dr.GetString(4);
                    ListPatient.Add(pt);
                }
            }
            if (dr != null)
                dr.Close();
            ConnectionBD.Connection.Close();
            return false;
        }
    }
}

