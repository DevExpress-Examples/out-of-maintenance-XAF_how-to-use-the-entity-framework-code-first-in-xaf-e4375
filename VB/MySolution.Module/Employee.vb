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
        Private privateFirstName As String
        Public Property FirstName() As String
            Get
                Return privateFirstName
            End Get
            Set(ByVal value As String)
                privateFirstName = value
            End Set
        End Property
        Private privateLastName As String
        Public Property LastName() As String
            Get
                Return privateLastName
            End Get
            Set(ByVal value As String)
                privateLastName = value
            End Set
        End Property
        Private privateBirthday? As Date
        Public Property Birthday() As Date?
            Get
                Return privateBirthday
            End Get
            Set(ByVal value? As Date)
                privateBirthday = value
            End Set
        End Property
        Private privateTasks As List(Of Task)
        Public Overridable Property Tasks() As List(Of Task)
            Get
                Return privateTasks
            End Get
            Set(ByVal value As List(Of Task))
                privateTasks = value
            End Set
        End Property
    End Class
End Namespace
