using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace project12
{
    class Program
    {
        

        static void Main(string[] args)
        {

            // Main function and calling (parsedata) function
            string inputPath = @"C:\Users\po\28-09-2021.pu";
            string outPutPath = @"C:\Users\po\source\repos\project12\project12\bin\Debug\netcoreapp3.1";

            ParseData(inputPath, outPutPath);

        }






        /// <summary>
        /// read third party file and parsing data to output format
        /// </summary>
        /// <param name="inputPath">path to input file</param>
        /// <param name="outPutPath">path to output file</param>
        public static void ParseData(string inputPath, string outPutPath)
        {


            //read file data
            StreamReader str = new StreamReader(inputPath);
            str.ReadToEnd();
        

            //  (write file output data)

            //  DateTime of file
            string dt = DateTime.Now.ToString("dd-MM-yyyy");
            StreamWriter wr = new StreamWriter($@"{outPutPath}\{dt}.pu");
            // variables of my output file
            int age = 30, age1 = 40;
            string country = "Egypt", country1 = "US";
            string name = "korain", name1 = "khaled";
            string[] date = { "otherdata" };
            string date1 =  "a , b , c" ;
            string[] date2 = date1.Split(',');
            string lt1 = date2.ElementAt(0);
            string lt2 = date2.ElementAt(1);
            string lt3 = date2.ElementAt(2);
            int count = 2;
          
            // formating file
            wr.Write(string.Format("date : {0} , count : {1}", dt, count + "\n" + "}" + "\n" + "   [" + "\n     "));
            wr.Write(string.Format("age :{0}\ncountry :{1}\nName :{2}\nDate :{3}", age, country, name, date[0] + "\n"));
            wr.Write(string.Format("age :{0}\ncountry :{1}\nName :{2}\nDate :{3}", age1, country1, name1, lt1+"\n"+lt2 + "\n" + lt3));
            wr.Close();
            
           

        }
    }
}
