using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static AppKST.Service.Enums;

namespace AppKST.Service
{
    public class ConsumeService
    {
        public static string ConsumirAPI(string request, string BaseURL, string servicePrefix, string controller, Method method)
        {
            var error = "";
            try
            {

                System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                (se, cert, chain, sslerror) =>
                {
                    return true;
                };

                var ruta = string.Format("{0}{1}{2}", BaseURL, servicePrefix, controller);
                error += "ruta en ConsumirAPI: " + ruta + Environment.NewLine;
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    string respuesta = string.Empty;
                    if (Method.GET == method)
                    {
                         respuesta = client.DownloadString(ruta);
                    }
                    else
                    {
                        respuesta = client.UploadString(ruta, method.ToString(), request);
                    }
                    error += "respuesta en ConsumirAPI: " + respuesta + Environment.NewLine;
                    return respuesta;
                }

            }
            catch (Exception ex)
            {
                // var excepcion = (HttpWebResponse)ex.Message;
                error += "excepcion en ConsumirAPI: " + ex.Message + Environment.NewLine;
                return error;
            }
        }

    }
}
