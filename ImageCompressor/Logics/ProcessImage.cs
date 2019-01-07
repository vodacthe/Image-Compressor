using ImageCompressor.Logics.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ImageCompressor.Logics
{
    public static class ProcessImage
    {
        public static void LoadFolder(string path, out int fileCount, out List<string> files)
        {
            files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly)
                            .Where(f => f.ToLower().EndsWith(CommonConstant.JPEG) || f.ToLower().EndsWith(CommonConstant.JPG)
                                    || f.ToLower().EndsWith(CommonConstant.PNG) || f.ToLower().EndsWith(CommonConstant.BTM)).ToList();
            fileCount = files.Count;
        }

        public static void CompressTask(int quality,int divider ,string savePath,string imagePath)
        {
            try
            {
                ImageCompress imgCompressor = ImageCompress.GetImageCompressObject;

                Image img = Image.FromFile(imagePath);
                imgCompressor.image = img;
                imgCompressor.compressionDivider = divider;
                imgCompressor.Save(imagePath, savePath, quality);
                img.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch
            { }

        }
    }
}
