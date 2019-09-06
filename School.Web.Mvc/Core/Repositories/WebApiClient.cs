using System;
using System.Net.Http;
using Microsoft.Extensions.Options;
using School.Common.Settings;

namespace School.Web.Mvc.Core.Repositories
{
    public class WebApiClient
    {
        private readonly MvcClientSettings _settings;

        public WebApiClient(IOptions<MvcClientSettings> settings)
        {
            this._settings = settings.Value;
        }

        public HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_settings.WebApiUri);
            return client;
        }
    }
}
