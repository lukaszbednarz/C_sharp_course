using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace ExceptionHandling
{
    class ImageBrowser
    {
        public string FolderPath { get; set; }

        public void ListImages()
        {
            if (FolderPath == null)
            {
                throw new InvalidOperationException("FolderPath property has not been set. Cannot List images.");
            }
            foreach (string imagePath in Directory.EnumerateFiles(FolderPath, "*.jpg", SearchOption.AllDirectories))
            {
                FileInfo fileInfo = new FileInfo(imagePath);

                Image image;

                try
                {
                    image = Bitmap.FromFile(fileInfo.FullName);
                }
                catch (OutOfMemoryException ex)
                {
                    
                    throw new ImageFormatException(ex, imagePath);
                }
                
                Console.WriteLine("{0}, {1}x{2} ({3:0,0} bytes)",
                fileInfo.Name,
                image.Size.Height,
                image.Size.Width,
                fileInfo.Length);
            }
        }
    }
}
