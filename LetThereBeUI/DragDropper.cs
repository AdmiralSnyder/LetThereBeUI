namespace LetThereBeUI
{
    public class DragDropper
    {
        public DragDropper(Control dragControl, Control parent)
        {
            DragControl = dragControl;
            ParentControl = parent;
            DragControl.MouseUp += DragControl_MouseUp;
            DragControl.MouseDown += DragControl_MouseDown;
            DragControl.MouseMove += DragControl_MouseMove;
        }

        public Control DragControl { get; private set; }
        public Control ParentControl { get; private set; }


        Point DragStartPoint;
        Point DragLocationOffset;
        bool Dragging = false;

        private void DragControl_MouseDown(object sender, MouseEventArgs e)
        {
            DragStartPoint = Control.MousePosition;

            DragLocationOffset = new(-e.Location.X, -e.Location.Y);
            Dragging = true;
        }

        private void DragControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                var senderCtrl = ((Control)sender);
                var point = e.Location;
                point = senderCtrl.PointToScreen(point);
                point = ParentControl.Parent.PointToClient(point);

                point.Offset(DragLocationOffset);
                ParentControl.Location = point;
            }
        }

        private void DragControl_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }
}
