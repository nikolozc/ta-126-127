Imports System.IO
Imports System.Text

Public Class Form1

    Private fs As FileStream
    Private path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Hello.txt"

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        fs = File.OpenWrite(path)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = File.ReadAllText(path)
        File.SetAttributes(path, FileAttributes.Hidden)
    End Sub

    Private Sub btnWriteFile_Click(sender As Object, e As EventArgs) Handles btnWriteFile.Click
        'if you haven't clicked the btnOpenFile, the application doiesn't know what file to use yet.
        'to add in some fault tolerance, open the file before trying to use it.
        Dim fsWrite As FileStream = File.OpenWrite(path)

        Dim fileWords As Byte() = New UTF8Encoding(True).GetBytes(TextBox1.Text)

        fsWrite.Write(fileWords, 0, fileWords.Length)

        'cloce the file when you're done.
        fsWrite.Close()
    End Sub
End Class
