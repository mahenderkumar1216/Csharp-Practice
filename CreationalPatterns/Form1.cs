using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationalPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            AbstactDatabase database;
            if (radUseSqlServer.Checked)
            {
                database = new SqlServerClass();
            }
            else
            {
                database = new OledbClass();
            }

            DbCommand command = database.Command;
            //now, we can do something, like:
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Customers";
            command.Connection.Open();
            DbDataReader reader = command.ExecuteReader();

            reader.Close();
            command.Connection.Close();
        }
    }
}
