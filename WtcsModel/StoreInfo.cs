using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WtcsModel
{
    internal class StoreInfo
    {
        public int storeId { get; set; }

        public string storeName { get; set; }

        public string storeNumber { get; set; }

        public int regionCount { get; set; }

        public string remark { get; set; }

        public int isDeleted { get; set; }
    }
}
