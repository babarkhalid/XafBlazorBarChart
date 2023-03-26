using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace XafBlazorBarChart.Blazor.Server.Pages
{
    public class IssueChartViewAdapter : IComponentAdapter, IComplexControl
    {
        private XafApplication application;
        private RenderFragment component;
        public RenderFragment ComponentContent
        {
            get
            {
                if (component == null)
                {
                    component = builder =>
                    {
                        builder.OpenComponent<IssueChartView>(0);
                        builder.CloseComponent();
                    };
                }
                return component;
            }
        }

        public event EventHandler ValueChanged;

        public object GetValue()
        {
            return null;
        }

        public void Refresh()
        {
            
        }

        public void Setup(IObjectSpace objectSpace, XafApplication application)
        {
            this.application = application;
        }

        public void SetValue(object value)
        {
            
        }
    }
}
