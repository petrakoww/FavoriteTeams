﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.SOAPService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfServiceLibrary1.CompositeType GetDataUsingDataContract(WcfServiceLibrary1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfServiceLibrary1.CompositeType> GetDataUsingDataContractAsync(WcfServiceLibrary1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTeams", ReplyAction="http://tempuri.org/IService1/GetTeamsResponse")]
        ApplicarionService.DTOs.TeamDTO[] GetTeams(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTeams", ReplyAction="http://tempuri.org/IService1/GetTeamsResponse")]
        System.Threading.Tasks.Task<ApplicarionService.DTOs.TeamDTO[]> GetTeamsAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTeamById", ReplyAction="http://tempuri.org/IService1/GetTeamByIdResponse")]
        ApplicarionService.DTOs.TeamDTO GetTeamById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTeamById", ReplyAction="http://tempuri.org/IService1/GetTeamByIdResponse")]
        System.Threading.Tasks.Task<ApplicarionService.DTOs.TeamDTO> GetTeamByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostTeam", ReplyAction="http://tempuri.org/IService1/PostTeamResponse")]
        string PostTeam(ApplicarionService.DTOs.TeamDTO teamDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostTeam", ReplyAction="http://tempuri.org/IService1/PostTeamResponse")]
        System.Threading.Tasks.Task<string> PostTeamAsync(ApplicarionService.DTOs.TeamDTO teamDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutTeam", ReplyAction="http://tempuri.org/IService1/PutTeamResponse")]
        string PutTeam(ApplicarionService.DTOs.TeamDTO teamDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutTeam", ReplyAction="http://tempuri.org/IService1/PutTeamResponse")]
        System.Threading.Tasks.Task<string> PutTeamAsync(ApplicarionService.DTOs.TeamDTO teamDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTeam", ReplyAction="http://tempuri.org/IService1/DeleteTeamResponse")]
        string DeleteTeam(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTeam", ReplyAction="http://tempuri.org/IService1/DeleteTeamResponse")]
        System.Threading.Tasks.Task<string> DeleteTeamAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFans", ReplyAction="http://tempuri.org/IService1/GetFansResponse")]
        ApplicarionService.DTOs.FanDTO[] GetFans(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFans", ReplyAction="http://tempuri.org/IService1/GetFansResponse")]
        System.Threading.Tasks.Task<ApplicarionService.DTOs.FanDTO[]> GetFansAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFansById", ReplyAction="http://tempuri.org/IService1/GetFansByIdResponse")]
        ApplicarionService.DTOs.FanDTO GetFansById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFansById", ReplyAction="http://tempuri.org/IService1/GetFansByIdResponse")]
        System.Threading.Tasks.Task<ApplicarionService.DTOs.FanDTO> GetFansByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostFan", ReplyAction="http://tempuri.org/IService1/PostFanResponse")]
        string PostFan(ApplicarionService.DTOs.FanDTO fanDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostFan", ReplyAction="http://tempuri.org/IService1/PostFanResponse")]
        System.Threading.Tasks.Task<string> PostFanAsync(ApplicarionService.DTOs.FanDTO fanDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutFan", ReplyAction="http://tempuri.org/IService1/PutFanResponse")]
        string PutFan(ApplicarionService.DTOs.FanDTO fanDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutFan", ReplyAction="http://tempuri.org/IService1/PutFanResponse")]
        System.Threading.Tasks.Task<string> PutFanAsync(ApplicarionService.DTOs.FanDTO fanDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFan", ReplyAction="http://tempuri.org/IService1/DeleteFanResponse")]
        string DeleteFan(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFan", ReplyAction="http://tempuri.org/IService1/DeleteFanResponse")]
        System.Threading.Tasks.Task<string> DeleteFanAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReviews", ReplyAction="http://tempuri.org/IService1/GetReviewsResponse")]
        ApplicarionService.DTOs.ReviewDTO[] GetReviews(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReviews", ReplyAction="http://tempuri.org/IService1/GetReviewsResponse")]
        System.Threading.Tasks.Task<ApplicarionService.DTOs.ReviewDTO[]> GetReviewsAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReviewsById", ReplyAction="http://tempuri.org/IService1/GetReviewsByIdResponse")]
        ApplicarionService.DTOs.ReviewDTO GetReviewsById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReviewsById", ReplyAction="http://tempuri.org/IService1/GetReviewsByIdResponse")]
        System.Threading.Tasks.Task<ApplicarionService.DTOs.ReviewDTO> GetReviewsByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostReview", ReplyAction="http://tempuri.org/IService1/PostReviewResponse")]
        string PostReview(ApplicarionService.DTOs.ReviewDTO reviewDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostReview", ReplyAction="http://tempuri.org/IService1/PostReviewResponse")]
        System.Threading.Tasks.Task<string> PostReviewAsync(ApplicarionService.DTOs.ReviewDTO reviewDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutReview", ReplyAction="http://tempuri.org/IService1/PutReviewResponse")]
        string PutReview(ApplicarionService.DTOs.ReviewDTO reviewDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutReview", ReplyAction="http://tempuri.org/IService1/PutReviewResponse")]
        System.Threading.Tasks.Task<string> PutReviewAsync(ApplicarionService.DTOs.ReviewDTO reviewDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteReview", ReplyAction="http://tempuri.org/IService1/DeleteReviewResponse")]
        string DeleteReview(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteReview", ReplyAction="http://tempuri.org/IService1/DeleteReviewResponse")]
        System.Threading.Tasks.Task<string> DeleteReviewAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVC.SOAPService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVC.SOAPService.IService1>, MVC.SOAPService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfServiceLibrary1.CompositeType GetDataUsingDataContract(WcfServiceLibrary1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfServiceLibrary1.CompositeType> GetDataUsingDataContractAsync(WcfServiceLibrary1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ApplicarionService.DTOs.TeamDTO[] GetTeams(string filter) {
            return base.Channel.GetTeams(filter);
        }
        
        public System.Threading.Tasks.Task<ApplicarionService.DTOs.TeamDTO[]> GetTeamsAsync(string filter) {
            return base.Channel.GetTeamsAsync(filter);
        }
        
        public ApplicarionService.DTOs.TeamDTO GetTeamById(int id) {
            return base.Channel.GetTeamById(id);
        }
        
        public System.Threading.Tasks.Task<ApplicarionService.DTOs.TeamDTO> GetTeamByIdAsync(int id) {
            return base.Channel.GetTeamByIdAsync(id);
        }
        
        public string PostTeam(ApplicarionService.DTOs.TeamDTO teamDto) {
            return base.Channel.PostTeam(teamDto);
        }
        
        public System.Threading.Tasks.Task<string> PostTeamAsync(ApplicarionService.DTOs.TeamDTO teamDto) {
            return base.Channel.PostTeamAsync(teamDto);
        }
        
        public string PutTeam(ApplicarionService.DTOs.TeamDTO teamDto) {
            return base.Channel.PutTeam(teamDto);
        }
        
        public System.Threading.Tasks.Task<string> PutTeamAsync(ApplicarionService.DTOs.TeamDTO teamDto) {
            return base.Channel.PutTeamAsync(teamDto);
        }
        
        public string DeleteTeam(int id) {
            return base.Channel.DeleteTeam(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteTeamAsync(int id) {
            return base.Channel.DeleteTeamAsync(id);
        }
        
        public ApplicarionService.DTOs.FanDTO[] GetFans(string filter) {
            return base.Channel.GetFans(filter);
        }
        
        public System.Threading.Tasks.Task<ApplicarionService.DTOs.FanDTO[]> GetFansAsync(string filter) {
            return base.Channel.GetFansAsync(filter);
        }
        
        public ApplicarionService.DTOs.FanDTO GetFansById(int id) {
            return base.Channel.GetFansById(id);
        }
        
        public System.Threading.Tasks.Task<ApplicarionService.DTOs.FanDTO> GetFansByIdAsync(int id) {
            return base.Channel.GetFansByIdAsync(id);
        }
        
        public string PostFan(ApplicarionService.DTOs.FanDTO fanDto) {
            return base.Channel.PostFan(fanDto);
        }
        
        public System.Threading.Tasks.Task<string> PostFanAsync(ApplicarionService.DTOs.FanDTO fanDto) {
            return base.Channel.PostFanAsync(fanDto);
        }
        
        public string PutFan(ApplicarionService.DTOs.FanDTO fanDto) {
            return base.Channel.PutFan(fanDto);
        }
        
        public System.Threading.Tasks.Task<string> PutFanAsync(ApplicarionService.DTOs.FanDTO fanDto) {
            return base.Channel.PutFanAsync(fanDto);
        }
        
        public string DeleteFan(int id) {
            return base.Channel.DeleteFan(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteFanAsync(int id) {
            return base.Channel.DeleteFanAsync(id);
        }
        
        public ApplicarionService.DTOs.ReviewDTO[] GetReviews(string filter) {
            return base.Channel.GetReviews(filter);
        }
        
        public System.Threading.Tasks.Task<ApplicarionService.DTOs.ReviewDTO[]> GetReviewsAsync(string filter) {
            return base.Channel.GetReviewsAsync(filter);
        }
        
        public ApplicarionService.DTOs.ReviewDTO GetReviewsById(int id) {
            return base.Channel.GetReviewsById(id);
        }
        
        public System.Threading.Tasks.Task<ApplicarionService.DTOs.ReviewDTO> GetReviewsByIdAsync(int id) {
            return base.Channel.GetReviewsByIdAsync(id);
        }
        
        public string PostReview(ApplicarionService.DTOs.ReviewDTO reviewDto) {
            return base.Channel.PostReview(reviewDto);
        }
        
        public System.Threading.Tasks.Task<string> PostReviewAsync(ApplicarionService.DTOs.ReviewDTO reviewDto) {
            return base.Channel.PostReviewAsync(reviewDto);
        }
        
        public string PutReview(ApplicarionService.DTOs.ReviewDTO reviewDto) {
            return base.Channel.PutReview(reviewDto);
        }
        
        public System.Threading.Tasks.Task<string> PutReviewAsync(ApplicarionService.DTOs.ReviewDTO reviewDto) {
            return base.Channel.PutReviewAsync(reviewDto);
        }
        
        public string DeleteReview(int id) {
            return base.Channel.DeleteReview(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteReviewAsync(int id) {
            return base.Channel.DeleteReviewAsync(id);
        }
    }
}