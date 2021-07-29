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
            var test = db.School108s.First();
            test.縣市名稱 = "1235";
            db.SaveChanges();
             test = db.School108s.First();
            Console.WriteLine(test.學校名稱);
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
