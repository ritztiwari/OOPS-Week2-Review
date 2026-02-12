using System;

internal class Frequency
{
    internal static int[] run(int[] num)
    {
        int count = 0;
        int[] fr = new int[10];

        for (int i = 0; i < num.Length; i++)
        {
            fr[num[i]]++;
        }


        int[] fr1 = new int[fr.Length];
        for (int s = 0; s < fr.Length; s++)
        {
            fr1[s] = fr[s];
        }

        Array.Sort(fr);

        int[] res = new int[num.Length];

        for (int j = fr.Length - 1; j >= 0; j--)
        {
            int l = fr[j]; 

            if (l == 0) continue; 

            for (int k = 0; k < fr1.Length; k++)
            {
                if (fr1[k] == l)
                {
                    for (int m = 0; m < l; m++)
                    {
                        res[count] = k;
                        count++;
                    }

                    fr1[k] = -1;
                    break;
                }
            }
        }

        return res;
    }
}

