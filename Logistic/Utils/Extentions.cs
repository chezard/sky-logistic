﻿namespace Logistic.Utils
{
    public static class Extentions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool IsSizeAllowed(this IFormFile file, int bytes)
        {
            return file.Length <= bytes * 1000;
        }
    }
}
