using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assig3.Restaurant
{
    public class Customer
    {
        private String name;
        private String address;
        private String phone;

        public Customer(String name, String address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public Customer(String name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentException("name cannot be empty");

            Name = name.Trim();
        }

        public String Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("name cannot be empty");

                name = value.Trim();
            }
        }
        public String Address
        {
            get
            {
                return address;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("address cannot be empty");

                address = value.Trim();
            }
        }

        public String Phone
        {
            get
            {
                return phone;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("phone cannot be empty");

                if (!Regex.Match(value, @"^[0-9]{10}$").Success)
                    throw new ArgumentException("inavlid phone number");

                phone = value.Trim();
            }
        }
    }
}
