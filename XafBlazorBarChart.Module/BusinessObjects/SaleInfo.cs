using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XafBlazorBarChart.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class SaleInfo : BaseObject
    { 
        public SaleInfo(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _region;
        [Size(50)]
        public string Region
        {
            get { return _region; }
            set { SetPropertyValue(nameof(Region), ref _region, value); }
        }

        private string _country;
        [Size(50)]
        public string Country
        {
            get { return _country; }
            set { SetPropertyValue(nameof(Country), ref _country, value); }
        }

        private string _city;
        [Size(50)]
        public string City
        {
            get { return _city; }
            set { SetPropertyValue(nameof(City), ref _city, value); }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { SetPropertyValue(nameof(Amount), ref _amount, value); }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { SetPropertyValue(nameof(Date), ref _date, value); }
        }
    }
}