string[] words = {"Delhi", "Mumbai", "Chennai", "Kolkata", "Bangalore"};

        Console.Write("Enter a word to search: ");
        string searchWord = Console.ReadLine();

        bool found = false;
        foreach (string word in words) {
            if (word.Equals(searchWord, StringComparison.OrdinalIgnoreCase)) {
                found = true;
                break;
            }
        }

        if (found) {
            Console.WriteLine("The word is present in the list.");
        } else {
            Console.WriteLine("The word is not present in the list.");
            }
