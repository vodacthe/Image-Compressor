#region[Directive]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
#endregion[Directive]

namespace ImageCompressor.Logics.Helper
{
    public class ImageCompress
    {

        #region[Data]
        private static volatile ImageCompress imageCompress;
        public Image image;
        public int width { get; set; }
        public int height { get; set; }
        public int compressionDivider { get; set; } = 1;
        private Image img;
        #endregion[Data]

        #region[Constructor]
        /// <summary>
        /// It is used to restrict to create the instance of the      ImageCompress
        /// </summary>
        private ImageCompress()
        {
        }
        #endregion[Constructor]

        #region[Poperties]
        /// <summary>
        /// Gets ImageCompress object
        /// </summary>
        public static ImageCompress GetImageCompressObject
        {
            get
            {
                if (imageCompress == null)
                {
                    imageCompress = new ImageCompress();
                }
                return imageCompress;
            }
        }

        #endregion[Poperties]

        #region[PublicFunction]
        /// <summary>
        /// This function is used to save the image
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="path"></param>
        public void Save(string fileName, string path, int quality)
        {
            path += "\\Compressed\\";
            fileName = fileName.Split(new string[] { "\\" }, StringSplitOptions.None).Last();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (ISValidFileType(fileName))
            {
                string pathaname = path+ fileName;
                save(pathaname, quality);
            }
        }
        #endregion[PublicFunction]

        #region[PrivateData]
        /// <summary>
        /// This function is use to compress the image to
        /// predefine size
        /// </summary>
        /// <returns>return bitmap in compress size</returns>
        private Image CompressImage()
        {
            if (image != null)
            {
                Image newImage = new Bitmap(image, new Size(image.Width / compressionDivider, image.Height / compressionDivider));

                return newImage;
            }
            else
            {
                throw new Exception("Please provide bitmap");
            }
        }

        /// <summary>
        /// This function is used to check the file Type
        /// </summary>
        /// <param name="fileName">String data type:contain the file name</param>
        /// <returns>true or false on the file extention</returns>
        private bool ISValidFileType(string fileName)
        {
            bool isValidExt = false;
            string fileExt = Path.GetExtension(fileName);
            switch (fileExt.ToLower())
            {
                case CommonConstant.JPEG:
                case CommonConstant.BTM:
                case CommonConstant.JPG:
                case CommonConstant.PNG:
                    isValidExt = true;
                    break;
            }
            return isValidExt;
        }

        /// <summary>
        /// This function is used to get the imageCode info
        /// on the basis of mimeType
        /// </summary>
        /// <param name="mimeType">string data type</param>
        /// <returns>ImageCodecInfo data type</returns>
        private ImageCodecInfo GetImageCoeInfo(string mimeType)
        {
            ImageCodecInfo[] codes = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].MimeType == mimeType)
                {
                    return codes[i];
                }
            }
            return null;
        }

        /// <summary>
        /// this function is used to save the image into a
        /// given path
        /// </summary>
        /// <param name="path">string data type</param>
        /// <param name="quality">int data type</param>
        private void save(string path ,int quality)
        {
            img = CompressImage();
            ////Setting the quality of the picture
            EncoderParameter qualityParam =
                new EncoderParameter(System.Drawing.Imaging.Encoder.Quality,quality);
            EncoderParameter compressionParam = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionCCITT3);
            ////Seting the format to save
            ImageCodecInfo imageCodec = GetImageCoeInfo("image/jpeg");
            ////Used to contain the poarameters of the quality
            EncoderParameters parameters = new EncoderParameters(2);
            parameters.Param[0] = qualityParam;
            parameters.Param[1] = compressionParam;
            ////Used to save the image to a  given path
            img.Save(path, imageCodec, parameters);
        }
        #endregion[PrivateData]
    }
}
