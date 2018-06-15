using System;
using System.Collections.Generic;
using System.IO;

namespace WebPass
{
    class ClippyIO
    {
        static List<List<ItemInfo>> listList = new List<List<ItemInfo>>();
        static List<ItemInfo> itemInfos = new List<ItemInfo>();
        static List<ItemInfo> dropDown1 = new List<ItemInfo>();
        static List<ItemInfo> dropDown2 = new List<ItemInfo>();

        public static List<List<ItemInfo>> Data_Load(String path)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[2].ToString() == "dropDownOne")
                    {
                        ItemInfo dd1 = new ItemInfo(values[0], values[1], values[2], values[3], int.Parse(values[4]));
                        dropDown1.Add(dd1);
                    }
                    else if (values[2].ToString() == "dropDownTwo")
                    {
                        ItemInfo dd2 = new ItemInfo(values[0], values[1], values[2], values[3], int.Parse(values[4]));
                        dropDown2.Add(dd2);
                    }
                    else
                    {
                        ItemInfo item = new ItemInfo(values[0], values[1], values[2], values[3]);
                        itemInfos.Add(item);

                    }

                }
                listList.Add(dropDown1);
                listList.Add(dropDown2);
                listList.Add(itemInfos);

                return listList;
            }
        }

        public static Boolean Data_Save(List<ItemInfo> item, String path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (ItemInfo thing in item)
                {
                    if (thing.Position1.Equals("dropDownOne") || thing.Position1.Equals("dropDownTwo"))
                    {
                        var line = thing.Type1 + "," + thing.Name + "," + thing.Position1 + "," + thing.Detail + "," + thing.Location;
                        writer.WriteLine(line);
                    }
                    else
                    {
                        var line = thing.Type1 + "," + thing.Name + "," + thing.Position1 + "," + thing.Detail;
                        writer.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("saved");
                return true;
        }
    }
}