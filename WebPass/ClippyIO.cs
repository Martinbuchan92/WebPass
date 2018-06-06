﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPass
{
    class ClippyIO
    {
        static List<itemInfo> itemInfos = new List<itemInfo>();

        public static List<itemInfo> Data_Load(String path)
        {
            using (var reader = new StreamReader(path))
            {
                List<string> information = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    itemInfo item = new itemInfo(values[0], values[1], values[2]);
                    itemInfos.Add(item);

                    information.Add(values[1]);
                }

                return itemInfos;
            }
        }

        public static Boolean Data_Save(List<itemInfo> item, String path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach(itemInfo thing in item)
                {
                    var line = thing.Type1 + ", " + thing.Name + ", " + thing.Detail;
                    writer.WriteLine(line);
                }
            }
                return true;
        }
    }
}