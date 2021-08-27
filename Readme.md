<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608510/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T310160)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomWizardExample/Form1.cs) (VB: [Form1.vb](./VB/CustomWizardExample/Form1.vb))
* [Person.cs](./CS/CustomWizardExample/Person.cs) (VB: [Person.vb](./VB/CustomWizardExample/Person.vb))
* [CustomDataSourceCreationService.cs](./CS/CustomWizardExample/Wizard/CustomDataSourceCreationService.cs) (VB: [CustomDataSourceCreationService.vb](./VB/CustomWizardExample/Wizard/CustomDataSourceCreationService.vb))
* [DataSourceWizardCustomizationService.cs](./CS/CustomWizardExample/Wizard/DataSourceWizardCustomizationService.cs) (VB: [DataSourceWizardCustomizationService.vb](./VB/CustomWizardExample/Wizard/DataSourceWizardCustomizationService.vb))
* [ChoosePersonsPage.cs](./CS/CustomWizardExample/Wizard/Presenters/ChoosePersonsPage.cs) (VB: [ChoosePersonsPage.vb](./VB/CustomWizardExample/Wizard/Presenters/ChoosePersonsPage.vb))
* [CustomChooseDataSourceNamePage.cs](./CS/CustomWizardExample/Wizard/Presenters/CustomChooseDataSourceNamePage.cs) (VB: [CustomChooseDataSourceNamePage.vb](./VB/CustomWizardExample/Wizard/Presenters/CustomChooseDataSourceNamePage.vb))
* [CustomChooseDataSourceTypePage.cs](./CS/CustomWizardExample/Wizard/Presenters/CustomChooseDataSourceTypePage.cs) (VB: [CustomChooseDataSourceTypePage.vb](./VB/CustomWizardExample/Wizard/Presenters/CustomChooseDataSourceTypePage.vb))
* [ChoosePersonsPageView.cs](./CS/CustomWizardExample/Wizard/Views/ChoosePersonsPageView.cs) (VB: [ChoosePersonsPageView.vb](./VB/CustomWizardExample/Wizard/Views/ChoosePersonsPageView.vb))
* [CustomChooseDataSourceTypePageView.cs](./CS/CustomWizardExample/Wizard/Views/CustomChooseDataSourceTypePageView.cs) (VB: [CustomChooseDataSourceTypePageView.vb](./VB/CustomWizardExample/Wizard/Views/CustomChooseDataSourceTypePageView.vb))
* [IChoosePersonsPageView.cs](./CS/CustomWizardExample/Wizard/Views/IChoosePersonsPageView.cs) (VB: [IChoosePersonsPageView.vb](./VB/CustomWizardExample/Wizard/Views/IChoosePersonsPageView.vb))
* [XmlPersonDataComponent.cs](./CS/CustomWizardExample/Wizard/XmlPersonDataComponent.cs) (VB: [XmlPersonDataComponent.vb](./VB/CustomWizardExample/Wizard/XmlPersonDataComponent.vb))
<!-- default file list end -->
# How to add a new data source type to the Data Source Wizard


This example demonstrates how to implement the <strong>DevExpress.Snap.Services.IDataSourceWizardCustomizationService</strong> interface and create a descendant of the <strong>DevExpress.Snap.Services.DataSourceCreationService</strong> class to add a new data source type to the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument15603">Data Source Wizard</a>, which allows end-users to establish a connection to an XML data file. <br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-new-data-source-type-to-the-data-source-wizard-t310160/16.1.4+/media/13d44a2d-879a-11e5-80bf-00155d62480c.png"><br />When end-users select the <strong>Xml Person</strong> item, the custom wizard page appears. On this page, end-users can select the XML file containing the required data, or load data from the predefined list.<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-new-data-source-type-to-the-data-source-wizard-t310160/16.1.4+/media/28f522d9-879a-11e5-80bf-00155d62480c.png"><br /><strong>See Also:</strong><br /><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument114899">How to customize the Data Source Wizard</a>

<br/>


