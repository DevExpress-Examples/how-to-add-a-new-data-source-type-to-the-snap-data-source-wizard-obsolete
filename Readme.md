# How to add a new data source type to the Data Source Wizard

> **Note**
>
> As you may already know, the [WinForms Snap control](https://docs.devexpress.com/WindowsForms/11373/controls-and-libraries/snap) and [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api) are now in maintenance support mode. No new features or capabilities are incorporated into these products. We recommend that you use [DevExpress Reporting](https://docs.devexpress.com/XtraReports/2162/reporting) tool to generate, edit, print, and export your business reports/documents.

This example demonstrates how to implement the <strong>DevExpress.Snap.Services.IDataSourceWizardCustomizationService</strong> interface and create a descendant of the <strong>DevExpress.Snap.Services.DataSourceCreationService</strong> class to add a new data source type to the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument15603">Data Source Wizard</a>, which allows end-users to establish a connection to an XML data file. <br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-new-data-source-type-to-the-data-source-wizard-t310160/18.1.3+/media/13d44a2d-879a-11e5-80bf-00155d62480c.png"><br />When end-users select the <strong>Xml Person</strong> item, the custom wizard page appears. On this page, end-users can select the XML file containing the required data, or load data from the predefined list.<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-new-data-source-type-to-the-data-source-wizard-t310160/18.1.3+/media/28f522d9-879a-11e5-80bf-00155d62480c.png"><br /><strong>See Also:</strong><br /><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument114899">How to customize the Data Source Wizard</a>

<br/>


