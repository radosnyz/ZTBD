using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTBD.Db
{
    interface IDbManager
    {
        void InsertData(Data data);
        List<Data> GetData();
    }
}
