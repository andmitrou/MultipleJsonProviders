using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonMultipleProviders.Providers
{
   public class NewtonsoftProvider: IJsonProvider
    {
        public Y Deserialize<Y>(string jsonContent)
        {
            if (String.IsNullOrEmpty(jsonContent))
                throw new NullReferenceException("jsonContent must not be empty!");

            return JsonConvert.DeserializeObject<Y>(jsonContent);
        }

        public string Serialise<T>(T obj)
        {
            if (obj == null)
                throw new NullReferenceException("object cannot be null!");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
