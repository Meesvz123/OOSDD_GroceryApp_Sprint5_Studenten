using Grocery.Core.Helpers;
using Grocery.Core.Interfaces;
using Grocery.Core.Models;
using Moq;

namespace TestCore
{
    public class TestHelpers
    {
        [SetUp]
        public void Setup()
        {
        }

        //Happy flow
        [Test]
        public void TestPasswordHelperReturnsTrue()
        {
            string password = "user3";
            string passwordHash = "sxnIcZdYt8wC8MYWcQVQjQ==.FKd5Z/jwxPv3a63lX+uvQ0+P7EuNYZybvkmdhbnkIHA=";
            Assert.IsTrue(PasswordHelper.VerifyPassword(password, passwordHash));
        }

        [TestCase("user1", "IunRhDKa+fWo8+4/Qfj7Pg==.kDxZnUQHCZun6gLIE6d9oeULLRIuRmxmH2QKJv2IM08=")]
        [TestCase("user3", "sxnIcZdYt8wC8MYWcQVQjQ==.FKd5Z/jwxPv3a63lX+uvQ0+P7EuNYZybvkmdhbnkIHA=")]
        public void TestPasswordHelperReturnsTrue(string password, string passwordHash)
        {
            Assert.IsTrue(PasswordHelper.VerifyPassword(password, passwordHash));
        }


        //Unhappy flow
        [Test]
        public void TestPasswordHelperReturnsFalse()
        {
            string password = "user3";
            string passwordHash = "sxnIcZdYt8wC8MYWcQVQjQ";
            Assert.IsFalse(PasswordHelper.VerifyPassword(password, passwordHash));
        }

        [TestCase("user1", "IunRhDKa+fWo8+4/Qfj7Pg")]
        [TestCase("user3", "sxnIcZdYt8wC8MYWcQVQjQ")]
        public void TestPasswordHelperReturnsFalse(string password, string passwordHash)
        {
            Assert.IsFalse(PasswordHelper.VerifyPassword(password, passwordHash));
        }

 
        [Test]
        public async Task CategoriesViewModel_LoadData_FillsCategories()
        {
            // Arrange
            var mockCategoryService = new Mock<ICategoryService>();

            mockCategoryService
                .Setup(s => s.GetAllCategoriesAsync())
                .ReturnsAsync(new List<Category>
                {
                    new Category(1, "Fruit"),
                    new Category(2, "Vegetables")

                });

            var vm = new CategoriesViewModel(mockCategoryService.Object);

            // Act
            await vm.LoadData();

            // Assert
            Assert.AreEqual(2, vm.Categories.Count);
            Assert.IsTrue(vm.Categories.Exists(c => c.Name == "Fruit"));
            Assert.IsTrue(vm.Categories.Exists(c => c.Name == "Vegetables"));

            mockCategoryService.Verify(s => s.GetAllCategoriesAsync(), Times.Once);
        }
    }
}
