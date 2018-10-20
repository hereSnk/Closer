using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloserRepository;
using System.Net;

namespace Closer.Models
{
    public class Buyer
    {
        internal bool RegisterBuyerData(BuyerInfo buyerInfo)
        {
            var data = FillBuyerInfo(buyerInfo);
            Repository repo = new Repository();
            return repo.RegisterBuyer(data);
        }

        public TBL_BUYER_INFO FillBuyerInfo(BuyerInfo buyerData)
        {
            TBL_BUYER_INFO buyerEntityInfo = new TBL_BUYER_INFO();
            buyerEntityInfo.Buyer_Email = buyerData._Buyer_Email;
            buyerEntityInfo.Id = buyerData._Id;
            buyerEntityInfo.Name = buyerData._Name;
            buyerEntityInfo.Password = buyerData._Password;
            buyerEntityInfo.Confirm_Password = buyerData._ConfirmPassword;
            buyerEntityInfo.Registration_time = GetSystemDateTime();
            buyerEntityInfo.Phone_no = buyerData._Phone_no;
            buyerEntityInfo.Location = buyerData._Location;

            return buyerEntityInfo;
        }
        internal string GetSystemDateTime()
        {
            string date = DateTime.Today.ToShortDateString();
            string time = DateTime.Now.ToString("HH.mm.ss");
            return date + " " + time;

        }

       
    }
}