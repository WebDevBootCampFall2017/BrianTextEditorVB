Imports System.IO

Public Class Form1

    Dim path As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAs.Click

        'save as function
        Dim sfd As SaveFileDialog = New SaveFileDialog
        sfd.DefaultExt = ".txt"
        sfd.Filter = "Text Files | *.txt"
        sfd.Title = "Save File As..."
        sfd.OverwritePrompt = True

        If sfd.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText)
        End If

        'Dim sw As StreamWriter = New StreamWriter(sfd.FileName)

        'If sfd.ShowDialog = DialogResult.OK Then
        'sw.Write(RichTextBox1.Text)
        'sw.Close()
        'End If


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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        'Open File Dialog
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        With ofd
            .Filter = "Text Files | *.txt"
            .Title = "Open a File"
            .FileName = ""
            .CheckFileExists = vbTrue
        End With

        If ofd.ShowDialog = DialogResult.OK Then
            RichTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText)
        End If
        'Dim dr As DialogResult = ofd.ShowDialog()

        'get filepath
        path = ofd.FileName

        'get stream reader
        'Dim sr = New StreamReader(path)

        'read lines until we get to the end of the stream
        'While Not sr.EndOfStream
        'RichTextBox1.Text += sr.ReadToEnd()
        'End While

        'close streamreader
        'SR.Close()

        'show open file in window form
        Me.Text = path

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub



    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click

        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
        End If


    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click

        'Word Wrap function
        If WordWrapToolStripMenuItem.CheckState = CheckState.Checked Then
            RichTextBox1.WordWrap = True
        End If
        If WordWrapToolStripMenuItem.CheckState = CheckState.Unchecked Then
            RichTextBox1.WordWrap = False
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Save.Click

        'Save Function
        Try
            File.WriteAllText(Path, RichTextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Error, invalid file path")

        End Try

    End Sub

    Private Sub HurricanesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HurricanesToolStripMenuItem.Click

        'Carolina Hurricanes color theme
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.BackColor = Color.Red
        MenuStrip1.ForeColor = Color.Red
        MenuStrip1.BackColor = Color.Black

    End Sub

    Private Sub IndiansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndiansToolStripMenuItem.Click

        'Cleveland Indians color theme
        RichTextBox1.ForeColor = Color.DarkBlue
        RichTextBox1.BackColor = Color.Red
        MenuStrip1.ForeColor = Color.Red
        MenuStrip1.BackColor = Color.DarkBlue

    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click

        'Dark Color Theme
        RichTextBox1.BackColor = Color.Black
        MenuStrip1.BackColor = Color.Black
        RichTextBox1.ForeColor = Color.White
        MenuStrip1.ForeColor = Color.White

    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click

        'Default color theme
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.BackColor = Color.White
        MenuStrip1.ForeColor = Color.Black
        MenuStrip1.BackColor = Color.White

    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click

        FindDialog.ShowDialog()

    End Sub

    Private Sub FindAndReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindAndReplaceToolStripMenuItem.Click

        FindandReplaceDialog.ShowDialog()

    End Sub
End Class
