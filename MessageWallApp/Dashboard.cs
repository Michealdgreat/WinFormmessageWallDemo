using System.ComponentModel;

namespace MessageWallApp
{
    public partial class Dashboard : Form
    {

        BindingList<string> messages = new BindingList<string>();
      //  BindingList<int> Addit = new BindingList<int>();

        public Dashboard()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            MessageListBox.DataSource = messages;
            MessageListBox.DisplayMember = nameof(Dashboard.Text);

           // MessageListBox.DataSource = Addit;
            // MessageListBox. = nameof(Dashboard.Text);
        }

        private void MessageText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNametext.Text))
            {
                // Do something different
                MessageBox.Show("Please enter a message before adding", "Blank Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add($"Hi {FirstNametext.Text}, {LastNameText.Text}");
                //Addit.Add(Convert.ToInt32(Number1.Text) + Convert.ToInt32(Number2.Text));
                FirstNametext.Text = "";
                LastNameText.Text = "";


            }
           // FirstNametext.Focus();
            LastNameText.Focus(); // set focus of the keyboard to Lastname text field.

        }

        //private void Number1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Number2_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void MessageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Console.WriteLine(Addit);
            // Console.WriteLine(messages);
        }
    }
}