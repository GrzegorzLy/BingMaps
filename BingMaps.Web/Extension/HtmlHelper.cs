using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace BingMaps.Web.Extension
{
    public static class HtmlHelper
    {
        public static MvcHtmlString LabelEditorValidatorFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            var editor = html.EditorFor(expression, new { htmlAttributes = new { @class = "col-md-10 form-control" } });

            return LabelValidatorBuilder(html, expression, editor);
        }

        public static MvcHtmlString LabelDisplayValidatorFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            var display = DisplayBuilder("col-md-10", "padding-left: 13px;", html.DisplayFor(expression));

            return LabelValidatorBuilder(html, expression, display);
        }

        public static MvcHtmlString LabelValidatorBuilder<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, MvcHtmlString @object)
        {
            var lable = html.LabelFor(expression, new { @class = "col-md-2 control-label text-right" });
            var validator = html.ValidationMessageFor(expression);

            return new MvcHtmlString("<div class =\"form-group row\">" + lable + @object + validator + "</div>");
        }

        private static MvcHtmlString DisplayBuilder(string @class, string style, MvcHtmlString display)
        {
            var div = new TagBuilder("div");
            div.AddCssClass(@class);
            div.Attributes["style"] = style;
            div.InnerHtml = display.ToHtmlString();
            return new MvcHtmlString(div.ToString());
        }       
    }
}