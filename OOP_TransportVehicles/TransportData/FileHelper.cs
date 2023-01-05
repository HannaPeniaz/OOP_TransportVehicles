﻿using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_TransportVehicles.TransportData
{
    public class FileHelper
    {
        public void WriteTextInFile(List <string> transportObjects)
        {
            Console.WriteLine("Write path and name to download your file (ex.D:\\1.txt) and press Enter.");
            var enteredFolder = Console.ReadLine();
            var filePosition = $@"{enteredFolder}";
            foreach (var transport in transportObjects)
            {
                using (FileStream file = new FileStream(filePosition, FileMode.Append))
                using (StreamWriter stream = new StreamWriter(file))
                {
                    stream.Write(transport);
                }
            }
        }
    }
}
