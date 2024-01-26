

namespace C3LE3Triangle
{
    internal class Program
    {

        //In the Main method
        //1. Instantiate the Triangle Class
        //2. Call the CalcPerimeter method
        //3. Call the CalcIPerimeter method
        //4. Call the CalcArea method
        //5. Call the CalcIArea method
        //6. Call the Display method
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.CalcPerimeter();
            triangle.CalcIPerimeter();
            triangle.CalcArea();
            triangle.CalcIArea();
            triangle.Display();
        }
    }
    //Create a Triangle Class
    //1. Declare a perimeter and area private instance variables of type double
    //2. Declare a perimeter and area private instance variables of type int
    //3. Declare a base, height, and hypotenuse private instance variables of type double
    //In the Constructor
    //1. Set the values to zero for the perimeters and areas instance variables
    //2. Set the values of base = 6.6, height = 3.4, and hypotenuse = 8.6

    internal class Triangle
    {
        private double perimeter;
        private double area;

        private int iPerimeter;
        private int iArea;

        private double triBase;
        private double height;
        private double hyp;

        public Triangle()
        {
            perimeter = 0;
            area = 0;

            perimeter = 0;
            area = 0;

            triBase = 6.6;
            height = 3.4;
            hyp = 8.6;

        }
        //Create a CalcPerimeter method with retur
        //Create a CalcIPerimeter with return type of int
        //1. Compute the perimeter and assign it to the appropriate instance variable
        //Formula for perimeter = base + height + hypotenuse
        public double CalcPerimeter()
        {
            perimeter = triBase + height + hyp;
            return perimeter;
        }

        //Create the CalcIArea with return type of int
        //1. Compute the area and assign it to the appropriate instance variable
        public int CalcIPerimeter()
        {
            perimeter = triBase + height + hyp;
            return iPerimeter;
        }
        //Formula for area = ½ * (base * height)
        //Create a CalcArea method with return type of double
        //1. Compute the area and assign it to the appropriate instance variablese * height)
        public double CalcArea()
        {
            area =  (.5)*(triBase * height);
            return iArea;
        }

        public int CalcIArea()
        {
            area = (.5) * (triBase * height);
            return iArea;
        }
        //Create a Display method with return type of void
        //1. Use WriteLine to display the following
        //The triangle has a perimeter of <perimeter.2> and an area of <area.4>
        //The triangle has an integer perimeter of <perimeter(5 digits)> and an
        //integer area of <area(5 digits)>
        //Format the output as follow:
        //• perimeter.2 = with 2 decimal values
        //• area.4 = with 4 decimal values
        //• perimeter(5 digits) = with 5 digits including leading zeros
        //• area(5 digits) = with 5 digits including leading zeros

        public void Display()
        {
            Console.WriteLine($"The triangle has a perimeter of {perimeter.ToString("F2")} and an area of {area.ToString("F4")}.");
            Console.WriteLine($"The triangle has an integer perimeter of {perimeter.ToString("F5")} and an integer area of {area.ToString("F5")}");
        }

    }
}
