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
        Private privateSubject As String
        Public Property Subject() As String
            Get
                Return privateSubject
            End Get
            Set(ByVal value As String)
                privateSubject = value
            End Set
        End Property
        Private privateDescription As String
        <FieldSize(FieldSizeAttribute.Unlimited)> _
        Public Property Description() As String
            Get
                Return privateDescription
            End Get
            Set(ByVal value As String)
                privateDescription = value
            End Set
        End Property
        Private privateAssignedTo As Employee
        Public Overridable Property AssignedTo() As Employee
            Get
                Return privateAssignedTo
            End Get
            Set(ByVal value As Employee)
                privateAssignedTo = value
            End Set
        End Property
    End Class
End Namespace
