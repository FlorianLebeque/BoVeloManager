﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVeloManager.Classes
{
    class Client : Human
    {

        private string etp_name;
        private string etp_adress;
        private string email;
        private string phone_num;
        private string insc_date;
        public Client(int id_, string first_name_, string last_name_, string etp_name_, string etp_adress_, string email_, string phone_num_, string insc_date_) : base(id_, first_name_ + last_name_) {

            etp_name = etp_name_;
                
            email = email_;
            phone_num = phone_num_;
            insc_date = insc_date_;
            }

        public string getEtpName() {
            return etp_name;
        }
        public string getEtpAdress() {
            return etp_adress;
        }
        public string getEmail() {
            return email;
        }
        public string getPhoneNumb() {
            return phone_num;
        }
        public string getInscDate() {
            return insc_date;
        }
        public displayInfo GetDisplayInfo() {
            displayInfo temp = new displayInfo();

            temp.CurClient = this;
            temp.name = this.getName();
            temp.id = this.getId();
            temp.etp_name = this.getEtpName();
            temp.etp_adress = this.getEtpAdress();
            temp.email = this.getEmail();
            temp.phone_num = this.getPhoneNumb();
            temp.insc_date = this.getInscDate();

            return temp;
        }
        public struct displayInfo {
            public Client CurClient { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string etp_name { get; set; }
            public string etp_adress { get; set; }
            public string email { get; set; }
            public string phone_num { get; set; }
            public string insc_date { get; set; }
        }

    }
}