using FA.JustBlog.Common.ExtensionMethod;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

[HtmlTargetElement("my-tag")]
public class PostedOnTagHelper : TagHelper
{
    public DateTime customerName { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var sb = new StringBuilder();
        sb.AppendFormat("Posted {0}", this.customerName.ToFriendlyTime());
        output.PreContent.SetHtmlContent(sb.ToString());
    }
}

