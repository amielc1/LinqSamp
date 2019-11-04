using Models;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LinqSamp
{
    public class Repository
    {
        public Repository()
        {

        }
        public void Run()
        {
            string connectionString = @"Data Source=E318878N\SQLEXPRESS;Initial Catalog=LinqSamp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var cfg = new Configuration();
            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionString = connectionString;
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2008Dialect>();
            });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            var sefact = cfg.BuildSessionFactory();

            using (var session = sefact.OpenSession())
            {

                using (var tx = session.BeginTransaction())
                {
                    //perform database logic 
                    var persons = session.CreateCriteria<Persons>().List<Persons>();
                    var books = session.CreateCriteria<Books>().List<Books>();

                    var personsWithBooks_where = (
                                            from book in books
                                            from person in persons
                                            where person.Id == book.PersonId
                                            select new
                                            {
                                                person.Name,
                                                book
                                            .BookName
                                            }).ToList();

                    var personsWithBooks_join = (
                                            from book in books
                                            join person in persons on
                                            book.PersonId equals person.Id
                                            select new
                                            {
                                                person.Name,
                                                book.BookName
                                            }).ToList();


                }
            }


        }
    }
}
