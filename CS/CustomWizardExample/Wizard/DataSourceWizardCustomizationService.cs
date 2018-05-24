using CustomWizardExample.Wizard.Presenters;
using CustomWizardExample.Wizard.Views;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.Snap.Services;

namespace CustomWizardExample.Wizard {
    public class DataSourceWizardCustomizationService : IDataSourceWizardCustomizationService {
        public void CustomizeDataSourceWizard(DevExpress.DataAccess.UI.Wizard.IWizardCustomization<DevExpress.DataAccess.Wizard.Model.DataSourceModel> tool) {
            tool.WizardTitle = "Custom Data Source Wizard";

            tool.StartPage = typeof(CustomChooseDataSourceNamePage);
            tool.RegisterPage<CustomChooseDataSourceNamePage, CustomChooseDataSourceNamePage>();
            tool.RegisterPage<CustomChooseDataSourceTypePage, CustomChooseDataSourceTypePage>();
            tool.RegisterPage<ChoosePersonsPage, ChoosePersonsPage>();
            tool.RegisterPageView<IChooseDataSourceTypePageView, CustomChooseDataSourceTypePageView>();
            tool.RegisterPageView<IChoosePersonsPageView, ChoosePersonsPageView>();
        }
    }
    public class CustomDataSourceType : DataSourceType {
        public static readonly DataSourceType XmlPersons = new CustomDataSourceType();
    }
}
