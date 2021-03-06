﻿using Ooui;
using Xamarin.Forms;

namespace Samples
{
    public class RefreshListViewSample : ISample
    {
        public string Title => "Xamarin.Forms RefreshListView";
        public string Path => "/refreshlistview";

        public Ooui.Element CreateElement ()
        {
            var page = new RefreshListView();
            return page.GetOouiElement ();
        }

        public void Publish ()
        {
            UI.Publish (Path, CreateElement);
        }
    }
}
