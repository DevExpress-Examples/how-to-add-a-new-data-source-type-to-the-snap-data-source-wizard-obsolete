using System.Drawing;
using System.Reflection;
using DevExpress.XtraBars.Ribbon;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.DataAccess.Wizard.Services;

namespace CustomWizardExample.Wizard.Views {
    public class CustomChooseDataSourceTypePageView : ChooseDataSourceTypePageView {
        public CustomChooseDataSourceTypePageView(DataSourceTypes dataSourceTypes) : base(dataSourceTypes) { }

        protected override void AddGalleryItems(System.Collections.Generic.IList<GalleryItem> list) {
            base.AddGalleryItems(list);
            AddItem(list, "Xml Person", GetImage(), CustomDataSourceType.XmlPersons);
        }

        Image GetImage() {
            string path = "CustomWizardExample.Wizard.Images.XmlBinding.png";
            return Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(path));
        }
    }
}
