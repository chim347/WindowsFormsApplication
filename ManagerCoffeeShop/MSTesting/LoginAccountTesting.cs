using ManagerCoffeeShop.DAO;

namespace MSTesting
{
    [TestClass]
    public class LoginAccountTesting
    {

        [TestMethod]
        public void Login_WithValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "khanh";
            string password = "1";
            bool expected = true;

            // Act
            bool actual = AccountDAO.Instance.Login(username, password);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Login_WithInvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string username = "iiiiiiii";
            string password = "00000000";
            bool expected = false;

            // Act
            bool actual = AccountDAO.Instance.Login(username, password);

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}