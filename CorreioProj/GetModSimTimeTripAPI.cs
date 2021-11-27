using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CorreioProj
{
    class GetModSimTimeTripAPI
    {

        String apiURL = "http://127.0.0.1:5000";

        private string getTripInfoRoute(String cepPartida, String cepDestino)
        {
            return String.Format("/gettripinfo&de={0}&para={1}", cepPartida, cepDestino);
        } 

        private string getCEPValidationRoute(String CEP)
        {
            return String.Format("/getcepvalidation&cep={0}", CEP);
        }

        public static string Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}
