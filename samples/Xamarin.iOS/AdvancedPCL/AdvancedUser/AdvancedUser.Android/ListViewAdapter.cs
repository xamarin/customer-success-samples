using System;
using System.Collections.Generic;

using Android.App;
using Android.Widget;
using Android.Views;

using AdvancedUser.BusinessLogicLayer.Models;

namespace AdvancedUser.Android
{
	public class ListViewAdapter : BaseAdapter<User>
	{
		private Activity _context;
		private IList<User> _list;

		public ListViewAdapter (Activity context, IList<User> list)
			:base ()
		{
			_context = context;
			_list = list;
		}

		public override int Count {
			get { return _list.Count; }
		}

		public override User this[int index] {
			get { return _list [index]; }
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView; 

			if (view == null)
				view = _context.LayoutInflater.Inflate (Resource.Layout.ListViewCell, parent, false);

			var user = this [position];

			view.FindViewById<TextView> (Resource.Id.Description).Text = user.Name;

			return view;
		}
	}
}