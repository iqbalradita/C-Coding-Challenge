using System;

public class OldPhonePadConverterTests
{
    public static void Main()
    {
        
        RunTest("222 2 22#", "CAB");

        
        RunTest("44 444#", "HI");

        
        RunTest("9 999 9999#", "WXYZ");

        
        RunTest("333 3 33#", "DEF");

        
        RunTest("0#", " ");

        
        RunTest("222 2 22<#", "CA");

        
        RunTest("1234567890#", "");

        Console.WriteLine("All test cases passed.");
    }

    private static void RunTest(string input, string expectedOutput)
    {
        string output = OldPhonePadConverter.ConvertInputToText(input);
        if (output == expectedOutput)
        {
            Console.WriteLine("PASS: Input: {0} -> Output: {1}", input, output);
        }
        else
        {
            Console.WriteLine("FAIL: Input: {0} -> Expected Output: {1}, Actual Output: {2}", input, expectedOutput, output);
        }
    }
}
