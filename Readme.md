<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608510/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T310160)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to add a new data source type to the Data Source Wizard


This example demonstrates how to implement the <strong>DevExpress.Snap.Services.IDataSourceWizardCustomizationService</strong> interface and create a descendant of the <strong>DevExpress.Snap.Services.DataSourceCreationService</strong> class to add a new data source type to the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument15603">Data Source Wizard</a>, which allows end-users to establish a connection to an XML data file. <br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-new-data-source-type-to-the-data-source-wizard-t310160/18.1.3+/media/13d44a2d-879a-11e5-80bf-00155d62480c.png"><br />When end-users select the <strong>Xml Person</strong> item, the custom wizard page appears. On this page, end-users can select the XML file containing the required data, or load data from the predefined list.<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-new-data-source-type-to-the-data-source-wizard-t310160/18.1.3+/media/28f522d9-879a-11e5-80bf-00155d62480c.png"><br /><strong>See Also:</strong><br /><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument114899">How to customize the Data Source Wizard</a>

<br/>


