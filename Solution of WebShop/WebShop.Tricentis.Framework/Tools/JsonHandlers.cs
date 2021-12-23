using System;
using Infrastructure.Settings;
using Microsoft.Extensions.Configuration;

namespace WebShop.Tricentis.Framework.Tools
{
    public class JsonHandlers
    {
        public void JsonReader(Appsettings model)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();

            var section = config.GetSection(nameof(Appsettings));
            var appsettingsModel = section.Get<Appsettings>();
            model = appsettingsModel;

            Console.WriteLine(model.BaseUrl);
        }
    }
}