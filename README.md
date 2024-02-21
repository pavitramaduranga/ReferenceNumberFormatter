# ReferenceNumberFormatter

The project contains a Console app and a test project.
</br></br>
<img width="257" alt="image" src="https://github.com/pavitramaduranga/ReferenceNumberFormatter/assets/4363523/e0103b0d-bcb9-438a-b94c-7336f845d289">

The test project contains test cases for the provided examples
</br></br>
<img width="362" alt="image" src="https://github.com/pavitramaduranga/ReferenceNumberFormatter/assets/4363523/ff4a73aa-5dd8-4396-94fa-fbce8f1f52aa">

# Logic for the Number Formatter

````
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
````
