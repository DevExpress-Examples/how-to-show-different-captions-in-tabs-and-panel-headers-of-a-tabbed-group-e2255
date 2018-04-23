Imports Microsoft.VisualBasic
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
Imports DevExpress.Wpf.Docking

Namespace DevExpressLayout
	''' <summary>
	''' Interaction logic for SampleWindow.xaml
	''' </summary>
	Partial Public Class SampleWindow
		Inherits Window

		Public Shared ReadOnly TabCaptionProperty As DependencyProperty

		Shared Sub New()
			TabCaptionProperty = DependencyProperty.RegisterAttached("TabCaption", GetType(String), GetType(SampleWindow))
		End Sub

		Public Shared Function GetTabCaption(ByVal obj As DependencyObject) As String
			Return CStr(obj.GetValue(TabCaptionProperty))
		End Function
		Public Shared Sub SetTabCaption(ByVal obj As DependencyObject, ByVal value As String)
			obj.SetValue(TabCaptionProperty, value)
		End Sub

		Public Sub New()
			InitializeComponent()

			'pnlProduct.CaptionTemplate = FindResource("AzureCaptionTemplate") as DataTemplate;
			'pnlEmployee.CaptionTemplate = FindResource("AzureCaptionTemplate") as DataTemplate;

			SetTabCaption(pnlProduct, "Tab 1")
			SetTabCaption(pnlEmployee, "Tab 2")
		End Sub
	End Class
End Namespace
