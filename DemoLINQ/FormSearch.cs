using DemoWebhallenLambda.Classes;

namespace DemoWebhallenLambda
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();

            Repository repo = new Repository();

            foreach(string category in repo.GetCategories())
            {
                comboBox1.Items.Add(category);
            }
        }

        private void buttonLambda_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            string category = comboBox1.Text;
            string condition = textBox1.Text;
            int min = int.Parse(minprisTxt.Text);
            int max = int.Parse(maxprisTxt.Text);
            var result = Product.Search(category, condition, min, max);
            foreach (var p in result)
            {
                listBox1.Items.Add($"{p.Headline} {p.Price} {p.Category}");
            }
        }
    }
}
