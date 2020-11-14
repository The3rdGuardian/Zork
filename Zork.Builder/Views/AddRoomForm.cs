using System.Windows.Forms;

namespace Zork.Builder.Views
{
    public partial class AddRoomForm : Form
    {

        public string RoomName
        {
            get => RoomNameTextbox.Text;
            set => RoomNameTextbox.Text = value;
        }
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void RoomNameTextbox_TextChanged(object sender, System.EventArgs e)
        {
            OkButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
