public static string OldPhonePad(string input)
{
    string output = "";
    int buttonPressCount = 0;
    char previousChar = '\0';
    
    foreach (char c in input)
    {
        if (char.IsDigit(c))
        {
            int buttonNumber = int.Parse(c.ToString());
            char currentChar = GetCharFromButtonPress(buttonNumber, buttonPressCount);
            
            if (currentChar == previousChar)
            {
                
                output += " "
            }
            
            output += currentChar;
            previousChar = currentChar;
            buttonPressCount = 0;
        }
        else if (c == '#')
        {
            
            break;
        }
        else if (c == '<')
        {
            
            if (output.Length > 0)
            {
                output = output.Substring(0, output.Length - 1);
                if (output.Length > 0)
                {
                    previousChar = output[output.Length - 1];
                }
                else
                {
                    previousChar = '\0';
                }
            }
        }
        else
        {
            
        }
    }
    
    return output;
}

private static char GetCharFromButtonPress(int buttonNumber, int buttonPressCount)
{
    char[][] buttonMappings = new char[][]
    {
        new char[] { ' ' },                  
        new char[] { '\0' },                 
        new char[] { 'A', 'B', 'C' },        
        new char[] { 'D', 'E', 'F' },        
        new char[] { 'G', 'H', 'I' },        
        new char[] { 'J', 'K', 'L' },        
        new char[] { 'M', 'N', 'O' },        
        new char[] { 'P', 'Q', 'R', 'S' },   
        new char[] { 'T', 'U', 'V' },        
        new char[] { 'W', 'X', 'Y', 'Z' }    
    };
    
    int index = (buttonPressCount - 1) % buttonMappings[buttonNumber].Length;
    return buttonMappings[buttonNumber][index];
}
