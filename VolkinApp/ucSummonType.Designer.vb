<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSummonType
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.picType = New System.Windows.Forms.PictureBox()
        Me.txtValue = New WindowsApp1.CustomTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.picType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRate
        '
        Me.lblRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRate.Location = New System.Drawing.Point(0, 0)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(190, 35)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rates: N/A"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(82, 4)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(112, 33)
        Me.lblValue.TabIndex = 3
        Me.lblValue.Text = "0"
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(192, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(2, 76)
        Me.pnlRight.TabIndex = 0
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(2, 76)
        Me.pnlLeft.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(2, 74)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(190, 2)
        Me.pnlBottom.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(2, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(190, 2)
        Me.pnlTop.TabIndex = 0
        '
        'picType
        '
        Me.picType.Image = Global.WindowsApp1.My.Resources.Resources.PurpleFragment
        Me.picType.Location = New System.Drawing.Point(5, 5)
        Me.picType.Name = "picType"
        Me.picType.Size = New System.Drawing.Size(30, 30)
        Me.picType.TabIndex = 0
        Me.picType.TabStop = False
        '
        'txtValue
        '
        Me.txtValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue.BackColor = System.Drawing.Color.Transparent
        Me.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValue.Location = New System.Drawing.Point(42, 5)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(145, 20)
        Me.txtValue.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblRate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 35)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblValue)
        Me.Panel2.Controls.Add(Me.txtValue)
        Me.Panel2.Controls.Add(Me.picType)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 37)
        Me.Panel2.TabIndex = 0
        '
        'ucSummonType
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.Name = "ucSummonType"
        Me.Size = New System.Drawing.Size(194, 76)
        CType(Me.picType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picType As PictureBox
    Friend WithEvents txtValue As CustomTextbox
    Friend WithEvents lblRate As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
