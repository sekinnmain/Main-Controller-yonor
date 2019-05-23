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
        private bool scheduleState = true;
        public MailingList()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int DispacherFrecuency { get; set; }
        private Advertisement[] Ads { get; set; }

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
            while (this.scheduleState)
            {
                var now = DateTime.Now;
                var schedule = new DateTime(now.Year, now.Month, now.Day, 8, 55, 00);
                if (schedule < now) schedule = schedule.AddDays(1);
                Thread.Sleep(schedule.Subtract(now));
                SendAds();

            }
        }
        public void StopAds()
        {
            //
            this.scheduleState = false;

        }


    }

}
