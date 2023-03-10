namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countReplace = 0;
            string text = File.ReadAllText("C:\\Users\\vladk\\OneDrive\\Рабочий стол\\C#\\Lab_6\\text.txt");
            char[] replace = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < replace.Length; j++)
                {
                    if (text[i] == replace[j])
                    {
                        countReplace++;
                    }
                }   
            }
            
            for (int i = 0; i < replace.Length; i++)
            {
                text = text.Replace(replace[i],'*');
            }
            File.WriteAllText("C:\\Users\\vladk\\OneDrive\\Рабочий стол\\C#\\Lab_6\\text1.txt",text);

            Console.WriteLine("Количество замен: " + countReplace);
        }
    }
}