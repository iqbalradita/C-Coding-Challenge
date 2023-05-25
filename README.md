# C-Coding-Challenge
public static string OldPhonePad(string input)
{
    Dictionary<char, int> buttonMappings = new Dictionary<char, int>()
    {
        {'A', 2}, {'B', 2}, {'C', 2},
        {'D', 3}, {'E', 3}, {'F', 3},
        {'G', 4}, {'H', 4}, {'I', 4},
        {'J', 5}, {'K', 5}, {'L', 5},
        {'M', 6}, {'N', 6}, {'O', 6},
        {'P', 7}, {'Q', 7}, {'R', 7}, {'S', 7},
        {'T', 8}, {'U', 8}, {'V', 8},
        {'W', 9}, {'X', 9}, {'Y', 9}, {'Z', 9}
    };

    StringBuilder output = new StringBuilder();
    char previousChar = ' ';

    foreach (char c in input)
    {
        if (c == '#')
        {
            break;
        }
        else if (char.IsDigit(c))
        {
            int buttonNumber = int.Parse(c.ToString());
            int numberOfPresses = 1;

            // Count the number of consecutive presses for the same button
            while (input.IndexOf(c, input.IndexOf(c) + numberOfPresses) == input.IndexOf(c) + numberOfPresses)
            {
                numberOfPresses++;
            }

            int letterIndex = (numberOfPresses - 1) % 3;
            char currentChar = buttonMappings.ElementAt(buttonNumber - 1).Key;

            if (currentChar == previousChar)
            {
                output.Append(' ');
                output.Append(currentChar);
            }
            else
            {
                output.Append(currentChar);
            }

            previousChar = currentChar;
        }
    }

    return output.ToString();
}
