
namespace WDproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Company
    {
        private string name;

        public Company(string name)
        {
            this.Name = name;
        }


        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The company name can not be blank!!!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
