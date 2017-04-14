using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkOOP
{
    public class Files
    {
        string Name;
        string Extension;
        string Size;


    }


    public class TextFiles : Files
    {
        string Content;
    }


    public class Images : Files
    {
        string Resolution;
    }


    public class Movie : Images
    {
        string Lenght;
    }


    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Text:file.txt(6B);Some string content
Image:img.bmp(19MB);1920x1080
Text:data.txt(12B); Another string
Text:data1.txt(7B); Yet another string
Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";

            string[] ArrTemp = text.Split(new char[] { ':', '(', ')', ';', '\n' });
            foreach (var item in ArrTemp)
            {
                Console.WriteLine(item);
            }
            List<string> Arr = new List<string>();
            int j = 0;
            for (int i = 0; i < ArrTemp.Length; i++)
            {
                if (ArrTemp[i] != "")
                {
                    Arr.Add(ArrTemp[i]);
                }
            }
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
