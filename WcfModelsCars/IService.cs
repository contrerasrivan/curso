using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfModelsCars
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        ModelsCars GetModelsCars(int modelscarsId);
    }

    [DataContract]
    public class ModelsCars
    {
        [DataMember]
        public string CarsModels { get; set; }
    }
    public class Service : IService
    {
        public ModelsCars GetModelsCars(int modelscarsId)
        {
            return new ModelsCars
            {
                CarsModels = "Toyota"
            };
        }
    }
}
