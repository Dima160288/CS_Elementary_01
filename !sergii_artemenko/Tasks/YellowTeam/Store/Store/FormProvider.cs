using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    abstract class FormProvider
    {
        public static Form Form
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new Form();
                }
                return _form;
            }
        }
        private static Form _form;
    }
}
