using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FinalApp.Model
{
    public class TodoItem
    {
        public string Text { get; set; }
        public bool IsDone { get; set; }

        public TodoItem(string text)
        {
            Text = text;
            IsDone = false;
        }
    }
}