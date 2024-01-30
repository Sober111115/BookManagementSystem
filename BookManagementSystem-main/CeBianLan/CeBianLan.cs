using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeBianLan
{
    public partial class CeBianLan : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public CeBianLan()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                       Primary.Grey700,
                       Primary.Grey900,
                       Primary.Grey600,
                       Accent.Amber400,
                       TextShade.WHITE);
        }
    }
}
