using Model.BCRA;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class MonetaryBaseRepository : ArgMacroRepository, IMonetaryBaseRepository
    {
       public List<MonetaryBase> All()
        {
            try
            { 
                return Context.MonetaryBase.ToList();
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
