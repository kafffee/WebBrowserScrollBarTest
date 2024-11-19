Option Strict Off
Imports System.Windows.Forms

Public Class QuickStartGuideView

    Private Sub wbr_LoadCompleted(sender As Object, e As NavigationEventArgs)
        wbr.Document.body.style.overflow = "hidden"

        'Dim doc As IHtmlDocument2 = TryCast((wbr.Document.DomDocument), HtmlDocument)
        'Dim ss As HTMLStyleSheet = doc.createStyleSheet("", 0)
        'ss.cssText = "h1 { color: blue; }"
        'Dim index As Integer = ss.addRule("h1", "color: red;")
        'ss.removeRule(index)

        'Dim Header As HtmlElement = wbr.Document.GetElementsByTagName("TOC")(0)
        'Dim StyleElement As HtmlElement = wbr.Document.CreateElement("style")
        'StyleElement.InnerHtml = "body {background-color:red !important;}"
        'Header.AppendChild(StyleElement)

        'Dim CurrentDocument = (mshtml.HTMLDocument)wbr.Document.DomDocument
        '    styleSheet = CurrentDocument.createStyleSheet("", 0);
        '    StreamReader streamReader = New StreamReader(@"test.css"); //test.css Is Stylesheet file
        '    String Text = streamReader.ReadToEnd();
        '    streamReader.Close();
        '    styleSheet.cssText = Text;
    End Sub

    Private Sub Button_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        'Dim Anker As HtmlElement = wbr.Document.GetElementById("TOC")
        'If Anker IsNot Nothing Then
        '    Anker.ScrollIntoView(True)
        'End If

        Dim Elemente As HtmlElementCollection = wbr.Document.Body.All
        For Each Element In Elemente
            Dim Name As String = Element.GetAttribute("TOC")
            If Not String.IsNullOrEmpty(Name) AndAlso (Name = Element.Section) Then
                Element.ScrollIntoView(True)
            End If
        Next
    End Sub

End Class
