<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestaInModalitàNormaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestaInModalitàProvaATempoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestaInModalitàHighLanderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestaInModalitàSandBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiocaProgettoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserisciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovaDomandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancellaDomandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancellaTutteLeDomandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AiutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuidaAllEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(14, 79)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 588)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 16)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Nome del progetto:"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "File di Chi Vuol Essere Milionario - Chemistry Edition (cvm)|*.cvm"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.InserisciToolStripMenuItem, Me.AiutoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(737, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "Barra dei menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovoToolStripMenuItem, Me.ApriToolStripMenuItem, Me.SalvaToolStripMenuItem, Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NuovoToolStripMenuItem
        '
        Me.NuovoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.NuovoToolStripMenuItem.Name = "NuovoToolStripMenuItem"
        Me.NuovoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuovoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NuovoToolStripMenuItem.Text = "Nuovo"
        '
        'ApriToolStripMenuItem
        '
        Me.ApriToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        Me.ApriToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ApriToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ApriToolStripMenuItem.Text = "Apri"
        '
        'SalvaToolStripMenuItem
        '
        Me.SalvaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SalvaToolStripMenuItem.Name = "SalvaToolStripMenuItem"
        Me.SalvaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalvaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SalvaToolStripMenuItem.Text = "Salva"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestaInModalitàNormaleToolStripMenuItem, Me.TestaInModalitàProvaATempoToolStripMenuItem, Me.TestaInModalitàHighLanderToolStripMenuItem, Me.TestaInModalitàSandBoxToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem2.Text = "Testa"
        '
        'TestaInModalitàNormaleToolStripMenuItem
        '
        Me.TestaInModalitàNormaleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TestaInModalitàNormaleToolStripMenuItem.Name = "TestaInModalitàNormaleToolStripMenuItem"
        Me.TestaInModalitàNormaleToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.TestaInModalitàNormaleToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.TestaInModalitàNormaleToolStripMenuItem.Text = "Testa in modalità normale"
        '
        'TestaInModalitàProvaATempoToolStripMenuItem
        '
        Me.TestaInModalitàProvaATempoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TestaInModalitàProvaATempoToolStripMenuItem.Name = "TestaInModalitàProvaATempoToolStripMenuItem"
        Me.TestaInModalitàProvaATempoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TestaInModalitàProvaATempoToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.TestaInModalitàProvaATempoToolStripMenuItem.Text = "Testa in modalità prova a tempo"
        '
        'TestaInModalitàHighLanderToolStripMenuItem
        '
        Me.TestaInModalitàHighLanderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TestaInModalitàHighLanderToolStripMenuItem.Name = "TestaInModalitàHighLanderToolStripMenuItem"
        Me.TestaInModalitàHighLanderToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.TestaInModalitàHighLanderToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.TestaInModalitàHighLanderToolStripMenuItem.Text = "Testa in modalità HighLander"
        '
        'TestaInModalitàSandBoxToolStripMenuItem
        '
        Me.TestaInModalitàSandBoxToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TestaInModalitàSandBoxToolStripMenuItem.Name = "TestaInModalitàSandBoxToolStripMenuItem"
        Me.TestaInModalitàSandBoxToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.TestaInModalitàSandBoxToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.TestaInModalitàSandBoxToolStripMenuItem.Text = "Testa in Modalità SandBox"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GiocaProgettoToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripMenuItem1.Text = "Modalità"
        '
        'GiocaProgettoToolStripMenuItem
        '
        Me.GiocaProgettoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GiocaProgettoToolStripMenuItem.Name = "GiocaProgettoToolStripMenuItem"
        Me.GiocaProgettoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GiocaProgettoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.GiocaProgettoToolStripMenuItem.Text = "Gioca Progetto"
        '
        'InserisciToolStripMenuItem
        '
        Me.InserisciToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.InserisciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovaDomandaToolStripMenuItem, Me.CancellaDomandaToolStripMenuItem, Me.CancellaTutteLeDomandeToolStripMenuItem})
        Me.InserisciToolStripMenuItem.Name = "InserisciToolStripMenuItem"
        Me.InserisciToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.InserisciToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.InserisciToolStripMenuItem.Text = "Progetto"
        '
        'NuovaDomandaToolStripMenuItem
        '
        Me.NuovaDomandaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.NuovaDomandaToolStripMenuItem.Name = "NuovaDomandaToolStripMenuItem"
        Me.NuovaDomandaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuovaDomandaToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.NuovaDomandaToolStripMenuItem.Text = "Nuova Domanda"
        '
        'CancellaDomandaToolStripMenuItem
        '
        Me.CancellaDomandaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancellaDomandaToolStripMenuItem.Name = "CancellaDomandaToolStripMenuItem"
        Me.CancellaDomandaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CancellaDomandaToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.CancellaDomandaToolStripMenuItem.Text = "Cancella Domanda Selezionata"
        '
        'CancellaTutteLeDomandeToolStripMenuItem
        '
        Me.CancellaTutteLeDomandeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancellaTutteLeDomandeToolStripMenuItem.Name = "CancellaTutteLeDomandeToolStripMenuItem"
        Me.CancellaTutteLeDomandeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.CancellaTutteLeDomandeToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.CancellaTutteLeDomandeToolStripMenuItem.Text = "Cancella tutte le domande"
        '
        'AiutoToolStripMenuItem
        '
        Me.AiutoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.AiutoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuidaAllEditorToolStripMenuItem})
        Me.AiutoToolStripMenuItem.Name = "AiutoToolStripMenuItem"
        Me.AiutoToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AiutoToolStripMenuItem.Text = "Aiuto"
        '
        'GuidaAllEditorToolStripMenuItem
        '
        Me.GuidaAllEditorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GuidaAllEditorToolStripMenuItem.Name = "GuidaAllEditorToolStripMenuItem"
        Me.GuidaAllEditorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.GuidaAllEditorToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.GuidaAllEditorToolStripMenuItem.Text = "Guida all' Editor"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.cvm"
        Me.OpenFileDialog1.Filter = "File di Chi Vuol Essere Milionario - Chemistry Edition (cvm)|*.cvm"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.PowderBlue
        Me.TextBox13.Location = New System.Drawing.Point(134, 42)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(588, 23)
        Me.TextBox13.TabIndex = 25
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(737, 675)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "Editor di Chi vuol essere milionario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InserisciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovaDomandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiocaProgettoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AiutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuidaAllEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CancellaDomandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents CancellaTutteLeDomandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestaInModalitàNormaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestaInModalitàProvaATempoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestaInModalitàHighLanderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TestaInModalitàSandBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
