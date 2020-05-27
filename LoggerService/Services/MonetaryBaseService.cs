using Model.BCRA;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service
{
    public class MonetaryBaseService : IMonetaryBaseService
    {

        private readonly IMonetaryBaseService monetaryBaseRepository;

        public List<MonetaryBase> All()
        {
            return monetaryBaseRepository.All();
        }
    }
}
