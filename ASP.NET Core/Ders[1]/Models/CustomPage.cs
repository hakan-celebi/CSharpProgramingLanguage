using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders_1_.Models
{
    public abstract class CustomPage<TModel> : RazorPage<TModel>
    {
        public string Text { get; } = "View Inherits";
        public string JoinText(string ViewText)
        {
            return Text + " " + ViewText;
        }
    }
}
