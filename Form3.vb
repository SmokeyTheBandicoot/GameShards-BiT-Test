Public Class Form3
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If verifynick() = True Then
            Form1.Show()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If verifynick() = True Then
            Form1.Show()
        End If
    End Sub
    Function verifynick()
        If TextBox1.Text = "" Then
            MsgBox("Inserire un nome. Il proprio nickname sarà utile per la LeaderBoard al termine della partita.", MsgBoxStyle.OkOnly)
            Return False
            Exit Function
        End If
        Return True
    End Function
End Class