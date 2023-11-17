using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Moq1
{
    public class OrderingSystemTests
    {
        [Fact]
        public void AddNewProduct_ShouldCallAddNewProductMethod()
        {
            // Arrange
            var productServiceMock = new Mock<IProductService>();
            var orderingSystem = new BreadOrderingSystem(productServiceMock.Object);

            // Act
            orderingSystem.AddProduct();

            // Assert
            productServiceMock.Verify(x => x.AddNewProduct(It.IsAny<string>()), Times.Once);
        }
    }
    public class ProductLoaderTests
    {
        [Fact]
        public void LoadProductsFromFile_ShouldHandleEmptyFile()
        {
            // Arrange
            var filePath = "C:\\Users\\Konrad\\source\\repos\\Moq1\\Moq1\\Products.txt";
            var mockConsole = new Mock<TextWriter>();
            var emptyFileContents = new string[0];
            mockConsole.Setup(x => x.WriteLine(It.IsAny<string>()));

            // Act
            var result = ProductLoader.LoadProductsFromFile(filePath);

            // Assert
            Assert.Empty(result);
            mockConsole.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void LoadProductsFromFile_ShouldHandleException()
        {
            // Arrange
            var filePath = "nonexistentfile.txt";
            var mockConsole = new Mock<TextWriter>();
            mockConsole.Setup(x => x.WriteLine(It.IsAny<string>()));
            var exceptionMessage = "File not found";

            // Act
            var result = ProductLoader.LoadProductsFromFile(filePath);

            // Assert
            Assert.Empty(result);
            mockConsole.Verify(x => x.WriteLine($"Wystąpił błąd podczas wczytywania produktów z pliku: {exceptionMessage}"), Times.Once);
        }
    }
}
