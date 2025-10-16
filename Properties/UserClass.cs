using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmony_Music_Player_.Properties
{
    public class UserClass
    {
        public string _FullName {  get; set; }
        public string _UserName {  get; set; }
        public string _Email {  get; set; }
        public DateTime _dt {  get; set; }
        public string _gender {  get; set; }
        public string _password {  get; set; }
        public string _phone { get; set; }
        public int _membership {  get; set; }

        public void insertFunc()
        {
            using(DataClasses2DataContext db=new DataClasses2DataContext())
            {
                User_tbl us=new User_tbl();
                us.full_name = this._FullName;
                us.username = this._UserName;
                us.email = this._Email;
                us.date_of_birth = this._dt;
                us.gender = this._gender;
                us.password=this._password;
                us.phone_number = this._phone;
                us.membership = Convert.ToString(this._membership);

                db.User_tbls.InsertOnSubmit(us);
                db.SubmitChanges();
            }
        }

        public void updateFunc(string uName) 
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                //User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                if (this._FullName != "")
                {
                    User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                    us.full_name = this._FullName;
                    db.SubmitChanges();
                }

                if (this._Email != "")
                {
                    User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                    us.email = this._Email;
                    db.SubmitChanges();
                }

                if (this._gender != "")
                {
                    User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                    us.gender = this._gender;
                    db.SubmitChanges();
                }

                if (this._phone != "")
                {
                    User_tbl uk = db.User_tbls.SingleOrDefault(x => x.username == uName);
                    uk.phone_number = this._phone;
                    db.SubmitChanges();
                }


            }
        }
        public void deleteFunc(string uName) 
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                if (us != null)
                {
                    db.User_tbls.DeleteOnSubmit(us);
                    db.SubmitChanges();
                }
            }
            
        }

        public bool searchFunc(string uName)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                User_tbl us=db.User_tbls.SingleOrDefault(x=>x.username==uName);
                if (us == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void changePass(string uName,string newPass)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                if(us != null)
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
                User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                if(us.password== Pass)
                {
                    return true;
                }
            }
            return false;
        }
        public void DOBchange(string uName,DateTime dt) 
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                if (us != null)
                {
                    us.date_of_birth = dt;
                    db.SubmitChanges();
                }
            }
        }

        public bool CheckPhone(string uName,string phn)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                User_tbl us = db.User_tbls.SingleOrDefault(x => x.username == uName);
                if (us.phone_number == phn)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
