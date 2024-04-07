using System.Diagnostics;

namespace ProjectJsonToCsvConverter
{
    public partial class JsonToCsvForm : Form
    {
        public JsonToCsvForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var userIntput = $"{textBoxUserInput.Text}/";

            try
            {
                JsonToCsv.CheckUserInput(userIntput);
                textBoxJson.Text = JsonToCsv.GetJson(userIntput);
            }
            catch (Exception ex)
            {
                DisplayInvalidInputMessage(ex.Message, "Error");
                return;
            }


        }

        private void DisplayInvalidInputMessage(string message, string v)
        {
            MessageBox.Show(message, v);
        }

        private void textBoxJson_TextChanged(object sender, EventArgs e)
        {
            btnConvert.Visible = true;
            btnConvert.Focus();
            textBoxCsv.Clear();
        }
    }
}
