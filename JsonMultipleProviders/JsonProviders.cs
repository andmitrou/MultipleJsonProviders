using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonMultipleProviders
{
    public class JsonProviders
    {
        List<IJsonProvider> parsers;
        public JsonProviders()
        {
            parsers = new List<IJsonProvider>();

            var definedParsers = AppDomain.CurrentDomain.GetAssemblies()
                         .SelectMany(t => t.GetTypes())
                         .Where(t => t.IsClass && t.Namespace == "JsonMultipleProviders.Providers");

            foreach (var parser in definedParsers)
            {
                var parserInstance = Activator.CreateInstance(parser) as IJsonProvider;
                parsers.Add(parserInstance);
            }

        }

        public IJsonProvider GetProvider(ProviderEnum availableParsers)
        {
            return parsers.FirstOrDefault(x => x.GetType().Name == availableParsers.ToString());
        }
    }
}
