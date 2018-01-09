using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FeeManagement.Controls
{
    public partial class NavBar : StackLayout
    {
        public NavBar()
        {
            InitializeComponent();
        }


        #region Title

        private static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(NavBar),
                                                                                            defaultValue: null, defaultBindingMode: BindingMode.TwoWay,
                                                                                            propertyChanged: OnTitleSet);

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }

        }

        private static void OnTitleSet(BindableObject bindable, object oldValue, object newValue)
        {
            ((bindable as NavBar).title as Label).Text = (newValue as string);
        }

        #endregion

        #region Tint

        private static readonly BindableProperty TintProperty = BindableProperty.Create(nameof(Tint), typeof(Color), typeof(NavBar),
                                                                                        defaultValue: Color.Black, defaultBindingMode: BindingMode.TwoWay,
                                                                                            propertyChanged: OnTintSet);

        public Color Tint
        {
            get
            {
                return (Color)GetValue(TintProperty);
            }
            set
            {
                SetValue(TintProperty, value);
            }

        }

        private static void OnTintSet(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as NavBar).BackgroundColor = (Color)newValue;
        }

        #endregion
    }
}
