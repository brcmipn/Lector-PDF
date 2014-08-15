Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oReader As New iTextSharp.text.pdf.PdfReader(TextBox1.Text)
        Dim its As New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy

        Dim file As New FileInfo(TextBox1.Text)

        MsgBox(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(oReader, 1, its), MsgBoxStyle.MsgBoxRight, "Leyendo " + file.Name)
        oReader.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        OpenFileDialog1.Filter = "Archivos PDF|*.pdf"
        OpenFileDialog1.Title = "Selecciona un archivo PDF"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub


End Class
