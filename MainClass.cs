using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Demo
{
    class MainClass
    {
        public static void Main()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            do
            {

                Console.WriteLine("Enter the operation do you want to perform on database like display, insert , update, delete");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "display":
                        dbHelper.createConnection();
                        break;

                    case "insert":
                        dbHelper.insertIntoDatabase();
                        dbHelper.createConnection();
                        break;

                    case "update":
                        dbHelper.updateIntoDatabase();
                        dbHelper.createConnection();
                        break;

                    case "delete":
                        dbHelper.deleteRecord();
                        dbHelper.createConnection();
                        break;

                    default:
                        break;
                } 
            } while (true);
        }
    }
}
