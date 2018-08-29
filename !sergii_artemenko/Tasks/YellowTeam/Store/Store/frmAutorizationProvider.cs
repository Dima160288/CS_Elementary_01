using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    class FrmAutorizationProvider : FormProvider
    {
        public static frmAutorization FrmAutorization
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new frmAutorization();
                }
                return _form;
            }
        }
        private static frmAutorization _form;
    }
}
