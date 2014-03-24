using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Skate.Shared;

namespace Skate.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISkateboardService
    {
        [OperationContract]
        List<Skateboard> GetSkateboards();

        [OperationContract]
        Skateboard GetSkateboard(string lastName);

        [OperationContract]
        void AddSkateboard(Skateboard newSkateboard);

        [OperationContract]
        void UpdateSkateboard(string lastName, Skateboard updatedSkateboard);

        [OperationContract]
        void DeleteSkateboard(string lastName);

        [OperationContract]
        void UpdateSkateboards(List<Skateboard> updatedSkateboards);
        
    }
}
