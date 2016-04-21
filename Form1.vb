Imports GameShardsCore
Imports GameShardsCore.GameShardsCoreBETA
Public Class Form1
    Dim filetext() As String
    Dim w As Byte
    Dim btns(3) As Button
    Dim x As Integer
    Dim help As String
    Dim correctans, kj As SByte
    Dim k As Integer = 2
    Dim listindex As UShort = 0
    Dim lives As Byte = 4
    Dim helpnumber As Byte = 3
    Dim a As Boolean = True
    Dim stoplabel As Boolean = False

    Private gsc As GameShardsCore.GameShardsCoreBETA
    Private Sub EditorDomandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectEditor.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTSMI.Click
        Me.Close()
    End Sub
    Private Sub ApriProgettoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProjectTSMI.Click
        If Form2.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            startproject(Form2.OpenFileDialog1.FileName)
        End If
    End Sub
    Public Sub startproject(ByVal projectpath As String)
        '  StatoAttualeToolStripMenuItem.Enabled = True
        Percent50TSMI.Enabled = True
        JumpQuestion.Enabled = True
        HelpTSMI.Enabled = True
        Try
            Dim reader As New IO.StreamReader(projectpath)
            filetext = Split(reader.ReadToEnd(), "§")
            reader.Close()
            restart()
            Timer1.Start()
            Timer3.Start()
            For f = 0 To 3
                btns(f).Enabled = True
            Next
            Button5.Enabled = True
        Catch
            MsgBox("An error prevented the project's loading. If you have finished a project and you want to play it again choose File-->Open Project...", MsgBoxStyle.Critical)
            CancelProject()
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ListBox1.SelectedItem = ListBox1.Items.Item(listindex)
        ListBox2.SelectedItem = ListBox2.Items.Item(listindex)
        Label5.Text = listindex
        If listindex Mod 5 = 0 Then
            If listindex = 0 Then
                Label7.Text = ListBox1.SelectedItem
            Else
                Label7.Text = ListBox1.Items.Item(listindex - 1)
            End If
        End If
        x = filetext(0)
        Label6.Text = "/ " & x
        TextBox2.Text = filetext(1)
        TextBox1.Text = filetext(k)
        If a = True Then
            Label2.Text = filetext(k + 1)
            a = False
        End If
        Button1.Text = filetext(k + 2)
        Button2.Text = filetext(k + 3)
        Button3.Text = filetext(k + 4)
        Button4.Text = filetext(k + 5)
        help = filetext(k + 6)
        correctans = filetext(k + 7)
        Label18.Text = filetext(k + 8)
        If w <> 0 And w <> correctans Then
            lives -= 1
            w = 0
            If lives = 0 Then
                If MsgBox("You Lost all the lives." & vbNewLine & "      ----Game Over----      " & vbNewLine & "Restart?", MsgBoxStyle.YesNo, "Game Over") = DialogResult.Yes Then
                    restart()
                End If
            End If
        End If
        If w = correctans Then
            w = 0
            MsgBox("Your answer is correct!", MsgBoxStyle.OkOnly)
            listindex += 1
            For f = 0 To 3
                btns(f).Enabled = True
            Next
            If filetext(k + 9) = "End" Then
                MsgBox("Congratulations! You completed the project.", MsgBoxStyle.OkOnly)
                a = False
                Timer3.Stop()
                CancelProject()
                Timer1.Stop()
            Else
                a = True
                k += 9
            End If
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btns(0) = Button1
        btns(1) = Button2
        btns(2) = Button3
        btns(3) = Button4
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        w = 1
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        w = 2
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        w = 3
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        w = 4
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If stoplabel = True Then
        ElseIf stoplabel = False Then
            Label9.Left -= 1
            If (Label9.Left + Label9.Width) < 0 Then
                Label9.Left = Me.Width
            End If
        End If
        Select Case lives
            Case 5
                Label19.Text = "YYYYY"
            Case 4
                Label19.Text = "YYYY"
            Case 3
                Label19.Text = "YYY"
            Case 2
                Label19.Text = "YY"
            Case 1
                Label19.Text = "Y"
            Case 0
                Label19.Text = ""
        End Select
    End Sub
    Sub restart()
        listindex = 0
        Label19.Text = "YYYY"
        k = 2
        Timer1.Stop()
        w = 0
        TextBox1.Clear()
        a = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        lives = 4
        ' StatoAttualeToolStripMenuItem.Enabled = True
        Percent50TSMI.Enabled = True
        JumpQuestion.Enabled = True
        HelpTSMI.Enabled = True
        HelpTSMI.Text = "Helps (x3)"
        helpnumber = 3
        Timer1.Start()
        Timer3.Start()
        For f = 0 To 3
            btns(f).Enabled = True
        Next
        Button5.Enabled = True
    End Sub
    Private Sub AiutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpTSMI.Click
        MsgBox(help, MsgBoxStyle.OkOnly, "aiuto alla domanda")
        helpnumber -= 1
        If helpnumber = 0 Then
            MsgBox("You finished the helps!")
            HelpTSMI.Enabled = False
        End If
        HelpTSMI.Text = "Help (x" & helpnumber & ")"
    End Sub
    Private Sub CambioDomandaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        JumpQuestion.Enabled = False
        w = correctans
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("Are you sure do you want to stop?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            MsgBox("You have just won " & Label7.Text & " Money!")
            Timer1.Stop()
            Timer3.Stop()
            CancelProject()
        End If
    End Sub
    Private Sub CancelProject()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        TextBox1.Text = ""
        help = ""
        Label19.Text = "YYYY"
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label2.Text = 5000.0
        a = True
        Timer1.Stop()
        Timer3.Stop()
        listindex = 0
        For f = 0 To 3
            btns(f).Enabled = True
        Next
        Button5.Enabled = False
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If TimeTrialTSMI.Checked = True Then
            Label2.Text -= 0.1
            If Label2.Text = 0 Then
                If MsgBox("The time is up. Restart?", MsgBoxStyle.YesNo, "Time Expired") = DialogResult.Yes Then
                    restart()
                Else
                    CancelProject()
                End If
            End If
        End If
    End Sub
    Private Sub Label9_enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter
        stoplabel = True
        Label9.ForeColor = Color.Gold
    End Sub
    Private Sub Label9_exit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseLeave
        stoplabel = False
        Label9.ForeColor = Color.DarkBlue
    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        gsc = New GameShardsCore.GameShardsCoreBETA
        gsc.OpenBrowser()
    End Sub
    Private Sub InformazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        kj = 2
        Dim albutton As SByte = -1
        Do While kj <> 0
            Dim rdn As Random
            rdn = New Random
            Dim bl As Byte = rdn.Next(0, 3)
            If bl <> (correctans - 1) And albutton <> bl Then
                albutton = bl
                btns(bl).Enabled = False
                kj -= 1
            End If
        Loop
    End Sub
    Private Sub RicominciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartTSMI.Click
        CancelProject()
        startproject(Form2.SaveFileDialog1.FileName)
    End Sub
    Private Sub LanguageTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LanguageTSMI.Click
        Dialog2.ShowDialog()
    End Sub
End Class
