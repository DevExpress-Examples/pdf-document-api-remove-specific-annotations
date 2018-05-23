Imports DevExpress.Pdf
Imports System.Linq

Namespace RemoveSpecificMarkupAnnotations

    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            ' Create a PDF Document Processor.
            Using processor As New PdfDocumentProcessor()

                ' Load a document.
                processor.LoadDocument("..\..\Document.pdf")

                For i As Integer = 0 To processor.Document.Pages.Count

                    ' Remove Bill Smith's markup annotations from a page.
                    processor.DeleteMarkupAnnotations(processor.GetMarkupAnnotationData(i).Where(Function(annotation) annotation.Author.Contains("Bill Smith")))

                    ' Save the result document.
                    processor.SaveDocument("..\..\Result.pdf")
                Next i
            End Using
        End Sub
    End Class
End Namespace