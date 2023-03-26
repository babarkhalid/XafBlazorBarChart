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

namespace XafBlazorBarChart.Blazor.Server.Controllers
{
    public class XafDashboardViewController : ViewController
    {
        public XafDashboardViewController()
        {
            
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            if(View.Id == "IssueChartView")
            {
                var dashboardCustomizationController = Frame.GetController<DevExpress.ExpressApp.SystemModule.DashboardCustomizationController>();
                dashboardCustomizationController.Active.SetItemValue("hideActions", false);
            }
        }
    }
}