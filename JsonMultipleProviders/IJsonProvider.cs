using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonMultipleProviders
{
    /// <summary>
    /// Interface that provides Json serialising/deserialize capabilities for classes
    /// that implement it.
    /// </summary>
    public interface IJsonProvider
    {
        string Serialise<T>(T obj);
        Y Deserialize<Y>(string jsonContent);
    }
}
