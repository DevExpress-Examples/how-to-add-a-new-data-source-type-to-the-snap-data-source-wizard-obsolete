Imports System.ComponentModel

Namespace CustomWizardExample
    Public Class Person
        <DisplayName("First Name")> _
        Public Property FirstName() As String
        <DisplayName("Second Name")> _
        Public Property SecondName() As String
    End Class
End Namespace
