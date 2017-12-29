using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw4
{
  
    public class Paper
    {
        private double _weight;
        private double _height;
        private double _width;
        private string _type;
        private string _color;
        private string _internationalType;

        private static int _count;

        #region Constructors
        public Paper()
        {
            Weight = 80.0;
            DefineInternationalType("A4", out _internationalType);
            _type = "printing";
            _color = "white";

            _count++;
        }
        public Paper(double weight, double height, double width, string type = "printing", string color = "white")
        {
            Weight = weight;
            Height = height;
            Width = width;
            Type = type;
            Color = color;

            _count++;
        }
        public Paper(double weight, string internationalType, string type = "printing", string color = "white")
        {
            Weight = weight;
            InternationalType = internationalType;
            Type = type;
            Color = color;

            _count++;
        }

        static Paper()
        {
            _count = 0;
        }
        #endregion

        #region Accessors        
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                    _height = value;
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string InternationalType
        {
            get
            {
                return _internationalType;
            }
            set
            {
                try
                {
                    DefineInternationalType(value, out _internationalType);
                }
                catch (UndefinedTypeException)
                {
                    _internationalType = "Custom";
                }
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        #endregion

        #region Methods
        public void DefineInternationalType(string internationalType, out string type)
        {
            if (String.Compare(internationalType, "A2", true) == 0)
            {
                Height = 594.0;
                Width = 420.0;
                type = "A2";
            }
            else if (String.Compare(internationalType, "A3", true) == 0)
            {
                Height = 420.0;
                Width = 297.0;
                type = "A3";
            }
            else if (String.Compare(internationalType, "A4", true) == 0)
            {
                Height = 297.0;
                Width = 210.0;
                type = "A4";
            }
            else if (String.Compare(internationalType, "A5", true) == 0)
            {
                Height = 210.0;
                Width = 148.0;
                type = "A5";
            }
            else
            {
                throw (new UndefinedTypeException("Введенный тип не существует или находиться в разработке"));
            }
        }
        #endregion
    }
}
