Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.Base
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC

Namespace MySolution.Module
    <DefaultClassOptions, ImageName("BO_Task")>
    Public Class Task
        Private privateId As Integer
        <Browsable(False)>
        Public Property Id() As Integer
            Get
                Return privateId
            End Get
            Protected Set(ByVal value As Integer)
                privateId = value
            End Set
        End Property
        Public Property Subject() As String
        <FieldSize(FieldSizeAttribute.Unlimited)>
        Public Property Description() As String
        Public Overridable Property AssignedTo() As Employee
    End Class
End Namespace
