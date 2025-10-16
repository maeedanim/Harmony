using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmony_Music_Player_.Properties
{
    public class AdminClass
    {
        public string _FullName { get; set; }
        public string _ad_UserName { get; set; }
        public string _Email { get; set; }
        public DateTime _dt { get; set; }
        public string _gender { get; set; }
        public string _password { get; set; }
        public string _phone { get; set; }


        public void insertFunc()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = new Admin();
                us.full_name = this._FullName;
                us.ad_username = this._ad_UserName;
                us.email = this._Email;
                us.date_of_birth = this._dt;
                us.gender = this._gender;
                us.password = this._password;
                us.phone_number = this._phone;
                

                db.Admins.InsertOnSubmit(us);
                db.SubmitChanges();
            }
        }

        public void updateFunc(string uName)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = db.Admins.SingleOrDefault(x => x.ad_username == uName);
                if (this._FullName != "")
                {
                    us.full_name = this._FullName;
                    db.SubmitChanges();
                }

                if (this._Email != "")
                {
                    us.email = this._Email;
                    db.SubmitChanges();
                }

                if (this._gender != "")
                {
                    us.gender = this._gender;
                    db.SubmitChanges();
                }

                if (this._phone != "")
                {
                    us.phone_number = this._phone;
                    db.SubmitChanges();
                }


            }
        }
        public void deleteFunc(string uName)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = db.Admins.SingleOrDefault(x => x.ad_username == uName);
                if (us != null)
                {
                    db.Admins.DeleteOnSubmit(us);
                    db.SubmitChanges();
                }
            }

        }

        public bool searchFunc(string uName)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = db.Admins.SingleOrDefault(x => x.ad_username == uName);
                if (us == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void changePass(string uName, string newPass)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = db.Admins.SingleOrDefault(x => x.ad_username == uName);
                if (us != null)
                {
                    us.password = newPass;
                    db.SubmitChanges();
                }
            }
        }

        public bool CheckPass(string uName, string Pass)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = db.Admins.SingleOrDefault(x => x.ad_username == uName);
                if (us.password == Pass)
                {
                    return true;
                }
            }
            return false;
        }

        public void DOBchange(string uName, DateTime dt)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = db.Admins.SingleOrDefault(x => x.ad_username == uName);
                if (us != null)
                {
                    us.date_of_birth = dt;
                    db.SubmitChanges();
                }
            }
        }

        public bool CheckPhone(string uName, string phn)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Admin us = db.Admins.SingleOrDefault(x => x.ad_username == uName);
                if (us.phone_number == phn)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
