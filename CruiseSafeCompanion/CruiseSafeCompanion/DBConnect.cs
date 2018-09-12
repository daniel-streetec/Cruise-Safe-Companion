using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CruiseSafeCompanion
{
    public static class DBConnect
    {
        /// <summary>
        /// The connection to the MySql Database
        /// </summary>
        private static MySqlConnection _connection;
        
        /// <summary>
        /// Public property for _connection, initializes the connection if it is null
        /// </summary>
        public static MySqlConnection Connection
        {
            get
            {
                if (_connection == null)
                    _initializeConnection();

                return _connection;
            }
        }

        /// <summary>
        /// Initializes the MySqlConnection object _connection
        /// </summary>
        private static void _initializeConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "dedivirt134.your-server.de";
            builder.Database = "cruisesafe";
            builder.UserID = "nullnp_9_r";
            builder.Password = "Mmcm27sW6J9Brdd4";
            builder.ConnectionTimeout = 10;

            _connection = new MySqlConnection(builder.ToString());
        }

        /// <summary>
        /// Try to connect to the database
        /// </summary>
        /// <returns>null if successful, otherwise the MySqlException that occured</returns>
        public static MySqlException TryConnect()
        {
            try
            {
                Connection.Open();
                Connection.Close();

                return null;
            }
            catch(MySqlException ex)
            {
                return ex;
            }
        }

        /// <summary>
        /// Execute a query against the MySqlDB
        /// </summary>
        /// <param name="Query">the sql query</param>
        /// <returns>the result of the query as a datatable object (null if error occurs)</returns>
        public static DataTable GetQueryResult(string Query)
        {
            try
            {
                MySqlCommand CMD = new MySqlCommand(Query, Connection);
                MySqlDataAdapter ADAPTER = new MySqlDataAdapter(CMD);
                DataTable dtResult = new DataTable();

                Connection.Open();
                ADAPTER.Fill(dtResult);
                Connection.Close();

                return dtResult;
            }
            catch(Exception ex)
            {
                ErrorHandler.Handle(ex);
                return null;
            }
        }
    }
}
