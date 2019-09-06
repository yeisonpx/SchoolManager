using System;
using Microsoft.Extensions.Options;
using School.Common.Settings;

namespace School.Web.Mvc.Core.Repositories
{
    public class SchoolClient : WebApiClient
    {
        public SchoolClient(IOptions<MvcClientSettings> options):base(options)
        {

        }
    }
}
