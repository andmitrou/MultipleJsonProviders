using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonMultipleProviders;
using System.Web.Script.Serialization;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example Create a dictionary object to be converted
            var dict = new Dictionary<string, object>();
            dict.Add("Name", "Contoso");
            dict.Add("Surname", "Ostoso");
            dict.Add("Age", "27");

            
            //Create Providers and select Native provider to Serialise
            var parsers = new JsonProviders();
            IJsonProvider nativeParser = parsers.GetProvider(ProviderEnum.NativeProvider);
            var json = nativeParser.Serialise<Dictionary<string, object>>(dict);
         

             //Now use different provider to deserialize it to object 
             IJsonProvider newtonParser = parsers.GetProvider(ProviderEnum.NewtonsoftProvider);
            var resultObject = newtonParser.Deserialize<Dictionary<String, object>>(json);

        }

      
    }
}
