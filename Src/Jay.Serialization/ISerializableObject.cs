using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay.Serialization
{
    public interface ISerializableObject
    {
        void GetObjectData(SerializableObjectInfo info);
        void SetObjectData(SerializableObjectInfo info);
    }
}
