using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database dataBase;

        [SetUp]
        public void Setup()
        {
            dataBase = new Database();
        }

        [Test]
        public void Add_ThrowsException_WhenCapcityIsExceded()
        {
            for (int i = 0; i < 16; i++)
            {
                dataBase.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() => dataBase.Add(17));
        }
        [Test]
        public void Add_IncreasesDatabbaseCount_WhenAddIsInvalidOperation()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                dataBase.Add(i);
            }
           
            Assert.That(dataBase.Count, Is.EqualTo(n));
        }
        [Test]
        public void Add_AddsElementToDataBase()
        {
            int element = 123;
            dataBase.Add(element);
            int[] elements = dataBase.Fetch();

            Assert.IsTrue(elements.Contains(element));

            
        }
        [Test]
        public void Remove_ThrowsException_WhenDatBaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => dataBase.Remove());
        }
        [Test]
        public void Remove_DecreaseDataBaseCouunt()
        {
            int lastElement = 3;
            dataBase.Add(1);
            dataBase.Add(2);
            dataBase.Add(3);
            dataBase.Remove();

            int[] elements = dataBase.Fetch();
            Assert.IsTrue(elements.Contains(lastElement));
            
        }
        [Test]
        public void Fetch_ReturnDataBaseCopyInsteadOfReference()
        {
            dataBase.Add(1);
            dataBase.Add(2);

            int[] firstCopy = dataBase.Fetch();
            dataBase.Add(3);
            int[] secondCopy = dataBase.Fetch();

            Assert.That(firstCopy, Is.Not.EqualTo(secondCopy));

        }
        [Test]
        public void CounteReturnsZero_WhenDataBaseIsEmpty()
        {
            Assert.That(dataBase.Count, Is.EqualTo(0));
        }
        [Test]
        public void Ctor_ThrowsException_WhenDatabaseCapacityIsEceded()
        {
            Assert.Throws<InvalidOperationException>(() =>
            dataBase = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
        }
        [Test]
        public void Ctor_AddsElementsToDatabase()
        {
            int[] arr = new int[] { 1, 2, 3 };
            dataBase = new Database(arr);
            Assert.That(dataBase.Count,Is.EqualTo(arr.Length));
            Assert.That(dataBase.Fetch, Is.EquivalentTo(arr));
        }


    }
}