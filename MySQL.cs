using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


/// <summary>
/// Permet de gerer les connections a la base de données
/// </summary>
namespace Quizz
{
    class MySQL
    {
        public static MySQL current;

        MySqlConnection _Connection;

        MySQL()
        {
            if (current == null)
                current = this;
        }
        public static void Init()
        {
            if (current == null)
                current = new MySQL();
        }

        /// <summary>
        /// Se connecter à une base de donnée
        /// </summary>
        /// <param name="server">Nom du serveur</param>
        /// <param name="database">Nom de la base de données</param>
        /// <param name="user">nom de l'utilisateur</param>
        /// <param name="password">Mot de passe de l'utilisateur</param>
        public void Connect(string server, string database, string user, string password)
        {
            _Connection = new MySqlConnection("SERVER=" + server + "; DATABASE=" + database + "; UID=" + user + "; PASSWORD=" + password);
            try
            {
                _Connection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Impossible de se connecter a la base de données "+ e.ToString());
            }
        }

        /// <summary>
        /// Fermer la derniere connection
        /// </summary>
        public void Close()
        {
            if(_Connection != null)
                _Connection.Close();
        }

        public void Insert(string table,string data)
        {
            MySqlCommand query = _Connection.CreateCommand();
            query.CommandText = "INSERT INTO " + table + " VALUES ('" + data + "')";
            try
            {
                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public Dictionary<string, List<string>> getData(string q)
        {
            Dictionary<string, List<string>> data = new Dictionary<string,List< string>>();
            MySqlCommand query = _Connection.CreateCommand();
            query.CommandText = q;
            try
            {

                MySqlDataReader reader = query.ExecuteReader();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    reader.Close();
                    reader = query.ExecuteReader();
                    List<string> temp = (from IDataRecord r in reader select r[reader.GetName(i)].ToString()).ToList(); 
                    data[reader.GetName(i)] = temp;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return data;
        }


    }
}
