<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128544921/14.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T223166)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# HTML Editor for ASP.NET Web Forms - How to process images inserted in Base64 format
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t223166/)**
<!-- run online end -->

This example demonstrates how to process images pasted as Base64 strings (for instance, images pasted from the clipboard), save them on the server, and work with the related resource links.

## Implementation Details

Follow the steps below to process images:

1. Subscribe to the [HtmlCorrecting](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor.HtmlCorrecting) event.
2. In the event handler, process `img` tags that contain Base64 data.
3. Retrieve serialized image data from a Base64 string and convert it to an array of bytes.
4. Save the array of bytes as an image file on the server and generate a client URL to the newly created file.
5. Replace the `src` attribute value of the processed `img` tag with the generated client URL.

## Files to Review
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
