using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameRentalSystem
{
    public class UserProfile
    {
        private string userID;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string address;
        private string city;
        private string state;
        private string zip;

        public UserProfile(string userID, string firstName, string lastName, string email, string password, string address, string city, string state, string zip)
        {
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public string getUserID()
        {
            return userID;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPassword()
        {
            return password;
        }
        public string getAddress()
        {
            return address;
        }
        public string getCity()
        {
            return city;
        }
        public string getState()
        {
            return state;
        }
        public string getZip()
        {
            return zip;
        }
    }
}
