﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkateRepository.Service.SkateboardServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SkateboardServiceReference.ISkateboardService")]
    public interface ISkateboardService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/GetSkateboards", ReplyAction="http://tempuri.org/ISkateboardService/GetSkateboardsResponse")]
        System.Collections.Generic.List<Skate.Shared.Skateboard> GetSkateboards();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/GetSkateboards", ReplyAction="http://tempuri.org/ISkateboardService/GetSkateboardsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Skate.Shared.Skateboard>> GetSkateboardsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/GetSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/GetSkateboardResponse")]
        Skate.Shared.Skateboard GetSkateboard(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/GetSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/GetSkateboardResponse")]
        System.Threading.Tasks.Task<Skate.Shared.Skateboard> GetSkateboardAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/AddSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/AddSkateboardResponse")]
        void AddSkateboard(Skate.Shared.Skateboard newSkateboard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/AddSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/AddSkateboardResponse")]
        System.Threading.Tasks.Task AddSkateboardAsync(Skate.Shared.Skateboard newSkateboard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/UpdateSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/UpdateSkateboardResponse")]
        void UpdateSkateboard(string lastName, Skate.Shared.Skateboard updatedSkateboard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/UpdateSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/UpdateSkateboardResponse")]
        System.Threading.Tasks.Task UpdateSkateboardAsync(string lastName, Skate.Shared.Skateboard updatedSkateboard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/DeleteSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/DeleteSkateboardResponse")]
        void DeleteSkateboard(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/DeleteSkateboard", ReplyAction="http://tempuri.org/ISkateboardService/DeleteSkateboardResponse")]
        System.Threading.Tasks.Task DeleteSkateboardAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/UpdateSkateboards", ReplyAction="http://tempuri.org/ISkateboardService/UpdateSkateboardsResponse")]
        void UpdateSkateboards(System.Collections.Generic.List<Skate.Shared.Skateboard> updatedSkateboards);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISkateboardService/UpdateSkateboards", ReplyAction="http://tempuri.org/ISkateboardService/UpdateSkateboardsResponse")]
        System.Threading.Tasks.Task UpdateSkateboardsAsync(System.Collections.Generic.List<Skate.Shared.Skateboard> updatedSkateboards);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISkateboardServiceChannel : SkateRepository.Service.SkateboardServiceReference.ISkateboardService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SkateboardServiceClient : System.ServiceModel.ClientBase<SkateRepository.Service.SkateboardServiceReference.ISkateboardService>, SkateRepository.Service.SkateboardServiceReference.ISkateboardService {
        
        public SkateboardServiceClient() {
        }
        
        public SkateboardServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SkateboardServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SkateboardServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SkateboardServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Skate.Shared.Skateboard> GetSkateboards() {
            return base.Channel.GetSkateboards();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Skate.Shared.Skateboard>> GetSkateboardsAsync() {
            return base.Channel.GetSkateboardsAsync();
        }
        
        public Skate.Shared.Skateboard GetSkateboard(string lastName) {
            return base.Channel.GetSkateboard(lastName);
        }
        
        public System.Threading.Tasks.Task<Skate.Shared.Skateboard> GetSkateboardAsync(string lastName) {
            return base.Channel.GetSkateboardAsync(lastName);
        }
        
        public void AddSkateboard(Skate.Shared.Skateboard newSkateboard) {
            base.Channel.AddSkateboard(newSkateboard);
        }
        
        public System.Threading.Tasks.Task AddSkateboardAsync(Skate.Shared.Skateboard newSkateboard) {
            return base.Channel.AddSkateboardAsync(newSkateboard);
        }
        
        public void UpdateSkateboard(string lastName, Skate.Shared.Skateboard updatedSkateboard) {
            base.Channel.UpdateSkateboard(lastName, updatedSkateboard);
        }
        
        public System.Threading.Tasks.Task UpdateSkateboardAsync(string lastName, Skate.Shared.Skateboard updatedSkateboard) {
            return base.Channel.UpdateSkateboardAsync(lastName, updatedSkateboard);
        }
        
        public void DeleteSkateboard(string lastName) {
            base.Channel.DeleteSkateboard(lastName);
        }
        
        public System.Threading.Tasks.Task DeleteSkateboardAsync(string lastName) {
            return base.Channel.DeleteSkateboardAsync(lastName);
        }
        
        public void UpdateSkateboards(System.Collections.Generic.List<Skate.Shared.Skateboard> updatedSkateboards) {
            base.Channel.UpdateSkateboards(updatedSkateboards);
        }
        
        public System.Threading.Tasks.Task UpdateSkateboardsAsync(System.Collections.Generic.List<Skate.Shared.Skateboard> updatedSkateboards) {
            return base.Channel.UpdateSkateboardsAsync(updatedSkateboards);
        }
    }
}
