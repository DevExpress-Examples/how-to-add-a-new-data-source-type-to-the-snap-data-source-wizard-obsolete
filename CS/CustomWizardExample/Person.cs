using System.ComponentModel;

namespace CustomWizardExample
{
    public class Person {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Second Name")]
        public string SecondName { get; set; }
    }
}
