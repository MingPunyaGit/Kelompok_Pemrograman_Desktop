Imports System.Security.Policy

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click
        Dim ganeForm As New Form2()
        Me.Hide()
        ganeForm.ShowDialog()
        Me.Show()
    End Sub
End Class
