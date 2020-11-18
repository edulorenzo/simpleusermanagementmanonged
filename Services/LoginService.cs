using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simpleusermanagement.Entities;
using simpleusermanagement.Helpers;
namespace simpleusermanagement.Services
{
    public interface ILoginService
    {
        Login Login(string email, string password);
    }
    public class LoginService
    {
        private DataContext _context;
        public LoginService(DataContext context)
        {
            _context = context;
        }
        public Login Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.Users.SingleOrDefault(x => x.Username == email);

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            // save login time

            // authentication successful
            return null;
        }

        private User logtime(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        //should really put this in the helpers
        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
    }
}
