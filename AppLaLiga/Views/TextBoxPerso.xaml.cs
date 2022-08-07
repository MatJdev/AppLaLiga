using System.Windows;
using System.Windows.Controls;


namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for TextBoxPerso.xaml
    /// </summary>
    public partial class TextBoxPerso : UserControl
    {
        public TextBoxPerso()
        {
            InitializeComponent();
        }

        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public string Text 
        {
            get { return textBox.Text; }
            set {; }
        }

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register
            ("Hint", typeof(string), typeof(TextBoxPerso));
    }
}
