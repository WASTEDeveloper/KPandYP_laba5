using System;
using System.Collections.Generic;
using System.Text;

namespace KPandYP_laba5
{
    public class Box
    {
        private double width;
        private double height;
        private double depth;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                bool widthTrue = true;
                while (widthTrue)
                {
                    if (value >= 0)
                    {
                        width = value;
                        widthTrue = false;
                    }
                    else
                    {
                        Console.WriteLine("Не может быть отрицательной длины, введите другое значение: ");
                        value = double.Parse(Console.ReadLine());
                    }
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                bool heightTrue = true;
                while (heightTrue)
                {
                    if (value >= 0)
                    {
                        height = value;
                        heightTrue = false;
                    }
                    else
                    {
                        Console.WriteLine("Не может быть отрицательной высоты, введите другое значение: ");
                        value = double.Parse(Console.ReadLine());
                    }
                }
            }
        }

        public double Depth
        {
            get
            {
                return depth;
            }
            set
            {
                bool depthTrue = true;
                while (depthTrue)
                {
                    if (value >= 0)
                    {
                        depth = value;
                        depthTrue = false;
                    }
                    else
                    {
                        Console.WriteLine("Не может быть отрицательной губины, введите другое значение: ");
                        value = double.Parse(Console.ReadLine());
                    }
                }
            }
        }

        public void Square()
        {
            Console.WriteLine($"Площадь коробки: {2 * (width * height + width * depth + height * depth)}");
        }

        public void Volume()
        {
            Console.WriteLine($"Объем коробки: {width * height * depth}");
        }

        public void Diagonal()
        {
            double dWidthHeight = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            double dHeightDepth = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(depth, 2));
            double dCubed = Math.Sqrt(Math.Pow(width,2) + Math.Pow(height, 2) + Math.Pow(depth, 2));

            if (dWidthHeight > dHeightDepth && dWidthHeight > dCubed)
            {
                Console.WriteLine($"Самая большая диагональ(длина, высота): {Math.Round(dWidthHeight, 2)}");
            }
            else if (dHeightDepth > dWidthHeight && dHeightDepth > dCubed)
            {
                Console.WriteLine($"Самая большая диагональ(высота, глубина): {Math.Round(dHeightDepth, 2)}");
            }
            else if (dCubed > dWidthHeight && dCubed > dHeightDepth)
            {
                Console.WriteLine($"Самая большая диагональ(длина, высота, глубина): {Math.Round(dCubed, 2)}");
            }
        }

        public void CheckVolume()
        {
            if ((width == depth && width / 2 == height) || (width == height && width / 2 == depth) || (height == depth && height / 2 == width))
            {
                Console.WriteLine("Полукуб!");
            } 
            else if (width == height && width == depth)
            {
                Console.WriteLine("Куб!");
            }
            else if ((width > height) || (height > depth) || (width > depth) || (height > width) || (depth > width) || (depth > height))
            {
                Console.WriteLine("Парелеллепипед!");
            }
        }
    }
}
