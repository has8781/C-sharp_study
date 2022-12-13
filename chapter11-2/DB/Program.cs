using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace _4_db {
    internal class Program {
        static void Main(string[] args)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=testdb.accdb";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            string query = "insert into sales (salecode,customercode,itemcode,date1,qty,price) " +
            "values (1, \"홍길동\",\"컴퓨터\",\"2019-08-02\",10, 10000)";
            // command를 생성하고, connection 설정
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
