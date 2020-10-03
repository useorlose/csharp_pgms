using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{

    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }

        public override string ToString()
        {
            return string.Format($"The name: {Name} from {Address} is available at {Phone}");
        }
    }

    class Serialization
    {

        static void Main(string[] args)
        {
            binaryInfo();
            Console.ReadKey();
        }

        private static void binaryInfo()
        {
            Console.WriteLine("to Deserialize type as: Read or to Serialize type as :Write");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "read")
                deserializing();
            else
                serializing();
        }

        private static void deserializing()
        {
            FileStream fs = new FileStream("C:\Users\CTEA\Documents\Binary.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter fm = new BinaryFormatter();
            Student s = fm.Deserialize(fs) as Student;
            Console.WriteLine(s.Name);
            fs.Close();
        }

        private static void serializing()
        {

            Student s = new Student { Address = "Hyderabad", Name = "SITARAM", Phone = 45678910 };
            BinaryFormatter fm = new BinaryFormatter();
            FileStream fs = new FileStream("C:\Users\CTEA\Documents\Binary.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fm.Serialize(fs, s);
            fs.Close();
        }
            fs.Flush();
            fs.Close();
       
    }
}
