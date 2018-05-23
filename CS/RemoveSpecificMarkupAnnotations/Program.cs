using DevExpress.Pdf;
using System.Linq;

namespace RemoveSpecificMarkupAnnotations {

    class Program {
        static void Main(string[] args) {

            // Create a PDF Document Processor.
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a document.
                processor.LoadDocument("..\\..\\Document.pdf");

                for (int i = 0; i <= processor.Document.Pages.Count; i++) {

                    // Remove Bill Smith's markup annotations from a page.
                    processor.DeleteMarkupAnnotations(processor.GetMarkupAnnotationData(i)
                    .Where(annotation => annotation.Author.Contains("Bill Smith")));

                    // Save the result document.
                    processor.SaveDocument("..\\..\\Result.pdf");
                }
            }
        }
    }
}