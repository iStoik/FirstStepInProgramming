string? inputLkneOne = Console.ReadLine();

if(inputLkneOne != null)
{

    int inputNumber = int.Parse(inputLkneOne);

    int startNumber = 1;

    string lineOutput = "0";

    while (startNumber <= inputNumber)
    {
        lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
        startNumber++;
    }

    //lineOutput=lineOutput+inputNumber;

   Console.WriteLine(lineOutput);
}