Imports System.Linq
Imports System.Data.Entity

Namespace MySolution.Module
    Public Class MyDbContext
        Inherits DbContext

        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub
        Private privateEmployees As DbSet(Of Employee)
        Public Property Employees() As DbSet(Of Employee)
            Get
                Return privateEmployees
            End Get
            Set(ByVal value As DbSet(Of Employee))
                privateEmployees = value
            End Set
        End Property
        Private privateTasks As DbSet(Of Task)
        Public Property Tasks() As DbSet(Of Task)
            Get
                Return privateTasks
            End Get
            Set(ByVal value As DbSet(Of Task))
                privateTasks = value
            End Set
        End Property
    End Class
End Namespace
