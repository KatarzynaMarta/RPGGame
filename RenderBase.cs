// See https://aka.ms/new-console-template for more information
//Reguły gry

namespace RPGGame
{
    public class RenderBase
    {
        private int windowWidth;

        public RenderBase(int windowWidth)
        {
            this.windowWidth = windowWidth;
        }

        public static void RenderLine(int widthChange)
        {
            if (widthChange > 0)
                for (int i = 0; i < widthChange; i++)
                {
                    Console.Write("-");
                }
            else
            {
                for (int i = widthChange; i < 0; i++)
                {
                    Console.Write("\b");
                }
            }
            Console.Write("\n");
        }
    }
}