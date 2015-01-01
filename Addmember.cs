using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace HouseofPain
{
    public partial class Addmember : Form
    {
        public Addmember()
        {
            InitializeComponent();
            refresh();
            disableShip();
        }
        public Addmember(String _fname)
        {
            InitializeComponent();
            //refresh();
           // disableShip();
            search_Record(_fname);
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lastBox.Text = "";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Addmember_Load(object sender, EventArgs e)
        {
            lastBox.Select();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dpBox_Click(object sender, EventArgs e)
        {
            openImageDialog.ShowDialog();
            string _image = openImageDialog.FileName;
            dpBox.ImageLocation = _image;
            dpBox.Refresh();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Finduser _newform = new Finduser();
            _newform.Show();

        }

        private void savebioButton_Click(object sender, EventArgs e)
        {
            if (!isReady())
                MessageBox.Show("Invalid Details! Please Check");
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                Table<Mdetail> _memberTable = db.GetTable<Mdetail>();
                Mdetail _newMember = new Mdetail();
                _newMember.IDD = kryptonTextBox1.Text;
                _newMember.lname = lastBox.Text;
                _newMember.fname = firstBox.Text;
                _newMember.city = cityBox.Text;
                if (kryptonRadioButton1.Checked)
                    _newMember.gender = "1";
                if(kryptonRadioButton2.Checked)
                    _newMember.gender = "2";
                _newMember.cardn = cardBox.Text;
                _newMember.cell = kryptonTextBox2.Text; //wphoneBox.Clear();
                _newMember.email = emailBox.Text;
                _newMember.invtype = invCombo.Text;
                _newMember.occu = occBox.Text;
                try
                {
                    _newMember.photo = dpBox.ImageLocation.ToString();
                }
                catch (Exception ex)
                {
                    //donothing
                }
                _newMember.ptrain = ptCombo.Text;
                _newMember.dop = dobBox.Text;
                _newMember.street = streetBox.Text;
                _newMember.home = phoneBox.Text;
                _newMember.workp = wphoneBox.Text;
                _memberTable.InsertOnSubmit(_newMember);
                db.SubmitChanges();
               // refresh();
            }
        }

        private void lastBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                firstBox.Select();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Attendance _newForm = new Attendance();
            _newForm.Show();
        }

        private void sEngineBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Record(sEngineBox.Text);
            }
        }
        void search_Record(String _txtName)
        {
            kryptonDataGridView1.Rows.Clear();
            int _tempId = 0;
            DataClasses1DataContext _database = new DataClasses1DataContext();
            Table<Mdetail> _Mdetail = _database.GetTable<Mdetail>();
            IQueryable<Mdetail> ItemQuery = from Item in _Mdetail

                                            where Item.fname.Contains(sEngineBox.Text)
                                            select Item;
           // if(ItemQuery.ElementAt(0).fname!="")
            foreach (Mdetail Item in ItemQuery)
            {
             //   kryptonDataGridView1.Rows.Add(i++.ToString(), Item.fname, Item.cardn, Item.home, Item.cell, Item.street, Item.email);
                lastBox.Text = Item.lname;
                firstBox.Text = Item.fname;
                cityBox.Text = Item.city; 
                cardBox.Text = Item.cardn;
                kryptonTextBox2.Text = Item.cell;
                dobBox.Text = Item.dop;
                if (Item.gender.Contains("1"))
                    kryptonRadioButton1.Checked = true;
                if (Item.gender.Contains("2"))
                    kryptonRadioButton2.Checked = true;
                wphoneBox.Text = Item.cell; //wphoneBox.Clear();
                phoneBox.Text = Item.home;
                emailBox.Text = Item.email;
                invCombo.Text = Item.invtype;
                occBox.Text = Item.occu;
                ptCombo.Text = Item.ptrain;
                dpBox.ImageLocation = Item.photo;
                dpBox.Refresh();
                streetBox.Text = Item.street; 
                wphoneBox.Text = Item.workp;
                kryptonTextBox1.Text = Item.IDD;
                _tempId = Convert.ToInt32(Item.IDD);
            }
            Table<Mship> _Mship = _database.GetTable<Mship>();
            IQueryable<Mship> MshipQuery = from Item in _Mship

                                            where (Convert.ToInt32(Item.IDD) == _tempId)
                                            select Item;
            foreach (Mship ship in MshipQuery)
            {
                kryptonDataGridView1.Rows.Add(ship.pg,ship.programme,ship.sdate,ship.edate,ship.nvisits,ship.state,ship.medate);
            }

        }

        private void snextButton_Click(object sender, EventArgs e)
        {

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        void refresh()
        {
            lastBox.Clear();
             firstBox.Clear();
             cityBox.Clear();
             cardBox.Clear();
             emailBox.Clear();
             streetBox.Clear();
             wphoneBox.Clear();
             phoneBox.Clear();
             dobBox.Clear();
             kryptonTextBox2.Clear();
             occBox.Clear();
             DataClasses1DataContext _database = new DataClasses1DataContext();
             Table<Mdetail> _Mdetail = _database.GetTable<Mdetail>();
             IQueryable<Mdetail> ItemQuery = from Item in _Mdetail
                                             select Item;
                foreach(Mdetail Item in ItemQuery){
                //Add the MemberShip ID here
                   int _temp = Convert.ToInt32(Item.IDD);
                    _temp++;
                    kryptonTextBox1.Text = Convert.ToString(_temp);
                }
        }
        bool isReady()
        {
            if (lastBox.Text != "" && firstBox.Text != "" && kryptonTextBox1.Text != "")
                return true;
            else
                return false;
           
        }

        private void addmShipButton_Click(object sender, EventArgs e)
        {
            enableShip();
        }
        void enableShip()
        {
            pgroupCombo.Enabled = true;
            pcombo.Enabled = true;
            sdateBox.Enabled = true;
            ppriceBox.Enabled = true;
            conditonsBox.Enabled = true;
            cardnumberBox.Enabled = true;
            spfeeBox.Enabled = true;
            vistsBox.Enabled = true;
            kryptonDataGridView1.Enabled = true;
            //For Current Date
            sdateBox.Text = Convert.ToString(DateTime.Now.Date.ToShortDateString());

        }
        void disableShip()
        {
            pgroupCombo.Enabled = false;
            pcombo.Enabled = false;
            sdateBox.Enabled = false;
            ppriceBox.Enabled = false;
            conditonsBox.Enabled = false;
            cardnumberBox.Enabled = false;
            spfeeBox.Enabled = false;
            vistsBox.Enabled = false;
            kryptonDataGridView1.Enabled = false;

        }

        private void saveAccountsButton_Click(object sender, EventArgs e)
        {
            if (ppriceBox.Text != "")
            {
                String pcText = pcombo.Text;
                String pgText = pgroupCombo.Text;
                DataClasses1DataContext _database = new DataClasses1DataContext();
                Table<Mship> _Mship = _database.GetTable<Mship>();
                Mship _newMship = new Mship();
                _newMship.programme = pcText;
                _newMship.pg = pgText;
                _newMship.sdate = sdateBox.Text;
                _newMship.price = ppriceBox.Text;
                _newMship.conditions = conditonsBox.Text;
                _newMship.IDD = kryptonTextBox1.Text;
                if(pcText == "1 Month")
                    _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(1).ToShortDateString());
                    if(pcText == "3 Month")
                        _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(3).ToShortDateString());
                        if(pcText == "6 Month")
                            _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(6).ToShortDateString());
                            if(pcText == "Annual Basis")
                                _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(12).ToShortDateString());
                           
               
                _newMship.nvisits = vistsBox.Text;
                _newMship.sfee = spfeeBox.Text;
                _Mship.InsertOnSubmit(_newMship);
                _database.SubmitChanges();
                clearMship();
                disableShip();
            }
            else
                MessageBox.Show("Please Enter the Payments!");
        }

        private void clearMship()
        {
            pgroupCombo.Refresh();
            pgroupCombo.ResetText();
            //pcombo.Text = "";
            sdateBox.Text = "";
            ppriceBox.Text = "";
            conditonsBox.Text = "";
            cardnumberBox.Text = "";
            spfeeBox.Text = "";
            vistsBox.Text = "";
        }

        private void editmShipButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext _database = new DataClasses1DataContext();
            //Table<Mship> _Mship = _database.GetTable<Mship>();
            // Mship _newMship = new Mship();

            var cityNameQuery =
    from mem in _database.Mships
    where mem.Id == Convert.ToInt32(cardnumberBox.Text)
    select mem;
            foreach (var customer in cityNameQuery)
            {
                String pcText = pcombo.Text;
                String pgText = pgroupCombo.Text;
                customer.programme = pcText;
                customer.pg = pgText;
                customer.sdate = sdateBox.Text;
                customer.price = ppriceBox.Text;
                customer.conditions = conditonsBox.Text;
                customer.IDD = kryptonTextBox1.Text;
                if (pcText == "1 Month")
                    customer.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(1).ToShortDateString());
                if (pcText == "3 Month")
                    customer.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(3).ToShortDateString());
                if (pcText == "6 Month")
                    customer.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(6).ToShortDateString());
                if (pcText == "Annual Basis")
                    customer.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(12).ToShortDateString());


                customer.nvisits = vistsBox.Text;
                customer.sfee = spfeeBox.Text;
            }
            // _Mship.InsertOnSubmit(customer);
            _database.SubmitChanges();
            clearMship();
            disableShip();
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataClasses1DataContext _database = new DataClasses1DataContext();
            //Table<Mship> _Mship = _database.GetTable<Mship>();
           // Mship _newMship = new Mship();
          
            var cityNameQuery =
    from mem in _database.Mships
    where mem.IDD == kryptonTextBox1.Text
    select mem;

           DataGridViewRow _tempRow = kryptonDataGridView1.Rows[e.RowIndex];

           foreach (var customer in cityNameQuery)
           {
               if (customer.pg == _tempRow.Cells[0].Value.ToString() && customer.programme == _tempRow.Cells[1].Value.ToString() && customer.sdate == _tempRow.Cells[2].Value.ToString())
               {
                   pcombo.Text = customer.programme;
                   pgroupCombo.Text = customer.pg;
                   sdateBox.Text = customer.sdate;
                   ppriceBox.Text = customer.price;
                   conditonsBox.Text = customer.conditions;
                   cardnumberBox.Text = customer.Id.ToString();
                   spfeeBox.Text = customer.sfee;
                   vistsBox.Text = customer.nvisits;
               }
           }
        /*   _database.SubmitChanges();

           pgroupCombo.Text = _tempRow.Cells[0].Value.ToString();
           pcombo.Text = _tempRow.Cells[1].Value.ToString();
           sdateBox.Text = _tempRow.Cells[2].Value.ToString();
           ppriceBox.Text = _tempRow.Cells[3].Value.ToString();
           conditonsBox.Text = _tempRow.Cells[4].Value.ToString();
           //cardnumberBox.Text = _tempRow.Cells[5].Value.ToString();*/
        }

        private void delmShipButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext _database = new DataClasses1DataContext();
            //Table<Mship> _Mship = _database.GetTable<Mship>();
            // Mship _newMship = new Mship();

            var cityNameQuery =
    from mem in _database.Mships
    where mem.Id == Convert.ToInt32(cardnumberBox.Text)
    select mem;
            if (cityNameQuery.Count() > 0)
            {
                _database.Mships.DeleteOnSubmit(cityNameQuery.First());
                _database.SubmitChanges();
            }
            clearMship();
            disableShip();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clearMship();
            refresh();
            disableShip();
        }
    }
}
