using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Demo
{
    class DatabaseHelper
    {
        public void createConnection()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\OWNER\\Documents\\Fruits.accdb;Persist Security Info = False;");
            OleDbCommand oleDbCommand = new OleDbCommand("select * from fruitDetails", oleDbConnection);
            oleDbConnection.Open();
            var reader = oleDbCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]+"\t\t\t "+reader["Quantity"] + " \t\t\t" + reader["price"]);
            }
            oleDbConnection.Close();
            Console.ReadLine();
        }

        public void insertIntoDatabase()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\OWNER\\Documents\\Fruits.accdb;Persist Security Info = False;");
            OleDbCommand oleDbCommand = new OleDbCommand("insert into fruitDetails values (12,'Royal lichi',20,45000)",oleDbConnection);
            oleDbConnection.Open();
            var reader = oleDbCommand.ExecuteNonQuery();
            Console.WriteLine(reader+"row is effected");
            oleDbConnection.Close();
            Console.ReadLine();
        }

        public void updateIntoDatabase()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\OWNER\\Documents\\Fruits.accdb;Persist Security Info = False;");
            OleDbCommand oleDbCommand = new OleDbCommand("update fruitDetails set Name = \"strawberry\" where ID = 7", oleDbConnection);
            oleDbConnection.Open();
            var reader = oleDbCommand.ExecuteNonQuery();
            Console.WriteLine(reader+" row Get Effected");
            oleDbConnection.Close();
            Console.ReadLine();
        }

        public void deleteRecord()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\OWNER\\Documents\\Fruits.accdb;Persist Security Info = False;");
            OleDbCommand oleDbCommand = new OleDbCommand("delete from fruitDetails where ID = 12", oleDbConnection);
            oleDbConnection.Open();
            var reader = oleDbCommand.ExecuteNonQuery();
            Console.WriteLine(reader + " row Get Effected");
            oleDbConnection.Close();
            Console.ReadLine();
        }
    }
}
