using System;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Services;

namespace CustomWizardExample.Wizard.Presenters {
    public class CustomChooseDataSourceNamePage : ChooseDataSourceNamePage<DataSourceModel> {
        public CustomChooseDataSourceNamePage(IChooseDataSourceNamePageView view, IDataSourceNameCreationService dataSourceNameCreator) 
            : base(view, dataSourceNameCreator) { }
        public override Type GetNextPageType() {
            return typeof(CustomChooseDataSourceTypePage);
        }
    }
}
