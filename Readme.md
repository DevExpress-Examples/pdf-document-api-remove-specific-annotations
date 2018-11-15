<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/RemoveSpecificMarkupAnnotations/Program.cs) (VB: [Program.vb](./VB/RemoveSpecificMarkupAnnotations/Program.vb))
<!-- default file list end -->
# How to delete particular markup annotations from a page


This example shows how to delete text markup annotations by a particular author.


<h3>Description</h3>

The <strong>PdfMarkupAnnotationData</strong> collection contains text markup annotations that should be deleted in a page. To delete text markup annotations in this collection, call the <strong>PdfDocumentProcessor.DeleteMarkupAnnotations</strong> method. <br><br>To retrieve markup annotation data in a page, call the <strong>PdfDocumentProcessor.GetMarkupAnnotationData</strong> method with a specified page number. The author name is accessed using the&nbsp; <strong>PdfMarkupAnnotationData.Author</strong> property.

<br/>


