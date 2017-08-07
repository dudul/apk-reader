﻿using System;
using Newtonsoft.Json;

namespace ApkReader.Run
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var reader = new ApkReader();
            var info = reader.Read(@"E:\Downloads\迅雷下载\wacai__00000001_v11.14.0.0_259.apk");
            var json = JsonConvert.SerializeObject(info,new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            });
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}