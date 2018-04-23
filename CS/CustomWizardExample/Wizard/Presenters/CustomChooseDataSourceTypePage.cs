using System.Collections.Generic;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.Entity.ProjectModel;
using System;

namespace CustomWizardExample.Wizard.Presenters {
    public class CustomChooseDataSourceTypePage : ChooseDataSourceTypePage<DataSourceModel> {
        public CustomChooseDataSourceTypePage(IChooseDataSourceTypePageView view, IWizardRunnerContext context, IEnumerable<SqlDataConnection> dataConnections, ISolutionTypesProvider solutionTypesProvider, SqlWizardOptions options)
            : base(view, context, dataConnections, solutionTypesProvider, options) { }
        public override Type GetNextPageType() {
            if (View.DataSourceType == CustomDataSourceType.XmlPersons)
                return typeof(ChoosePersonsPage);
            return base.GetNextPageType();
        }
    }
}