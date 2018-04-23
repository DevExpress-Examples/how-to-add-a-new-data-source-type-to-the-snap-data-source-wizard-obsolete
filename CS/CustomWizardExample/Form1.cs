using DevExpress.Snap.Services;
using CustomWizardExample.Wizard;
using DevExpress.Office.Options;

namespace CustomWizardExample
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1() {
            InitializeComponent();
            InitializeSnapControl();
        }
        void InitializeSnapControl() {
            snapControl.Text = "Click the \"Add New Data Source\" button to invoke the customized Data Source Wizard that allows you to establish a connection to an XML data file.";
            snapControl.Options.DataSourceWizardOptions.DataSourceTypes = DataSourceTypes.Sql | DataSourceTypes.Excel;
            snapControl.AddService(typeof(IDataSourceWizardCustomizationService), new DataSourceWizardCustomizationService());
            snapControl.AddService(typeof(IDataSourceCreationService), new CustomDataSourceCreationService());
        }
    }
}
