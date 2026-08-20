using LINQTasks_answers.Collections;
using LINQTasks_answers.Collections.ObjectsCollections;

namespace LINQTasks_answers
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
            var result = numbers.Any(number => number > 0);

            return result;
        }

        private bool IsManTruckInCollection(List<Car> cars)
        {
            // Return a boolean result -> if a 'MAN' truck presents in the collection
            var result = cars.Any(car => car.Mark == Marks.Man);

            return result;
        }

        private bool DoesCollectionHasYellowCrossoverWithMaxSpeed(List<Car> cars)
        {
            // Return a boolean result -> if any crossover with yellow color or maximum speed higher 200 presents in the collection
            var result = cars.Any(car => car.CarType == CarType.Crossover && (car.Color == Color.Yellow || car.MaxSpeed > 200));

            return result;
        }

        [Test]
        public void NoPositiveNumbers()
        {
            Assert.That(IsAnyPositiveNumberExist(IntegersCollections.numberWithoutPositive), Is.False);
        }

        [Test]
        public void PositiveNumbersExist()
        {
            Assert.That(IsAnyPositiveNumberExist(IntegersCollections.numbersWithPositive), Is.True);
        }

        [Test]
        public void NoManTruckInTheCollection()
        {
            Assert.That(IsManTruckInCollection(CarsCollections.CarsWithDifferentCarTypes), Is.False);
        }

        [Test]
        public void CollectionHasYellowCrossoverWithMaxSpeed()
        {
            Assert.That(DoesCollectionHasYellowCrossoverWithMaxSpeed(CarsCollections.CarsWithDifferentCarTypes), Is.True);
        }
    }
}
