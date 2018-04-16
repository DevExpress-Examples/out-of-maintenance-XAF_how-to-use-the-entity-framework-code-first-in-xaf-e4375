Imports System.Linq
Imports System.Data.Entity

Namespace MySolution.Module
	Public Class MyDbContext
		Inherits DbContext

		Public Sub New(ByVal connectionString As String)
			MyBase.New(connectionString)
		End Sub
		Public Property Employees() As DbSet(Of Employee)
		Public Property Tasks() As DbSet(Of Task)
		Public Property ModuleInfo() As DbSet(Of DevExpress.ExpressApp.EF.Updating.ModuleInfo)
	End Class
End Namespace
