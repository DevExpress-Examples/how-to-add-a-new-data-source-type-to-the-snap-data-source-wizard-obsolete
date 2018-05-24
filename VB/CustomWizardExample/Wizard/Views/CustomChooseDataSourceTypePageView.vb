Imports System.Reflection
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.Utils.Svg

Namespace CustomWizardExample.Wizard.Views
    Public Class CustomChooseDataSourceTypePageView
        Inherits ChooseDataSourceTypePageView

        Public Sub New(ByVal dataSourceTypes As DataSourceTypes)
            MyBase.New(dataSourceTypes)
        End Sub

        Protected Overrides Sub AddGalleryItems(list As IList(Of GalleryItem))
            MyBase.AddGalleryItems(list)
            AddItem(list, "Xml Person", GetImage(), CustomDataSourceType.XmlPersons)
        End Sub

        Private Function GetImage() As SvgImage
            Dim path As String = "XmlBinding.svg"
            Return SvgImage.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
        End Function
    End Class
End Namespace
