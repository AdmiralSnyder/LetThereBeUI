using System;
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
    public partial class ButtonControl : DraggableControl
    {
        private static Dictionary<string, Action> TitleActions = new();

        public static void RegisterAction(string title, Action action) => TitleActions.Add(title, action);

        public ButtonControl()
        {
            InitializeComponent();
            TitleTB.Focus();
            dragDropper2 = new(button1, this);
        }

        DragDropper dragDropper2;

        private ButtonControlStates State = ButtonControlStates.New;

        private void button1_Click(object sender, EventArgs e)
        {
            if (State == ButtonControlStates.New)
            {
                TitleTB.Focus();
            }
            else if (State == ButtonControlStates.TextAssigned)
            {
                if (TitleActions.TryGetValue(button1.Text, out var action))
                {
                    action();
                }
            }
        }

        private void TitleTB_TextChanged(object sender, EventArgs e)
        {
            button1.Text = TitleTB.Text;
        }

        private void TitleTB_Leave(object sender, EventArgs e)
        {
            TitleTB.Visible = false;
            State = ButtonControlStates.TextAssigned;
        }

        public Action OkAction { get; set; }

        private void ButtonControl_DoubleClick(object sender, EventArgs e)
        {
            TitleTB.Visible = true;
            TitleTB.Focus();
        }
    }

    public enum ButtonControlStates
    {
        New,
        TextAssigned,
    }
}
