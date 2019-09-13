using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM.Helper
{
  public   class Utility
    {
        public static bool ValidateString(TextBox validator, ErrorProvider errorValidator, Label name, CancelEventArgs e)
        {
            string a = errorValidator.Container.Components.Count.ToString();
            if (string.IsNullOrEmpty(validator.Text.Trim()))
            {

                errorValidator.SetError(validator, name.Text + " is required.");
                e.Cancel = true;
                return false;
            }
            else
            {
                errorValidator.SetError(validator, string.Empty);
                e.Cancel = false;
                return true;
            }
        }
        public static bool ValidateDate(TextBox validator, ErrorProvider errorValidator, Label name, CancelEventArgs e)
        {

            if (!string.IsNullOrEmpty(validator.Text))
            {
                string[] formats = { "M/d/yyyy", "M/d/yy" };
                DateTime value;

                if (!DateTime.TryParseExact(validator.Text, formats, new CultureInfo("en-US"), DateTimeStyles.None, out value))
                {
                    errorValidator.SetError(validator, name.Text + " is required only date format.");
                    e.Cancel = true;
                    return false;

                }
                else
                {
                    errorValidator.SetError(validator, string.Empty);
                    e.Cancel = false;
                }
            }
            else
            {
                errorValidator.SetError(validator, name.Text + " is required.");
                e.Cancel = false;
                return false;
            }
            return true;

        }



        public static bool ValidateNumber(TextBox validator, ErrorProvider errorValidator, Label name, CancelEventArgs e)
        {
            decimal result;
            if (!decimal.TryParse(validator.Text, out result))
            {
                errorValidator.SetError(validator, name.Text + " is required only Number.");
               e.Cancel = true;
                return false;

            }
            else
            {
                errorValidator.SetError(validator, string.Empty);
                e.Cancel = false;
                return true;
            }

        }
    }
}
