using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using MongoDB;

namespace DByoungProgramist
{
    class Db
    {
        private  Db()
        {

        }
        public static dynamic connect()
        {
            return new LiteDatabase("mydata.db");
        }

    }
}
