namespace ccwc;

class Program
{
    static void Main(string[] args)
    {

        // Step 1
        string flag = args.Length > 1 ? args[0] : "";
        string fileName = args.Length > 1 ? args[1] : args[0];
        string[] lines = File.ReadAllLines(fileName);
        byte[] bytes = File.ReadAllBytes(fileName);
        string text = File.ReadAllText(fileName);
        string[] words = text.Split(new char[] {' ', '\n', '\r', '\t'}, StringSplitOptions.RemoveEmptyEntries);
        string chars = File.ReadAllText(fileName);
        
        if (flag == "-c")
        {
            Console.WriteLine($"{bytes.Length} {fileName}");
        }

        // Step 2
        if (flag == "-l")
        {
            Console.WriteLine($"{lines.Length} {fileName}");
        }

        // Step 3
        if (flag == "-w")
        {
            Console.WriteLine($"{words.Length} {fileName}");
        }

        // Step 4
        if (flag == "-m")
        {
            Console.WriteLine($"{chars.Length} {fileName}");
        }

        // Step 5
        if(flag == "")
        {
            Console.WriteLine($"{lines.Length} {words.Length} {chars.Length} {fileName}");
        }

        // Step 6
        if (args.Length == 0)
        {
            using StreamReader reader = new StreamReader(Console.OpenStandardInput());
            string stdinText = reader.ReadToEnd();

            long byteCount = System.Text.Encoding.UTF8.GetByteCount(stdinText);
            long lineCount = stdinText.Split('\n').Length - 1;
            string[] stdinWords = stdinText.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (flag == "-l") Console.WriteLine($"{lineCount}");
            if (flag == "-c") Console.WriteLine($"{byteCount}");
            if (flag == "-w") Console.WriteLine($"{stdinWords.Length}");
            if (flag == "-m") Console.WriteLine($"{stdinText.Length}");
        }
    }
}
