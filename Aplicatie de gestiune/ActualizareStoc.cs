using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Aplicatie_de_gestiune
{
    class ActualizareStoc
    {
      
            private OleDbConnection con = new OleDbConnection();
            private OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            OleDbDataReader r1;
            OleDbDataReader r2;
            private int cantitateActualizare = 0;
            private int cantitateActuala = 0;
        private int multiplicator = 0;

            public void actualizareStoc(int idProdus, int metoda, int catAmAdaugat)
            {
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\dudu\\Desktop\\Licenta Litrin Daniel Mihai\\Gestiune.mdb";
            cmd.Connection = con;
            switch (metoda)
            {
                case 1://APROVIZIONARE +
                    con.Open();
                    cmd.CommandText = "Select Cantitate " +
                        "from Produse " +
                        "Where IdProdus = " + idProdus + " ";
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        cantitateActualizare = r.GetInt32(0);
                        con.Close();
                        con.Open();
                        cmd.CommandText = "Update Produse " +
                        "SET Cantitate=(" + cantitateActualizare + "+" + catAmAdaugat + ") " +
                        "Where IdProdus = " + idProdus + "";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    con.Close();
                    cantitateActualizare = 0;
                    break;

                case 2://APROVIZIONARE -
                    con.Open();
                    cmd.CommandText = "Select Cantitate " +
                        "from Produse " +
                        "Where IdProdus = " + idProdus + " ";
                    r1 = cmd.ExecuteReader();
                    if (r1.Read())
                    {
                        cantitateActualizare = r1.GetInt32(0);
                        con.Close();
                        con.Open();
                        cmd.CommandText = "Update Produse " +
                        "SET Cantitate=(" + cantitateActualizare + "-" + catAmAdaugat + ") " +
                        "Where IdProdus = " + idProdus + "";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    con.Close();
                    cantitateActualizare = 0;
                    break;

                case 3://ABSOLVIRE ANULARE
                    List<string> list = new List<string>();
                    con.Open();
                    cmd.CommandText = "SELECT Ingredient FROM ProduseContinut WHERE IdProdus= " + idProdus + "";
                    r1 = cmd.ExecuteReader();
                    int i = 0;
                    while(r1.Read())
                    {
                        list.Add(r1.GetString(0));
                        i++;
                    }
                    con.Close();

                    for (int j = 0; j < i; j++)
                    {
                        con.Open();
                        cmd.CommandText = "SELECT Cantitate FROM Produse WHERE DProdus= '" + list[j] + "'";
                        r2 = cmd.ExecuteReader();
                        if (r2.Read())
                        {
                            cantitateActuala = r2.GetInt32(0);
                            con.Close();
                            con.Open();
                            cmd.CommandText = "SELECT CantitateIngredient FROM ProduseContinut WHERE Ingredient= '" + list[j] + "'";
                            r1 = cmd.ExecuteReader();
                            if (r1.Read())
                            {
                                multiplicator = r1.GetInt32(0);
                                con.Close();
                                con.Open();
                                cmd.CommandText = "UPDATE Produse SET Cantitate= " + (cantitateActuala - (multiplicator * catAmAdaugat)) + " WHERE DProdus= '" + list[j] + "'";
                                //MessageBox.Show(list[j] + " : " + cantitateActuala +" - "+ multiplicator  + catAmAdaugat.ToString());
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }
                    con.Close();
                    multiplicator = 0;
                    cantitateActuala = 0;
                    break;

                case 4:
                    List<string> list1 = new List<string>();
                    con.Open();
                    cmd.CommandText = "SELECT Ingredient FROM ProduseContinut WHERE IdProdus= " + idProdus + "";
                    r1 = cmd.ExecuteReader();
                    int i1 = 0;
                    while (r1.Read())
                    {
                        list1.Add(r1.GetString(0));
                        i1++;
                    }
                    con.Close();

                    for (int j = 0; j < i1; j++)
                    {
                        con.Open();
                        cmd.CommandText = "SELECT Cantitate FROM Produse WHERE DProdus= '" + list1[j] + "'";
                        r2 = cmd.ExecuteReader();
                        if (r2.Read())
                        {
                            cantitateActuala = r2.GetInt32(0);
                            con.Close();
                            con.Open();
                            cmd.CommandText = "SELECT CantitateIngredient FROM ProduseContinut WHERE Ingredient= '" + list1[j] + "'";
                            r1 = cmd.ExecuteReader();
                            if (r1.Read())
                            {
                                multiplicator = r1.GetInt32(0);
                                con.Close();
                                con.Open();
                                cmd.CommandText = "UPDATE Produse SET Cantitate= " + (cantitateActuala + (multiplicator * catAmAdaugat)) + " WHERE DProdus= '" + list1[j] + "'";
                                //MessageBox.Show(list1[j] + " : " + cantitateActuala +" - "+ multiplicator  + catAmAdaugat.ToString());
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }
                    con.Close(); 
                    multiplicator = 0;
                    cantitateActuala = 0;
                    break;
            }
        }
    }
}


