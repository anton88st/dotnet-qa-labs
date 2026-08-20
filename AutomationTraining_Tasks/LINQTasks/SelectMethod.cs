using LINQTasks_answers.Collections;
using LINQTasks_answers.Collections.ObjectsCollections;

namespace LINQTasks
{
    public class SelectMethod
    {
        /*
         * Documentation: 
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=net-8.0
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.oftype?view=net-8.0
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.selectmany?view=net-8.0
         * 
         * There are two parts in the class: 
         * - Methods;
         * - Tests (DO NOT MAKE ANY CHANGES);
         * In methods you should write code with the help of LINQ methods from the documentation. Tasks are written in methods.
         */

        private IEnumerable<int> GetNumbersFromObject(IEnumerable<object> objects)
        {
            /* Implement the GetNumbersFromObject method, which given a collection of objects of different types, will return a collection of integers.
             * Please note that if an object in the input collection is a string, it should be parsed to int if possible. The result collection shall be ordered from least to greatest.
             * E.g.: input collection { "2", 4, "qwe", new DateTime(2020, 1, 2), true, "23"} ->  the result shall be { 2, 4, 23}.
            */

            IEnumerable<int> result = default; //...write your code instead of 'default'...

            return result;
        }

        private IEnumerable<User> GetUserInfoFromString(string usersInfo, string emaildDomain)
        {
            /*
             * Implement the GetUserInfoFromString method, which given a single string containing user data of multiple users and email domain (e.g.: gmail),
             * will return a user object, filtered by email domain. User's data is valid and can be properly parsed. For example, for an input string:
             * "1, John, john@com;2, Jane, jane@gmail.com" -> a John object will be the result as he has a gmail domain.
             * User object you can find here: Collections.ObjectsCollections.UsersCollections
             */

            IEnumerable<User> result = default; //...write your code instead of 'default'...

            return result;
        }

        private int GetSumOfNestedListsWithNumbers(List<List<int>> numbers)
        {
            /*
             * Implement a GetSumOfNestedListsWithNumbers method, which given a list with nested numbers lists and return the sum of all numbers in nested lists.
             * Use SelectMany method for the task
             */

            int result = default; //...write your code instead of 'default'...

            return result;
        }

        private IEnumerable<string> GetCarMarkModelCollection(List<string> marks, List<string> models)
        {
            /*
             * Implement a GetCarMarkModelCollection method, which given list with marks and list with models and return a collection of "mark model" items. 
             * E.g: marks - "Opel", models - "Kadet", "Astra" -> result will be: "Opel Kadet", "Opel Astra". 
             * User SelectMany method for the task.
             */

            IEnumerable<string> result = default; //...write your code instead of 'default'...

            return result;
        }


        [Test]
        public void ObjectWithNumbersAndTryParseStrings()
        {
            var result = GetNumbersFromObject(DifferentObjectsTypesCollections.Objects);

            CollectionAssert.AreEquivalent(new List<object> { 1, 13, 23, 44 }, result);
        }

        [Test]
        [TestCase("microsoft", "User2")]
        public void UserInfoConvertedToUserObject(string emaildDomain, string userName)
        {
            var result = GetUserInfoFromString(StringsCollections.UserInfo, emaildDomain);

            Assert.AreEqual(userName, result.FirstOrDefault().Name, "The name of the user is not correct");
        }

        [Test]
        [TestCase(35)]
        public void SumOfNestedListsNumbers(int sum)
        {
            var result = GetSumOfNestedListsWithNumbers(IntegersCollections.NestedNumbersLists);

            Assert.AreEqual(sum, result, "The sum is not correct");
        }

        [Test]
        public void CarMarkModelCollection()
        {
            var result = GetCarMarkModelCollection(StringsCollections.Marks, StringsCollections.Models);

            Assert.AreEqual(StringsCollections.ExpectedMarksModelsCollection, result, "Collection of cars is not correct");
        }
    }
}
