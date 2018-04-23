using DevExpress.Data.WizardFramework;
using DevExpress.DataAccess.Wizard.Model;
using CustomWizardExample.Wizard.Views;
using System.Windows.Forms;
using DevExpress.Snap.Services;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChoosePersonsPage : WizardPageBase<IChoosePersonsPageView, DataSourceModel> {
        public ChoosePersonsPage(IChoosePersonsPageView view) : base(view) { }

        public override void Begin() {
            View.PersonSourceType = PersonSourceType.XmlFilePath;
        }

        public override bool Validate(out string errorMessage) {
            errorMessage = string.Empty;
            bool result = false;
            if (View.PersonSourceType == PersonSourceType.Static) {
                result = View.ShowWarning();
                if (result)
                    View.XmlFilePath = "Data.xml";
            }
            else {
                using (OpenFileDialog dlg = new OpenFileDialog()) {
                    dlg.Filter = "XML Files|*.xml";
                    if (dlg.ShowDialog() == DialogResult.OK) {
                        result = true;
                        View.XmlFilePath = dlg.FileName;
                    }
                }
            }
            return result;
        }

        public override void Commit() {
            SnapDataSourceModel snapDataSourceModel = (SnapDataSourceModel)Model;
            snapDataSourceModel.Tag = View.XmlFilePath;
            snapDataSourceModel.DataSchema = new Person();
        }
        public override bool MoveNextEnabled { get { return false; } }
        public override bool FinishEnabled { get { return true; } }
    }
}
