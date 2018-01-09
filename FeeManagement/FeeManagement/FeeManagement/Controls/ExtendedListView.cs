using System;

using Xamarin.Forms;

namespace FeeManagement.Controls
{
    public class ExtendedListView : ListView
    {
        protected override void SetupContent(Cell content, int index)
        {
            if (index % 3 == 0)
                (content as ViewCell).View.BackgroundColor = Color.White;
            else if (index % 3 == 1)
                (content as ViewCell).View.BackgroundColor = Color.LightGray;
			else if (index % 3 == 2)
                (content as ViewCell).View.BackgroundColor = Color.SlateGray;
            base.SetupContent(content, index);
        }
    }
}

