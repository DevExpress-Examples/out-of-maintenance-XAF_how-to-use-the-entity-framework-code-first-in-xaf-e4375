Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.Base
Imports System.ComponentModel

Namespace MySolution.Module
	<DefaultClassOptions, ImageName("BO_Employee")> _
	Public Class Employee
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
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property Birthday() As Date?
		Public Overridable Property Tasks() As List(Of Task)
	End Class
End Namespace
