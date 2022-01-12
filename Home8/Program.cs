using System;

namespace Home8
{
    class Program
    {
        static void Main(string[] args)
        {
            Function play = new Function( 5 , "minutes" , 10 , "minutes");
            play.TimeAdder();
        }
    }
}
