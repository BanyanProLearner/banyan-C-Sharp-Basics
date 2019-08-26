using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int showdigit;
    int retval=0;
    int noofCol;    
   int noofRow=0;
    try {
    noofRow = Convert.ToInt32(Console.ReadLine());
   }
  catch{
        Console.WriteLine("INVALID INPUT\n");
    System.Environment.Exit(retval);
}
  //int noofRow = Console.ReadLine();
  
    if (!(noofRow > 0 && noofRow < 21 && retval < 1 )) {
        Console.WriteLine("INVALID INPUT\n");
        retval=1;
    }

    if (retval==0) {
        noofCol = noofRow+(noofRow-1);
        
        for (int idx=0;idx<noofRow;idx++) {
            showdigit = (noofRow-idx)%10;
            showdigit = (showdigit ==0 ? 9:showdigit-1);
            for (int jdx=0;jdx<idx;jdx++){
                Console.Write(" ");  
            }
            for (int kdx=0;kdx < noofCol;kdx++ ){
                Console.Write(showdigit);    
            }
            Console.WriteLine();
            noofCol-=2;
        }
    }



        }
    }
}