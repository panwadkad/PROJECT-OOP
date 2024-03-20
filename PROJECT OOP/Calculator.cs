using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_OOP
{
    public class Calculator : Data
    {
        public int count = 0;   

        public int addcount()  //เป็นการแอดค่าเข้า
        {
            count += 1;
            return count;
        }
        public int Remain()  //คงเหลือ
        {
            remain = this.revenue - this.expenses;
            return remain;
        }
        
        //ผลรวมของรายรับ
        public void sumofrev(int revenue)
        {
            this.revenue += revenue;
            
        }

        //ผลรวมของรายจ่าย
        public void sumofexp(int expenses)
        {
            this.expenses += expenses;
            
        }
    }
}
