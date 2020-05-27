using Model.BCRA;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service
{
    public class BCRAService : IBCRAService
    {
        private readonly IMonetaryBaseRepository monetaryBaseRepository;

        public BCRAService()
        {
            monetaryBaseRepository = new MonetaryBaseRepository();
        }

        public List<MonetaryBase> monetaryBasesOverTime()
        { 
            return monetaryBaseRepository.All();
        }
    }
}



