using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace CreationalPatterns.BuilderPattern
{
    public partial class BuilderPatternForm : Form
    {
        public BuilderPatternForm()
        {
            InitializeComponent();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            IDatabaseBuilder builder;

            if(radUseSqlServer.Checked)
            {
                builder = new SqlServerDatabaseBuilder();
            }
            else
            {
                builder = new OledbDatabaseBuilder();
            }

            director.Build(builder);
            AbstactDatabase database = builder.Database;
            DbCommand command = database.Command;
            command.CommandText = "Select * from Customers";
            command.Connection.Open();
            DbDataReader reader = command.ExecuteReader();
            reader.Close();
            command.Connection.Close();
        }
    }
}
