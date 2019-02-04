using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatterns
{
    class AnnotationPrograms
    {

        private string name { get; set; }
        [Required(ErrorMessage = "this field is mandatory")]       
        [RegularExpression(@"[a-zA-Z]{3,25}")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public void ValidationOfAnnotation()
        {
            try
            {
                Console.WriteLine("enter name");
                string name = Console.ReadLine();
                AnnotationPrograms annotation = new AnnotationPrograms();
                annotation.name = name;
                ValidationContext validation = new ValidationContext(annotation, null, null);
                var result = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(annotation, validation, result, true);
                Console.WriteLine(isValid);  
                foreach (var message in result)
                {
                    Console.WriteLine(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }  

   
}
