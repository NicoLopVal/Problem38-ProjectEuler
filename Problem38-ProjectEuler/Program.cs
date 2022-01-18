List<string> pandigitals = new();

double maxPandigital = 0;

int counter = 1;

while (counter <= 9999)
{
    int totalDigits = 0;
    int multiplier = 1;
    bool matchDigits = false;
    bool isPandigital = true;
    string builtValue = "";

    while (true)
    {
        string currentProduct = (counter * multiplier).ToString();
        totalDigits += currentProduct.Length;
        if (totalDigits > 9 || currentProduct.Contains("0"))
        {
            matchDigits = false;
            break;
        }
        builtValue = builtValue + currentProduct;
        if (totalDigits == 9)
        {
            matchDigits = true;
            break;
        }
        multiplier++;
    }
    if (matchDigits)
    {
        for(int i = 0; i < builtValue.Length; i++)
        {
            for (int j = 0; j < builtValue.Length; j++)
            {
                if (i == j)
                    continue;
                if (builtValue[i] == builtValue[j])
                {
                    isPandigital = false;
                    break;
                }
            }
            if (!isPandigital)
                break;
        }
        if (isPandigital)
        {
            pandigitals.Add(builtValue);
            if(Convert.ToDouble(builtValue) > maxPandigital)
                maxPandigital=Convert.ToDouble(builtValue);
        }
    }
    counter++;
}

Console.WriteLine("the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with (1,2, ... , n) where n > 1 is: " + maxPandigital);