﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetThereBeUI
{
    public partial class CaptchaControl : DraggableControl
    {
        public CaptchaControl()
        {
            InitializeComponent();
            dragDropper = new(pictureBox1, this);
        }

        DragDropper dragDropper;
    }
}
