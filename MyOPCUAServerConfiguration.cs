using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyOPCUAServer
{
    //[DataContract(Namespace = Namespaces.BatchPlant)] dT
    [DataContract(Namespace = "http://opcfoundation.org/OPCUAServer")]
    public class MyOPCUAServerConfiguration
    {
        public MyOPCUAServerConfiguration()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
    }
}
