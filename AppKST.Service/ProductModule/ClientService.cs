using AppKST.Models;
using AppKST.Models.ClientModule;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKST.Service
{
    public class ClientService
    {
        public string baseURL = ConfigurationManager.AppSettings["apiConnect"];


        public string servicePrefix = "api/";

        public List<ClienteDTO> SearchCliente(SearchClienteDTO filtros)
        {
            var _JsonRequest = JsonConvert.SerializeObject(filtros, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                _JsonRequest,
                baseURL,
                servicePrefix,
                "Client/SearchClient",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<List<ClienteDTO>>(_response);
            return apiResponse;
        }
        public List<TipoDocumentoDTO> GetTipoDocumento()
        {
            var _response = ConsumeService.ConsumirAPI(
                String.Empty,
                baseURL,
                servicePrefix,
                "Client/getTipoDocumento",
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<TipoDocumentoDTO>>(_response);
            return apiResponse;
        }
        public List<ClienteSubcripcionesDTO> getSubcripciones(SearchClienteSubcripcionesDTO filtros)
        {
            var _JsonRequest = JsonConvert.SerializeObject(filtros, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                _JsonRequest,
                baseURL,
                servicePrefix,
                "Client/getSuscripciones",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<List<ClienteSubcripcionesDTO>>(_response);
            return apiResponse;
        }
        public ApiResponseDTO UpdateClient(ClienteDTO _data)
        {
            string json = JsonConvert.SerializeObject(_data, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                json,
                baseURL,
                servicePrefix,
                "Client/UpdateClient",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<ApiResponseDTO>(_response);
            return apiResponse;
        }
        public ApiResponseDTO InsertClient(ClienteDTO _data)
        {
            string json = JsonConvert.SerializeObject(_data, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                json,
                baseURL,
                servicePrefix,
                "Client/InsertClient",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<ApiResponseDTO>(_response);
            return apiResponse;
        }

        public List<ProvinciaDTO> getProvincia(int idDepa)
        {
            
            var _response = ConsumeService.ConsumirAPI(
                string.Empty,
                baseURL,
                servicePrefix,
                "Client/getProvincia?idDepa=" + idDepa,
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<ProvinciaDTO>>(_response);
            return apiResponse;
        }
        public List<DistritoDTO> getDistrito(int idProv)
        {

            var _response = ConsumeService.ConsumirAPI(
                string.Empty,
                baseURL,
                servicePrefix,
                "Client/getDistrito?idProv=" + idProv,
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<DistritoDTO>>(_response);
            return apiResponse;
        }

        public List<DepartamentoDTO> getDepartamento()
        {
            var _response = ConsumeService.ConsumirAPI(
                string.Empty,
                baseURL,
                servicePrefix,
                "Client/getDepartamento",
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<DepartamentoDTO>>(_response);
            return apiResponse;
        }

    }
}
