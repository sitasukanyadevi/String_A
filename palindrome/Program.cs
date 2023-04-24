string[] words = {"Madam", "Kolkata", "Chennai", "Delhi", "Level", "Noon"};
int palindromeCount = 0;
string palindromeWords = "";
foreach (string word in words) {
            char[] chars = word.ToLower().ToCharArray();
            Array.Reverse(chars);
            string reversedWord = new string(chars);
            if (reversedWord.Equals(word.ToLower(), StringComparison.OrdinalIgnoreCase)) {
                palindromeCount++;
                if (palindromeWords == "") {
                    palindromeWords += word;
                } else {
                    palindromeWords += ", " + word;
                }
            }
        }
Console.WriteLine("Total palindrome count: " + palindromeCount);
Console.WriteLine("Palindrome words: " + palindromeWords);
