using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextCapture
{
    public class TextWithCaptionControl : System.Web.UI.WebControls.WebControl
    {
        public string DefaultText;
        public string TextCaption;
        public string Position;
        public string Separator;

        private char[] _allowedSeparators={' ',',','.',':'} ;
        private const char DefaultSeparator = ':'; 

        private Label _caption;
        private TextBox _textBox;

        public void Init()
        {
            _textBox = new TextBox();
            _caption = new Label();
            _textBox.Text = DefaultText;
            _textBox.Enabled = true;
            _caption.Text = TextCaption + ValidateSeparator(Separator);
        }

        private char ValidateSeparator(string value)
        {
            if ((value.Length == 1)&&(_allowedSeparators.Contains(value[0])))
            {
                return value[0];
            }
            return DefaultSeparator;
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            Init();
            Page.RegisterRequiresControlState(this);
            if (DefaultText == "")
            {
                //...
            }
            
        }
        protected override void AddAttributesToRender(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Value, DefaultText);
            output.AddAttribute(HtmlTextWriterAttribute.Value, Position);
            output.AddAttribute(HtmlTextWriterAttribute.Value, TextCaption);
            output.AddAttribute(HtmlTextWriterAttribute.Value, Separator);
            //добавить другие свойства

            base.AddAttributesToRender(output);
        }


        protected override void Render(HtmlTextWriter writer)
        {
            HtmlTextWriterTag br = HtmlTextWriterTag.Br;
            
            switch (Position)
            {
                case "Left":
                    this.Controls.Add(_caption);
                    this.Controls.Add(_textBox);
                    break;
                case "Right":
                    this.Controls.Add(_textBox);
                    this.Controls.Add(_caption);
                    
                    break;
                case "Top":
                    this.Controls.Add(_caption);
                    Controls.Add(new LiteralControl("<br />"));
                    this.Controls.Add(_textBox);
                    break;
                case "Bottom":
                    this.Controls.Add(_textBox);
                    Controls.Add(new LiteralControl("<br />"));
                    this.Controls.Add(_caption);
                    break;

            }

            
            this.RenderChildren(writer);
        }



        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
