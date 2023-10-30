//using System.Runtime.InteropServices;

//namespace WoodLand

//{

//    public class Tela

//    {

//        [DllImport("kernel32.dll", ExactSpelling = true)]

//        private static extern IntPtr GetConsoleWindow();

//        private static IntPtr ThisCon = GetConsoleWindow();



//        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

//        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);



//        // State of the application once loaded

//        private const int HIDE = 0;

//        private const int MAXIMIZE = 3;

//        private const int MINIMIZE = 6;

//        private const int RESTORE = 9;



//        public static void Teste()

//        {



//            ShowWindow(ThisCon, MAXIMIZE);



//            System.Console.WindowWidth = Console.LargestWindowWidth;

//            System.Console.WindowHeight = Console.LargestWindowHeight;

//            System.Console.BufferWidth = Console.LargestWindowWidth;

//            System.Console.BufferHeight = Console.LargestWindowHeight;

//        }



//    }

//}