using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_OOP

      
{
    public class Filecsv 
    {
        public string sort ;
        public string Path = @"D:\work code\PROJECT OOP\Data.csv";
       
        public bool wrifile(List<Data> data)
        {
            foreach(Data item in data)
            {
                sort += item.number + "," + item.day + "," + item.schedule + "," + item.revenue + "," + item.expenses + "," + item.remain + "\n";
            }

            try
            {
                File.AppendAllText(Path, sort);
                return true;
            }
            catch  //จับที่มันerror
            { 
                return false; 
            }
       
        }


        
    }
}
