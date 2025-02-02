﻿using Assignment.Question01;
using Assignment.Question02;
using Assignment.Question03;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1:What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class
            #endregion
            #region Q2:Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private

            #endregion
            #region Q3:Can an interface contain fields in C#?
            //c) Only if they are static
            #endregion
            #region Q4:In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Q5:Which keyword is used to implement an interface in a class in C#?
            //d) implements [none of all ':'] i do not use this keyword implements in Java
            #endregion
            #region Q6:Can an interface contain static methods in C#?
            // a) Yes [in C# 8.0]

            #endregion
            #region Q7:In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public
            #endregion
            #region Q8:What is the purpose of an explicit interface implementation in C#?
            // To provide a clear separation between interface and class members
            #endregion
            #region Q9: In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors
            #endregion
            #region Q10:How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas

            #endregion

            #endregion
            #region Part02
            #region Q1
            //Circle circle = new Circle(5.0);
            //Rectangle rectangle = new Rectangle(10.0, 40.0);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion
            #region Q2:
            //IAuthenticationService authService01 = new BasicAuthenticationService
            //{
            //    Username = "Nada",
            //    Password = "Nada123",
            //    Role = "Admin"
            //};
            //IAuthenticationService authService02 = new BasicAuthenticationService
            //{
            //    Username = "Nour",
            //    Password = "Nour123",
            //    Role = "Student"
            //};
            //bool isAuthenticated = authService01.AuthenticateUser("Nada", "Nada123");
            //Console.WriteLine($"User authentication : {isAuthenticated}"); 


            //bool isAuthorized = authService01.AuthorizeUser("Nada", "Admin");
            //Console.WriteLine($"User authorization : {isAuthorized}");


            //isAuthenticated = authService02.AuthenticateUser("Nada", "Nour123");
            //Console.WriteLine($"User authentication  : {isAuthenticated}");
            //isAuthorized = authService02.AuthorizeUser("Nour", "Admin");
            //Console.WriteLine($"User authorization : {isAuthorized}"); 
            #endregion
            #region Q3:
            //INotificationService EmailService = new EmailNotificationService();
            //INotificationService SMSService = new SmsNotificationService();
            //INotificationService PushService = new PushNotificationService();

  
            //EmailService.SendNotification("Noura@gmail.com", "Hi,Noura.");
            //SMSService.SendNotification("Nour", "Your SMS notification message.");
            //PushService.SendNotification("Noura", "Your push notification message.");

           
            #endregion

            #endregion
        }
    }
}
