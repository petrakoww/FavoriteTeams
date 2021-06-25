using ApplicarionService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        
        [OperationContract]
        List<TeamDTO> GetTeams(string filter);

        [OperationContract]
        TeamDTO GetTeamById(int id);

        [OperationContract]
        string PostTeam(TeamDTO teamDto);

        [OperationContract]
        string PutTeam(TeamDTO teamDto);

        [OperationContract]
        string DeleteTeam(int id);

        
        [OperationContract]
        List<FanDTO> GetFans(string filter);

        [OperationContract]
        FanDTO GetFansById(int id);

        [OperationContract]
        string PostFan(FanDTO fanDto);

        [OperationContract]
        string PutFan(FanDTO fanDto);

        [OperationContract]
        string DeleteFan(int id);

        
        [OperationContract]
        List<ReviewDTO> GetReviews(string filter);

        [OperationContract]
        ReviewDTO GetReviewsById(int id);

        [OperationContract]
        string PostReview(ReviewDTO reviewDto);

        [OperationContract]
        string PutReview(ReviewDTO reviewDto);

        [OperationContract]
        string DeleteReview(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
