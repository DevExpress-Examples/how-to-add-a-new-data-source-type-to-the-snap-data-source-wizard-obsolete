Imports CustomWizardExample.Wizard.Presenters
Imports CustomWizardExample.Wizard.Views
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.Snap.Services

Namespace CustomWizardExample.Wizard
    Public Class DataSourceWizardCustomizationService
        Implements IDataSourceWizardCustomizationService

        Public Sub CustomizeDataSourceWizard(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of DataSourceModel)) Implements IDataSourceWizardCustomizationService.CustomizeDataSourceWizard
            tool.WizardTitle = "Custom Data Source Wizard"

            tool.StartPage = GetType(CustomChooseDataSourceNamePage)
            tool.RegisterPage(Of CustomChooseDataSourceNamePage, CustomChooseDataSourceNamePage)()
            tool.RegisterPage(Of CustomChooseDataSourceTypePage, CustomChooseDataSourceTypePage)()
            tool.RegisterPage(Of ChoosePersonsPage, ChoosePersonsPage)()
            tool.RegisterPageView(Of IChooseDataSourceTypePageView, CustomChooseDataSourceTypePageView)()
            tool.RegisterPageView(Of IChoosePersonsPageView, ChoosePersonsPageView)()
        End Sub
    End Class
    Public Class CustomDataSourceType
        Inherits DataSourceType

        Public Shared ReadOnly XmlPersons As DataSourceType = New CustomDataSourceType()
    End Class
End Namespace
