using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPass
{
    public class ItemInfo
    {
        public enum Type {Clip, File, Program}
        public enum Position { button, dropDownOne, dropDownTwo}

        Type type;
        String name;
        String detail;
        Position position;

        public ItemInfo(String type, String name, String position, String detail)
        {
            bool parseResult = Type.TryParse<Type>(type, out Type result);
            if (parseResult)
            {
                this.Type1 = result;
            }
            this.Name = name;
            this.Detail = detail;
            bool parsePosition = Position.TryParse<Position>(position, out Position result2);
            if (parsePosition)
            {
                this.Position1 = result2;
            }
        }


        public static String Return_Details(String item, List<ItemInfo> list)
        {
            foreach (ItemInfo thing in list)
            {
                if (item == thing.Name) 
                {
                    return thing.Detail;
                }
            }
            return "Not Found";
        }

        internal Type Type1 { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Detail { get => detail; set => detail = value; }
        internal Position Position1 { get => position; set => position = value; }
    }
}
