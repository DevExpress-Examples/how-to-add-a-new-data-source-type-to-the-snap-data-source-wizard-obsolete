Imports System.Reflection
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.DataAccess.Wizard.Services

Namespace CustomWizardExample.Wizard.Views
    Public Class CustomChooseDataSourceTypePageView
        Inherits ChooseDataSourceTypePageView

        Public Sub New(ByVal dataSourceTypes As DataSourceTypes)
            MyBase.New(dataSourceTypes)
        End Sub
        Protected Overrides Sub InitializeGallery(ByVal galleryItemGroup As GalleryItemGroup)
            MyBase.InitializeGallery(galleryItemGroup)
            Dim galleryItem As GalleryItem = New GalleryItem With {.Description = "Xml Person", .Image = GetImage(), .Tag = CustomDataSourceType.XmlPersons}
            galleryItemGroup.Items.Add(galleryItem)
        End Sub
        Private Function GetImage() As Image
            Dim path As String = "XmlBinding.png"
            Return Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
        End Function
    End Class
End Namespace
