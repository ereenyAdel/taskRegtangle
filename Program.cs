using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRectangle
{
    class Program
    {


        public class Point
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        };

        // Returns Total Area of two overlap  
        // rectangles 
        static int overlappingArea(Point l1, Point r1,
                                   Point l2, Point r2)
        {
            Point pointL = new Point(0, 0);
            Point pointr = new Point(0, 0);
            pointL.x = l1.x < l2.x ? l1.x : l2.x;
            pointL.y = l1.y < l2.y ? l1.y : l2.y;
            pointr.x = r1.x > r2.x ? r1.x : r2.x;
            pointr.y = r1.y > r2.y ? r1.y : r2.y;

            int l = Math.Abs(pointL.x - pointr.x);
            int r = Math.Abs(pointL.y - pointr.y);
            
            return (l * r);
        }



        // Driver Code 
        static void Main(string[] args)
        {

        //get the string from user and split it 

        String str = Console.ReadLine();
            char[] spearator = { '[', '(', ',', ')', ']' };
            String[] strlist = str.Split(spearator,
                   StringSplitOptions.None);


            // get Points of rectangle 1 and put it in array
            int[] Xregtangle1 = new int[] { int.Parse(strlist[2]), int.Parse(strlist[6]), int.Parse(strlist[10]), int.Parse(strlist[14]) };
            int[] Yregtangle1 = new int[] { int.Parse(strlist[3]), int.Parse(strlist[7]), int.Parse(strlist[11]), int.Parse(strlist[15]) };

            // get Points of rectangle 2 and put it in array
            int[] Xregtangle2 = new int[] { int.Parse(strlist[18]), int.Parse(strlist[22]), int.Parse(strlist[26]), int.Parse(strlist[30]) };
            int[] Yregtangle2 = new int[] { int.Parse(strlist[19]), int.Parse(strlist[23]), int.Parse(strlist[27]), int.Parse(strlist[31]) };

            // max and min Point in rectangle 1
            var maxXrectangle1 = Xregtangle1.Max();
            var maxYrectangle1 = Yregtangle1.Max();
            var minXrectangle1 = Xregtangle1.Min();
            var minYrectangle1 = Yregtangle1.Min();
            Point ll1 = new Point(maxXrectangle1, maxYrectangle1),
                rr1 = new Point(minXrectangle1, minYrectangle1);

            // max and min Point in rectangle 2
            var maxXrectangle2 = Xregtangle2.Max();
            var maxYrectangle2 = Yregtangle2.Max();
            var minXrectangle2 = Xregtangle2.Min();
            var minYrectangle2 = Yregtangle2.Min();
            Point ll2 = new Point(maxXrectangle2, maxYrectangle2),
                rr2 = new Point(minXrectangle2, minYrectangle2);

            //Get OverlappingArea 
            Console.WriteLine(overlappingArea(ll1, rr1, ll2, rr2));


        }
       
    }
}
