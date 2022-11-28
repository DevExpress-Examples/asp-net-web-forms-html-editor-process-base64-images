Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ASPxHtmlEditor1_HtmlCorrecting(ByVal sender As Object, ByVal e As HtmlCorrectingEventArgs)
        Dim regex As New Regex("<img[^/]+src=[""'](?<data>data:image/[^'""]*)[""'][^/]*/ >")
        e.Html = regex.Replace(e.Html, New MatchEvaluator(Function(m)
            Dim base64Value As String = m.Groups("data").Value
            Dim tagStr As String = m.Value
            Return tagStr.Replace(base64Value, CreateImageFromBase64(base64Value))
        End Function))
    End Sub
    Private Function CreateImageFromBase64(ByVal base64String As String) As String
        base64String = base64String.Split(New String() { "base64," }, StringSplitOptions.RemoveEmptyEntries)(1)
        Dim imageBytes() As Byte = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
            ms.Write(imageBytes, 0, imageBytes.Length)
            Using image As Image = System.Drawing.Image.FromStream(ms, True)
                Dim serverPath As String = String.Format("~/Images/{0}{1}", Guid.NewGuid(), GetFileExtension(image))
                image.Save(Server.MapPath(serverPath))
                Return ResolveClientUrl(serverPath)
            End Using
        End Using
    End Function
    Private Function GetFileExtension(ByVal image As Image) As String
        Dim format As ImageFormat = image.RawFormat
        Dim fileExtension As String = ".jpeg"
        If ImageFormat.Bmp.Equals(format) Then
            fileExtension = ".bmp"
        ElseIf ImageFormat.Gif.Equals(format) Then
            fileExtension = ".gif"
        ElseIf ImageFormat.Png.Equals(format) Then
            fileExtension = ".png"
        End If
        Return fileExtension
    End Function
End Class