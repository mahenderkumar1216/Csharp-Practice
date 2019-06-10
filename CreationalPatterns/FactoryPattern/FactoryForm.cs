using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationalPatterns.FactoryPattern
{
    public partial class FactoryForm : Form
    {
        public FactoryForm()
        {
            InitializeComponent();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            IDataBase database;
            DatabaseType databaseType = DatabaseType.SqlServer;
            if (radUseOleDb.Checked)
                databaseType = DatabaseType.OleDb;
            database = DatabaseFactory.CreateDatabase(databaseType);

            IDbCommand command = database.Command;
            // now, we can do something, like:
            //command.CommandType = CommandType.Text;
            //command.CommandText = "SELECT * FROM Customers";
            //command.Connection.Open();
            //IDataReader reader = command.ExecuteReader();

            //reader.Close();
            //command.Connection.Close();

        }
    }
}
