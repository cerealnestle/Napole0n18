﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apa_yakk
{
    internal class OlahCitra
    {
        public static bool KeBrightness(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = Math.Min(c1.R + 255, 255);
                    int g1 = Math.Min(c1.G + 0, 0);
                    int b1 = Math.Min(c1.B + 0, 0);
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }
    }
}

