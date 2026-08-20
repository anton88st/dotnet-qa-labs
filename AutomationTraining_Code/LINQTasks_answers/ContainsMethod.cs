using LINQTasks_answers.Collections;
using LINQTasks_answers.Collections.ObjectsCollections;

namespace LINQTasks_answers
{
    public class ContainsMethod
    {
        /*
         * Documentation: 
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.contains?view=net-8.0
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=net-8.0
         * There are two parts in the class: 
         * - Methods;
         * - Tests (DO NOT MAKE ANY CHANGES);
         * In methods you should write code with the help of LINQ methods from the documentation. Tasks are written in methods.
         */

        private bool IsDateAvailableInCollection(List<DateTime> dates, DateTime data)
        {
            // Return a boolean result -> if a collection contains current date time.
            var result = dates.Contains(data);

            return result;
        }

        private int CountLaptopUsers(List<Laptop> laptops, User user)
        {
            // Return an int result -> count, how many laptops owned by the user. You can apply contains method as well. 
            // The structure of Laptop class you can find here: Collections.ObjectsCollections.LaptopsCollection file -> class Laptop.
            var result = laptops.Count(laptop => laptop.Owners.Contains(user.Name));

            return result;
        }

        [Test]
        public void DatePresentsInTheCollection()
        {
            Assert.That(IsDateAvailableInCollection(DatesTimesCollection.dates, DateTime.Today), Is.True);
        }

        [Test]
        public void DateNotPresentsInTheCollection()
        {
            Assert.That(IsDateAvailableInCollection(DatesTimesCollection.noDateNow, DateTime.Now), Is.False);
        }

        [Test]
        [TestCase(2)]
        public void OneUserOwnedSeveralLaptops(int expectedCount)
        {
            var actualCount = CountLaptopUsers(LaptopsCollection.Laptops, UsersCollections.Adam);

            Assert.That(expectedCount, Is.EqualTo(actualCount), "Owners count is not valid");
        }
    }
}
