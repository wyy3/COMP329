using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP329_Milestone3
{
    class Singleton
    {
        private Singleton() { }

        public static Singleton Instance { get; } = new Singleton();
        
        private decimal CID;
        private string CName;

        public decimal GetCompanyID()
        {
            return CID;
        }

        public string GetCompanyName()
        {
            return CName;
        }

        public void CompanyInfo(decimal CompanyID, string CompanyName)
        {
            CID = CompanyID;
            CName = CompanyName;
        }
    }
}
