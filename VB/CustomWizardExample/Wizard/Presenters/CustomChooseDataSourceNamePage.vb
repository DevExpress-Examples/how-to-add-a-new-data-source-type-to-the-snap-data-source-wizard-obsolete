Imports System
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Services

Namespace CustomWizardExample.Wizard.Presenters
    Public Class CustomChooseDataSourceNamePage
        Inherits ChooseDataSourceNamePage(Of DataSourceModel)

        Public Sub New(ByVal view As IChooseDataSourceNamePageView, ByVal dataSourceNameCreator As IDataSourceNameCreationService)
            MyBase.New(view, dataSourceNameCreator)
        End Sub
        Public Overrides Function GetNextPageType() As Type
            Return GetType(CustomChooseDataSourceTypePage)
        End Function
    End Class
End Namespace
