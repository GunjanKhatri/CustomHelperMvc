using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelperMVC.Helper
{
    public static class CustomHelper
    {
        public static IHtmlString DropdownMultiselectList()
        {
            TagBuilder tb = new TagBuilder("select");
            tb.Attributes.Add("multiple", "multiple");
            tb.Attributes.Add("id", "dcList");
            tb.Attributes.Add("name", "dcList");
            TagBuilder tb1 = new TagBuilder("option");
            tb1.Attributes.Add("value", "Canada");
            tb1.SetInnerText("Canada");
            TagBuilder tb2 = new TagBuilder("option");
            tb2.Attributes.Add("value", "India");
            tb2.SetInnerText("India");
            TagBuilder tb3 = new TagBuilder("option");
            tb3.Attributes.Add("value", "Australia");
            tb3.SetInnerText("Australia");
            TagBuilder tb4 = new TagBuilder("option");
            tb4.Attributes.Add("value", "China");
            tb4.SetInnerText("China");
            TagBuilder tb5 = new TagBuilder("option");
            tb5.Attributes.Add("value", "UK");
            tb5.SetInnerText( "UK");
            TagBuilder tb6 = new TagBuilder("option");
            tb6.Attributes.Add("value", "US");
            tb6.SetInnerText("US");
            tb.InnerHtml += tb1;
            tb.InnerHtml += tb2;
            tb.InnerHtml += tb3;
            tb.InnerHtml += tb4;
            tb.InnerHtml += tb5;
            tb.InnerHtml += tb6;
            //for (int i = 1; i <= 6; i++)
            //{
            //    tb.InnerHtml += tb + i.ToString();
            //}
            return new MvcHtmlString(tb.ToString());
        }
    }
}