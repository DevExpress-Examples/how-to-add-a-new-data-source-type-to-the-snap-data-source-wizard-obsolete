using DevExpress.DataAccess.Wizard.Views;

namespace CustomWizardExample.Wizard.Views {
    public enum PersonSourceType {
        Static,
        XmlFilePath
    }
    public interface IChoosePersonsPageView : IWizardPageView {
        string XmlFilePath { get; set; }
        PersonSourceType PersonSourceType { get; set; }
        bool ShowWarning();
    }
}
