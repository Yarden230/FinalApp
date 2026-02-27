using Android.App;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using FinalApp.Model;
using FinalApp;
using System.Collections.Generic;

namespace FinalApp
{
    [Activity(Label = "FinalApp", MainLauncher = false)]
    public class ToDoActivity : AppCompatActivity
    {
        EditText etTask;
        Button btnAdd;
        ListView lvTasks;

        List<TodoItem> Tasks;
        TodoAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.todolist_layout);

            etTask = FindViewById<EditText>(Resource.Id.etTask);
            btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            lvTasks = FindViewById<ListView>(Resource.Id.lvTasksList);

            Tasks = new List<TodoItem>();
            adapter = new TodoAdapter(this, Tasks);

            lvTasks.Adapter = adapter;

            btnAdd.Click += (s, e) =>
            {
                string text = etTask.Text.Trim();

                if (text.Length > 0)
                {
                    Tasks.Add(new TodoItem(text));
                    adapter.NotifyDataSetChanged();
                    etTask.Text = "";
                }
            };
        }
    }
}
