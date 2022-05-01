using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACS.Librairie
{
    public partial class UCClient : UserControlACS
    {
        public UCClient()
        {
            InitializeComponent();
            //lis =  Produit.Items();
            adgv.DataSource = Client.Items();
        }


    }
}
