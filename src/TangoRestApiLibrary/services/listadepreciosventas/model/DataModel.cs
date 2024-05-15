using Newtonsoft.Json;

namespace TangoRestApiClient.services.listadepreciosventas.model;

    public  class ListaDePreciosVentasData
    {
        [JsonProperty("value")]
        public ListaDePreciosVentasDataset? Value { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("exceptionInfo")]
        public object? ExceptionInfo { get; set; }

        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }
    }

    public partial class ListaDePreciosVentasDataset
    {
        [JsonProperty("GVA10_PARAMETROS_AUTOMATIZACION")]
        public string? Gva10ParametrosAutomatizacion { get; set; }

        [JsonProperty("CTA_LISTA_VENTA_POR_SUCURSAL")]
        public string? CtaListaVentaPorSucursal { get; set; }

        [JsonProperty("ID_GVA10")]
        public int IdGva10 { get; set; }

        [JsonProperty("NRO_DE_LIS")]
        public int NroDeLis { get; set; }

        [JsonProperty("NOMBRE_LIS")]
        public string? NombreLis { get; set; }

        [JsonProperty("HABILITADA")]
        public bool Habilitada { get; set; }

        [JsonProperty("MON_CTE")]
        public bool MonCte { get; set; }

        [JsonProperty("DECIMALES")]
        public long Decimales { get; set; }

        [JsonProperty("INCLUY_IVA")]
        public bool IncluyIva { get; set; }

        [JsonProperty("INCLUY_IMP")]
        public bool IncluyImp { get; set; }

        [JsonProperty("FEC_DESDE")]
        public DateTime? FecDesde { get; set; }

        [JsonProperty("FEC_HASTA")]
        public DateTime? FecHasta { get; set; }

        [JsonProperty("OBSERVACIONES")]
        public string? Observaciones { get; set; }

        [JsonProperty("COD_DESCRIP")]
        public string? CodDescrip { get; set; }
    }
