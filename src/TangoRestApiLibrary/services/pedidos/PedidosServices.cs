using TangoRestApiClient.Common.Config;
using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.baseServices;
using TangoRestApiClient.services.pedidos.model;

namespace TangoRestApiClient.services.pedidos;

public class PedidosServices : BaseServices, IPedidosServices
{

    public PedidosServices(ITangoConfig config) : base(config)
    {
        ProcessId = "19845";
    }

    public PedidoQuery GetData()
    {
        var dataJson = ServiceGetData();
        if (dataJson.Result != null)
        {
            try
            {
                PedidoQuery data = Newtonsoft.Json.JsonConvert.DeserializeObject<PedidoQuery>(dataJson.Result);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacción: {ex.Message}");
                return new PedidoQuery();
            }
        }
        else
        {
            Console.WriteLine($"dataJson.Result is null");
            return new PedidoQuery();
        }
    }

    public PedidoDataset GetDataById(int id)
    {
        throw new System.NotImplementedException();
    }

    public TransactionResultModel Insert(PedidoDataset data)
    {
        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        string resultJson = ServicePostData(jsonData).Result;
        if (resultJson != null)
        {
            try
            {
                TransactionResultModel result = Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionResultModel>(resultJson);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar el resultado de la transacción: {ex.Message}");
                return new TransactionResultModel();
            }
        }
        else
        {
            // Devuelve un nuevo TransactionResultModel en lugar de lanzar una excepción
            return new TransactionResultModel();
        }
    }

    public TransactionResultModel Edit(PedidoDataset data)
    {
        throw new System.NotImplementedException();
    }

    public TransactionResultModel Delete(int id)
    {
        throw new System.NotImplementedException();
    }
}
