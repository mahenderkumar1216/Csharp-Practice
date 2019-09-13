using DRY.Common;
using DRY.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY
{
    class ProgramUsingSingleton
    {
        private static DataSet _employeeTable;
        private static List<IEmployee> _employees;
        private static List<FreightByShipper> _freightByShipperList;
        private static DataSet _invoiceTable;
        static IDatabase myDatabase = DatabaseFactory.CreateDatabase(DatabaseType.SqlServer);
        private static void Main(string[] args)
        {


            Console.WriteLine("Beginning extract at " + DateTime.Now);
            Extract();
            Console.WriteLine("Finished extract at " + DateTime.Now);

            Console.WriteLine("Beginning transform at " + DateTime.Now);
            Transform();
            Console.WriteLine("Finished transform at " + DateTime.Now);

            Console.WriteLine("Beginning load at " + DateTime.Now);
            // Load();
            Console.WriteLine("Finished load at " + DateTime.Now);

            Console.ReadLine();
        }

        private static void Extract()
        {
            myDatabase.Command.CommandType = CommandType.Text;
            myDatabase.Command.CommandText = "select* from invoices where orderdate > @LastRunDate order by salesperson, customerid, orderdate, productid";
            var v = myDatabase.CreateParameter;
            v.ParameterName = "LastRunDate";
            v.Value = new DateTime(1996, 1, 1);
            v.DbType = DbType.DateTime;
            myDatabase.Command.Parameters.Add(v);

            IDataAdapter myAdapter = myDatabase.DbDataAdapter;
            _invoiceTable = new DataSet();
            myAdapter.Fill(_invoiceTable);

            //foreach (DataRow row in _invoiceTable.Tables[0].Rows)
            //{
            //    Console.WriteLine("{0}-{1}-{2}", row[0], row[1], row[2]);
            //}
            ShowOutput(_invoiceTable, 3);
            myDatabase.Connection.Close();

            myDatabase.Command.CommandType = CommandType.Text;
            myDatabase.Command.CommandText = "select FirstName + LastName, (select(count(*)) from Employees where ReportsTo = e.EmployeeId) from Employees e";
            myAdapter = myDatabase.DbDataAdapter;
            _employeeTable = new DataSet();
            myAdapter.Fill(_employeeTable);
            foreach (DataRow row in _employeeTable.Tables[0].Rows)
            {
                Console.WriteLine("{0}-{1}", row[0], row[1]);
            }
        }

        public static void ShowOutput(DataSet dataset, int columnsToDisplay = 0)
        {
            foreach (DataTable dt in dataset.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int columnIndex = 0;
                    int columnCount = dt.Columns.Count;
                    if (columnsToDisplay > 0 && columnsToDisplay < columnCount)
                    {
                        columnCount = columnsToDisplay;
                    }
                    while (columnIndex < columnCount)
                    {
                        Console.Write(row[columnIndex]);
                        columnIndex++;
                        if (columnIndex < columnCount)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        private static void Transform()
        {
            DataTable shippers = _invoiceTable.Tables[0].DefaultView.ToTable(true, new[] { "ShipperName" });
            _freightByShipperList = new List<FreightByShipper>();
            foreach (DataRow row in shippers.Rows)
            {
                Console.WriteLine("{0}", row[0]);
                var myShipper = new FreightByShipper { ShipperName = row[0].ToString() };
                myShipper.Freight = CalculateFreightForShipper(myShipper.ShipperName);
                _freightByShipperList.Add(myShipper);


            }
            var totalFreight = (decimal)_invoiceTable.Tables[0].Compute("sum(freight)", "");
            Console.WriteLine("Total Freight: " + totalFreight);

            _employees = new List<IEmployee>();
            foreach (DataRow row in _employeeTable.Tables[0].Rows)
            {
                var employee = CheckManager.GetEmployee((int)row[1]);
                employee.Name = row[0].ToString();
                _employees.Add(employee);
            }
            foreach (Employee employee in _employees)
            {
                employee.SetBonus(totalFreight);
            }
        }

        private static decimal CalculateFreightForShipper(string shipperName)
        {
            var result =
                    (decimal)
                    _invoiceTable.Tables[0].Compute("sum(freight)", "shippername='" + shipperName + "'");
            Console.WriteLine("{0}:{1:#.##}", shipperName, result);
            return result;
        }

        private static void Load()
        {
            foreach (FreightByShipper shipper in _freightByShipperList)
            {
                using (var myConnection = new SqlConnection())
                {
                    myConnection.ConnectionString =
                        "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True";

                    string myQuery = "delete FreightSummary where RunDate = @RunDate and ShipperName = @ShipperName";
                    using (var myCommand = new SqlCommand(myQuery, myConnection))
                    {
                        myCommand.Parameters.Add(new SqlParameter("RunDate", DateTime.Today));
                        myCommand.Parameters.Add(new SqlParameter("ShipperName", shipper.ShipperName));
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                    }

                    myQuery =
                        "insert FreightSummary (RunDate,ShipperName,Freight) VALUES (@RunDate, @ShipperName, @Freight)";
                    using (var myCommand = new SqlCommand(myQuery, myConnection))
                    {
                        myCommand.Parameters.Add(new SqlParameter("RunDate", DateTime.Today));
                        myCommand.Parameters.Add(new SqlParameter("ShipperName", shipper.ShipperName));
                        myCommand.Parameters.Add(new SqlParameter("Freight", shipper.Freight));
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();

                        string result = String.Format("{0}:{1:#.##}", shipper.ShipperName,
                                                      shipper.Freight);
                        Console.WriteLine("Added Row to summary: " + result);
                    }
                }
            }
            foreach (Employee employee in _employees)
            {
                using (var myConnection = new SqlConnection())
                {
                    myConnection.ConnectionString =
                        "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True";

                    string myQuery = "delete EmployeeBonus where Date = @RunDate and EmployeeName = @EmployeeName";
                    using (var myCommand = new SqlCommand(myQuery, myConnection))
                    {
                        myCommand.Parameters.Add(new SqlParameter("RunDate", DateTime.Today));
                        myCommand.Parameters.Add(new SqlParameter("EmployeeName", employee.Name));
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                    }

                    myQuery =
                        "insert EmployeeBonus (Date,EmployeeName,Bonus) VALUES (@RunDate, @EmployeeName, @Bonus)";
                    using (var myCommand = new SqlCommand(myQuery, myConnection))
                    {
                        myCommand.Parameters.Add(new SqlParameter("RunDate", DateTime.Today));
                        myCommand.Parameters.Add(new SqlParameter("EmployeeName", employee.Name));
                        myCommand.Parameters.Add(new SqlParameter("Bonus", employee.Bonus));
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();

                        string result = String.Format("{0}:{1}:{2:#.##}", employee.Name,
                                                      employee.IsManager ? "Manager" : "Employee",
                                                      employee.Bonus);
                        Console.WriteLine("Added Row to summary: " + result);
                    }
                }
            }
        }
    }
}
