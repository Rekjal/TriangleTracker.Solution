namespace TriangleTracker.Models
{
    public class Triangle
    {
        public static string TriangleChecker(int side1, int side2, int side3)
        {
            int firstPairing = side1 + side2;
            int secondPairing = side2 + side3;
            int thirdPairing = side1 + side3;
            if ((firstPairing <= side3) || (secondPairing <= side1) || (thirdPairing <= side2))
            {
                //    return notatrinalge;
                return "Not A Triangle";
            }
            else
            {
                if ((side1 == side2) && (side2 == side3) && (side1 == side3))
                {
                    return "Your triangle is an equilateral triangle";
                }
                else if ((side1 == side2) || (side2 == side3) || (side1 == side3))
                {
                    return "Your triangle is an isosceles triangle";
                }
                else
                {
                    return "Your triangle is a scalene triangle";
                }
            }
        }
    }
}