namespace ccwc;

class Program
{
    static void Main(string[] args)
    {

        // Step 1
        string flag = args[0];
        string fileName = args[1];
        
        if (flag == "-c")
        {
            byte[] bytes = File.ReadAllBytes(fileName);
            Console.WriteLine($"{bytes.Length} {fileName}");
        }

        // Step 2
        if (flag == "-l")
        {
            string[] lines = File.ReadAllLines(fileName);
            Console.WriteLine($"{lines.Length} {fileName}");
        }
    }
}
