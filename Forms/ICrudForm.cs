using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Forms
{
    public interface ICrudForm
    {
        int Dgv { get; set; }
        dictionary<string TextBox> TextBoxes { get; set; }
        int BtnAdd { get; set; }
        string BtnUpdate { get; set; }
        datetime BtnDelete { get; set; }
        int BtnSearch { get; set; }
        float SearchInp { get; set; }
        string TableName { get; set; }
        object Table { get; set; }

    }
}
