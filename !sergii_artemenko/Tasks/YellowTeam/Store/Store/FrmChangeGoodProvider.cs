using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class FrmChangeGoodProvider
    {
        public static frmChangeGood FrmChangeGood
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new frmChangeGood();
                }
                return _form;
            }
        }
        private static frmChangeGood _form;
    }
}
