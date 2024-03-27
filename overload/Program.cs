



//namespace task6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Min());
//        }
//        public static int Min()
//        {
//            int[] arr = { 5, 3, 4, 9, 6, 1, 8 };
//            int min = arr[0];
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] < min)
//                {
//                    min = arr[i];
//                }
//            }
//            return min;
//        }
//    }
//}






//namespace task6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Area());
//        }
//        public static int Area()
//        {
//            int p = 3;
//            int r = 5;
//            int s = p * r * r;
//            return s;
//        }
//    }
//}













//namespace task6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Area());
//        }
//        public static int Area()
//        {
//            int length = 3;
//            int width = 4;
//            int s = length * width;
//            return s;
//        }
//    }
//}








//namespace task6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Area());
//        }
//        public static int Area()
//        {
//            int length = 3;
//            int width = 4;
//            int height = 5;
//            int s = 2 * (length * width + length * height + width * height);
//            return s;
//        }
//    }
//}







//namespace task6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Area());
//        }
//        public static int Area()
//        {
//            int a = 3;
//            int b = 4;
//            int c = 5;
//            int r = 8;
//            int p = (a + b + c) / 2;
//            int s = p * r;

//            return s;
//        }
//    }
//}










namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area(8));
            Console.WriteLine(Area(2, 6));
            Console.WriteLine(Area(2, 6, 4));
            Console.WriteLine(Area(2, 6, 4, 8));
        }
        public static int Area(int radius)
        {
            int p = 3;
            return p * radius * radius;
        }
        public static int Area(int width, int height)
        {
            return width * height;
        }
        public static int Area(int width, int length, int height)
        {
            return 2 * (width * length + width * height + length * height);
        }
        public static int Area(int a, int b, int c, int radius)
        {
            int perimetr = (a + b + c) / 2;
            return perimetr * radius;
        }



    }
}