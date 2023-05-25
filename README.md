# C-Coding-Challenge
Certainly! Here's the README file for the OldPhonePadConverter class in C#:

## OldPhonePadConverter

The OldPhonePadConverter class provides a method to convert input strings into the correct output based on an old phone keypad. It supports cycling through letters on buttons and pausing for a second when the same button is pressed consecutively. The converted output includes the send key "#" at the end.

### Usage

1. Create an instance of the OldPhonePadConverter class:
   
   OldPhonePadConverter converter = new OldPhonePadConverter();
   

2. Call the `ConvertInput` method and pass the input string to be converted:
   
   string outputString = converter.ConvertInput(inputString);
   

3. The `ConvertInput` method will return the converted output string based on the old phone keypad.

### Example


OldPhonePadConverter converter = new OldPhonePadConverter();
string inputString = "222 2 22#";
string outputString = converter.ConvertInput(inputString);
Console.WriteLine(outputString);  // Output: CAB#


### Test Cases

The OldPhonePadConverter class includes several test cases to verify its functionality. You can run the tests by calling the `RunTests` method:


OldPhonePadConverter converter = new OldPhonePadConverter();
converter.RunTests();


The test cases cover various scenarios, including single button presses, multiple button presses with pauses, no button presses, and button presses with pauses at the end. Each test case compares the expected output with the actual output and prints `True` if they match.
