using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesTrial
{
    internal class FetchCustomAttributeValues
    {
        
        static void Main()
        {
            Type t = typeof(CustomAttribute);

           
            CustomAttribute author = (CustomAttribute)Attribute.GetCustomAttribute(t, typeof(CustomAttribute));

            if (author != null)
            {
                Console.WriteLine("Author Name: " + author.DeveloperName);
                Console.WriteLine("Version: " + author.Version);
            }
            else
            {
                Console.WriteLine("No Author attribute found.");
            }
        }
    }


}
