using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace TestCore
{
    public class CategoryRepositoryTests
    {
        private Mock<ICategoryRepository> _mockRepository;

        [SetUp]
        public void Setup()
        {
            _mockRepository = new Mock<ICategoryRepository>();

            _mockRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(
                new List<Category>
                {
                    new Category(1, "Fruit"),
                    new Category(2, "Groente")
                });
        }

        [Test]
        public async Task GetAllAsync_ReturnsCategoryList()
        {
            // Act
            var result = await _mockRepository.Object.GetAllAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);

            
        }
    }
}
