using System;
class Program{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
    static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.Write("Enter half DNA sequence: ");
            string halfdna = Console.ReadLine();

            if (IsValidSequence(halfdna))
            {
                Console.WriteLine("Current half DNA sequence: " + halfdna);

                Console.Write("Do you want to replicate it? (Y/N): ");
                string replicateChoice = Console.ReadLine();

                if (replicateChoice.ToUpper() == "Y")
                {
                    string replicatedSequence = ReplicateSequence(halfdna);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                } 
                else if (replicateChoice.ToUpper() == "N"){
                } else {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            } else {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            string continueChoice = Console.ReadLine();

            if (continueChoice.ToUpper() == "Y"){
                continueProgram = true;
            
            } else if (continueChoice.ToUpper() == "N"){
                continueProgram = false;
            } else {
                Console.WriteLine("Please input Y or N.");
                continue;
            }
        }
    }
}