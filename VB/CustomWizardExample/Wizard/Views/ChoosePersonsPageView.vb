Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess.UI.Wizard.Views

Namespace CustomWizardExample.Wizard.Views
    Partial Public Class ChoosePersonsPageView
        Inherits WizardViewBase
        Implements IChoosePersonsPageView

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "Implementation of IWizardPageView"

        Public Overrides ReadOnly Property HeaderDescription() As String
            Get
                Return "Select one of data lists below"
            End Get
        End Property

        #End Region

        #Region "Implementation of IChoosePersonsPageView"

        Public Property XmlFilePath() As String Implements IChoosePersonsPageView.XmlFilePath

        Public Property PersonSourceType() As PersonSourceType Implements IChoosePersonsPageView.PersonSourceType
            Get
                Return If(Me.rgDataSourceType.SelectedIndex = 0, PersonSourceType.XmlFilePath, PersonSourceType.Static)
            End Get
            Set(ByVal value As PersonSourceType)
                If value = PersonSourceType.XmlFilePath Then
                    Me.rgDataSourceType.SelectedIndex = 0
                Else
                    Me.rgDataSourceType.SelectedIndex = 1
                End If
            End Set
        End Property

        Private Function IChoosePersonsPageView_ShowWarning() As Boolean Implements IChoosePersonsPageView.ShowWarning
            Return XtraMessageBox.Show(LookAndFeel, Me, "Use persons from the predefined list?", "Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes
        End Function

        #End Region
    End Class
End Namespace
