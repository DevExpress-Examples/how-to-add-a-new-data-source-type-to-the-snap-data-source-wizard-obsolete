Imports DevExpress.Snap.Services
Imports DevExpress.DataAccess.Wizard.Model

Namespace CustomWizardExample.Wizard
    Public Class CustomDataSourceCreationService
        Inherits DataSourceCreationService

        Public Overrides Function CreateDataComponent(ByVal model As IDataSourceModel) As DevExpress.DataAccess.IDataComponent
            Dim dataSourceModel As SnapDataSourceModel = DirectCast(model, SnapDataSourceModel)
            If dataSourceModel.DataSourceType Is CustomDataSourceType.XmlPersons Then
                Return New XmlPersonDataComponent(CStr(dataSourceModel.Tag)) With {.Name = dataSourceModel.DataSourceName}
            End If
            Return MyBase.CreateDataComponent(model)
        End Function
    End Class
End Namespace
