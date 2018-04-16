Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.Base
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC

Namespace MySolution.Module
	<DefaultClassOptions, ImageName("BO_Task")> _
	Public Class Task
		Private privateId As Integer
		<Browsable(False)> _
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Protected Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Public Property Subject() As String
		<FieldSize(FieldSizeAttribute.Unlimited)> _
		Public Property Description() As String
		Public Overridable Property AssignedTo() As Employee
	End Class
End Namespace
