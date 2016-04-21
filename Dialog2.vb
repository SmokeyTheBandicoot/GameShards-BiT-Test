Imports System.Windows.Forms
Imports GameShardsCore.GameShardsCoreBETA
Public Class Dialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        MsgBox("All windows of the game will be closed.It is needed to update the language. You'll be redirected to the main window")
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim langFold As New IO.DirectoryInfo("C:\\GameShardsSoftware\Games\WhoWantsToBeABillionaire\Languages")
            Dim Fold As IO.FileInfo() = langFold.GetFiles()
            For Each file In Fold
                If file.Extension = ".lang" Then
                    ListBox1.Items.Add(file.Name)
                End If
            Next
        Catch
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ListBox1.Items.Clear()
            Dim langFold As New IO.DirectoryInfo("C:\\GameShardsSoftware\Games\WhoWantsToBeABillionaire\Languages")
            Dim Fold As IO.FileInfo() = langFold.GetFiles()
            For Each file In Fold
                If file.Extension = ".lang" Then
                    ListBox1.Items.Add(file.Name)
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Diagnostics.Process.Start("explorer.exe", "C:\GameShardsSoftware\Games\WhoWantsToBeABillionaire\Languages")
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim g As New GameShardsCore.GameShardsCoreBETA
        g.OpenBrowser()
    End Sub
End Class
