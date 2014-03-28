using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkateRepository.Interface;
using Skate.Shared;
using Skate.Presentation;
using SkateRepository.Service;
using SkateRepository.CSV;
using SkateRepository.SQL;
using SkateRepository.Caching;

namespace Skate.Infrastructure
{
    public class SkateContainer
    {
        //Uncomment this line to use a WCF service repository
        //static ISkateRepository _repository = new ServiceRepository();

        //Uncomment this line to use a CSV file repository
        //static ISkateRepository _repository = new CSVRepository();

        //Uncomment this line to use a SQL database table repository
        //static ISkateRepository _repository = new SQLRepository();

        //Uncomment this line to use a Caching database table repository
        static ISkateRepository wrappedRepository = new ServiceRepository();
        static ISkateRepository _repository = new CachingRepository(wrappedRepository);

        public SkateViewModel ViewModel = new SkateViewModel(_repository);
        
    }
}
