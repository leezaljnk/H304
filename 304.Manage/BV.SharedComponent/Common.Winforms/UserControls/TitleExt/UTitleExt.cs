using System;
using System.Windows.Forms;
using Common.Winforms.Properties;

namespace Common.Winforms.UserControls.TitleExt
{
    public partial class UTitleExt : UserControl
    {
        private TitleBackgroud _imgBg = TitleBackgroud.RedBlue;
        private TitleType _type = TitleType.Extend;

        public UTitleExt()
        {
            InitializeComponent();
            //if (PublicVariables.Style == 1)
            //    this.BackgroundImage = global::Common.Winforms.Properties.Resources.info_menu_bg_01;
            //else
            //    this.BackgroundImage = global::Common.Winforms.Properties.Resources.info_menu_bg2;
        }

        public string Title
        {
            get => label3.Text;
            set => label3.Text = value;
        }

        public bool ShowButtonExt
        {
            get => label4.Visible;
            set => label4.Visible = value;
        }

        public bool ShowButtonEdit
        {
            get => lblEdit.Visible;
            set => lblEdit.Visible = value;
        }

        public TitleBackgroud ImageBG
        {
            get => _imgBg;
            set
            {
                _imgBg = value;
                if (PublicVariables.Style == 1)
                    BackgroundImage = Resources.info_menu_bg_01;
                else
                    BackgroundImage = Resources.info_menu_bg2;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public TitleType TypeOfTitle
        {
            get => _type;
            set
            {
                if (_type == value) return;
                _type = value;
                if (_type == TitleType.Hided)
                    label4.Image = Resources.down_button_18x18px;
                else
                    label4.Image = Resources.up_button_18x18px;
            }
        }

        public event EventHandler TitleClick;
        public event EventHandler OnEdit;

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

    public enum TitleType
    {
        Extend = 0,
        Hided = 1
    }

    public enum TitleBackgroud
    {
        RedBlue = 1,
        Blue = 2
    }
}