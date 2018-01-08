using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FeeManagement.Controls
{
    public partial class Tile : Grid
    {
        public Tile()
        {
            InitializeComponent();
        }

        #region TileImage

        private static readonly BindableProperty TileImageProperty = BindableProperty.Create(nameof(TileImage), typeof(ImageSource), typeof(Tile),
                                                                                            defaultValue: null, defaultBindingMode: BindingMode.TwoWay,
                                                                                            propertyChanged: OnTileImageSet);

        public ImageSource TileImage
        {
            get
            {
                return (ImageSource)GetValue(TileImageProperty);
            }
            set
            {
                SetValue(TileImageProperty, value);
            }

        }

        private static void OnTileImageSet(BindableObject bindable, object oldValue, object newValue)
        {
            ((bindable as Tile).tileImage as Image).Source = (newValue as ImageSource);
        }

		#endregion

		#region TileText

        private static readonly BindableProperty TileTextProperty = BindableProperty.Create(nameof(TileText), typeof(string), typeof(Tile),
																							defaultValue: null, defaultBindingMode: BindingMode.TwoWay,
																							propertyChanged: OnTileTextSet);

		public string TileText
		{
			get
			{
				return (string)GetValue(TileTextProperty);
			}
			set
			{
                SetValue(TileTextProperty, value);
			}

		}

		private static void OnTileTextSet(BindableObject bindable, object oldValue, object newValue)
		{
            ((bindable as Tile).tileText as Label).Text = (newValue as string);
		}

        #endregion
    }
}
