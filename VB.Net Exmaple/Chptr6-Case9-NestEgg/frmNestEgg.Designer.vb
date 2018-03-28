<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNestEgg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNestEgg))
        Me.mnuExitClear = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.txtDownpament = New System.Windows.Forms.TextBox()
        Me.lblDownpayment = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstSavings = New System.Windows.Forms.ListBox()
        Me.mnuExitClear.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuExitClear
        '
        Me.mnuExitClear.BackColor = System.Drawing.Color.White
        Me.mnuExitClear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuExitClear.Location = New System.Drawing.Point(0, 0)
        Me.mnuExitClear.Name = "mnuExitClear"
        Me.mnuExitClear.Size = New System.Drawing.Size(284, 24)
        Me.mnuExitClear.TabIndex = 0
        Me.mnuExitClear.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(5, 105)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(275, 22)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Start Saving Your Nest Egg"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Chptr6_Case9_NestEgg.My.Resources.Resources.Santander_Logo
        Me.picLogo.Location = New System.Drawing.Point(0, 27)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(284, 75)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(92, 226)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 3
        Me.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(92, 177)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtInterest.TabIndex = 4
        Me.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterest.ForeColor = System.Drawing.Color.Red
        Me.lblInterest.Location = New System.Drawing.Point(76, 160)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(133, 14)
        Me.lblInterest.TabIndex = 5
        Me.lblInterest.Text = "Input Interest (percent)"
        Me.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.ForeColor = System.Drawing.Color.Red
        Me.lblYears.Location = New System.Drawing.Point(77, 209)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(131, 14)
        Me.lblYears.TabIndex = 6
        Me.lblYears.Text = "Input Amount of Years"
        Me.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDownpament
        '
        Me.txtDownpament.Location = New System.Drawing.Point(92, 275)
        Me.txtDownpament.Name = "txtDownpament"
        Me.txtDownpament.Size = New System.Drawing.Size(100, 20)
        Me.txtDownpament.TabIndex = 8
        Me.txtDownpament.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDownpayment
        '
        Me.lblDownpayment.AutoSize = True
        Me.lblDownpayment.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownpayment.ForeColor = System.Drawing.Color.Red
        Me.lblDownpayment.Location = New System.Drawing.Point(83, 258)
        Me.lblDownpayment.Name = "lblDownpayment"
        Me.lblDownpayment.Size = New System.Drawing.Size(119, 14)
        Me.lblDownpayment.TabIndex = 9
        Me.lblDownpayment.Text = "Input Downpayment"
        Me.lblDownpayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Red
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(105, 311)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lstSavings
        '
        Me.lstSavings.FormattingEnabled = True
        Me.lstSavings.Location = New System.Drawing.Point(82, 355)
        Me.lstSavings.Name = "lstSavings"
        Me.lstSavings.Size = New System.Drawing.Size(120, 95)
        Me.lstSavings.TabIndex = 11
        '
        'frmNestEgg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.lstSavings)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDownpayment)
        Me.Controls.Add(Me.txtDownpament)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuExitClear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuExitClear
        Me.Name = "frmNestEgg"
        Me.Text = "Start Saving Your Nest Egg"
        Me.mnuExitClear.ResumeLayout(False)
        Me.mnuExitClear.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuExitClear As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents lblInterest As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents txtDownpament As TextBox
    Friend WithEvents lblDownpayment As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lstSavings As ListBox
End Class
