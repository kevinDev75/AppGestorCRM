using AppKST.Models;
using AppKST.Models.ProductModule;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppKST.Service.ProductModule
{
    public class ProductService
    {
        //public string baseURL = "https://localhost:44303/";
        public string baseURL = ConfigurationManager.AppSettings["apiConnect"];


        public string servicePrefix = "api/";

        public List<ProductoDetailDTO> SearchProduct(SearchProductDTO filtros)
        {
            var _JsonRequest = JsonConvert.SerializeObject(filtros, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                _JsonRequest,
                baseURL,
                servicePrefix,
                "Product/SearchProduct",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<List<ProductoDetailDTO>>(_response);
            return apiResponse;
        } 
        public List<DemografiaDTO> GetDemografia()
        {
            var _response = ConsumeService.ConsumirAPI(
                String.Empty,
                baseURL,
                servicePrefix,
                "Product/getDemografia",
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<DemografiaDTO>>(_response);
            return apiResponse;
        }
        public List<EditorialDTO> GetEditorial()
        {
            var _response = ConsumeService.ConsumirAPI(
                String.Empty,
                baseURL,
                servicePrefix,
                "Product/getEditorial",
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<EditorialDTO>>(_response);
            return apiResponse;
        }
        public List<FormatoDTO> GetFormato()
        {
            var _response = ConsumeService.ConsumirAPI(
                String.Empty,
                baseURL,
                servicePrefix,
                "Product/getFormato",
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<FormatoDTO>>(_response);
            return apiResponse;
        }
        public List<ColeccionDTO> GetColeccion()
        {
            var _response = ConsumeService.ConsumirAPI(
                String.Empty,
                baseURL,
                servicePrefix,
                "Product/getColeccion",
                Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<List<ColeccionDTO>>(_response);
            return apiResponse;
        }
        public List<ColeccionDTO> getColeccionSearch(ColeccionDTO dTO)
        {
            string json = JsonConvert.SerializeObject(dTO, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                json,
                baseURL,
                servicePrefix,
                "Product/getColeccionSearch",
                Enums.Method.POST);


            var apiResponse = JsonConvert.DeserializeObject<List<ColeccionDTO>>(_response);
            return apiResponse;
        }



        public ApiResponseDTO RegisterProduct(ProductoDTO _data)
        {
            string json = JsonConvert.SerializeObject(_data,Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                json,
                baseURL,
                servicePrefix,
                "Product/RegisterProduct",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<ApiResponseDTO>(_response);
            return apiResponse;
        }
        public ApiResponseDTO UpdateProduct(ProductoDTO _data)
        {
            string json = JsonConvert.SerializeObject(_data, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                json,
                baseURL,
                servicePrefix,
                "Product/UpdateProduct",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<ApiResponseDTO>(_response);
            return apiResponse;
        }
        public ApiResponseDTO DeleteProduct(ProductoDTO objproducto)
        {
            string json = JsonConvert.SerializeObject(objproducto, Formatting.Indented);
            var _response = ConsumeService.ConsumirAPI(
                json,
                baseURL,
                servicePrefix,
                "Product/DeleteProduct",
                Enums.Method.POST);

            var apiResponse = JsonConvert.DeserializeObject<ApiResponseDTO>(_response);
            return apiResponse;
        }


        public ProductoDetailDTO getProductxID(int id)
        {
            var _response = ConsumeService.ConsumirAPI(
              String.Empty,
              baseURL,
              servicePrefix,
              "Product/getProductxID?idProduct="+ id,
              Enums.Method.GET);

            var apiResponse = JsonConvert.DeserializeObject<ProductoDetailDTO>(_response);
            return apiResponse;
        }

    }
}
