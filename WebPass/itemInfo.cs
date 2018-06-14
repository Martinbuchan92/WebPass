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
        public enum Position { ButtonOne, ButtonTwo, ButtonThree, ButtonFour, ButtonFive, ButtonSix, ButtonSeven, ButtonEight, ButtonNine, ButtonTen, dropDownOne, dropDownTwo}

        Type type;
        String name;
        String detail;
        Position position;
        int location;

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

        public ItemInfo(String type, String name, String position, String detail, int location) : this(type, name, position, detail)
        {
            this.location = location;
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

        public static ItemInfo Details_From_Position(String selectedPosition, List<ItemInfo> list)
        {
            foreach (ItemInfo thing in list)
            {
                if (selectedPosition == thing.Position1.ToString())
                {
                    return thing;
                }
            }
            return null;
        }

        internal Type Type1 { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Detail { get => detail; set => detail = value; }
        internal Position Position1 { get => position; set => position = value; }
        public int Location { get => location; set => location = value; }

        public static implicit operator List<object>(ItemInfo v)
        {
            throw new NotImplementedException();
        }
    }
}
