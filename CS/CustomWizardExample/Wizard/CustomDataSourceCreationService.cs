using DevExpress.Snap.Services;
using DevExpress.DataAccess.Wizard.Model;

namespace CustomWizardExample.Wizard {
    public class CustomDataSourceCreationService : DataSourceCreationService {
        public override DevExpress.DataAccess.IDataComponent CreateDataComponent(IDataSourceModel model) {
            SnapDataSourceModel dataSourceModel = (SnapDataSourceModel)model;
            if (dataSourceModel.DataSourceType == CustomDataSourceType.XmlPersons)
                return new XmlPersonDataComponent((string)dataSourceModel.Tag) { Name = dataSourceModel.DataSourceName };
            return base.CreateDataComponent(model);
        }
    }
}
