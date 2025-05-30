using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChestionarAuto
{
    [TestClass]
    public class ModelUnitTests
    {
        private IModel _model;

        [TestInitialize]
        public void Init()
        {
            _model = new Model();
        }

        [TestMethod]
        public void TestUserAdd_UniqueConstraint() => Assert.AreEqual(false, _model.AddUser("admin", "admin", "", ""));

        [TestMethod]
        public void TestUserAdd_EmptyFields() => Assert.AreEqual(false, _model.AddUser("", "", "", ""));

        [TestMethod]
        public void TestRemoveUser_EmptyField() => Assert.AreEqual(false, _model.RemoveUser(""));

        [TestMethod]
        public void TestRemoveUser_NonExistentUser() => Assert.AreEqual(false, _model.RemoveUser("nonExistentUser"));

        [TestMethod]
        public void TestResetUserProgress_NonExistentUser() => Assert.AreEqual(false, _model.UserResetProgress("nonExistentUser"));

        [TestMethod]
        public void TestUserAdd_SQLInjection() => Assert.AreEqual(false, _model.AddUser("admin' OR '1'='1", "numeExemplu", "email@email.com", "password123"));

        [TestMethod]
        public void TestUserAdd_InvalidEmail() => Assert.AreEqual(false, _model.AddUser("numeUser", "nume user", "email@.com", "cevaParola"));

        [TestMethod]
        public void TestLogin_SQLInjection() => Assert.AreEqual(false, _model.Login("admin' OR '1'='1", "parola1234"));

        [TestMethod]
        public void TestLogin_InvalidPassword() => Assert.AreEqual(false, _model.Login("admin", "invalidPass123"));

        [TestMethod]
        public void TestLogin_EmptyFields() => Assert.AreEqual(false, _model.Login("", ""));

        [TestMethod]
        public void TestUserAdd_Success()
        {
            Assert.AreEqual(true, _model.AddUser("newUserToAdd", "New User", "newuser@gmail.com", "validPassword123"));
            _model.RemoveUser("newUserToAdd");
        }
        [TestMethod]
        public void TestRemoveUser_Success()
        {
            _model.AddUser("abc123", "ABC", "abc1234@gmail.com", "abcPass123");
            var result = _model.RemoveUser("abc123");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLogin_Success()
        {
            _model.AddUser("abc123", "ABC", "abc1234@gmail.com", "abcPass123");
            var result = _model.Login("abc123", "abcPass123");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestResetUserProgress_Success()
        {
            _model.AddUser("abc123", "ABC", "abc1234@gmail.com", "abcPass123");
            var result = _model.UserResetProgress("abc123");
            Assert.IsTrue(result);
        }
    }
}
