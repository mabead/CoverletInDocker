using System;

namespace SomeProject
{
    public enum TimeOfDay
    {
        Morning,
        Evening,
        Night,
    }
    public static class SomeClass
    {
        public static void Hello(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good morning");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good evening");
                    break;
                case TimeOfDay.Night:
                    Console.WriteLine("Good night");
                    break;
            }

        }
    }
}
