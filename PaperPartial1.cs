using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw4
{
    public partial class Paper
    {
        public string PaperInfo()
        {
            return String.Format("Format: {0}\nWeight: {1}\nHeight: {2}\nWidth: {3}\nType: {4}\nColor: {5}",
                                            InternationalType, Weight, Height, Width, Type, Color);
        }
        public void PaperInfo(out string[] info)
        {
            int size = 6;
            info = new string[size];
            info[1] = "Format: " + InternationalType;
            info[2] = "Weight: " + Weight;
            info[3] = "Height: " + Height;
            info[4] = "Width: " + Width;
            info[5] = "Type: " + Type;
            info[6] = "Color: " + Color;
        }
    }
}