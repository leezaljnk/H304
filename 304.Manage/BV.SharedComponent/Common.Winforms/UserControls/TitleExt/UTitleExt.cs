using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.TitleExt
{
    public partial class UTitleExt : UserControl
    {
        public UTitleExt()
        {
            InitializeComponent();
            //if (PublicVariables.Style == 1)
            //    this.BackgroundImage = global::Common.Winforms.Properties.Resources.info_menu_bg_01;
            //else
            //    this.BackgroundImage = global::Common.Winforms.Properties.Resources.info_menu_bg2;
        }
        public event EventHandler TitleClick;
        public event EventHandler OnEdit;
        public string Title
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        public bool ShowButtonExt
        {
            get { return label4.Visible; }
            set { label4.Visible = value; }
        }

        public bool ShowButtonEdit
        {
            get { return lblEdit.Visible; }
            set { lblEdit.Visible = value; }
        }
        private TitleBackgroud _imgBg = TitleBackgroud.Red_Blue;
        public TitleBackgroud ImageBG
        {
            get { return _imgBg; }
            set
            {
                _imgBg = value;
                if (PublicVariables.Style == 1)
                {
                    this.BackgroundImage = global::Common.Winforms.Properties.Resources.info_menu_bg_01;
                }
                else
                {
                    this.BackgroundImage = global::Common.Winforms.Properties.Resources.info_menu_bg2;
                }
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private TitleType _type = TitleType.Extend;
        public TitleType TypeOfTitle
        {
            get { return _type; }
            set
            {
                if (_type == value) return;
                _type = value;
                if (_type == TitleType.Hided)
                {
                    label4.Image = global::Common.Winforms.Properties.Resources.down_button_18x18px;
                }
                else
                {
                    label4.Image = global::Common.Winforms.Properties.Resources.up_button_18x18px;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (TypeOfTitle == TitleType.Extend) TypeOfTitle = TitleType.Hided;
            else TypeOfTitle = TitleType.Extend;
            if (TitleClick != null) TitleClick(this, e);
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            if (OnEdit != null) OnEdit(this, e);
        }
    }

    public enum TitleType : int
    {
        Extend = 0,
        Hided = 1
    }

    public enum TitleBackgroud : int
    {
        Red_Blue = 1,
        Blue = 2
    }
}
