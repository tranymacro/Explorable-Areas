using System;;

namespace WalterCooper101320
{
    class Program
    {
        //private means that only members of this class
        //can access (read or change) these variables
        private int diameter = 9;
        private int minimumDiameter = 1;
        private string measurementSystem = "inches";
        private int step = 1;

        //Constructor
        //When an instance is made, the statements in this method
        //will run first, and only once
        public Program()
        {
            Console.WriteLine("Steps to draw a Dogon-like pot:");
            DrawPot();
        }

        private void DrawPot()
        {
            //if-then conditional statement
            if (diameter <= minimumDiameter)
            {
                Console.WriteLine($"{step}. Draw the lid");
            }
            else
            {
                Console.WriteLine($"{step}. Draw a circle that is {diameter} {measurementSystem} in size");

                if (diameter >= minimumDiameter)
                {
                    Console.WriteLine($"{step}. Draw a circle that is {minimumDiameter} {measurementSystem} in size");
                }



                else
                {
                    Console.WriteLine($"{step}. Draw the lid");
                }

                if (diameter == minimumDiameter)
                {
                    Console.WriteLine($"{step}. Draw a circle that is {diameter} {measurementSystem} in size");


                }

                else
                {
                    Console.WriteLine($"{step}. Draw the lid");
                }

                Console.ReadKey();
                {

                }
                {

                    {


                    }

                }
            }
        }

    }

}

                
        

            

            






