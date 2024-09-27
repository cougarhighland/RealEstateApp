using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_
{
    public enum FormType
    {
        Ownership,
        Tenement,
        Rental
    }
    public class LegalForm
    {
        private FormType form;

        public FormType Form { get { return form; } set { form = value; } }
    }
}
