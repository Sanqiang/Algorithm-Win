
namespace Algorithm.StackAndQueue
{
    class CCN3_7
    {
        public class Animal
        {
            public int Order;

            public bool isBefore(Animal a)
            {
                return this.Order < a.Order;
            }
        }

        public class Dog : Animal
        {

        }

        public class Cat : Animal
        {

        }

        public class AnimalQuene
        {
            public System.Collections.Generic.Queue<Dog> dogs = new System.Collections.Generic.Queue<Dog>();
            public System.Collections.Generic.Queue<Cat> cats = new System.Collections.Generic.Queue<Cat>();
            public int Order = 0;

            public void Enquene(Animal a)
            {
                a.Order = Order++;
                if (a is Dog)
                {
                    dogs.Enqueue((Dog)a);
                }
                else if (a is Cat)
                {
                    cats.Enqueue((Cat)a);
                }
            }

            public Animal dequeneAny()
            {
                if (cats.Count == 0 && dogs.Count ==0)
                {
                    return null;
                }
                else if (cats.Count==0)
                {
                    return dogs.Dequeue();
                }
                else if (dogs.Count ==0)
                {
                    return cats.Dequeue();
                }

                Dog d = dogs.Peek();
                Cat c = cats.Peek();
                if (d.isBefore(d))
                {
                    return dogs.Dequeue();
                }
                else
                {
                    return cats.Dequeue();
                }
            }
        }
    }
}
