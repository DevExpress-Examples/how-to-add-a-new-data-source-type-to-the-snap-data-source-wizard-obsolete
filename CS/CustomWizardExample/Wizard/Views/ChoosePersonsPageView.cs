using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.UI.Wizard.Views;

namespace CustomWizardExample.Wizard.Views {
    public partial class ChoosePersonsPageView : WizardViewBase, IChoosePersonsPageView {

        public ChoosePersonsPageView() {
            InitializeComponent();
        }

        #region Implementation of IWizardPageView

        public override string HeaderDescription { get { return "Select one of data lists below"; } }

        #endregion

        #region Implementation of IChoosePersonsPageView

        public string XmlFilePath { get; set; }

        public PersonSourceType PersonSourceType {
            get {
                return this.rgDataSourceType.SelectedIndex == 0 ? PersonSourceType.XmlFilePath : PersonSourceType.Static;
            }
            set {
                if (value == PersonSourceType.XmlFilePath)
                    this.rgDataSourceType.SelectedIndex = 0;
                else
                    this.rgDataSourceType.SelectedIndex = 1;
            }
        }

        bool IChoosePersonsPageView.ShowWarning() {
            return XtraMessageBox.Show(LookAndFeel, this, "Use persons from the predefined list?", "Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        #endregion
    }
}
