using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonMultipleProviders;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a dictionary object to be converted
            var dict = new Dictionary<string, object>();
            dict.Add("Name", "Contoso");
            dict.Add("Surname", "Ostoso");
            dict.Add("Age", "27");

            //Create Providers and select provider to Serialise
            var parsers = new JsonProviders();
            IJsonProvider parser = parsers.GetProvider(ProviderEnum.NewtonsoftProvider);
            var json = parser.Serialise<Dictionary<string, object>>(dict);
        }
    }
}
