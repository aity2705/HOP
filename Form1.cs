using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
//using OnBarcode.Barcode;

namespace HouseofPain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseConnection objConnect = new DatabaseConnection();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            Table<Mdetail> memberDetail = database.GetTable<Mdetail>();
            
            labelBooking.Text = "View and Manage bookings \n for trainer and classes.";
            labelpros.Text = "View and Manage sales \n prospects.";
            labeltask.Text = "Action items on your to do list.";
            labelpointsale.Text = "Sell a Product over the \n counter";
            labelreport.Text = "Financial reports and billing information.";
            buttonAdd.Text = "Add";
            buttonfind.Text = "Find";
            buttonbooking.Text = "Booking";
            buttonpros.Text = "Prospects";
            buttontask.Text = "Tasks";
            buttonlast.Text = "Last Visitors";
            buttonmake.Text = "Make a Sale";
            buttonreports.Text = "Reports";
            buttonbilling.Text = "Billing";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addmember _formAdd = new Addmember();
            _formAdd.Show();
           
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            Finduser _formFind = new Finduser();
            _formFind.Show();
        }
    }
}
