using System;
public class NumberToWords
{
    private string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    private string[] tens ={ "", "", "Twenty", "Thirty", "Forty",  "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        public string Convert(int num)
        {
            if (num == 0)
                return "Zero";

            string result = "";

            if (num >= 1000000)
            {
                int millionPart = num / 1000000;
                result += ConvertBelowThousand(millionPart) + " Million ";
                num %= 1000000;
            }

            if (num >= 1000)
            {
                int thousandPart = num / 1000;
                result += ConvertBelowThousand(thousandPart) + " Thousand ";
                num %= 1000;
            }

            if (num > 0)
            {
                result += ConvertBelowThousand(num);
            }

            return result.Trim();
        }
        private string ConvertBelowThousand(int num)
        {
            string words = "";

            if (num >= 100)
            {
                words += ones[num / 100] + " Hundred ";
                num %= 100;
            }

            if (num >= 20)
            {
                words += tens[num / 10] + " ";
                num %= 10;
            }

            if (num > 0)
            {
                words += ones[num] + " ";
            }

            return words.Trim();
        }
    }
