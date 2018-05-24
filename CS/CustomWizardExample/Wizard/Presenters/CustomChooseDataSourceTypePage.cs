using System.Collections.Generic;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.Entity.ProjectModel;
using System;
using DevExpress.DataAccess.Wizard.Services;

namespace CustomWizardExample.Wizard.Presenters {
    public class CustomChooseDataSourceTypePage : ChooseDataSourceTypePage<DataSourceModel> {
        public CustomChooseDataSourceTypePage(IChooseDataSourceTypePageView view, IWizardRunnerContext context, IConnectionStorageService connectionStorageService, ISolutionTypesProvider solutionTypesProvider, SqlWizardOptions options) : base(view, context, connectionStorageService, solutionTypesProvider, options)
        {
        }

        public override Type GetNextPageType() {
            if (View.DataSourceType == CustomDataSourceType.XmlPersons)
                return typeof(ChoosePersonsPage);
            return base.GetNextPageType();
        }
    }
}