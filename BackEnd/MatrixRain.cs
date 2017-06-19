using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecryptAnagram
{
    class MatrixRain
    {

        //time one circle in milliseconds 
        static int DelayOneTour = 50;

        /// <summary>
        /// start here 
        /// </summary>
        /// <param name="TimeToWork"  work time in sec.></param>
        public static void StartMatrixRain(double TimeToWork = 5)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetWindowPosition(0, 0);
            Console.WindowLeft = Console.WindowTop = 0;

            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth ;
            Console.CursorVisible = false;

            Console.Clear();

            int height = Console.WindowHeight;
            int width = Console.WindowWidth - 1;

            // starting y positions of bright green characters
            int[] y = new int[width];


            // setup the screen and initial conditions of y
            Initialize(width, height, y);



            int ms = 0;
            DateTime startTime = DateTime.Now;
            bool isContinue = true;
            // do the Matrix effect
            // every loop all y's get incremented by 1
            while (isContinue)
            {
                DateTime t1 = DateTime.Now;

                isContinue = UpdateAllColumns(width, height, y);
                isContinue = isContinue && (((TimeSpan)(DateTime.Now - startTime)).TotalSeconds <= TimeToWork);

                ms = DelayOneTour - (int)((TimeSpan)(DateTime.Now - t1)).TotalMilliseconds;
                if (ms > 0)
                    System.Threading.Thread.Sleep(ms);
            }
            Console.Clear();
        }


        private static bool UpdateAllColumns(int width, int height, int[] y)
        {
            int x;
            // draws 3 characters in each x column each time... 
            // a dark green, light green, and a space

            // y is the position on the screen
            // y[x] increments 1 each time so each loop does the same thing but down 1 y value
            for (x = 0; x < width; ++x)
            {
                // the bright green character
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x, y[x]);
                Console.Write(AsciiCharacter);

                // the dark green character -  2 positions above the bright green character
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                int temp = y[x] - 2;
                Console.SetCursorPosition(x, inScreenYPosition(temp, height));
                Console.Write(AsciiCharacter);

                // the 'space' - 20 positions above the bright green character
                int temp1 = y[x] - 20;
                Console.SetCursorPosition(x, inScreenYPosition(temp1, height));
                Console.Write(' ');

                // increment y
                y[x] = inScreenYPosition(y[x] + 1, height);
            }

            // F5 to reset, Escape to stop
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.F5)
                    Initialize(width, height, y);
                else if (key == ConsoleKey.Escape)
                    return false;
            }
            return true;
        }

        // Deals with what happens when y position is off screen
        public static int inScreenYPosition(int yPosition, int height)
        {
            if (yPosition < 0)
                return yPosition + height;
            else if (yPosition < height)
                return yPosition;
            else
                return 0;
        }

        // only called once at the start
        private static void Initialize(int width, int height, int[] y)
        {
            for (int x = 0; x < width; ++x)
            {
                // gets random number 
                y[x] = rand.Next(height);
            }
        }


        static Random rand = new Random();

        static char AsciiCharacter
        {
            get
            {
                int t = rand.Next(10);
                if (t <= 2)
                    // returns a number
                    return (char)('0' + rand.Next(10));
                else if (t <= 4)
                    // small letter
                    return (char)('a' + rand.Next(27));
                else if (t <= 6)
                    // capital letter
                    return (char)('A' + rand.Next(27));
                else
                    // any ascii character
                    return (char)(rand.Next(32, 255));
            }
        }


    }
}
