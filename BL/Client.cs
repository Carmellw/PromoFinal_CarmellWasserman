using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromoFinal_CarmellWasserman.DAL;
using System.Data;


namespace PromoFinal_CarmellWasserman.BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_PhoneNumber;
        private int m_ZipCode;
        private int m_id;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public int ZipCode { get => m_ZipCode; set => m_ZipCode = value; }
        public int Id { get => m_id; set => m_id = value; }


        public void Insert()
        {
            Client_Dal.Insert(m_FirstName, m_LastName, m_PhoneNumber, m_ZipCode);
        }

        public Client() { }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_PhoneNumber = (int)dataRow["PhoneNumber"];
            m_ZipCode = (int)dataRow["ZipCode"];
            this.m_id = (int)dataRow["id"];
        }

        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }

        public bool Update()
        {
            return Client_Dal.Update( m_id , m_FirstName, m_LastName, m_PhoneNumber, m_ZipCode);
        }


    }
}
