using System.Reflection.Metadata.Ecma335;


namespace MonstaMathLIB
{
    public class monstaLib
    {

        double version = 1.1;
        double pi = 3.14;
        double area;

        public string CreaterInfo()
        {
            string developer = "Developed by: Ata Yigit Uzay Ustundag";
            return developer;
        }

        public string VersionInfo()
        {
            return $"Version: {version}";
        }

        // ADDING
        public string add(int a, int b)
        {
            return $"Resut of: {a} + {b} = " + (a + b);
        }
        public string add(int a, int b, int c)
        {
            return $"Resut of: {a} + {b} + {c} = " + (a + b + c);
        }
        public string add(int a, int b, int c, int d)
        {
            return $"Resut of: {a} + {b} + {c} + {d} = " + (a + b + c + d);
        }
        public string add(int a, int b, int c, int d, int e)
        {
            return $"Resut of: {a} + {b} + {c} + {d} + {e} = " + (a + b + c + d + e);
        }
        public string add(double a, double b)
        {
            return $"Resut of: {a} + {b} = " + (a + b);
        }
        public string add(double a, double b, double c)
        {
            return $"Resut of: {a} + {b} + {c} = " + (a + b + c);
        }
        public string add(double a, double b, double c, double d)
        {
            return $"Resut of: {a} + {b} + {c} + {d} = " + (a + b + c + d);
        }
        public string add(double a, double b, double c, double d, double e)
        {
            return $"Resut of: {a} + {b} + {c} + {d} + {e} = " + (a + b + c + d + e);
        }

        // SUBTRACTING
        public string subtract(int a, int b)
        {
            return $"Resut of: {a} - {b} = " + (a - b);
        }
        public string subtract(int a, int b, int c)
        {
            return $"Resut of: {a} - {b} - {c} = " + (a - b - c);
        }
        public string subtract(int a, int b, int c, int d)
        {
            return $"Resut of: {a} - {b} - {c} - {d} = " + (a - b - c - d);
        }
        public string subtract(int a, int b, int c, int d, int e)
        {
            return $"Resut of: {a} - {b} - {c} - {d} - {e} = " + (a - b - c - d - e);
        }
        public string subtract(double a, double b)
        {
            return $"Resut of: {a} - {b} = " + (a - b);
        }
        public string subtract(double a, double b, double c)
        {
            return $"Resut of: {a} - {b} - {c} = " + (a - b - c);
        }
        public string subtract(double a, double b, double c, double d)
        {
            return $"Resut of: {a} - {b} - {c} - {d} = " + (a - b - c - d);
        }
        public string subtract(double a, double b, double c, double d, double e)
        {
            return $"Resut of: {a} - {b} - {c} - {d} - {e} = " + (a - b - c - d - e);
        }

        // MULTIPLYING
        public string multiply(int a, int b)
        {
            return $"Resut of {a} * {b} = " + (a * b);
        }
        public string multiply(double a, double b)
        {
            return $"Resut of {a} * {b} = " + (a * b);
        }

        // DIVIDING
        public string division(int a, int b)
        {
            return $"Resut of {a} / {b} = " + (a / b);
        }
        public string division(double a, double b)
        {
            return $"Resut of {a} / {b} = " + (a / b);
        }

        // AREA CALCULATION
        public string squareArea(int a)
        {
            return $"Area of given Square: {a * a}";
        }
        public string squareArea(double a)
        {
            return $"Area of given Square: {a * a}";
        }

        public string rectangleArea(int l, int w)
        {
            return $"Area of given Rectangle: {l * w}";
        }
        public string rectangleArea(double l, double w)
        {
            return $"Area of given Rectangle: {l * w}";
        }

        public string triangleArea(int b, int h)
        {
            area = (0.5) * (b) * (h);
            return $"Area of given Tirangle: {area}";
        }
        public string triangleArea(double b, double h)
        {
            area = (0.5) * (b) * (h);
            return $"Area of given Tirangle: {area}";
        }

        public string circleArea(int r)
        {
            area = pi * (r * r);
            return $"Area of given Circle: {area}";
        }
        public string circleArea(double r)
        {
            area = pi * (r * r);
            return $"Area of given Circle: {area}";
        }

        public string ellipseArea(int a, int b)
        {
            area = pi * a * b;
            return $"Area of given Ellipse: {area}";
        }
        public string ellipseArea(double a, double b)
        {
            area = pi * a * b;
            return $"Area of given Ellipse: {area}";
        }

        //PERIMETER CALCULATION
        public string trianglePerimeter(int a, int b, int c)
        {
            area = a + b + c;
            return $"Perimeter of given Triangle: {area}";
        }
        public string trianglePerimeter(double a, double b, double c)
        {
            area = a + b + c;
            return $"Perimeter of given Triangle: {area}";
        }

        public string rectanglePerimeter(int l, int w)
        {
            area = 2 * (l * w);
            return $"Perimter of given Rectangle: {area}";
        }
        public string rectanglePerimeter(double l, double w)
        {
            area = 2 * (l * w);
            return $"Perimter of given Rectangle: {area}";
        }

        public string parallelogramPerimeter(int b, int h)
        {
            area = 2 * (b * h);
            return $"Perimter of given Parallelogram: {area}";
        }
        public string parallelogramPerimeter(double b, double h)
        {
            area = 2 * (b * h);
            return $"Perimter of given Parallelogram: {area}";
        }

        public string squarePerimeter(int a)
        {
            area = 4 * a;
            return $"Perimeter of given Square: {area}";
        }
        public string squarePerimeter(double a)
        {
            area = 4 * a;
            return $"Perimeter of given Square: {area}";
        }

        public string rhombusPerimeter(int a)
        {
            area = 4 * a;
            return $"Perimeter of given Thombus: {area}";
        }
        public string rhombusPerimeter(double a)
        {
            area = 4 * a;
            return $"Perimeter of given Thombus: {area}";
        }

        public string hexagonPerimeter(int a)
        {
            area = 6 * a;
            return $"Perimeter of given Hexagon: {area}";
        }
        public string hexagonPerimeter(double a)
        {
            area = 6 * a;
            return $"Perimeter of given Hexagon: {area}";
        }

    }
}
