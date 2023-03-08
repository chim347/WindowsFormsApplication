using ManagerCoffeeShop.DAO;
using ManagerCoffeeShop.DTO;

namespace NUnitTesting
{
    [TestFixture]
    public class LoginAccountTesting
    {

        [Test]
        public void Login_WithValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "khanh";
            string password = "1";
            bool expected = true;

            // Act
            bool actual = AccountDAO.Instance.Login(username, password);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Login_WithInvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string username = "iiiiiiii";
            string password = "00000000";
            bool expected = false;

            // Act
            bool actual = AccountDAO.Instance.Login(username, password);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}