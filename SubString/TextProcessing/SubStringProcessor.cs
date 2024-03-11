namespace TextProcessing.SubStringProcessor
{
    // SubString Processor Class for Processing the Presence of Substrings within a larger String
    public class SubStringProcessor
    {
        // Getter/Setter for list of indexes
        public List<int> Positions { get; set; }

        //C onstructor
        public SubStringProcessor(string fullString, string subString)
        {
            Positions = GetSubStringPositions(fullString, subString);
        }

        // Primary Functional Method
        public static List<int> GetSubStringPositions(string fullString, string subString)
        {
            // Initialise Empty List of Indexes substrings start at
            List<int> positions = new List<int>();

            for (int i = 0; i < fullString.Length - subString.Length + 1; i++)
            {
                bool[] matches = new bool[subString.Length];

                for (int j = 0; j < subString.Length; j++)
                {
                    // Convert String to Character
                    char str_char = fullString[i + j];
                    char substr_char = subString[j];

                    // Normalise values based on ASCII integer values
                    if (str_char == substr_char || str_char - 32 == substr_char || str_char == substr_char - 32)
                    {
                        matches[j] = true;
                    }
                }

                // Check full substring exists through match array
                bool match = matches.All(x => x == true);
                if (match)
                {
                    // Add Position(+1) to List
                    positions.Add(i + 1);
                    matches = new bool[subString.Length];
                    //Skip rest of substring
                    i += subString.Length;
                }
            }

            return positions;
        }

        //Can Expand Functionality in class
    }
}
