/*
             Recursive.BackSack.Stuff[] items = { new Recursive.BackSack.Stuff(3, 4), new Recursive.BackSack.Stuff(4, 5), new Recursive.BackSack.Stuff(5, 6) };
            int result = Recursive.BackSack.OptimizeValueOneZero(items, 10);
            Console.WriteLine(result);
            Recursive.BackSack.Stuff[] items2 = { new Recursive.BackSack.Stuff(4, 4500), new Recursive.BackSack.Stuff(5, 5700), new Recursive.BackSack.Stuff(2, 2250), new Recursive.BackSack.Stuff(1, 1100), new Recursive.BackSack.Stuff(6, 6700) };
            int result2 = Recursive.BackSack.OptimizeValueDuplicate(items2, 8);
            Console.WriteLine(result2);
 */ 
namespace Algorithm.Recursive
{
    class BackSack
    {
        public class Stuff
        {
            public int Value;
            public int Weight;
            public Stuff() { }
            public Stuff(int weight, int value)
            {
                this.Value = value;
                this.Weight = weight;
            }
        }

        public static int OptimizeValueOneZero(Stuff[] items, int volumn)
        {
            int length = items.Length, i, j;
            int[,] cache = new int[length + 1, volumn + 1];
            for (i = 1; i <= length; i++)
            {
                for (j = 1; j <= volumn; j++)
                {
                    int old_value = cache[i - 1, j];

                    if (j >= items[i - 1].Weight)
                    {
                        int new_value = items[i - 1].Value;
                        if (i - 2 >= 0 && j - items[i - 2].Value >= 0)
                        {
                            new_value += cache[i - 1, j - items[i - 2].Value];
                        }
                        cache[i, j] = new_value > old_value ? new_value : old_value;
                    }
                    else
                    {
                        cache[i, j] = old_value;
                    }
                }
            }
            return cache[length, volumn];
        }

        public static int OptimizeValueDuplicate(Stuff[] items, int volumn)
        {
            int length = items.Length, i, j;
            int[] cache = new int[volumn];

            for (i = 0; i < length; i++)
            {
                for (j = items[i].Weight; j < volumn; j++)
                {
                    int old_value = cache[j];
                    int new_value = items[i].Value;
                    if (j - items[i].Weight>=0)
                    {
                        new_value += cache[j - items[i].Weight];
                    }
                    cache[j] = new_value > old_value ? new_value : old_value;
                }
            }
            return cache[volumn - 1];
        }
    }
}
