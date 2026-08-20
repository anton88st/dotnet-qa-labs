using LINQTasks_answers.Collections;
using LINQTasks_answers.Collections.ObjectsCollections;

namespace LINQTasks
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

            bool result = default; //...write your code instead of 'default'...

            return result;
        }

        private int CountLaptopUsers(List<Laptop> laptops, User user)
        {
            // Return an int result -> count, how many laptops owned by the user. You can apply contains method as well. 
            // The structure of Laptop class you can find here: Collections.ObjectsCollections.LaptopsCollection file -> class Laptop.

            int result = default; //...write your code instead of 'default'...

            return result;
        }

        [Test]
        public void DatePresentsInTheCollection()
        {
            Assert.IsTrue(IsDateAvailableInCollection(DatesTimesCollection.dates, DateTime.Today));
        }

        [Test]
        public void DateNotPresentsInTheCollection()
        {
            Assert.IsFalse(IsDateAvailableInCollection(DatesTimesCollection.noDateNow, DateTime.Now));
        }

        [Test]
        [TestCase(2)]
        public void OneUserOwnedSeveralLaptops(int expectedCount)
        {
            var actualCount = CountLaptopUsers(LaptopsCollection.Laptops, UsersCollections.Adam);

            Assert.AreEqual(expectedCount, actualCount, "Owners count is not valid");
        }
    }
}
