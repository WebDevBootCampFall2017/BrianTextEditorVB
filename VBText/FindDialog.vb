Public Class FindDialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim search_target = TextBox1.Text
        Dim random_string = Form1.RichTextBox1.Text
        Dim index = random_string.IndexOf(search_target)
        Dim result_string = random_string.Substring(index, search_target.Length)

        'Form1.ShowDialog()
        'Form1.Cursor = Cursor.Position(index)

    End Sub
End Class