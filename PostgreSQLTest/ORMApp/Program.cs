/*
 P2PFinance finance between persons
Copyright (C) 2015 MaxGo
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMApp.Model;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.PostgreSQL;

namespace ORMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["p2pfDB"].ConnectionString;
            var dbFactory = new OrmLiteConnectionFactory(ConnectionString, PostgreSQLDialectProvider.Instance);
            using (IDbConnection db = dbFactory.Open())
            {
                db.CreateTableIfNotExists<Investor>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Borrower>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor1>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor2>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor3>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor4>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor5>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor6>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor7>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor8>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor9>();
                Console.WriteLine(db.GetLastSql());
                db.CreateTableIfNotExists<Investor10>();
                Console.WriteLine(db.GetLastSql());
            }
        }
    }
}
