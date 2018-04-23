Imports DevExpress.DataAccess.Wizard.Views

Namespace CustomWizardExample.Wizard.Views
    Public Enum PersonSourceType
        [Static]
        XmlFilePath
    End Enum
    Public Interface IChoosePersonsPageView
        Inherits IWizardPageView

        Property XmlFilePath() As String
        Property PersonSourceType() As PersonSourceType
        Function ShowWarning() As Boolean
    End Interface
End Namespace
