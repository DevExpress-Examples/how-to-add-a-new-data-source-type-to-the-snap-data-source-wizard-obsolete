using System.Drawing;
using System.Reflection;
using DevExpress.XtraBars.Ribbon;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.DataAccess.Wizard.Services;

namespace CustomWizardExample.Wizard.Views {
    public class CustomChooseDataSourceTypePageView : ChooseDataSourceTypePageView {
        public CustomChooseDataSourceTypePageView(DataSourceTypes dataSourceTypes) : base(dataSourceTypes) { }
        protected override void InitializeGallery(GalleryItemGroup galleryItemGroup) {
            base.InitializeGallery(galleryItemGroup);
            GalleryItem galleryItem = new GalleryItem {
                Description = "Xml Person",
                Image = GetImage(),
                Tag = CustomDataSourceType.XmlPersons
            };
            galleryItemGroup.Items.Add(galleryItem);
        }
        Image GetImage() {
            string path = "CustomWizardExample.Wizard.Images.XmlBinding.png";
            return Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(path));
        }
    }
}
