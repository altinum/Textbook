namespace TextBook
{
    public partial class Form1 : Form
    {

        Models.TextbookSupportContext context = new Models.TextbookSupportContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = context.Students.ToList();
            textbookBindingSource.DataSource = context.Textbooks.ToList();

        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            var sf = from x in context.Students
                     where x.Name.Contains(txtStudent.Text)
                     select x;

            studentBindingSource.DataSource = sf.ToList();
        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (studentBindingSource.Current == null) return;

            var ssssss = studentBindingSource.Current as Models.Student;

            var llllll = from x in context.Orders
                         where x.StudentFk == ssssss.StudentId
                         select new Osztály
                         {
                             Rendelésazonos0tó = x.OrderSk,
                             Könyvc0m = x.TextbookFkNavigation.Title
                         };

            osztályBindingSource.DataSource = llllll.ToList();
           

           



        }
    }
}
