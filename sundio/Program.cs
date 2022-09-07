using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sundio
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<List<string>> groups = new List<List<string>>();
            List<string> current = null;
            foreach (var line in File.ReadAllLines(@"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\merge_ace_sundio.txt", Encoding.Default))
            {
                if (line.Contains("0400900000") && line[17] == 'n' && current == null)
                    current = new List<string>();
                else if (line.Length == 0 && current != null)
                {
                    groups.Add(current);
                    current = null;
                }
                if (current != null)
                    current.Add(line);
            }

            


              foreach (var s in groups)
               {
               

                File.AppendAllLines(@"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\ACE_New_keep_encod.txt", s, Encoding.GetEncoding(65001));
                
        }

}

}
