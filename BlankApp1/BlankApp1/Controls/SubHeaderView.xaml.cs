using System.ComponentModel;
using Xamarin.Forms;


namespace BlankApp1.Controls
{
    public partial class SubHeaderView : ContentView
    {
        // SubHeader - Content
        public static readonly BindableProperty TextPropertyContent = BindableProperty.Create(
            nameof(SubHeaderContent), typeof(string),
            typeof(Label), default(string), BindingMode.TwoWay);

        public string SubHeaderContent
        {
            get { return (string)GetValue(TextPropertyContent); }
            set {  SetValue(TextPropertyContent, value); }
        }


        // SubHeader - Title
        public static readonly BindableProperty TextPropertyTitle = BindableProperty.Create(
            nameof(SubHeaderTitle), typeof(string),
            typeof(Label), default(string), BindingMode.TwoWay);

        public string SubHeaderTitle
        {
            get { return (string)GetValue(TextPropertyTitle); }
            set { SetValue(TextPropertyTitle, value); }
        }


        //public event 
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TextPropertyTitle.PropertyName)
            {               
                this.lblTitle.Text = SubHeaderTitle;
            }
            if (propertyName == TextPropertyContent.PropertyName)
            {
                this.lblContent.Text = SubHeaderContent;
            }
        }

        public SubHeaderView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            // Set the inner BindingContext of the controls to this, while the outer BindingContext of this is set externally.
            Content.BindingContext = this;
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        // This is needed  for intermediate value changes.
        // An initial binding usually works without, even without being a BindableProperty.
        // TODO This seems superfluous for a BindableProperty.
        protected void RaisePropertyChanged(string propertyName)
        {
            // TODO This does not work for the inherited PropertyChanged.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
