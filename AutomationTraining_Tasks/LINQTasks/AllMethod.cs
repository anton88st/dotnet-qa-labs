using LINQTasks_answers.Collections;
using System.Threading.Channels;

namespace LINQTasks
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

            bool result = default; //...write your code instead of 'default'...

            return result;
        }

        private bool HaveAllObjectsTheSameCarType(List<Car> cars)
        {
            // Return a boolean result -> if all cars in the collection have the same car type.

            bool result = default; //...write your code instead of 'default'...

            return result;
        }

        private bool AreAllWordsValidRefactored(List<string> words)
        {
            // Refactor the method IsAllWordsAreValid() by applying LINQ methods.

            bool result = default; //...write your code instead of 'default'...

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
            Assert.IsFalse(AreAllNumbersEven(IntegersCollections.NumbersWithPositive));
        }

        [Test]
        public void AllNumbersAreEven()
        {
            Assert.IsTrue(AreAllNumbersEven(IntegersCollections.EvenNumbers));
        }

        [Test]
        public void AllObjectsWithTheSameCarType()
        {
            Assert.IsTrue(HaveAllObjectsTheSameCarType(CarsCollections.CarsWithTheSameCarType));
        }

        [Test]
        public void NotAllObjectsWithTheSameCarType()
        {
            Assert.IsFalse(HaveAllObjectsTheSameCarType(CarsCollections.CarsWithDifferentCarTypes));
        }

        [Test]
        public void AreAllWordsValid()
        {
            Assert.IsTrue(AreAllWordsValid(StringsCollections.ValidWords));
        }

        [Test]
        public void NotAllWordsAreValid()
        {
            Assert.IsFalse(AreAllWordsValid(StringsCollections.Words));
        }

        [Test]
        public void AreAllWordsValidRefactored()
        {
            Assert.IsTrue(AreAllWordsValidRefactored(StringsCollections.ValidWords));
        }

        [Test]
        public void NotAllWordsAreValidRefactored()
        {
            Assert.IsFalse(AreAllWordsValidRefactored(StringsCollections.Words));
        }
    }
}