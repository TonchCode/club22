namespace FileReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {   // homework: Write a program that reads from console and writes to a file,
            // and for every ' ' it makes a new line in the text file

            FileStream fs = new FileStream("temp.txt", FileMode.OpenOrCreate);
            StreamWriter sr = new StreamWriter(fs);
              
            sr.WriteLine(Console.ReadLine());

            sr.Close();
            fs.Close();
        }
    }
}