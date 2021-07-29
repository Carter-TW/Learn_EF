using System;
using System.Linq;

namespace Learn_EF
{
    public class School
    {
        public School()
        {

        }
        public  void Update()
        {
            
            var db = new School_108Context();
            var test = db.School108s.FirstOrDefault();
            Console.WriteLine(test.縣市名稱);
            test.縣市名稱 = "132213456";
            db.SaveChanges();
            test = db.School108s.FirstOrDefault();
            Console.WriteLine(test.縣市名稱);
            
        }
    }
    class Program
    {

        static void Main()
        {
            School tw = new School();
            tw.Update();
        }
        
       
         
        
       
    }
}
