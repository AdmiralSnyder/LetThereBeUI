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
    public partial class TextBoxControl : DraggableControl
    {
        public static bool TryGetValue(string title, out string? value)
        {
            foreach (var tbc in TextBoxControls)
            {
                if (tbc.label1.Text == title)
                {
                    value = tbc.ContentTB.Text;
                    return true;
                }
            }
            value = default;
            return false;
        }

        public static Dictionary<string, (Action<TextBoxControl> AddAction, Action<TextBoxControl> RemoveAction)> TitleAction = new()
        {
            ["Password"] = (tb => tb.ContentTB.PasswordChar = '*', tb => tb.ContentTB.PasswordChar = '\0'),
        };

        public static List<TextBoxControl> TextBoxControls = new();

        public TextBoxControl()
        {
            InitializeComponent();

            DragDropper1 = new(label1, this);
            DragDropper2 = new(LabelTB, this);
            DragDropper3 = new(ContentTB, this);

            TextBoxControls.Add(this);
        }

        DragDropper DragDropper1 { get; set; }
        DragDropper DragDropper2 { get; set; }
        DragDropper DragDropper3 { get; set; }

        private void LabelTB_Leave(object sender, EventArgs e)
        {
            string oldValue = label1.Text;
            string newValue = LabelTB.Text;
            if (oldValue != newValue)
            {
                if (TitleAction.TryGetValue(oldValue, out var actions))
                {
                    actions.RemoveAction(this);
                }

                label1.Text = LabelTB.Text;
                
                if (TitleAction.TryGetValue(newValue, out actions))
                {
                    actions.AddAction(this);
                }
                LabelTB.Visible = false;
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            LabelTB.Visible = true;
            LabelTB.Focus();
        }
    }
}
