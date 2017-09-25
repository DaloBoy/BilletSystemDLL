using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BilletSystemDLLUnittests
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBillet" in both code and config file together.
    [ServiceContract]
    public interface IBillet
    {
        //Kappa123

        [OperationContract]
        int BilPris();

        [OperationContract]
        int BilPrisMedBizz();

        [OperationContract]
        int BilPrisØresund();

        [OperationContract]
        int BilPrisØresundBizz();

        [OperationContract]
        int MCPris();

        [OperationContract]
        int MCØresund();

        [OperationContract]
        int MCPrisØresunBIzz();

        [OperationContract]
        int MCBrobiz();


        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
