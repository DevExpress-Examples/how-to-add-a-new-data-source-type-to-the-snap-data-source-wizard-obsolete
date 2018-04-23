Imports DevExpress.Data.WizardFramework
Imports DevExpress.DataAccess.Wizard.Model
Imports CustomWizardExample.Wizard.Views
Imports System.Windows.Forms

Namespace CustomWizardExample.Wizard.Presenters
    Public Class ChoosePersonsPage
        Inherits WizardPageBase(Of IChoosePersonsPageView, DataSourceModel)

        Public Sub New(ByVal view As IChoosePersonsPageView)
            MyBase.New(view)
        End Sub

        Public Overrides Sub Begin()
            View.PersonSourceType = PersonSourceType.XmlFilePath
        End Sub

        Public Overrides Function Validate(<System.Runtime.InteropServices.Out()> ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty
            Dim result As Boolean = False
            If View.PersonSourceType = PersonSourceType.Static Then
                result = View.ShowWarning()
                If result Then
                    View.XmlFilePath = "Data.xml"
                End If
            Else
                Using dlg As New OpenFileDialog()
                    dlg.Filter = "XML Files|*.xml"
                    If dlg.ShowDialog() = DialogResult.OK Then
                        result = True
                        View.XmlFilePath = dlg.FileName
                    End If
                End Using
            End If
            Return result
        End Function

        Public Overrides Sub Commit()
            Model.Tag = View.XmlFilePath
            Model.DataSchema = New Person()
        End Sub
        Public Overrides ReadOnly Property MoveNextEnabled() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property FinishEnabled() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
