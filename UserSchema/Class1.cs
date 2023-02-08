using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSchema
{
    public class Class1
    {
        private string _Id;
        private string _Name;
        private string _Email;
        private string _Password;
        private string _Mobile_no;
        private string _Gender;
        private string _UserType;
        private string _Image;
        public string Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }

        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        public string Mobile_no
        {
            get
            {
                return _Mobile_no;
            }
            set
            {
                _Mobile_no = value;
            }
        }
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        public string UserType
        {
            get
            {
                return _UserType;
            }
            set
            {
                _UserType= value;

            }
        }
        public string Image
        {
            get
            {
                return _Image;
            }
          set
            {
                _Image = value;
            }
        }
    }
}

