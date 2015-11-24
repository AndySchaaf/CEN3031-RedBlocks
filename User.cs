using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameRentalSystem
{
    public class User
    {
        private string firstName;
        private string userID;
        private const string EMPTY_STRING = "";
        private UserProfile profile;

        public void setProfile(string userID, string firstName,string lastName, string email, string password, string address, string city, string state, string zip) {
            this.firstName = firstName;
            this.userID = userID;
            profile = new UserProfile(userID,firstName,lastName,email,password,address,city,state,zip);
        }

        public UserProfile getProfile()
        {
            return profile;
        }
    }
}
