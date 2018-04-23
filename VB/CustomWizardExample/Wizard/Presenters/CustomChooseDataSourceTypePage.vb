Imports System.Collections.Generic
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.Entity.ProjectModel
Imports System

Namespace CustomWizardExample.Wizard.Presenters
    Public Class CustomChooseDataSourceTypePage
        Inherits ChooseDataSourceTypePage(Of DataSourceModel)

        Public Sub New(ByVal view As IChooseDataSourceTypePageView, ByVal context As IWizardRunnerContext, ByVal dataConnections As IEnumerable(Of SqlDataConnection), ByVal solutionTypesProvider As ISolutionTypesProvider, options As SqlWizardOptions)
            MyBase.New(view, context, dataConnections, solutionTypesProvider, options)
        End Sub
        Public Overrides Function GetNextPageType() As Type
            If View.DataSourceType Is CustomDataSourceType.XmlPersons Then
                Return GetType(ChoosePersonsPage)
            End If
            Return MyBase.GetNextPageType()
        End Function
    End Class
End Namespace