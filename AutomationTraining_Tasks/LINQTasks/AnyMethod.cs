using LINQTasks_answers.Collections;

namespace LINQTasks
{
    public class AnyMethod
    {
        /*
         * Documentation: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any?view=net-8.0
         * There are two parts in the class: 
         * - Methods;
         * - Tests (DO NOT MAKE ANY CHANGES);
         * In methods you should write code with the help of LINQ methods from the documentation. Tasks are written in methods.
         */

        private bool IsAnyPositiveNumberExist(List<int> numbers)
        {
            // Return a boolean result -> if any number in the collection is a positive number

            bool result = default; //...write your code instead of 'default'...

            return result;
        }

        private bool IsManTruckInCollection(List<Car> cars)
        {
            // Return a boolean result -> if a 'MAN' truck presents in the collection

            bool result = default; //...write your code instead of 'default'...

            return result;
        }

        private bool DoesCollectionHasYellowCrossoverWithMaxSpeed(List<Car> cars)
        {
            // Return a boolean result -> if any crossover with yellow color or maximum speed higher 200 presents in the collection

            bool result = default; //...write your code instead of 'default'...

            return result;
        }

        [Test]
        public void NoPositiveNumbers()
        {
            Assert.IsFalse(IsAnyPositiveNumberExist(IntegersCollections.NumberWithoutPositive));
        }

        [Test]
        public void PositiveNumbersExist()
        {
            Assert.IsTrue(IsAnyPositiveNumberExist(IntegersCollections.NumbersWithPositive));
        }

        [Test]
        public void NoManTruckInTheCollection()
        {
            Assert.IsFalse(IsManTruckInCollection(CarsCollections.CarsWithDifferentCarTypes));
        }

        [Test]
        public void CollectionHasYellowCrossoverWithMaxSpeed()
        {
            Assert.IsTrue(DoesCollectionHasYellowCrossoverWithMaxSpeed(CarsCollections.CarsWithDifferentCarTypes));
        }
    }
}
