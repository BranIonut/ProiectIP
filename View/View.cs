﻿using ChestionarAuto.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto
{
    public class View : IView
    {
        private Form1 _form;
        private IPresenter presenter;
        private QuizControl quizControl;
        public View(Form1 form)
        {
            _form = form;
        }

        public void SetPresenter(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void LoadLoginControl()
        {
            var loginControl = new LogInUserControl();
            loginControl.LoginRequested += (s, e) => presenter.OnLoginRequest(e.Username, e.Password);
            loginControl.SignUpRequested += (s, e) => LoadSignupControl();
            _form.LoadUserControl(loginControl);
        }

        public void LoadSignupControl()
        {
            var signupControl = new SignUpUserControl();
            signupControl.LoginRequested += (s, e) => LoadLoginControl();
            signupControl.SignupRequested += (s, e) => presenter.OnSignupRequest(e.Username, e.Name, e.Email, e.Password);
            _form.LoadUserControl(signupControl);
        }

        public void LoadUserDashboardControl(string role)
        {
            var dashboardUserControl = new DashboardUserControl();

            dashboardUserControl.LogOutRequested += (s, e) => presenter.OnLogoutRequest();
            dashboardUserControl.AdminDashBoardRequested += (s, e) => LoadAdminDashboardControl();
            dashboardUserControl.StartQuizRequested += (s, e) => StartQuizControl();
            if (role == "admin")
            {
                dashboardUserControl.SetAdminDashBttnVisibility(false);
                dashboardUserControl.SetAdminDashBttnVisibility(true);
            }
            else if (role == "user")
            {
                dashboardUserControl.SetAdminDashBttnVisibility(false);
            }
            //dashboardUserControl.SetAdminDashBttnVisibility(true);
            _form.LoadUserControl(dashboardUserControl);
        }

        public void LoadAdminDashboardControl()
        {
            var dashboardAdminControl = new DashboardAdminControl();
            dashboardAdminControl.UserPanelRequested += (s, e) => LoadUserDashboardControl("admin");
            _form.LoadUserControl(dashboardAdminControl);
        }

        public void StartQuizControl()
        {
            quizControl = new QuizControl();

            quizControl.NextQuestionClicked += (s, e) => presenter.OnNextQuestion(e.SelectedAnswers);
            quizControl.AbortQuizClicked += (s, e) => presenter.OnAbortQuiz();

            _form.LoadUserControl(quizControl);
            quizControl.UpdateUI(0, 0);
            presenter.OnStartQuiz();
        }

        public void ShowQuestion(Question question, bool isLastQuestion = false)
        {
            quizControl.LoadQuestion(question, isLastQuestion);
        }

        public void ShowQuizResults(Quiz _quiz)
        {
            quizControl.ShowQuizResults(_quiz.correctAnswers, _quiz.wrongAnswers, _quiz.quizState);
            presenter.GoToMainMenu();
        }

        public void UpdateUI(int correctAnswers, int wrongAnswers)
        {
            quizControl.UpdateUI(correctAnswers, wrongAnswers);
        }
    }
}
