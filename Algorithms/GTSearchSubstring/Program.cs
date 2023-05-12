static string LongestSubstringWithoutRepeatingCharacters(string s)
    {
        string longestSubstring = "";
        string currentSubstring = "";

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            // Se il carattere è già presente nella sottostringa corrente,
            // allora la sottostringa corrente diventa la sottostringa a partire
            // dal carattere successivo alla prima occorrenza del carattere ripetuto.
            if (currentSubstring.Contains(c))
            {
                int index = currentSubstring.IndexOf(c);
                currentSubstring = currentSubstring.Substring(index + 1);
            }

            // Aggiungiamo il carattere corrente alla sottostringa corrente.
            currentSubstring += c;

            // Se la sottostringa corrente è più lunga della sottostringa più lunga finora trovata,
            // allora aggiorniamo la sottostringa più lunga trovata.
            if (currentSubstring.Length > longestSubstring.Length)
            {
                longestSubstring = currentSubstring;
            }
        }

        return longestSubstring;
    }

string inputString = "abcbbabcabaaa";
string subString = LongestSubstringWithoutRepeatingCharacters(inputString);

Console.WriteLine($"Initial String: {inputString}");
Console.WriteLine($"Substring: {subString}");