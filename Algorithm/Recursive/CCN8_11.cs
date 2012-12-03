/*
            Console.WriteLine(Recursive.CCN8_11.getWays("0|0^1|1|0&1", true));
            Console.WriteLine(Recursive.CCN8_11.getWaysWithMathmetic("0|0^1|1|0&1", true));
 */
namespace Algorithm.Recursive
{
    class CCN8_11
    {
        public static int getWays(string exp, bool result, int s = 0, int e = -1, System.Collections.Generic.Dictionary<string, int> cache = null)
        {
            if (e == -1)
            {
                e = exp.Length - 1;
            }
            string key = s + result.ToString() + e;
            if (cache == null)
            {
                cache = new System.Collections.Generic.Dictionary<string, int>();
            }
            else
            {
                if (cache.ContainsKey(key))
                {
                    return cache[key];
                }
            }

            if (s == e)
            {
                char op = exp[s];
                if (op == '1' && result)
                {
                    return 1;
                }
                else if (op == '0' && (!result))
                {
                    return 1;
                }
                return 0;
            }
            int c = 0;
            if (result)
            {
                for (int i = s + 1; i <= e; i += 2)
                {
                    char op = exp[i];
                    switch (op)
                    {
                        case '|':
                            c += getWays(exp, true, s, i - 1, cache) * getWays(exp, true, i + 1, e, cache);
                            c += getWays(exp, true, s, i - 1, cache) * getWays(exp, false, i + 1, e, cache);
                            c += getWays(exp, false, s, i - 1, cache) * getWays(exp, true, i + 1, e, cache);
                            break;
                        case '&':
                            c += getWays(exp, true, s, i - 1, cache) * getWays(exp, true, i + 1, e, cache);
                            break;
                        case '^':
                            c += getWays(exp, true, s, i - 1, cache) * getWays(exp, false, i + 1, e, cache);
                            c += getWays(exp, false, s, i - 1, cache) * getWays(exp, true, i + 1, e, cache);
                            break;
                    }
                }
            }
            else
            {
                for (int i = s + 1; i <= e; i += 2)
                {
                    char op = exp[i];
                    switch (op)
                    {
                        case '|':
                            c += getWays(exp, false, s, i - 1, cache) * getWays(exp, false, i + 1, e, cache);
                            break;
                        case '&':
                            c += getWays(exp, false, s, i - 1, cache) * getWays(exp, false, i + 1, e, cache);
                            c += getWays(exp, true, s, i - 1, cache) * getWays(exp, false, i + 1, e, cache);
                            c += getWays(exp, false, s, i - 1, cache) * getWays(exp, true, i + 1, e, cache);
                            break;
                        case '^':
                            c += getWays(exp, true, s, i - 1, cache) * getWays(exp, true, i + 1, e, cache);
                            c += getWays(exp, false, s, i - 1, cache) * getWays(exp, false, i + 1, e, cache);
                            break;
                    }
                }
            }
            cache.Add(key, c);
            return c;
        }


        public static int getWaysWithMathmetic(string exp, bool result, int s = 0, int e = -1, System.Collections.Generic.Dictionary<string, int> cache = null)
        {
            if (e == -1)
            {
                e = exp.Length - 1;
            }


            string key = s + "|" + e;
            int c = 0;
            if (cache == null)
            {
                cache = new System.Collections.Generic.Dictionary<string, int>();
            }

            if (cache.ContainsKey(key))
            {
                c = cache[key];
            }
            else
            {
                if (s == e)
                {
                    if (exp[s] == '1')
                    {
                        c = 1;
                    }
                    else
                    {
                        c = 0;
                    }
                }
                for (int i = s + 1; i <= e; i += 2)
                {
                    char op = exp[i];
                    switch (op)
                    {
                        case '|':
                            int left_ops = ((i - 1) - s) / 2;
                            int right_ops = (e - (i + 1)) / 2;
                            int total = getCount(left_ops) * getCount(right_ops);
                            int total_false = getWaysWithMathmetic(exp, false, s, i - 1, cache) * getWaysWithMathmetic(exp, false, i + 1, e, cache);
                            c += total - total_false;
                            break;
                        case '&':
                            c += getWaysWithMathmetic(exp, true, s, i - 1, cache) * getWaysWithMathmetic(exp, true, i + 1, e, cache);
                            break;
                        case '^':
                            c += getWaysWithMathmetic(exp, true, s, i - 1, cache) * getWaysWithMathmetic(exp, false, i + 1, e, cache);
                            c += getWaysWithMathmetic(exp, false, s, i - 1, cache) * getWaysWithMathmetic(exp, true, i + 1, e, cache);
                            break;
                    }
                }
                cache.Add(key, c);
            }

            if (result)
            {
                return c;
            }
            else
            {
                int num_ops = (e - s) / 2;
                return getCount(num_ops) - c;
            }
        }

        private static int getCount(int n)
        {
            long num = 1;
            long rem = 1;
            for (int i = 2; i <= n; i++)
            {
                num *= (n + i);
                rem *= i;
                if (num % rem == 0)
                {
                    num /= rem;
                    rem = 1;
                }
            }
            return (int)num;
        }
    }
}
