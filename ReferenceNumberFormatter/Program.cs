public class Program
{
    private static void Main(string[] args)
    {

        //Please implement in C# the function that
        //increments a string based on the rules below.
        //It should take the string of unknown length and increment the numeric ending of that string by 1.
        //If numeric ending is overflown it must be reset.
        //Don’t use regular expressions.


        //Function signature:
        //void Increment(char[] referenceNumber)


        //Examples:

        //000002-> 000003
        //999999-> 000000
        //999899-> 999900
        //GL - 321->GL - 322
        //GL - 999->GL - 000
        //DRI000EDERS0RE->DRI000EDERS0RE
        //DRI000EDERS0RE99999->
        //DRI000EDERS0RE00000


        char[] referenceNumber = "GL-999".ToCharArray();
        Increment(referenceNumber);
        Console.WriteLine($"GL-999 > {0}", new string(referenceNumber));

    }

    public static void Increment(char[] referenceNumber)
    {
        for (int i = referenceNumber.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(referenceNumber[i]))
            {
                if (referenceNumber[i] < '9')
                {
                    referenceNumber[i]++;
                    return;
                }
                else
                {
                    referenceNumber[i] = '0';
                }
            }
            else
            {
                break;
            }
        }
    }


}