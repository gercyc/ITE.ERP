﻿using ITE.Entidades.POCO.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSolution.Framework.BaseForms;

namespace ITEDesktop
{
    public partial class TraTesteView : ITSDBTransaction
    {
        public TraTesteView()
        {
            InitializeComponent();
            EFBindingNav.DataMember = "Produto";
        }
        public TraTesteView(Produto p) : this()
        {
            EFBindingNav.DataSource = p;
        }
    }
}
