using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace JsonMultipleProviders.Providers
{
    public class NativeProvider : IJsonProvider
    {
        private JavaScriptSerializer nativeParser = new JavaScriptSerializer();

        public Y Deserialize<Y>(string jsonContent)
        {
            if (String.IsNullOrEmpty(jsonContent))
                throw new NullReferenceException("jsonContent must not be empty!");

            return nativeParser.Deserialize<Y>(jsonContent);
        }

        public string Serialise<T>(T obj)
        {
            if (obj == null)
                throw new NullReferenceException("jsonContent must not be empty!");

            return nativeParser.Serialize(obj);
        }
    }

}
