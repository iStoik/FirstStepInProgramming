// string? inputLine = Console.ReadLine();

// if(inputLine != null)
// {
//    int inputNumber = int.Parse(inputLine);

//    //int outNumber = inputNumber*inputNumber;
//    int outNumber = (int)Math.Pow(inputNumber,2);

//    Console.WriteLine(outNumber);
// }

String? InputNum = Console.ReadLine();

if(InputNum != null)
{
    int StartNum = 2;
    string LineOutput = "";

    while(StartNum <= (int.Parse(InputNum)))
    {       
        LineOutput = LineOutput + StartNum + ", ";        
        StartNum+=2;
    }
    Console.WriteLine(LineOutput.Remove(LineOutput.Length - 2));
}