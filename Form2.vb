Public Class Form2
    Dim x As Integer
    Dim cat As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvaToolStripMenuItem.Click
        Save()
    End Sub
    Private Function Save() As Boolean
        Try
            If TextBox13.Text <> "" Then
            Else
                MsgBox("Inserire il nome del progetto", MsgBoxStyle.Critical)
                Exit Try
            End If
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim savewrites As New IO.StreamWriter(SaveFileDialog1.FileName)
                Dim savedfile As String = ""
                Dim c As Object
                savedfile &= (x - 1) & "§"
                savedfile &= TextBox13.Text & "§"
                For y As UShort = 0 To (TabControl1.TabPages.Count - 1)
                    Dim curtab As TabPage = TabControl1.TabPages(y)
                    For Each c In curtab.Controls
                        If TypeOf c Is NumericUpDown Then
                            savedfile += c.value & "§"
                        End If
                        If TypeOf c Is TextBox Then
                            savedfile += c.Text & "§"
                        End If
                        If TypeOf c Is ComboBox Then
                            savedfile += c.text & "§"
                        End If
                    Next
                Next
                savedfile &= "End§"
                savewrites.WriteLine(savedfile)
                savewrites.Close()
            End If
            Return True
            Exit Function
        Catch
            Return False
            Exit Function
        End Try
        Return True
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovaDomandaToolStripMenuItem.Click
        Dim tabpage As New TabPage
        Dim quest, ans1, ans2, ans3, ans4, help As New TextBox
        Dim lbquest, lbans1, lbans2, lbans3, lbans4, lbhelp, lbcorrectans, lbcategory, lbtime As New Label
        Dim correctans, time As New NumericUpDown
        Dim combo As New ComboBox
        lbtime.Left = 118
        lbtime.Top = 400
        lbtime.Text = "Tempo a disposizione per la domanda: "
        combo.Text = "Seleziona Categoria"
        combo.Items.Add("Algebra")
        combo.Items.Add("(Altro)")
        combo.Items.Add("Aritmetica")
        combo.Items.Add("Arte")
        combo.Items.Add("Attualità")
        combo.Items.Add("Chimica")
        combo.Items.Add("Cultura")
        combo.Items.Add("Curiosità")
        combo.Items.Add("Elettronica")
        combo.Items.Add("Fisica")
        combo.Items.Add("Geografia")
        combo.Items.Add("Grammatica")
        combo.Items.Add("Informatica")
        combo.Items.Add("Letteratura")
        combo.Items.Add("Meccanica")
        combo.Items.Add("Passatempo")
        combo.Items.Add("Religione")
        combo.Items.Add("Sanità")
        combo.Items.Add("Scienza")
        combo.Items.Add("Sport")
        combo.Items.Add("StoriaSvago")
        combo.Sorted = True
        combo.Location = New Point(177, 428)
        combo.Width = 247
        lbcategory.Text = "Categoria:"
        lbcategory.Location = New Point(3, 432)
        tabpage.Text = "Domanda " & x
        tabpage.Name = "TabPage" & x
        lbcorrectans.Text = "La risposta corretta è la risposta:"
        lbcorrectans.Left = 118
        lbcorrectans.Top = 373
        correctans.Maximum = 4
        correctans.Minimum = 1
        correctans.Left = 288
        correctans.Top = 371
        correctans.Width = 120
        time.Maximum = 1000.0
        time.Minimum = 1.0
        time.Left = 288
        time.Top = 400
        time.Value = 30.0
        quest.Text = ""
        quest.Multiline = True
        quest.Left = 6
        quest.Top = 19
        quest.Width = 589
        quest.Height = 79
        quest.ScrollBars = ScrollBars.Vertical
        quest.TabIndex = 1
        ans1.Text = ""
        ans1.Multiline = True
        ans1.Left = 6
        ans1.Top = 125
        ans1.Width = 276
        ans1.Height = 57
        ans1.ScrollBars = ScrollBars.Vertical
        ans1.TabIndex = 2
        ans2.Text = ""
        ans2.Multiline = True
        ans2.Left = 315
        ans2.Top = 125
        ans2.Width = 276
        ans2.Height = 57
        ans2.ScrollBars = ScrollBars.Vertical
        ans2.TabIndex = 3
        ans3.Text = ""
        ans3.Multiline = True
        ans3.Left = 6
        ans3.Top = 204
        ans3.Width = 276
        ans3.Height = 57
        ans3.ScrollBars = ScrollBars.Vertical
        ans2.TabIndex = 4
        ans4.Text = ""
        ans4.Multiline = True
        ans4.Left = 315
        ans4.Top = 204
        ans4.Width = 276
        ans4.Height = 57
        ans4.ScrollBars = ScrollBars.Vertical
        ans4.TabIndex = 5
        help.Text = ""
        help.Multiline = True
        help.Left = 6
        help.Top = 293
        help.Width = 585
        help.Height = 57
        help.ScrollBars = ScrollBars.Vertical
        help.TabIndex = 6
        lbquest.Text = "Domanda"
        lbquest.Left = 6
        lbquest.Top = 3
        lbans1.Text = "Risposta 1"
        lbans1.Left = 6
        lbans1.Top = 109
        lbans2.Text = "Risposta 2"
        lbans2.Left = 312
        lbans2.Top = 109
        lbans3.Text = "Risposta 3"
        lbans3.Left = 6
        lbans3.Top = 185
        lbans4.Text = "Risposta 4"
        lbans4.Left = 312
        lbans4.Top = 185
        lbhelp.Text = "Aiuto"
        lbhelp.Left = 6
        lbhelp.Top = 277
        tabpage.Controls.Add(quest)
        tabpage.Controls.Add(time)
        tabpage.Controls.Add(lbtime)
        tabpage.Controls.Add(ans1)
        tabpage.Controls.Add(ans2)
        tabpage.Controls.Add(ans3)
        tabpage.Controls.Add(ans4)
        tabpage.Controls.Add(help)
        tabpage.Controls.Add(lbquest)
        tabpage.Controls.Add(lbans1)
        tabpage.Controls.Add(lbans2)
        tabpage.Controls.Add(lbans3)
        tabpage.Controls.Add(lbans4)
        tabpage.Controls.Add(lbhelp)
        tabpage.Controls.Add(correctans)
        tabpage.Controls.Add(lbcorrectans)
        tabpage.Controls.Add(lbcategory)
        tabpage.Controls.Add(combo)
        tabpage.BackColor = Color.CadetBlue
        TabControl1.TabPages.Add(tabpage)
        x += 1
    End Sub
    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox13.Text.Contains("§") Then
            MsgBox("Il nome del progetto non può contenere il carattere ""§"" in quanto carattere riservato.", MsgBoxStyle.Information)
            TextBox13.Clear()
        End If
    End Sub
    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriToolStripMenuItem.Click
        If Dialog1.ShowDialog = DialogResult.Yes Then
            Save()
        ElseIf Dialog1.DialogResult = DialogResult.No Then
        ElseIf Dialog1.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        cleartab()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim reader As New IO.StreamReader(OpenFileDialog1.FileName)
            Dim filetext() As String
            filetext = Split(reader.ReadToEnd(), "§")
            reader.Close()
            Dim x As Integer
            x = filetext(0)
            TextBox13.Text = filetext(1)
            Dim k As Integer = 2
            For y As UShort = 1 To (x)
                Dim tabpage As New TabPage
                tabpage.Text = "Domanda " & y
                tabpage.Name = "TabPage" & y
                Dim quest, ans1, ans2, ans3, ans4, help As New TextBox
                Dim lbquest, lbans1, lbans2, lbans3, lbans4, lbhelp, lbcorrectans, lbtime As New Label
                Dim correctans, time As New NumericUpDown
                Dim combo As New ComboBox
                lbtime.Left = 118
                lbtime.Top = 400
                lbtime.Text = "Tempo a disposizione per la domanda: "
                combo.Text = "Seleziona Categoria"
                combo.Items.Add("Algebra")
                combo.Items.Add("(Altro)")
                combo.Items.Add("Aritmetica")
                combo.Items.Add("Arte")
                combo.Items.Add("Attualità")
                combo.Items.Add("Chimica")
                combo.Items.Add("Cultura")
                combo.Items.Add("Curiosità")
                combo.Items.Add("Elettronica")
                combo.Items.Add("Fisica")
                combo.Items.Add("Geografia")
                combo.Items.Add("Grammatica")
                combo.Items.Add("Informatica")
                combo.Items.Add("Letteratura")
                combo.Items.Add("Meccanica")
                combo.Items.Add("Passatempo")
                combo.Items.Add("Religione")
                combo.Items.Add("Sanità")
                combo.Items.Add("Scienza")
                combo.Items.Add("Sport")
                combo.Items.Add("StoriaSvago")
                combo.Location = New Point(177, 428)
                combo.Width = 247
                combo.Sorted = True
                time.Maximum = 1000.0
                time.Minimum = 1.0
                time.Left = 288
                time.Top = 400
                time.Value = filetext(k + 1)
                lbcorrectans.Text = "La risposta corretta è la risposta:"
                lbcorrectans.Left = 118
                lbcorrectans.Top = 373
                correctans.Maximum = 4
                correctans.Minimum = 1
                correctans.Value = filetext(k + 7)
                correctans.Left = 288
                correctans.Top = 371
                correctans.Width = 120
                quest.Text = filetext(k)
                quest.Multiline = True
                quest.Left = 6
                quest.Top = 19
                quest.Width = 589
                quest.Height = 79
                quest.ScrollBars = ScrollBars.Vertical
                quest.TabIndex = 1
                ans1.Text = filetext(k + 2)
                ans1.Multiline = True
                ans1.Left = 6
                ans1.Top = 125
                ans1.Width = 276
                ans1.Height = 57
                ans1.ScrollBars = ScrollBars.Vertical
                ans1.TabIndex = 2
                ans2.Text = filetext(k + 3)
                ans2.Multiline = True
                ans2.Left = 315
                ans2.Top = 125
                ans2.Width = 276
                ans2.Height = 57
                ans2.ScrollBars = ScrollBars.Vertical
                ans2.TabIndex = 3
                ans3.Text = filetext(k + 4)
                ans3.Multiline = True
                ans3.Left = 6
                ans3.Top = 204
                ans3.Width = 276
                ans3.Height = 57
                ans3.ScrollBars = ScrollBars.Vertical
                ans3.TabIndex = 4
                ans4.Text = filetext(k + 5)
                ans4.Multiline = True
                ans4.Left = 315
                ans4.Top = 204
                ans4.Width = 276
                ans4.Height = 57
                ans4.ScrollBars = ScrollBars.Vertical
                ans4.TabIndex = 5
                help.Text = filetext(k + 5)
                help.Multiline = True
                help.Left = 6
                help.Top = 293
                help.Width = 585
                help.Height = 57
                help.ScrollBars = ScrollBars.Vertical
                help.TabIndex = 6
                combo.Text = filetext(k + 8)
                lbquest.Text = "Domanda"
                lbquest.Left = 6
                lbquest.Top = 3
                lbans1.Text = "Risposta 1"
                lbans1.Left = 6
                lbans1.Top = 109
                lbans2.Text = "Risposta 2"
                lbans2.Left = 312
                lbans2.Top = 109
                lbans3.Text = "Risposta 3"
                lbans3.Left = 6
                lbans3.Top = 185
                lbans4.Text = "Risposta 4"
                lbans4.Left = 312
                lbans4.Top = 185
                lbhelp.Text = "Aiuto"
                lbhelp.Left = 6
                lbhelp.Top = 277
                tabpage.Controls.Add(quest)
                tabpage.Controls.Add(time)
                tabpage.Controls.Add(lbtime)
                tabpage.Controls.Add(ans1)
                tabpage.Controls.Add(ans2)
                tabpage.Controls.Add(ans3)
                tabpage.Controls.Add(ans4)
                tabpage.Controls.Add(help)
                tabpage.Controls.Add(lbquest)
                tabpage.Controls.Add(lbans1)
                tabpage.Controls.Add(lbans2)
                tabpage.Controls.Add(lbans3)
                tabpage.Controls.Add(lbans4)
                tabpage.Controls.Add(lbhelp)
                tabpage.Controls.Add(correctans)
                tabpage.Controls.Add(lbcorrectans)
                tabpage.Controls.Add(combo)
                tabpage.BackColor = Color.CadetBlue
                TabControl1.TabPages.Add(tabpage)
                k += 9
            Next
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        x = TabControl1.TabPages.Count + 1
        If TextBox13.Text.Contains("§") Then
            MsgBox("Il nome del progetto non può contenere il carattere ""§"" in quanto carattere riservato.", MsgBoxStyle.OkOnly)
            TextBox13.Clear()
        End If
    End Sub
    Private Sub NuovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovoToolStripMenuItem.Click
        ' If MsgBox("Vuoi prima salvare le modifiche apportate?", MsgBoxStyle.YesNoCancel) = DialogResult.Yes Then
        '     Save()
        '     cleartab()
        ' ElseIf MsgBox("Vuoi prima salvare le modifiche apportate?", MsgBoxStyle.YesNoCancel) = DialogResult.No Then
        '     cleartab()
        'Else
        '     Exit Sub
        'End If
        Select Case MsgBox("Vuoi prima salvare le modifiche apportate?", MsgBoxStyle.YesNoCancel)
            Case DialogResult.Yes
                Save()
                cleartab()
            Case DialogResult.No
                cleartab()
            Case DialogResult.Cancel
        End Select
    End Sub
    Private Sub cleartab()
        If TabControl1.TabPages.Count <> 0 Then
            For j As UShort = 0 To TabControl1.TabPages.Count - 1
                TabControl1.TabPages.RemoveAt(0)
            Next
        End If
    End Sub
    Private Sub GiocaProgettoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GiocaProgettoToolStripMenuItem.Click
        If Dialog1.ShowDialog = DialogResult.Yes Then
            Save()
        ElseIf Dialog1.DialogResult = DialogResult.No Then
        ElseIf Dialog1.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub CancellaDomandaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellaDomandaToolStripMenuItem.Click
        If MsgBox("Sei sicuro di voler cancellare questa domanda?", MsgBoxStyle.OkCancel) = DialogResult.OK Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        End If
    End Sub
    Private Sub CancellaTutteLeDomandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellaTutteLeDomandeToolStripMenuItem.Click
        If MsgBox("Sei sicuro di voler cancellare tutto il progetto?", MsgBoxStyle.OkCancel) = DialogResult.OK Then
            cleartab()
        End If
    End Sub
    Private Sub TestaInModalitàNormaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestaInModalitàNormaleToolStripMenuItem.Click
        If MsgBox("Per continuare è necessario salvare le modifiche. Continuare?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If Save() = True Then
                Dim stri As String = SaveFileDialog1.FileName
                Form1.Show()
                Form1.ProjectPlay.Checked = True
                Form1.startproject(stri)
            End If
        Else
            Exit Sub
        End If
        Me.Hide()
    End Sub
    Private Sub TestaInModalitàProvaATempoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestaInModalitàProvaATempoToolStripMenuItem.Click
        If MsgBox("Per continuare è necessario salvare le modifiche. Continuare?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If Save() = True Then
                Dim stri As String = SaveFileDialog1.FileName
                Form1.Show()
                Form1.TimeTrialTSMI.Checked = True
                Form1.startproject(stri)
            End If
        Else
            Exit Sub
        End If
        Me.Hide()
    End Sub
    Private Sub TestaInModalitàHighLanderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestaInModalitàHighLanderToolStripMenuItem.Click
        If MsgBox("Per continuare è necessario salvare le modifiche. Continuare?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If Save() = True Then
                Dim stri As String = SaveFileDialog1.FileName
                Form1.Show()
                Form1.HighlanderToolStripMenuItem.Checked = True
                Form1.startproject(stri)
            End If
        Else
            Exit Sub
        End If
        Me.Hide()
    End Sub
    Private Sub TestaInModalitàSandBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestaInModalitàSandBoxToolStripMenuItem.Click
        If MsgBox("Per continuare è necessario salvare le modifiche. Continuare?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If Save() = True Then
                Dim stri As String = SaveFileDialog1.FileName
                Form1.Show()
                Form1.SandBoxToolStripMenuItem.Checked = True
                Form1.startproject(stri)
            End If
        Else
            Exit Sub
        End If
        Me.Hide()
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub
End Class