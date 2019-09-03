﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToGoCompany.Forms.Views
{
    public partial class UcDashboard : UserControl
    {
        private static UcDashboard _instance;
        
        public UcDashboard()
        {
            InitializeComponent();
        }

        public static UcDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcDashboard();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
