﻿using System;
using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputFileStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}