using System.Linq;
using EPatient.Models;
using EPatient.Models.Auth;

namespace EPatient.Utilities
{
    class Login
    {
        private EPatientContext _context;


        public bool LoggedIn(string username, string password, bool isRememberMeChecked)
        {
            using (_context = new EPatientContext())
            {
                var user = _context.Users.Include("TimeTables").SingleOrDefault(u => u.Username == username);

                if (user == null)
                    return false;

                var hashedPassword = user.Password;

                if (HashingPassword.CheckPassword(password, hashedPassword))
                {
                    RememberMe(isRememberMeChecked, username, password);
                    AuthUser.Model = user;
                    return true;
                }

                return false;
            }
        }

        private void RememberMe(bool isChecked, string username, string password)
        {
            if (isChecked)
            {
                Properties.Settings.Default.LoginFormUsername = username;
                Properties.Settings.Default.LoginFormPassword = password;
            }
            else
            {
                Properties.Settings.Default.LoginFormUsername = null;
                Properties.Settings.Default.LoginFormPassword = null;
            }

            Properties.Settings.Default.LoginFormRememberMe = isChecked;
            Properties.Settings.Default.Save();
        }
    }
}
