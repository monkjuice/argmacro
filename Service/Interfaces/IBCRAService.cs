using Model.BCRA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IBCRAService
    {
        public List<MonetaryBase> monetaryBasesOverTime();
    }
}
