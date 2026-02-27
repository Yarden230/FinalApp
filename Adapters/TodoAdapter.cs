using Android.Content;
using Android.Views;
using Android.Widget;
using FinalApp.Model;
using System.Collections.Generic;

namespace FinalApp
{
    public class TodoAdapter : BaseAdapter<TodoItem>
    {
        List<TodoItem> items;
        Context context;

        public TodoAdapter(Context context, List<TodoItem> items)
        {
            this.context = context;
            this.items = items;
        }

        public override TodoItem this[int position] => items[position];
        public override int Count => items.Count;
        public override long GetItemId(int position) => position;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(context)
                    .Inflate(Resource.Layout.todo_row_layout, parent, false);
            }

            CheckBox cbDone = view.FindViewById<CheckBox>(Resource.Id.cbDone);
            TextView tvText = view.FindViewById<TextView>(Resource.Id.tvText);
            Button btnDelete = view.FindViewById<Button>(Resource.Id.btnDelete);

            TodoItem item = items[position];

            tvText.Text = item.Text;

            // ----- CHECKBOX -----
            cbDone.CheckedChange -= OnCheckedChanged;
            cbDone.Checked = item.IsDone;
            cbDone.Tag = position;
            cbDone.CheckedChange += OnCheckedChanged;

            // ----- DELETE -----
            btnDelete.Click -= OnDeleteClick;
            btnDelete.Tag = position;
            btnDelete.Click += OnDeleteClick;

            return view;
        }

        // ================= EVENTS =================

        void OnCheckedChanged(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb?.Tag == null) return;

            int position = (int)cb.Tag;

            if (position >= 0 && position < items.Count)
            {
                items[position].IsDone = e.IsChecked;
            }
        }

        void OnDeleteClick(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            if (btn?.Tag == null) return;

            int position = (int)btn.Tag;

            if (position >= 0 && position < items.Count)
            {
                items.RemoveAt(position);
                NotifyDataSetChanged();
            }
        }
    }
}
