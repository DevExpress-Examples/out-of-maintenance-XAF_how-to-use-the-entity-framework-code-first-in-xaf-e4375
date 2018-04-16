Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.EF


Namespace MySolution.Module
    Public NotInheritable Partial Class MySolutionModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
            ExportedTypeHelpers.AddExportedTypeHelper(GetType(EFExportedTypeHelperCF).FullName)
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Return ModuleUpdater.EmptyModuleUpdaters
        End Function
    End Class
End Namespace
