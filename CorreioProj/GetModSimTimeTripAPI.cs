using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CorreioProj
{
    class GetModSimTimeTripAPI
    {

        static String apiURL = "https://sun-superficial-balloon.glitch.me";

        public static dynamic getTripInfoRoute(String cepPartida, String cepDestino)
        {
            // Formatando nossa URL para o request da rota.
            String URL = String.Format("/gettripinfo&de={0}&para={1}", cepPartida, cepDestino);

            // Realizando o request.
            String response = performRequest(URL);

            dynamic jsonResponse = JsonConvert.DeserializeObject<object>(response);

            return jsonResponse;
        } 

        public static string getCEPValidationRoute(String CEP)
        {
            // Formatando nossa URL para o request da validação do CEP informado.
            String URL = String.Format("/getcepvalidation&cep={0}", CEP);

            // Realizando o request.
            String response = performRequest(URL);

            // Convertendo nossa string objeto JSON pelo JsonConvert 
            dynamic jsonResponse = JsonConvert.DeserializeObject<object>(response);

            // Retornando o valor para a key "street", que conforme a API que fizemos, irá retornar "error" quando o CEP
            // for inválido (ou seja, quando o CEP não for encontrado pela API dos correios)
            return jsonResponse["street"];
        }

        private static string performRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiURL + url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36";
            Console.WriteLine(request.UserAgent);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}
