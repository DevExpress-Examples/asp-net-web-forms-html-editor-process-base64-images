using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using DevExpress.Web.ASPxHtmlEditor;

public partial class _Default : System.Web.UI.Page {
    protected void ASPxHtmlEditor1_HtmlCorrecting(object sender, HtmlCorrectingEventArgs e) {
        Regex regex = new Regex("<img[^/]+src=[\"'](?<data>data:image/[^'\"]*)[\"'][^/]*/>");
        e.Html = regex.Replace(e.Html, new MatchEvaluator(m => {
            string base64Value = m.Groups["data"].Value;
            string tagStr = m.Value;
            return tagStr.Replace(base64Value, CreateImageFromBase64(base64Value));
        }));
    }
    string CreateImageFromBase64(string base64String) {
        base64String = base64String.Split(new string[] { "base64," }, StringSplitOptions.RemoveEmptyEntries)[1];
        byte[] imageBytes = Convert.FromBase64String(base64String);
        using(MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length)) {
            ms.Write(imageBytes, 0, imageBytes.Length);
            using(Image image = Image.FromStream(ms, true)) {
                string serverPath = string.Format("~/Images/{0}{1}", Guid.NewGuid(), GetFileExtension(image));
                image.Save(Server.MapPath(serverPath));
                return ResolveClientUrl(serverPath);
            }
        }
    }
    string GetFileExtension(Image image) {
        ImageFormat format = image.RawFormat;
        string fileExtension = ".jpeg";
        if(ImageFormat.Bmp.Equals(format))
            fileExtension = ".bmp";
        else if(ImageFormat.Gif.Equals(format))
            fileExtension = ".gif";
        else if(ImageFormat.Png.Equals(format))
            fileExtension = ".png";
        return fileExtension;
    }
}