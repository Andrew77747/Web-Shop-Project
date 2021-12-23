using System;

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

            Console.WriteLine(model.Url);
            Console.WriteLine(model.Driver);
            Console.WriteLine(model.Timeout);
            Console.WriteLine(model.Driver);
        }
    }
}