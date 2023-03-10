using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 3, denominator = 4, read1 = 3, read2 = 7;
            string path = "C:/Users/vladk/OneDrive/Рабочий стол/C#/Lab_6/lab1.dat";
            string path2 = "C:/Users/vladk/OneDrive/Рабочий стол/C#/Lab_6/lab1(2).dat";

            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
            for (int i = 1; i < 10; i++)
            {
                writer.Write(first);
                Console.WriteLine("В файл 1 записали: " + first + '[' + i + ']');
                first *= denominator;
            }
            writer.Close();

            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
            BinaryWriter writer2 = new BinaryWriter(File.Open(path2, FileMode.OpenOrCreate));
            for (int i = 1; reader.PeekChar() != -1; i++)
            {
                int a = 0;
                if (i == read1 || i == read2)
                {
                    //writer2.Write(reader.ReadInt32());
                    a = reader.ReadInt32();
                    writer2.Write(a);
                    Console.WriteLine("\nВ файл 2 записали: " + a + '[' + i + ']');
                }
                else
                    reader.ReadInt32();
            }
            reader.Close();
            writer2.Close();
        }
    }
}