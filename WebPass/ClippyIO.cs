using System;
using System.Collections.Generic;
using System.IO;

namespace WebPass
{
    class ClippyIO
    {
        static List<ItemInfo> itemInfos = new List<ItemInfo>();

        public static List<ItemInfo> Data_Load(String path)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    ItemInfo item = new ItemInfo(values[0], values[1], values[2], values[3]);
                    itemInfos.Add(item);
                }

                return itemInfos;
            }
        }

        public static Boolean Data_Save(List<ItemInfo> item, String path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach(ItemInfo thing in item)
                {
                    var line = thing.Type1 + "," + thing.Name + "," + thing.Position1 + "," + thing.Detail;
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("saved");
                return true;
        }
    }
}