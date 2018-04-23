Imports DevExpress.Snap.Services
Imports CustomWizardExample.Wizard
Imports DevExpress.Office.Options

Namespace CustomWizardExample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            InitializeSnapControl()
        End Sub
        Private Sub InitializeSnapControl()
            snapControl.Text = "Click the ""Add New Data Source"" button to invoke the customized Data Source Wizard that allows you to establish a connection to an XML data file."
            snapControl.Options.DataSourceWizardOptions.DataSourceTypes = DataSourceTypes.Sql Or DataSourceTypes.Excel
            snapControl.AddService(GetType(IDataSourceWizardCustomizationService), New DataSourceWizardCustomizationService())
            snapControl.AddService(GetType(IDataSourceCreationService), New CustomDataSourceCreationService())
        End Sub
    End Class
End Namespace
