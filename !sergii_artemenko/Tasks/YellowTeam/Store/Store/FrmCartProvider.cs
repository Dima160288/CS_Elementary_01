using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class FrmCartProvider
    {
        public static frmCart FrmCart
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new frmCart();
                }
                return _form;
            }
        }
        private static frmCart _form;
    }
}
