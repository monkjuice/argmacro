using Model.BCRA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    interface IMonetaryBaseService
    {
        public List<MonetaryBase> All();
    }
}
