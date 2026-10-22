using System.Diagnostics;
using System.Xml.Linq;

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

        void ListOrders()
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


            var sumOfOrders = (from x in context.Orders
                               where x.StudentFk == ssssss.StudentId
                               select x.TextbookFkNavigation.Price).Sum();

            textBoxSunOfOrders.Text = sumOfOrders.ToString();

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ListOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = studentBindingSource.Current as Models.Student;
            var t = textbookBindingSource.Current as Models.Textbook;

            if (t == null || s == null) return;

            var o = new Models.Order();

            o.StudentFk = s.StudentId;
            o.TextbookFk = t.TextbookId;

            context.Orders.Add(o);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while saving changes: " + ex.Message);
            }

            ListOrders();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var o = osztályBindingSource.Current as Osztály;

            if (o == null) return;

            var orderToDelete = from x in context.Orders
                                where x.OrderSk == o.Rendelésazonos0tó
                                select x;

            try
            {
                context.Orders.Remove(orderToDelete.FirstOrDefault());
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting order: " + ex.Message);
            }


            ListOrders();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddStudent fac = new FormAddStudent();
            if (fac.ShowDialog() == DialogResult.OK)
            {
                context.Students.Add(fac.NewSudent);
                context.SaveChanges();

                studentBindingSource.DataSource = context.Students.ToList();


                MessageBox.Show(":)");
            }



        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XDocument xdoc = new XDocument();
                xdoc.Declaration = new XDeclaration("1.0", "utf-8", "yes");

                XElement rootElement = new XElement("students");
                xdoc.Add(rootElement);

                var studentList = context.Students.ToList();

                foreach (var student in studentList)
                {
                    XElement studentElement = new XElement("student");
                    rootElement.Add(studentElement);

                    XElement nameElement = new XElement("name");
                    nameElement.Value = student.Name??"n/a";
                    studentElement.Add(nameElement);

                    XElement neptunElement = new XElement("neptun");
                    neptunElement.Value = student.Neptun??"nincs megadva";
                    studentElement.Add(neptunElement);

                    var ordersOfStudent = from x in context.Orders
                                          where x.StudentFk == student.StudentId
                                          select new { x.TextbookFkNavigation.Title };

                    XElement ordersElement = new XElement("orders");
                    studentElement.Add(ordersElement);

                    foreach (var order in ordersOfStudent)
                    {
                        XElement orderElement = new XElement("order"); //order itt egyes számban van
                        orderElement.Value = order.Title??string.Empty;
                        ordersElement.Add(orderElement);
                    }

                }

                xdoc.Save(sfd.FileName);
                MessageBox.Show("Ok");




            }

        }
    }
}
