using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPass
{
    class itemInfo
    {
        public enum Type {Clip, File, Program}

        Type type;
        String name;
        String detail;

        public itemInfo(String type, String name, String detail)
        {
            bool parseResult = Type.TryParse<Type>(type, out Type result);
            if (parseResult)
            {
                this.Type1 = result;
            }
            this.Name = name;
            this.Detail = detail;
        }

        internal Type Type1 { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Detail { get => detail; set => detail = value; }

    }
}
