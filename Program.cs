Console.WriteLine("Elias Gamma-code Bits Length (c) 2023 by zara6502");
if (args.Length > 0)
{
    int i = 0, ii = 0;
    for (int j = 0; j < args.Length; j++)
    {
        bool success = false;
        int minuspos = args[j].IndexOf("-", 0);
        if (minuspos > 0)
        {
            int lenfirst = minuspos;
            int lensecond = args[j].Length - minuspos - 1;
            if (lenfirst <= lensecond)
            {
                success = int.TryParse(args[j].Substring(0, lenfirst), out i) && int.TryParse(args[j].Substring(minuspos + 1, lensecond), out ii) && (i <= ii);
            }
        }
        else
        {
            success = int.TryParse(args[j], out i);
            ii = i;
        }
        if (success && (i > 0))
        {
            for(; i <= ii; i++)
            {
                int count = 0;
                for (int n = 2; n <= i; n <<= 1) count += 2;
                Console.WriteLine("{0} = {1} bits", i, ++count);
            }
        }
        else
            Console.WriteLine("{0} = wrong input", args[j]);
    }
    return;
}
Console.WriteLine("Usage: elias [n1] [n2-n3] ... [nX] - space separated numbers or intervals");

/*int bitsElias(int n)
{
    int count = 0;
    for (int i = 2; i <= n; i <<= 1) count += 2;
    return ++count;
}*/
