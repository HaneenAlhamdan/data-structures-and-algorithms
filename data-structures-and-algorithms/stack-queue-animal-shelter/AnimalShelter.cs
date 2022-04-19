using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.stack_queue_animal_shelter
{
    public class AnimalShelter
    {
        public Queue<Cat> CatsQueue = new Queue<Cat>();
        public Queue<Dog> DogsQueue = new Queue<Dog>();

        public void enqueue(Animal animal)
        {
          
            if (animal is Cat)
            {
                Cat cat = new Cat();
                CatsQueue.Enqueue(cat);
            }
            else if (animal is Dog)
            {
                Dog dog = new Dog();
                DogsQueue.Enqueue(dog);
            }
        }

        public Animal dequeue(string pref)
        {
            if (pref == "cat")
            {
                return CatsQueue.Dequeue();

            }
            else if (pref == "dog")
            {
                return DogsQueue.Dequeue();
            }
            return null;
        }
    }
}