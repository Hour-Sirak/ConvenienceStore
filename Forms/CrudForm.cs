using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Forms
{
    public class CrudForm: ICrudForm
    {
        private void btnProAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new();
                db.InsertProduct(inpProName.Text, cbbProType.Text, float.Parse(inpProSalePrice.Text));
                updateProcductDGV();

                MessageBox.Show("Successfully added.", this.TableName + " record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to add record.", this.TableName + " record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}     
