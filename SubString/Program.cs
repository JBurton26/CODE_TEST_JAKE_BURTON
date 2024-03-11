using TextProcessing.SubStringProcessor;
namespace main;
class Program
{
    static void Main(string[] args)
    {
        //Get String
        Console.WriteLine("Enter a string: ");
        string fullString = Console.ReadLine();

        //Get Substring to search for
        Console.WriteLine("Enter a substring to find: ");
        string subString = Console.ReadLine();
        
        //Create SubStringProcessor
        SubStringProcessor subStringProcessor = new SubStringProcessor(fullString, subString);

        if (subStringProcessor.Positions.Count == 0)
        {
            Console.WriteLine("<no matches>");
        }
        else
        {
            Console.Write("SubStrings Found At Positions: ");
            subStringProcessor.Positions.ForEach(position => Console.Write(position + " "));
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}