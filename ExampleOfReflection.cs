using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPatterns
{
    class ExampleOfReflection
    {
        public void ReflectionImplementation()
        {
            Type type = Type.GetType("DesignPatterns.HomeFacade");
            Console.WriteLine("fully classified class name = {0}", type.FullName);
            Console.WriteLine("only the class name = {0}", type.Name);
            Console.WriteLine("properties in " + type.Name + " class");
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property.PropertyType.Name + "   " + property.Name);
            }
        }
    }
}
