using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoFinal_CarmellWasserman.BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_PhoneNumber;
        private int m_ZipCode;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public int ZipCode { get => m_ZipCode; set => m_ZipCode = value; }
    }
}
