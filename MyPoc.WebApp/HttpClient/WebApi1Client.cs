using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyPoc.Web.HttpClients
{
    public interface IWebApi1Client
    {
        Task<string> Get();
    }
    public class WebApi1Client : IWebApi1Client
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _httpClient;

        public WebApi1Client(IConfiguration config, HttpClient httpClient)
        {
            _config = config;
            string url = config.GetValue<string>("webapi1url");
            httpClient.BaseAddress = new Uri(url);
            _httpClient = httpClient;
        }

        public async Task<string> Get()
        {
            var queryString = $"api/values";
            var response = await _httpClient.GetStringAsync(queryString);
            return response;
        }   
    }
}
