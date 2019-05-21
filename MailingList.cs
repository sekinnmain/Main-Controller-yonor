using System;
using System.Collections.Generic;

namespace Main.yonor
{
    /// <summary>
    /// Summary description for MailingList
    /// </summary>
    public class MailingList
    {
        private VipCustomer[] Subscribers;
        //private Advertisement[] Ads;
        public Queue<Advertisement> Ads = new Queue<Advertisement>();
        private DateTime StartDate;
        private DateTime EndDate;
        public MailingList()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int DispacherFrecuency { get; set; }
        private Advertisement[] Ads{get; set;}

        public void AddAd(Advertisement myAd)
        {
            Ads = new Advertisement[myAd];
        }
    
        public void SendAds()
        {
            Mailer myMailer = new Mailer();
            myMailer.SendEmail(this.Ads.Dequeue());
            //delegate?
        }
        public void StartAds()
        {
            //
        }
        public void StopAds()
        {
            //
        }


    }

}
