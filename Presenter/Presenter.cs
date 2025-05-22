using ChestionarAuto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public class Presenter : IPresenter
    {
        private IModel _model;
        private IView _view;

        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;

        }

        public void OnLogoutRequest()
        {
            _model.Logout();
            _view.LoadLoginControl();
        }

        public void OnLoginRequest(string username, string password)
        {
            bool success = false;
            success = _model.Login(username, password);

            if (success)
            { 
                _view.LoadUserDashboardControl(_model.GetLoggedUserRole());
            }
            else
            {
                _view.LoadLoginControl();
            }
        }

        public void OnSignupRequest(string username, string name, string email, string password)
        {
            bool success = false;
            success = _model.AddUser(username, name, email, password);
            if (success)
            {
                _view.LoadLoginControl();
            }
            else
            {
                _view.LoadSignupControl();
            }
        }
    }
}
