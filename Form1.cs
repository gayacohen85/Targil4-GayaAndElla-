namespace Targil4._2_GayaAndElla_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void viewSysremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;
            viewForm.Show();
        }
    }
}
