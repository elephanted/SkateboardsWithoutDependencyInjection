using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Skate.Shared;
using SkateRepository.Service.SkateboardServiceReference;
using SkateRepository.Interface;


namespace SkateRepository.Service
{
    public class ServiceRepository : ISkateRepository
    {
        SkateboardServiceClient ServiceProxy = new SkateboardServiceClient();

        public IEnumerable<Skate.Shared.Skateboard> GetSkateboards()
        {
            return ServiceProxy.GetSkateboards();
        }

        public Skateboard GetSkateboard(string skateboardName)
        {
            return ServiceProxy.GetSkateboard(skateboardName);
        }

        public void AddSkateboard(Skateboard newSkateboard)
        {
            ServiceProxy.AddSkateboard(newSkateboard);
        }

        public void UpdateSkateboard(string lastName, Skateboard updatedSkateboard)
        {
            ServiceProxy.UpdateSkateboard(lastName, updatedSkateboard);
        }

        public void DeleteSkateboard(string lastName)
        {
            ServiceProxy.DeleteSkateboard(lastName);
        }

        public void UpdateSkateboards(IEnumerable<Skateboard> updateSkateboards)
        {
            ServiceProxy.UpdateSkateboards(updateSkateboards.ToList());
        }
    }
}
