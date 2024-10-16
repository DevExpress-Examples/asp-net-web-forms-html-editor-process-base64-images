<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128544921/14.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T223166)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# HTML Editor for ASP.NET Web Forms - How to process images inserted in Base64 format

This example demonstrates how to process images pasted as Base64 strings (for instance, images pasted from the clipboard), save them on the server, and work with the related resource links.

## Implementation Details

Follow the steps below to process images:

1. Subscribe to the [HtmlCorrecting](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor.HtmlCorrecting) event.
2. In the event handler, process `img` tags that contain Base64 data.
3. Retrieve serialized image data from a Base64 string and convert it to an array of bytes.
4. Save the array of bytes as an image file on the server and generate a client URL to the newly created file.
5. Replace the `src` attribute value of the processed `img` tag with the generated client URL.

## Files to Review
* [Default.aspx.cs](./CS/Default.aspx.cs)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-html-editor-process-base64-images&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-html-editor-process-base64-images&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
