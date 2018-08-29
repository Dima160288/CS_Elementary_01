using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class FrmRegistrationProvider : FormProvider
    {
        public static frmRegistration FrmRegistration
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new frmRegistration();
                }
                return _form;
            }
        }
        private static frmRegistration _form;
    }
}
