using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Laboratorium3
{
    internal class ImageProcessing
    {
        public static Bitmap Negative(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;
            BitmapData srcData = image.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            image.UnlockBits(srcData);
            int current = 0;
            int cChannels = 3;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    current = y * srcData.Stride + x * 4;
                    for (int c = 0; c < cChannels; c++)
                    {
                        result[current + c] = (byte)(255 - buffer[current + c]);
                    }
                    result[current + 3] = 255;
                }
            }
            Bitmap resImg = new Bitmap(w, h);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;
        }

        public static Bitmap ApplyThreshold(Bitmap inputBitmap, int threshold)
        {
            Bitmap outputBitmap = new Bitmap(inputBitmap.Width, inputBitmap.Height);

            for (int y = 0; y < inputBitmap.Height; y++)
            {
                for (int x = 0; x < inputBitmap.Width; x++)
                {
                    Color pixelColor = inputBitmap.GetPixel(x, y);
                    int grayscaleValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                    Color newColor = (grayscaleValue < threshold) ? Color.Black : Color.White;

                    outputBitmap.SetPixel(x, y, newColor);
                }
            }

            return outputBitmap;
        }

        public static Bitmap MirrorEffect(Bitmap image)
        {
            Bitmap resultBitmap = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    resultBitmap.SetPixel(i, j, image.GetPixel(image.Width - i - 1, j));
                }
            }

            return resultBitmap;
        }

        public static Bitmap RotateImage(Bitmap image, int angle)
        {
            var src = OpenCvSharp.Extensions.BitmapConverter.ToMat(image);
            Mat dst = new Mat();
            Point2f center = new Point2f(src.Width / 2, src.Height / 2);
            Mat rot = Cv2.GetRotationMatrix2D(center, angle, 1.0);
            Cv2.WarpAffine(src, dst, rot, src.Size());
            return dst.ToBitmap();
        }

        public static Bitmap DetectEdges(Bitmap inputBitmap)
        {
            // Convert Bitmap to Mat
            Mat inputImage = BitmapConverter.ToMat(inputBitmap);

            // Convert input image to grayscale
            Mat grayImage = new Mat();
            Cv2.CvtColor(inputImage, grayImage, ColorConversionCodes.BGR2GRAY);

            // Gaussian blur to reduce noise
            Mat blurredImage = new Mat();
            Cv2.GaussianBlur(grayImage, blurredImage, new OpenCvSharp.Size(5, 5), 0);

            // Canny edge detection
            Mat edges = new Mat();
            Cv2.Canny(blurredImage, edges, 50, 150);

            // Convert Mat to Bitmap
            Bitmap resultBitmap = edges.ToBitmap();

            return resultBitmap;
        }
    }
}
