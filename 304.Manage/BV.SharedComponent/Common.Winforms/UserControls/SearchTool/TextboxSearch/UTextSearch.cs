using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.SearchTool.TextboxSearch
{
    public partial class UTextSearch : UserControl
    {
        public UTextSearch()
        {
            InitializeComponent();
            VisualizeUI();
        }
        private void VisualizeUI()
        {
            listBox1.Visible = false;
            this.Height = textBox1.Height;
            textBox1.Focus();
        }
        private Type GetTypeValue()
        {
            if (DataSource == null||!DataSource.Columns.Contains(ValueMember)) return null;
            return DataSource.Columns[ValueMember].DataType;            
        }
        private void ShowContent(string filter)
        {
            if (filter == string.Empty || this.DataSource == null ||
                this.DisplayMember == string.Empty || this.ValueMember == string.Empty)
            {
                VisualizeUI();
                this.SelectedValue = null;
                return;
            }
            listBox1.Visible = true;
            listBox1.DataSource = null;
            this.Height = 150;
            Type t_value = GetTypeValue();
            var source = from ds in DataSource.AsEnumerable()
                         where ds.Field<string>(this.DisplayMember).Contains(filter)
                         select ds;
            string fi_exp = DisplayMember + " LIKE '*" + filter + "*'";
            //DataRow[] dv = DataSource.Select(fi_exp);

            DataView dv = new DataView(DataSource);
            dv.RowFilter = fi_exp;

            listBox1.DisplayMember = DisplayMember;
            listBox1.ValueMember = ValueMember;
            listBox1.DataSource = dv;
        }
        public DataTable DataSource
        {
            get;set;            
        }

        public string ValueMember
        {
            //get { return listBox1.ValueMember; }
            //set { listBox1.ValueMember = value; }
            get;set;
        }

        public string DisplayMember
        {
            //get { return listBox1.DisplayMember; }
            //set { listBox1.DisplayMember = value; }
            get;set;
        }

        public object SelectedValue
        {
            get
            {
                if (listBox1.SelectedIndex == -1) return null;
                return listBox1.SelectedValue;
            }

            set
            {
                if (value == null)
                {
                    listBox1.SelectedIndex = -1;
                    textBox1.Text = string.Empty;
                }
                else
                {
                    listBox1.SelectedValue = value;
                    textBox1.Text = listBox1.Text;
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedValue !=null)
            {
                textBox1.Text = listBox1.Text;
            }
            VisualizeUI();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.ShowContent(textBox1.Text);
        }
               
        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1_DoubleClick(sender, new EventArgs());
            }
        }
    }
}
