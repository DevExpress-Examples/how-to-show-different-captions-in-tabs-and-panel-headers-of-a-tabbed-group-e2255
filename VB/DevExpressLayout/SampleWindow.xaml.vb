Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Docking

Namespace DevExpressLayout
    ''' <summary>
    ''' Interaction logic for SampleWindow.xaml
    ''' </summary>
    Partial Public Class SampleWindow
        Inherits Window

        'public static readonly DependencyProperty TabCaptionProperty;

        'static SampleWindow() {
        '    TabCaptionProperty = DependencyProperty.RegisterAttached("TabCaption", typeof(string), typeof(SampleWindow));
        '}

        'public static string GetTabCaption(DependencyObject obj) {
        '    return (string)obj.GetValue(TabCaptionProperty);
        '}
        'public static void SetTabCaption(DependencyObject obj, string value) {
        '    obj.SetValue(TabCaptionProperty, value);
        '}

        Public Sub New()
            InitializeComponent()

            'pnlProduct.CaptionTemplate = FindResource("AzureCaptionTemplate") as DataTemplate;
            'pnlEmployee.CaptionTemplate = FindResource("AzureCaptionTemplate") as DataTemplate;

            'SetTabCaption(pnlProduct, "Tab 1");
            'SetTabCaption(pnlEmployee, "Tab 2");
        End Sub
    End Class
End Namespace
