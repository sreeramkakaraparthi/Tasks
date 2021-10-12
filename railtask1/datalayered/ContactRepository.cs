using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Data;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace datalayered
{
    public class ContactRepository : IContactRepository
    {
        private System.Data.IDbConnection db; 

        public ContactRepository(string connString)
        {
            this.db = new SqlConnection(connString);
        }

        //private IDbConnection SqlConnection(string connString)
        //{
        //    throw new NotImplementedException();
        //}

        public Train Add(Train train)
        {
            //var sql = "INSERT INTO Train(train_no,train_name,source_name,destination_name,start_time,end_time)VALUES(@train_no,@train_name,@source_name,@destination_name,@start_time,@end_time);" +
            //    "SELECT CAST(SCOPE_IDENTITY() as int)";
            this.db.Insert(train);
            //var train_no = this.db.Query<int>(sql, train).Single();
            //train.train_no = train_no;
            return train;
        }
    } 
}
