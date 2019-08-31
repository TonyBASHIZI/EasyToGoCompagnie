using MySql.Data.MySqlClient;
using EasyToGoCompany.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToGoCompany.Classes
{
    public class Glossaire
    {
        private EasyToGoCompany.Classes.Connection.Connection cnx = null;

        private MySqlConnection con = null;
        private MySqlDataAdapter adapter = null;
        
        private static Glossaire _instance = null;

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
                cnx = new EasyToGoCompany.Classes.Connection.Connection();
                cnx.Connect();

                con = new MySqlConnection(cnx.path);

                if (!con.State.ToString().ToLower().Equals("open"))
                    con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de connexion. \n" +ex.Message);
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

        public DataSet LoadDatas(string table, string orderBy = " ")
        {
            InitializeConnection();

            using (IDbCommand cmd = con.CreateCommand())
            {
                DataSet ds = new DataSet();

                if (orderBy == " ")
                {
                    cmd.CommandText = "SELECT * FROM `easy_to_go`.`" + table;                   
                    adapter = new MySqlDataAdapter((MySqlCommand)cmd);
                    adapter.Fill(ds);
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM `easy_to_go`.`" + table + "` ORDER BY `" + orderBy + "` DESC";
                    adapter = new MySqlDataAdapter((MySqlCommand)cmd);
                    adapter.Fill(ds);
                }

                return ds;
            }
        }

        public void LoadCombos(string field, string table, ComboBox combo)
        {
            InitializeConnection();

            combo.Items.Clear();

            using (IDbCommand cmd = con.CreateCommand())
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
            InitializeConnection();

            List<string> list = new List<string>();

            using (IDbCommand cmd = con.CreateCommand())
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
            InitializeConnection();

            int id = 0;

            using (IDbCommand cmd = con.CreateCommand())
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
            InitializeConnection();

            int id = 0;

            using (IDbCommand cmd = con.CreateCommand())
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
            InitializeConnection();

            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM `easy_to_go`.`" + table + "` WHERE id = @id ;";

                SetParameter(cmd, "@id", DbType.Int32, 4, id);

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("Cet identifiante n'existe pas.");
            }
        }

        #endregion

        #region Model

        public void InsertUpdateBus(Bus bus)
        {
            InitializeConnection();

            using (IDbCommand cmd = con.CreateCommand())
            {
                if (bus.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO `easy_to_go`.`bus` (`ref_compagnie`,`ref_pos`,`numero`,`plaque`,`marque`," +
                        "`place`) VALUES (@ref_compagnie, @ref_pos, @numero, @plaque, @marque, @place); ";

                    SetParameter(cmd, "@ref_compagnie", DbType.String, 255, bus.RefCompagnie);
                    SetParameter(cmd, "@ref_pos", DbType.String, 255, bus.RefNumeroPos);
                    SetParameter(cmd, "@numero", DbType.String, 100, bus.Numero);
                    SetParameter(cmd, "@plaque", DbType.String, 100, bus.Plaque);
                    SetParameter(cmd, "@marque", DbType.String, 100, bus.Marque);
                    SetParameter(cmd, "@place", DbType.Int32, 10, bus.Place);
                }
                else
                {
                    cmd.CommandText = "UPDATE `easy_to_go`.`bus` SET `ref_compagnie` = @ref_compagnie, `numero` = @numero," +
                        "`plaque` = @plaque, `ref_pos` = @ref_pos, `marque` = @marque, `place` = @place WHERE `id` = @id; ";

                    SetParameter(cmd, "@id", DbType.Int32, 10, bus.Id);
                    SetParameter(cmd, "@ref_compagnie", DbType.String, 255, bus.RefCompagnie);
                    SetParameter(cmd, "@ref_pos", DbType.String, 255, bus.RefNumeroPos);
                    SetParameter(cmd, "@numero", DbType.String, 100, bus.Numero);
                    SetParameter(cmd, "@plaque", DbType.String, 100, bus.Plaque);
                    SetParameter(cmd, "@marque", DbType.String, 100, bus.Marque);
                    SetParameter(cmd, "@place", DbType.Int32, 10, bus.Place);
                }

                cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}
