Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.EF
Imports System.Data.Entity


Namespace MySolution.Module
	Public NotInheritable Partial Class MySolutionModule
		Inherits ModuleBase

		Public Sub New()
			InitializeComponent()
			Database.SetInitializer(Of MyDbContext)(New DropCreateDatabaseIfModelChanges(Of MyDbContext)())
		End Sub
		Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
			Dim updater As ModuleUpdater = New Updater(objectSpace, versionFromDB)
			Return New ModuleUpdater() { updater }
		End Function
	End Class
End Namespace
