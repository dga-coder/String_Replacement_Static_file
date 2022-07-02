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
            //string path = @"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\merge_ace_sundio.txt";
            //Console.Write(path);
            //Console.ReadLine();

            //    string text;
            //    using (var streamReader = new StreamReader(@"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\merge_ace_sundio.txt", Encoding.UTF8))
            //    {
            //        text = streamReader.ReadToEnd();
            //        //string tofind = "0400900000";
            //        //int start = text.IndexOf(tofind) + tofind.Length;
            //        //Console.Write(text);
            //        //Console.Write(start);

            //        string data = getBetween(text, "0400900000", "0400900000");

            //    }
            //}

            //public static string getBetween(string strSource, string strStart, string strEnd)
            //{
            //    int Start, End;
            //    if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            //    {
            //        Start = strSource.IndexOf(strStart, 0) + strStart.Length;
            //        End = strSource.IndexOf(strEnd, Start);
            //        return strSource.Substring(Start, End - Start);
            //    }
            //    else
            //    {
            //        return "";
            //    }

            //string path = @"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\merge_ace_sundio.txt";

            //using (StreamReader sr = new StreamReader(path, true))
            //{
            //    while (sr.Peek() >= 0)
            //    {
            //        Console.Write((char)sr.Read());
            //    }

            //    //Test for the encoding after reading, or at least
            //    //after the first read.
            //    Console.WriteLine("The encoding used was {0}.", sr.CurrentEncoding);
            //    Console.ReadKey();
            //    Console.ReadLine();
            //    Console.WriteLine();

            //}


            //public static Encoding GetEncoding(string filename)
            //{
            //    Read the BOM
            //   var bom = new byte[4];
            //    using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            //    {
            //        file.Read(bom, 0, 4);
            //    }

            //    Analyze the BOM
            //    if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            //    if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            //    if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            //    if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            //    if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            //    return Encoding.ASCII;
            //}



            //////////////////////////////working Encoding.GetEncoding(65001))

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

            //////////////////////////////


            //string outfile =@"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\SavedList.txt";

            //File.WriteAllText(@"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\SavedList.txt", groups.ToString());
            //TextWriter tw = new StreamWriter(@"c:\\users\\athdga\\desktop\\sundio\\ace merged\\savedlist.txt");


              foreach (var s in groups)
               {
                //string str = string.Join("\n", s) + Environment.NewLine;
                //Console.Write(str);
                //Console.ReadKey();
                //foreach (var t in str)
                //{

                File.AppendAllLines(@"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\ACE_New_keep_encod.txt", s, Encoding.GetEncoding(65001));
                //File.AppendAllLines(@"C:\\Users\\athdga\\Desktop\\sundio\\TFS Merged\\TFS_Cancellation.txt", s, Encoding.GetEncoding(65001));
                //File.AppendAllLines(@"C:\\Users\\athdga\\Desktop\\sundio\\TFS Merged\\TFS_Amendment.txt", s, Encoding.GetEncoding(65001));

                //}
                //string str = string.Join(", ", s);//+ Environment.NewLine;
                //foreach (var t in str)
                //{
                //    tw.WriteLine(string.Join(", ", t)); // + Environment.NewLine);
                //}

            }
            //tw.Close();

            //using (var reader = new StreamReader(@"C:\\Users\\athdga\\Desktop\\sundio\\ACE Merged\\merge_ace_sundio.txt"))
            //{
            //    var textInBetween = new List<string>();

            //    bool startTagFound = false;

            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        if (String.IsNullOrEmpty(line))
            //            continue;

            //        if (!startTagFound)
            //        {
            //            startTagFound = line.StartsWith("0400900000");
            //            continue;
            //        }

            //        bool endTagFound = line.StartsWith("0400900000");
            //        if (endTagFound)
            //        {
            //            // Do stuff with the text you've read in between here
            //            // ...

            //            textInBetween.Clear();
            //            continue;
            //        }

            //        textInBetween.Add(line);
            //    }
        }



}

}

