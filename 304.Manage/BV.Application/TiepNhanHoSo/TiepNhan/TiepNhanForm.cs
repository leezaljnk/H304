﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.TiepNhanHoSo
{
    public partial class TiepNhanForm : Form
    {
        public TiepNhanForm()
        {
            InitializeComponent();
        }

        public void InitThongTin()
        {
            ctrPhieuTiepNhan.InitControlUI();
        }
    }
}