namespace Mammals 
{
    public abstract class Animal {
        public abstract void MakeSound();
        public abstract void GoPlay();
        public virtual void Walk() {

            var classType = this.GetType().Name;
            var output = $"The {classType} walks down the street.";

            Console.WriteLine(output);
        } 
    }

    public class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Bark Bark");
        }
        public override void GoPlay() {
            GoFetch();
        }
        private void GoFetch() {
            Console.WriteLine("Dog runs and grabs the ball.");
        }
    }

    public class Cat : Animal {
        public override void MakeSound() {
            Console.WriteLine("Meow Meow");
        }
        public override void GoPlay() {
            Console.WriteLine("Cat yawns and stretches.");
        }
    }
}