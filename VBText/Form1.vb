Imports System.IO

Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub ProgramInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramInformationToolStripMenuItem.Click
        MessageBox.Show("Text Editor in Visual Basic
Brian Port
Version: 1.0.0
Coding Boot Camp")
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RichTextBox1.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        'Open File Dialog
        Dim ofd As OpenFileDialog = New OpenFileDialog()

        'Get File from user
        Dim dr As DialogResult = ofd.ShowDialog()

        'get filename from dialog result
        Dim filename = ofd.FileName

        'get stream reader
        Dim fr = New StreamReader(filename)

        'read lines until we get to the end of the stream
        While Not fr.EndOfStream
            RichTextBox1.Text += fr.ReadLine()
        End While

        'close file reader
        fr.Close()

    End Sub

    Private Sub FontSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontSizeToolStripMenuItem.Click

    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub CheckBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChkBoxWordWrap.Click
        'Word Wrap Function
        If ChkBoxWordWrap.Checked Then
            RichTextBox1.WordWrap = True
        Else
            RichTextBox1.WordWrap = False
        End If


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Word Wrap function
        If CheckBox1.Checked = True Then
            RichTextBox1.WordWrap = True
        Else
            RichTextBox1.WordWrap = False
        End If
    End Sub
End Class
