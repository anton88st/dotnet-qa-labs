using LINQTasks_answers.Collections;
using LINQTasks_answers.Collections.ObjectsCollections;
using System;

namespace LINQTasks
{
    public class WhereMethod
    {
        /*
         * Documentation: 
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-8.0
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=net-8.0
         * 
         * There are two parts in the class: 
         * - Methods;
         * - Tests (DO NOT MAKE ANY CHANGES);
         * In methods you should write code with the help of LINQ methods from the documentation. Tasks are written in methods.
         */

        private int? SumWeightsOfCarsForSpecifiedOwner(List<Car> cars, string user)
        {
            // Return int result -> calculate overall weight of cars owned by user. 
            // The structure of car class, you can find here: Collections.ObjectCollections.CarsCollection -> car class.

            int result = default; //...write your code instead of 'default'...

            return result;
        }

        private int? GetWordAsPerIndex(List<string> words)
        {
            // Return int result -> calculate chars count for words from the collection, if a word contains index of placing in the collection.
            // E.g.: "1.Add", "4.Add", "3.All" -> the system should calculate length for the first and third word, because they contain an index in the collection.
            // The second word has an invalid index - should be 2.

            int result = default; //...write your code instead of 'default'...

            return result;
        }

        private IEnumerable<string> GetWordAsPerTheirLenght(List<string> words, int length)
        {
            // Result a collection with strings -> return a collection of words, which chars count is higher than needed length.

            IEnumerable<string> result = default; //...write your code instead of 'default'...

            return result;
        }

        private IEnumerable<Student> GetStudentWithAverageMaerkHigherRequired(List<Student> students, int requiredAverageMark)
        {
            // Result is a student -> return a student if his average mark is higher than required. If a student doesn't have any marks, his average mark is 0. 
            // The structure of student class, you can find here: Collections.ObjectCollections.StudentsCollections -> student class.

            IEnumerable<Student> result = default; //...write your code instead of 'default'...

            return result;
        }

        private IEnumerable<Laptop> GetLaptopsWithMultipleVideoCardsRefactored(List<Laptop> laptops, Company company)
        {
            // Refator method GetLaptopsWithMultipleVideoCards() by applying LINQ methods.

            IEnumerable<Laptop> result = default; //...write your code instead of 'default'...

            return result;
        }

        private IEnumerable<Laptop> GetLaptopsWithMultipleVideoCards(List<Laptop> laptops, Company company)
        {
            var result = new List<Laptop>();
            foreach (var laptop in laptops)
            {
                var count = 0;
                foreach (var videoCard in laptop.VideoCards)
                {
                    if (videoCard.Company == company)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    result.Add(laptop);
                }
            }

            return result;
        }

        [Test]
        [TestCase("Adam", 3090)]
        public void SumWeightOfCarsOwnedByOneUser(string userName, int expectedWeightCount)
        {
            var result = SumWeightsOfCarsForSpecifiedOwner(CarsCollections.CarsOwnedByOneUser, userName);

            Assert.AreEqual(expectedWeightCount, result, "Weight is not valid");
        }

        [Test]
        [TestCase(26)]
        public void WordAsPerIndexExists(int expectedResult)
        {
            var result = GetWordAsPerIndex(StringsCollections.WordsWithIndexes);

            Assert.AreEqual(expectedResult, result, "Count is not valid");
        }

        [Test]
        [TestCase(6, "schedule")]
        public void WordsWithValidLeght(int length, string expectedWord)
        {
            var result = GetWordAsPerTheirLenght(StringsCollections.Words, length);

            Assert.IsTrue(result.Count().Equals(1));
            Assert.IsTrue(result.FirstOrDefault().Contains(expectedWord));
        }

        [Test]
        [TestCase(5, 8)]
        public void StudentWithMaxAverageMark(int expectedId, int requiredAverageMark)
        {
            var result = GetStudentWithAverageMaerkHigherRequired(StudentsCollections.Students, requiredAverageMark);

            Assert.AreEqual(expectedId, result.FirstOrDefault().Id, "Wrong student was selected");
        }

        [Test]
        [TestCase(Company.AMD, 10)]
        public void LaptopsHaveTwoVideoCardsRefactored(Company company, int expectedId)
        {
            var result = GetLaptopsWithMultipleVideoCardsRefactored(LaptopsCollection.LaptopsWithVideoCards, company);

            Assert.AreEqual(expectedId, result.FirstOrDefault().Id, "Wrong laptop was selected");
        }

        [Test]
        [TestCase(Company.AMD, 10)]
        public void LaptopsHaveTwoVideoCards(Company company, int expectedId)
        {
            var result = GetLaptopsWithMultipleVideoCards(LaptopsCollection.LaptopsWithVideoCards, company);

            Assert.AreEqual(expectedId, result.FirstOrDefault().Id, "Wrong laptop was selected");
        }
    }
}
