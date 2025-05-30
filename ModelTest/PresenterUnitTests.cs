using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace ChestionarAuto
{
    /// <summary>
    /// Summary description for PresenterTests
    /// </summary>
    [TestClass]
    public class PresenterUnitTests
    {
        private Mock<IModel> _mockModel;
        private Mock<IView> _mockView;
        private IPresenter _presenter;

        [TestInitialize]
        public void Init()
        {
            _mockModel = new Mock<IModel>();
            _mockView = new Mock<IView>();
            _presenter = new Presenter(_mockModel.Object, _mockView.Object);    
        }

        [TestMethod]
        public void OnSignupRequest_ShouldLoadLogin_WhenSignupSuccessful()
        {
            _mockModel.Setup(m => m.AddUser("validTestUser", "Test User", "test@email.com", "validPass1234")).Returns(true);

            var result = _presenter.OnSignupRequest("validTestUser", "Test User", "test@email.com", "validPass1234");

            Assert.IsTrue(result);
            _mockView.Verify(v => v.LoadLoginControl(true), Times.Once);
        }

        [TestMethod]
        public void OnLoginRequest_ShouldLoadDashboard_WhenLoginSuccessful()
        {
            _mockModel.Setup(m => m.Login("validTestUser", "validPass1234")).Returns(true);
            _mockModel.Setup(m => m.GetLoggedUserRole()).Returns("user");

            _presenter.OnLoginRequest("validTestUser", "validPass1234");

            _mockView.Verify(v => v.LoadUserDashboardControl("user"), Times.Once);
        }

        [TestMethod]
        public void OnLoginRequest_ShouldLoadLogin_WhenLoginFails()
        {
            _mockModel.Setup(m => m.Login("nonExistentUser", "validPass1234")).Returns(false);
            _mockModel.Setup(m => m.GetLoggedUserRole()).Returns("user");

            _presenter.OnLoginRequest("nonExistentUser", "validPass1234");

            _mockView.Verify(v => v.LoadLoginControl(false), Times.Once);
        }

        [TestMethod]
        public void OnChangeUserRole_ShouldCallModelWithCorrectParams()
        {
            _mockModel.Setup(m => m.ChangeUserRole("validTestUser", "admin")).Returns(true);

            var result = _presenter.OnChangeUserRole("validTestUser", "admin");

            Assert.IsTrue(result);
            _mockModel.Verify(m => m.ChangeUserRole("validTestUser", "admin"), Times.Once);
        }

        [TestMethod]
        public void OnRemoveUser_ShouldReturnTrue_WhenUserIsRemovedSuccessfully()
        {
            string username = "validTestUser";

            _mockModel.Setup(m => m.RemoveUser(username)).Returns(true);

            bool result = _presenter.OnRemoveUser(username);

            Assert.IsTrue(result);
            _mockModel.Verify(m => m.RemoveUser(username), Times.Once);
        }

        [TestMethod]
        public void OnRemoveUser_ShouldReturnFalse_WhenUserIsRemoveFails()
        {
            string username = "nonExistentUser";

            _mockModel.Setup(m => m.RemoveUser(username)).Returns(false);

            bool result = _presenter.OnRemoveUser(username);

            Assert.IsFalse(result);
            _mockModel.Verify(m => m.RemoveUser(username), Times.Once);
        }
    }
}
