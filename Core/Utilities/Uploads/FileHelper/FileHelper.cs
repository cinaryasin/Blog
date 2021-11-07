﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Uploads.FileHelper
{
    public class FileHelper
    {
        static string directory = Directory.GetCurrentDirectory() + @"\wwwroot\";
        //static string path = @"/Images\";

        /// <summary>
        /// File Helper Add
        /// </summary>
        /// <param name="file"> File </param>
        /// <param name="path"> @"/Images\" </param>
        /// <returns></returns>
        public static string Add(IFormFile file,string path)
        {
            string extension = Path.GetExtension(file.FileName);
            string newFileName = Guid.NewGuid().ToString("N") + extension;

            if (!Directory.Exists(directory + path))
            {
                Directory.CreateDirectory(directory + path);
            }

            using (FileStream fileStream = File.Create(directory + path + newFileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }


            return (path + newFileName).Replace("\\", "/");
        }



        public static void Delete(string imagePath)
        {
            if (File.Exists(directory + imagePath.Replace("/", "\\")) && Path.GetFileName(imagePath) != "image.bmp")
            {
                File.Delete(directory + imagePath.Replace("/", "\\"));
            }
        }


        public static string Update(IFormFile file, string oldImagePath,string newPath)
        {
            Delete(oldImagePath);
            return Add(file, newPath);


        }


    }
}
