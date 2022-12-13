using System;
using System.Drawing;
class RectContainsApp {
    public static void Main() {
        Rectangle rect = new Rectangle(10, 20, 80, 40);
        Point pt1 = new Point(30, 40);
        Point pt2 = new Point(90, 60);
        Console.WriteLine("포함되는가? : {0}", rect.Contains(pt1));
        Console.WriteLine("포함되는가? : {0}", rect.Contains(pt2));
    }
}
