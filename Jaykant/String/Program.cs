namespace String;

class Program
{
    static void Main()
    {
        Console.Write("Enter digit string: ");
        string num = Console.ReadLine();

        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());

        List<string> results = GenerateExpressions(num, target);

        if (results.Count == 0)
        {
            Console.WriteLine("No valid result found.");
        }
        else
        {
            Console.WriteLine("Valid expressions:");
            foreach (string expr in results)
            {
                Console.WriteLine(expr);
            }
        }

        Console.ReadLine();
    }

    static List<string> GenerateExpressions(string num, int target)
    {
        int n = num.Length;

        List<string> expressions = new List<string>();
        List<long> values = new List<long>();
        List<long> lastOperands = new List<long>();

      
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && num[0] == '0') break;

            string part = num.Substring(0, i + 1);
            long value = long.Parse(part);

            expressions.Add(part);
            values.Add(value);
            lastOperands.Add(value);
        }

     
        for (int pos = 1; pos < n; pos++)
        {
            List<string> nextExpressions = new List<string>();
            List<long> nextValues = new List<long>();
            List<long> nextLastOperands = new List<long>();

            for (int i = 0; i < expressions.Count; i++)
            {
                for (int j = pos; j < n; j++)
                {
                    if (j > pos && num[pos] == '0') break;

                    string part = num.Substring(pos, j - pos + 1);
                    long value = long.Parse(part);

            
                    nextExpressions.Add(expressions[i] + "+" + part);
                    nextValues.Add(values[i] + value);
                    nextLastOperands.Add(value);

            
                    nextExpressions.Add(expressions[i] + "-" + part);
                    nextValues.Add(values[i] - value);
                    nextLastOperands.Add(-value);

                 
                    long mulValue = values[i] - lastOperands[i] + lastOperands[i] * value;
                    nextExpressions.Add(expressions[i] + "*" + part);
                    nextValues.Add(mulValue);
                    nextLastOperands.Add(lastOperands[i] * value);
                }
            }

            expressions = nextExpressions;
            values = nextValues;
            lastOperands = nextLastOperands;
        }

        List<string> result = new List<string>();
        for (int i = 0; i < expressions.Count; i++)
        {
            if (values[i] == target)
                result.Add(expressions[i]);
        }

        return result;
    }
}

