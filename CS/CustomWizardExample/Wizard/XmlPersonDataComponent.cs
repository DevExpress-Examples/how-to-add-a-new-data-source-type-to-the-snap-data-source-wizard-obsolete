using System.Xml.Linq;
using System.Collections.Generic;
using DevExpress.DataAccess;

namespace CustomWizardExample.Wizard {
    public class XmlPersonDataComponent : List<Person>, IDataComponent {
        const string xmlPersonDataSource = "Persons";
        const string xml_Name = "Name";
        const string xml_Person = "Person";
        const string xml_FirstName = "FirstName";
        const string xml_SecondName = "SecondName";

        readonly string fileName;

        public XmlPersonDataComponent(string fileName) {
            this.fileName = fileName;
        }

        public string Name { get; set; }
        public string DataMember { get { return string.Empty; } }
        public string FileName { get { return fileName; } }

        public void Fill(IEnumerable<DevExpress.Data.IParameter> sourceParameters) {
            var root = XDocument.Load(this.fileName).Root;
            LoadFromXml(root);
        }
        public void LoadFromXml(XElement element) {
            Clear();
            string name = GetAttributeValue(element, xml_Name);
            if (!string.IsNullOrEmpty(name))
                Name = name;
            foreach (var item in element.Elements()) {
                var firstName = GetAttributeValue(item, "FirstName");
                var secondName = GetAttributeValue(item, "SecondName");
                var person = new Person() { FirstName = firstName, SecondName = secondName };
                Add(person);
            }
        }
        public XElement SaveToXml() {
            XElement element = new XElement(xmlPersonDataSource);

            if (!string.IsNullOrEmpty(Name))
                element.Add(new XAttribute(xml_Name, Name));
            foreach (var item in this) {
                XElement person = new XElement(xml_Person);
                person.Add(new XAttribute(xml_FirstName, item.FirstName));
                person.Add(new XAttribute(xml_SecondName, item.SecondName));
                element.Add(person);
            }

            return element;
        }
        string GetAttributeValue(XElement element, string attributeName) {
            XAttribute attrbute = element.Attribute(attributeName);
            return attrbute == null ? null : attrbute.Value;
        }
        
        public void Dispose() {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing) {
            //do nothing
        }
    }
}
