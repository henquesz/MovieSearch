using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace MovieSearch
{
    public class Class1
    {
        string nome;
        string ano;
        string cateogria;
        string duracao;

        public void apiCall(string[] args)
        {

            string apiKey = "3c0f6d32";
            string baseUri = $"http://www.omdbapi.com/?apikey={apiKey}";
            string name = "maniac";
            string type = "series";

            var sb = new StringBuilder(baseUri);
            sb.Append($"&s={name}");
            sb.Append($"&type={type}");
            var request = WebRequest.Create(sb.ToString());
            request.Timeout = 1000;
            request.Method = "GET";
            request.ContentType = "application/json";

            string result = string.Empty;

            try
            {
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine(result);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

    }
}

