using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Wpf.Docking;

namespace DevExpressLayout
{
    /// <summary>
    /// Interaction logic for SampleWindow.xaml
    /// </summary>
    public partial class SampleWindow : Window {

        public static readonly DependencyProperty TabCaptionProperty;

        static SampleWindow() {
            TabCaptionProperty = DependencyProperty.RegisterAttached("TabCaption", typeof(string), typeof(SampleWindow));
        }

        public static string GetTabCaption(DependencyObject obj) {
            return (string)obj.GetValue(TabCaptionProperty);
        }
        public static void SetTabCaption(DependencyObject obj, string value) {
            obj.SetValue(TabCaptionProperty, value);
        }

        public SampleWindow() {
            InitializeComponent();
            
            //pnlProduct.CaptionTemplate = FindResource("AzureCaptionTemplate") as DataTemplate;
            //pnlEmployee.CaptionTemplate = FindResource("AzureCaptionTemplate") as DataTemplate;

            SetTabCaption(pnlProduct, "Tab 1");
            SetTabCaption(pnlEmployee, "Tab 2");
        }
    }
}
