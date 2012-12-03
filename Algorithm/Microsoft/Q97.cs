
namespace Algorithm.Microsoft
{
    class Q97
    {
        //97.1
        //reverseStr

        //97.2
        //two pointer

        //97.3
        //same as 97.1

        //97.4
        /*
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Microsoft.Q97.shuffle(cards);
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }
         */
        public static void shuffle(int[] cards)
        {
            int length = cards.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                int rd = new System.Random().Next(i);
                swap(cards, i, rd);
            }
        }

        private static void swap(int[] cards, int i, int j)
        {
            int temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }


        //97.5
    }
}
