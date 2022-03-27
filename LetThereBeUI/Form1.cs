namespace LetThereBeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ButtonControl.RegisterAction("OK", () =>
            {
                if (TextBoxControl.TryGetValue("Username", out var username) && username == "user1" &&
                    TextBoxControl.TryGetValue("Password", out var password) && password == "thePassword" &&
                    TextBoxControl.TryGetValue("Captcha", out var captcha) && captcha == "qux64th")
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Something's wrong.");
                }
            });
        }

        Random Random = new Random();

        static ControlTypes[] Options = Enum.GetValues<ControlTypes>();
        static Dictionary<ControlTypes, Func<Control>> ControlFuncsDict = new()
        {
            [ControlTypes.Captcha] = () => new CaptchaControl(),
            [ControlTypes.Button] = () => new ButtonControl(),
            [ControlTypes.TextBox] = () => new TextBoxControl(),
        };

        private void LetThereBeUIB_Click(object sender, EventArgs e)
        {
            var r = Options[Random.Next(Options.Length)];
            

            var ctrl = ControlFuncsDict[r]();
            var point = LetThereBeUIB.Location;
            point.Offset(20, 20);
            ctrl.Location = point;
            ctrl.Parent = this;
        }
    }

    public enum ControlTypes
    {
        Captcha,
        Button,
        TextBox
    }
}