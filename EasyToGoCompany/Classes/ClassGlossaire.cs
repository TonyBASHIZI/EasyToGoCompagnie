using MySql.Data.MySqlClient;
using EasyToGoCompany.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EasyToGoCompany.Classes
{
    public class Glossaire
    {
        private MySqlDataAdapter adapter = null;
        
        private static Glossaire _instance = null;

        public Glossaire()
        {
            InitializeConnection();
        }

        public static Glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Glossaire();
                return _instance;
            }
        }

        #region Common

        public void InitializeConnection()
        {
            try
            {
                Connection.Connection.Instance.Connect();

                if (Connection.Connection.Instance.Con.State == ConnectionState.Closed)
                    Connection.Connection.Instance.Con.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Echec de connexion. \n" + ex.Message);
            }
        }

        private void SetParameter(IDbCommand cmd, string name, DbType type, int length,  object value)
        {
            IDbDataParameter param = cmd.CreateParameter();

            param.ParameterName = name;
            param.DbType = type;
            param.Size = length;

            if (value == null)
            {
                if (!param.IsNullable)
                {
                    param.DbType = DbType.String;
                }

                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = value;
            }

            cmd.Parameters.Add(param);
        }

        public DataSet LoadDatas(string table, string orderBy = " ", string where = " ", string value = null)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                DataSet ds = new DataSet();

                if (orderBy == " ")
                {
                    if (where == " " && value == null)
                    {
                        cmd.CommandText = "SELECT * FROM `easy_to_go`.`" + table + "`; ";

                        SetParameter(cmd, "@table", DbType.String, 30, table);

                        using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                        {
                            adapter.Fill(ds);
                        }
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = "SELECT * FROM `easy_to_go`.`" + table + "` WHERE `easy_to_go`.`" + table + "`.`" + where + "` = @value ; ";

                        SetParameter(cmd, "@value", DbType.String, 30, value);

                        using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                        {
                            adapter.Fill(ds);
                        }
                    }
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM `easy_to_go`.`" + table + "` ORDER BY `" + orderBy + "` DESC";

                    using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        adapter.Fill(ds);
                    }
                }

                return ds;
            }
        }

        public void LoadCombos(string field, string table, ComboBox combo)
        {
            combo.Items.Clear();

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT `" + field + "` FROM `easy_to_go`.`" + table + "` ORDER BY `" + field + "` ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    combo.Items.Add(dr[field]).ToString();
                }

                dr.Dispose();
                dr.Close();
            }
        }

        public List<string> LoadString(string field, string table)
        {
            List<string> list = new List<string>();

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT `" + field + "` FROM `easy_to_go`.`" + table + "` ORDER BY `" + field + "` ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(dr[field].ToString());
                }

                dr.Dispose();
                dr.Close();
            }

            return list;
        }

        public int SelectId(string table, string field)
        {
            int id = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (field.Contains("'"))
                {
                    int index = field.IndexOf("'");
                    field = field.Insert(index + 1, "'");
                }

                cmd.CommandText = "SELECT id FROM " + table + " WHERE designation = '" + field + "'";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }

                dr.Dispose();
                dr.Close();
            }

            return id;
        }

        public int SelectId(string table, string field, string value)
        {
            int id = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (field.Contains("'"))
                {
                    int index = field.IndexOf("'");
                    field = field.Insert(index + 1, "'");
                }

                cmd.CommandText = "SELECT id FROM `easy_to_go`.`" + table + "` WHERE `" + field + "` = `" + value + "`";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }

                dr.Dispose();
                dr.Close();
            }

            return id;
        }

        public void Delete(string table, int id)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM `easy_to_go`.`" + table + "` WHERE id = @id ;";

                SetParameter(cmd, "@id", DbType.Int32, 4, id);

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("Cet identifiante n'existe pas.");
            }
        }

        public DataSet LoadDashboard()
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                string date = Convert.ToDateTime(ConvertToOwerDateTimeFormat(DateTime.Now.ToString())).ToString("yyyy-MM-dd 00:00:00");
                DataSet ds = new DataSet();

                cmd.CommandText = "SELECT bus.ref_compagnie as COMPAGNIE, date_format(transaction.dateTransact, '%W, %M %d, %Y - %H:%i') as DATE, " +
                    "bus.numero as NUMERO, transaction.ref_bus as PLAQUE, (montant - (commission + fraisTransact)) as MONTANT " +
                    "FROM transaction inner join bus on transaction.ref_bus = bus.plaque " +
                    "where bus.ref_compagnie = @company AND dateTransact >= '"+ date +"' order by DATE desc; ";

                SetParameter(cmd, "@company", DbType.String, 100, User.Instance.DescriptionSession);

                using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                {
                    adapter.Fill(ds);
                }

                return ds;
            }
        }

        public int GetBusCount()
        {
            int nombre = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT count(ref_compagnie) as nombre FROM easy_to_go.bus " +
                    " WHERE easy_to_go.bus.ref_compagnie = @company group by ref_compagnie; ";

                SetParameter(cmd, "@company", DbType.String, 255, User.Instance.DescriptionSession);

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        nombre = dr["nombre"] == DBNull.Value ? 0 : Convert.ToInt32(dr["nombre"]);
                    }
                }
            }

            return nombre;
        }

        public int GetInactiveBusCount()
        {
            int nombre = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT count(ref_compagnie) as nombre FROM easy_to_go.bus " +
                    " WHERE bus.ref_compagnie = @company AND bus.etat = 'INACTIF' group by ref_compagnie; ";

                SetParameter(cmd, "@company", DbType.String, 255, User.Instance.DescriptionSession);

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        nombre = dr["nombre"] == DBNull.Value ? 0 : Convert.ToInt32(dr["nombre"]);
                    }
                }
            }

            return nombre;
        }

        public int GetAmount()
        {
            int nombre = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT solde FROM compte WHERE designation = @company ; ";

                SetParameter(cmd, "@company", DbType.String, 255, User.Instance.DescriptionSession);

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        nombre = dr["solde"] == DBNull.Value ? 0 : Convert.ToInt32(dr["solde"].ToString());
                    }
                }
            }

            return nombre;
        }

        public int GetAmountByBus(string plaque, string date = null)
        {
            int nombre = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (plaque != null && date == null)
                {
                    cmd.CommandText = "SELECT sum(montant - (commission + fraisTransact)) as montant FROM transaction WHERE ref_bus = '" + plaque +"'; ";

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            nombre = dr["montant"] == DBNull.Value? 0 : Convert.ToInt32(dr["montant"]);
                        }
                    }
                }
                else
                {
                    date = ConvertToOwerDateTimeFormat(date);
                    cmd.CommandText = "SELECT sum(montant - (commission + fraisTransact)) as montant FROM transaction " +
                        " WHERE ref_bus = '" + plaque + "' AND dateTransact >= '"+ date +"'; ";

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            nombre = dr["montant"] == DBNull.Value ? 0 : Convert.ToInt32(dr["montant"]);
                        }
                    }
                }
            }

            return nombre;
        }


        public int GetAmountBusByHour(string plaque, string date, string begin, string end)
        {
            int nombre = 0;
            date = Convert.ToDateTime(ConvertToOwerDateTimeFormat(date)).ToString("yyyy-MM-dd ");
            begin = date + begin.Insert(begin.LastIndexOf(":"), ":00");
            end = date + end.Insert(end.LastIndexOf(":"), ":00");

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT sum(montant - (commission + fraisTransact)) as montant FROM transaction " +
                    "WHERE (ref_bus = '" + plaque + "') AND (dateTransact BETWEEN '" + begin + "' AND '" + end + "'); ";

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        nombre = dr["montant"] == DBNull.Value ? 0 : Convert.ToInt32(dr["montant"]);
                    }
                }
            }

            return nombre;
        }

        public int GetAmountBusByDay(string plaque, string begin, string end)
        {
            int nombre = 0;
            begin = Convert.ToDateTime(ConvertToOwerDateTimeFormat(begin)).ToString("yyyy-MM-dd 00:00:00");
            end = Convert.ToDateTime(ConvertToOwerDateTimeFormat(end)).ToString("yyyy-MM-dd 00:00:00");

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT sum(montant - (commission + fraisTransact)) as montant FROM transaction " +
                    "WHERE (ref_bus = '" + plaque + "') AND (dateTransact BETWEEN '" + begin + "' AND '" + end + "'); ";

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        nombre = dr["montant"] == DBNull.Value ? 0 : Convert.ToInt32(dr["montant"]);
                    }
                }
            }

            return nombre;
        }

        #endregion

        #region Model

        public void InsertUpdateBus(Bus bus)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (bus.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO `easy_to_go`.`bus` (`ref_compagnie`,`ref_pos`,`numero`,`plaque`,`marque`," +
                        "`place`,`annee_fabrication`,`kilometrage`,`mise_en_circulation`, `etat`) VALUES " +
                        "(@ref_compagnie, @ref_pos, @numero, @plaque, @marque, @place, @fabrication, @km, @circulation, @etat); ";

                    SetParameter(cmd, "@ref_compagnie", DbType.String, 255, bus.RefCompagnie);
                    SetParameter(cmd, "@ref_pos", DbType.String, 255, bus.RefNumeroPos);
                    SetParameter(cmd, "@numero", DbType.String, 100, bus.Numero);
                    SetParameter(cmd, "@plaque", DbType.String, 100, bus.Plaque);
                    SetParameter(cmd, "@marque", DbType.String, 100, bus.Marque);
                    SetParameter(cmd, "@place", DbType.Int32, 10, bus.Place);
                    SetParameter(cmd, "@fabrication", DbType.String, 100, bus.AnneeFabrication);
                    SetParameter(cmd, "@km", DbType.String, 100, bus.Kilometrage);
                    SetParameter(cmd, "@circulation", DbType.DateTime, 100, bus.MiseEnCirculation);
                    SetParameter(cmd, "@etat", DbType.String, 100, bus.Etat);
                }
                else
                {
                    cmd.CommandText = "UPDATE `easy_to_go`.`bus` SET `ref_compagnie` = @ref_compagnie, `numero` = @numero," +
                        "`plaque` = @plaque, `ref_pos` = @ref_pos, `marque` = @marque, `place` = @place, " +
                        "`annee_fabrication` = @fabrication, `kilometrage` = @km, `mise_en_circulation` = @circulation, " +
                        "`etat` = @etat WHERE `id` = @id; ";

                    SetParameter(cmd, "@id", DbType.Int32, 10, bus.Id);
                    SetParameter(cmd, "@ref_compagnie", DbType.String, 255, bus.RefCompagnie);
                    SetParameter(cmd, "@ref_pos", DbType.String, 255, bus.RefNumeroPos);
                    SetParameter(cmd, "@numero", DbType.String, 100, bus.Numero);
                    SetParameter(cmd, "@plaque", DbType.String, 100, bus.Plaque);
                    SetParameter(cmd, "@marque", DbType.String, 100, bus.Marque);
                    SetParameter(cmd, "@place", DbType.Int32, 10, bus.Place);
                    SetParameter(cmd, "@fabrication", DbType.String, 100, bus.AnneeFabrication);
                    SetParameter(cmd, "@km", DbType.String, 100, bus.Kilometrage);
                    SetParameter(cmd, "@circulation", DbType.DateTime, 100, bus.MiseEnCirculation);
                    SetParameter(cmd, "@etat", DbType.String, 100, bus.Etat);

                }

                cmd.ExecuteNonQuery();
            }
        }

        public Compagnie GetCompagnie(string name = null)
        {
            Compagnie compagnie = null;
            byte[] photo = null;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (name != null)
                {
                    cmd.CommandText = "SELECT * FROM easy_to_go.compagnie WHERE `compagnie`.`noms` = @name; ";

                    SetParameter(cmd, "@name", DbType.String, 255, name);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            compagnie = new Compagnie
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Adresse = dr["adresse"].ToString(),
                                Description = dr["description"].ToString(),
                                Noms = dr["noms"].ToString(),
                                Rccm = dr["rccm"].ToString(),
                                Photo = dr["photo"] == DBNull.Value ? photo : (byte[])dr["photo"]
                            };
                        }
                    }

                }
                else
                {
                    throw new Exception("Ce profile n'existe pas. Veillez contacter l'adminisatrateur du sytème");
                }

                return compagnie;
            }
        }

        public void InsertUpdateCompagnie(Compagnie comp)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (comp.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO `easy_to_go`.`compagnie` (`noms`,`description`,`adresse`,`photo`,`rccm`)"
                        + " VALUES (@noms,@description,@adresse,@photo,@rccm); " +
                        "UPDATE `easy_to_go`.`utilisateur` SET `description` = @noms WHERE `id` = @idUser; ";

                    SetParameter(cmd, "@idUser", DbType.Int32, 10, User.Instance.IdSession);
                    SetParameter(cmd, "@noms", DbType.String, 255, comp.Noms);
                    SetParameter(cmd, "@description", DbType.String, 255, comp.Description);
                    SetParameter(cmd, "@adresse", DbType.String, 255, comp.Adresse);
                    SetParameter(cmd, "@rccm", DbType.String, 35, comp.Rccm);
                    SetParameter(cmd, "@photo", DbType.Binary, int.MaxValue, comp.Photo);
                }
                else
                {
                    cmd.CommandText = "UPDATE `easy_to_go`.`compagnie` SET `noms` = @noms, `description` = @description, " 
                        + "`adresse` = @adresse, `photo` = @photo, `rccm` = @rccm WHERE `id` = @id; " +
                        "UPDATE `easy_to_go`.`utilisateur` SET `description` = @noms WHERE `id` = @idUser; ";

                    SetParameter(cmd, "@idUser", DbType.Int32, 10, User.Instance.IdSession);
                    SetParameter(cmd, "@id", DbType.Int32, 10, comp.Id);
                    SetParameter(cmd, "@noms", DbType.String, 255, comp.Noms);
                    SetParameter(cmd, "@description", DbType.String, 255, comp.Description);
                    SetParameter(cmd, "@adresse", DbType.String, 255, comp.Adresse);
                    SetParameter(cmd, "@rccm", DbType.String, 35, comp.Rccm);
                    SetParameter(cmd, "@photo", DbType.Binary, int.MaxValue, comp.Photo);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public User LoginRequest(string username, string password)
        {
            User user = null;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM `easy_to_go`.`utilisateur`	WHERE " +
                    " `utilisateur`.`username` = @username AND `utilisateur`.`password` = @password " +
                    " AND `utilisateur`.`etat` = @etat; ";

                /// TODO: Select Code Compagnie for more authenticity

                SetParameter(cmd, "@username", DbType.String, 255, username);
                SetParameter(cmd, "@password", DbType.String, 255, password);
                SetParameter(cmd, "@etat", DbType.String, 255, "ACTIF");

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        user = new User
                        {
                            IdSession = Convert.ToInt32(dr["id"]),
                            DescriptionSession = dr["description"].ToString(),
                            UsernameSession = dr["username"].ToString(),
                            NiveauSession = Convert.ToInt32(dr["niveau"]),
                            PasswordSession = dr["password"].ToString()
                        };
                    }
                }
            }

            return user;
        }

        public bool UpdateUser(User user)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (user.Id == 0)
                {
                    cmd.CommandText = "UPDATE `easy_to_go`.`utilisateur` SET `username` = @username, `password` = @password " +
                        " WHERE `id` = @idUser; ";

                    SetParameter(cmd, "@idUser", DbType.Int32, 10, User.Instance.IdSession);
                    SetParameter(cmd, "@description", DbType.String, 255, User.Instance.DescriptionSession);
                    SetParameter(cmd, "@username", DbType.String, 255, user.Username);
                    SetParameter(cmd, "@password", DbType.String, 255, user.Password);
                    SetParameter(cmd, "@niveau", DbType.String, 10, user.Niveau);

                }

                return cmd.ExecuteNonQuery() != 0 ? true : false;
            }
        }

        #endregion

        #region Annexe

        public string ConvertToOwerDateTimeFormat(string field)
        {
            string date = null;

            if (field.Contains("Jan") || field.Contains("Feb") || field.Contains("Mar") ||
                field.Contains("Apr") || field.Contains("Jun") || field.Contains("Jul") ||
                field.Contains("Aug") || field.Contains("Sep") || field.Contains("Oct") ||
                field.Contains("Nov") || field.Contains("Dec"))
            {
                if (field.Contains("Jan"))
                {
                    int index = field.IndexOf("Jan");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "01");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Feb"))
                {
                    int index = field.IndexOf("Feb");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "02");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Mar"))
                {
                    int index = field.IndexOf("Mar");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "03");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Apr"))
                {
                    int index = field.IndexOf("Apr");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "04");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("May"))
                {
                    int index = field.IndexOf("May");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "05");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Jun"))
                {
                    int index = field.IndexOf("Jun");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "06");
                }

                if (field.Contains("Jul"))
                {
                    int index = field.IndexOf("Jul");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "07");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Aug"))
                {
                    int index = field.IndexOf("Aug");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "08");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Sep"))
                {
                    int index = field.IndexOf("Sep");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "09");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Oct"))
                {
                    int index = field.IndexOf("Oct");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "10");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Nov"))
                {
                    int index = field.IndexOf("Nov");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "11");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Dec"))
                {
                    int index = field.IndexOf("Dec");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "12");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            else
            {
                date = field;
            }

            return date;
        }

        #endregion
    }
}
