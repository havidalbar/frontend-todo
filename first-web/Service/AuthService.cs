using System;
namespace first_web.Service
{
    public class AuthService
    {
        private bool _isAuthenticated;

        public bool IsAuthenticated()
        {
            return _isAuthenticated;
        }

        public void Login(string email, string password)
        {
            // Implement your authentication logic here
            // For example, validate against a database or an API
            _isAuthenticated = true; // Set this based on your authentication logic
        }

        public void Logout()
        {
            _isAuthenticated = false;
        }
    }
}

