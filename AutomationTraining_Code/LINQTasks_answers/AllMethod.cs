using LINQTasks_answers.Collections;
using LINQTasks_answers.Collections.ObjectsCollections;

namespace LINQTasks_answers
{
    public class AllMethod
    {
        /*
         * Documentation: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=net-8.0
         * There are two parts in the class: 
         * - Methods;
         * - Tests (DO NOT MAKE ANY CHANGES);
         * In methods you should write code with the help of LINQ methods from the documentation. Tasks are written in methods.
         */

        private bool AreAllNumbersEven(List<int> numbers)
        {
            // Return a boolean result -> if all numbers in the collection are even
            var result = numbers.All(number => number % 2 == 0);

            return result;
        }

        private bool HaveAllObjectsTheSameCarType(List<Car> cars)
        {
            // Return a boolean result -> if all cars in the collection have the same car type.
            var result = cars.All(car => car.CarType == cars.First().CarType);

            return result;
        }

        private bool AreAllWordsValidRefactored(List<string> words)
        {
            // Refactor the method IsAllWordsAreValid() by applying LINQ methods.
            var result = words.All(word => char.IsUpper(word[0]) && word.Length > 3 && word.Length < 8);

            return result;
        }

        private bool AreAllWordsValid(List<string> words)
        {
            foreach (var word in words)
            {
                if (string.IsNullOrEmpty(word))
                {
                    return false;
                }
                if (char.IsLower(word[0]))
                {
                    return false;
                }
                if (word.Length < 3)
                {
                    return false;
                }
                if (word.Length > 8)
                {
                    return false;
                }
            }
            return true;
        }

        [Test]
        public void NotAllNumbersAreEven()
        {
            Assert.That(AreAllNumbersEven(IntegersCollections.numbersWithPositive), Is.False);
        }

        [Test]
        public void AllNumbersAreEven()
        {
            Assert.That(AreAllNumbersEven(IntegersCollections.evenNumbers), Is.True);
        }

        [Test]
        public void AllObjectsWithTheSameCarType()
        {
            Assert.That(HaveAllObjectsTheSameCarType(CarsCollections.CarsWithTheSameCarType), Is.True);
        }

        [Test]
        public void NotAllObjectsWithTheSameCarType()
        {
            Assert.That(HaveAllObjectsTheSameCarType(CarsCollections.CarsWithDifferentCarTypes), Is.False);
        }

        [Test]
        public void AreAllWordsValid()
        {
            Assert.That(AreAllWordsValid(StringsCollections.ValidWords), Is.True);
        }

        [Test]
        public void NotAllWordsAreValid()
        {
            Assert.That(AreAllWordsValid(StringsCollections.Words), Is.False);
        }

        [Test]
        public void AreAllWordsValidRefactored()
        {
            Assert.That(AreAllWordsValidRefactored(StringsCollections.ValidWords), Is.True);
        }

        [Test]
        public void NotAllWordsAreValidRefactored()
        {
            Assert.That(AreAllWordsValidRefactored(StringsCollections.Words), Is.False);
        }
    }
}