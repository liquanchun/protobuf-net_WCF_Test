using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProtoBuf_Model
{
    [DataContract]
    [ProtoContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";
        int intValue = 1;

        [DataMember]
        [ProtoMember(1)]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        [ProtoMember(2)]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

        [DataMember]
        [ProtoMember(3)]
        public int IntValue
        {
            get { return intValue; }
            set { intValue = value; }
        }
    }
}
