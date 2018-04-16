Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace MySolution.Module
	Public Class Updater
		Inherits ModuleUpdater

		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			If ObjectSpace.GetObjects(Of Employee)().Count = 0 Then
				Dim employee = ObjectSpace.CreateObject(Of Employee)()
				employee.FirstName = "Mary"
				employee.LastName = "Tellitson"
				Dim task = ObjectSpace.CreateObject(Of Task)()
				task.Subject = "Check reports"
				task.AssignedTo = employee
			End If
		End Sub
	End Class
End Namespace
