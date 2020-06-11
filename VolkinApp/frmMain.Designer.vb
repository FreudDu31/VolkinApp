<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picFont = New System.Windows.Forms.PictureBox()
        Me.picTool = New System.Windows.Forms.PictureBox()
        Me.pnlMiddle = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuHideOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHideRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlOption = New System.Windows.Forms.Panel()
        Me.chkKeyBinding = New System.Windows.Forms.CheckBox()
        Me.picMinus = New System.Windows.Forms.PictureBox()
        Me.picPlus = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlRates = New System.Windows.Forms.Panel()
        Me.ucSummonFriendship = New WindowsApp1.ucSummonType()
        Me.ucSummonScroll = New WindowsApp1.ucSummonType()
        Me.ucSummonFactionScroll = New WindowsApp1.ucSummonType()
        Me.ucSummonDiamond = New WindowsApp1.ucSummonType()
        CType(Me.picFont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlOption.SuspendLayout()
        CType(Me.picMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRates.SuspendLayout()
        Me.SuspendLayout()
        '
        'picFont
        '
        Me.picFont.Image = Global.WindowsApp1.My.Resources.Resources.font
        Me.picFont.Location = New System.Drawing.Point(3, 3)
        Me.picFont.Name = "picFont"
        Me.picFont.Size = New System.Drawing.Size(24, 24)
        Me.picFont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFont.TabIndex = 3
        Me.picFont.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picFont, "Change font")
        '
        'picTool
        '
        Me.picTool.Image = Global.WindowsApp1.My.Resources.Resources.tools
        Me.picTool.Location = New System.Drawing.Point(33, 3)
        Me.picTool.Name = "picTool"
        Me.picTool.Size = New System.Drawing.Size(24, 24)
        Me.picTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTool.TabIndex = 4
        Me.picTool.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picTool, "Change background")
        '
        'pnlMiddle
        '
        Me.pnlMiddle.BackColor = System.Drawing.Color.Transparent
        Me.pnlMiddle.ContextMenuStrip = Me.ContextMenuStrip1
        Me.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMiddle.Location = New System.Drawing.Point(0, 208)
        Me.pnlMiddle.Name = "pnlMiddle"
        Me.pnlMiddle.Size = New System.Drawing.Size(388, 664)
        Me.pnlMiddle.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHideOptions, Me.menuHideRates})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(143, 48)
        '
        'menuHideOptions
        '
        Me.menuHideOptions.Name = "menuHideOptions"
        Me.menuHideOptions.Size = New System.Drawing.Size(142, 22)
        Me.menuHideOptions.Text = "Hide options"
        '
        'menuHideRates
        '
        Me.menuHideRates.Name = "menuHideRates"
        Me.menuHideRates.Size = New System.Drawing.Size(142, 22)
        Me.menuHideRates.Text = "Hide rates"
        '
        'pnlOption
        '
        Me.pnlOption.BackColor = System.Drawing.Color.Transparent
        Me.pnlOption.Controls.Add(Me.chkKeyBinding)
        Me.pnlOption.Controls.Add(Me.picMinus)
        Me.pnlOption.Controls.Add(Me.picPlus)
        Me.pnlOption.Controls.Add(Me.picFont)
        Me.pnlOption.Controls.Add(Me.picTool)
        Me.pnlOption.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOption.Location = New System.Drawing.Point(0, 0)
        Me.pnlOption.Name = "pnlOption"
        Me.pnlOption.Size = New System.Drawing.Size(388, 38)
        Me.pnlOption.TabIndex = 0
        '
        'chkKeyBinding
        '
        Me.chkKeyBinding.AutoSize = True
        Me.chkKeyBinding.Location = New System.Drawing.Point(123, 3)
        Me.chkKeyBinding.Name = "chkKeyBinding"
        Me.chkKeyBinding.Size = New System.Drawing.Size(79, 17)
        Me.chkKeyBinding.TabIndex = 6
        Me.chkKeyBinding.Text = "KeyBinding"
        Me.ToolTip1.SetToolTip(Me.chkKeyBinding, "Key binding are NumPad0 to NumPad9 from top to buttom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can Ctrl+NumPad to cou" &
        "nt down")
        Me.chkKeyBinding.UseVisualStyleBackColor = True
        '
        'picMinus
        '
        Me.picMinus.Image = Global.WindowsApp1.My.Resources.Resources.navigate_minus
        Me.picMinus.Location = New System.Drawing.Point(93, 3)
        Me.picMinus.Name = "picMinus"
        Me.picMinus.Size = New System.Drawing.Size(24, 24)
        Me.picMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMinus.TabIndex = 5
        Me.picMinus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picMinus, "Delete the last counter")
        '
        'picPlus
        '
        Me.picPlus.Image = Global.WindowsApp1.My.Resources.Resources.plus
        Me.picPlus.Location = New System.Drawing.Point(63, 3)
        Me.picPlus.Name = "picPlus"
        Me.picPlus.Size = New System.Drawing.Size(24, 24)
        Me.picPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPlus.TabIndex = 5
        Me.picPlus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picPlus, "Add a new counter")
        '
        'pnlRates
        '
        Me.pnlRates.BackColor = System.Drawing.Color.Transparent
        Me.pnlRates.Controls.Add(Me.ucSummonFriendship)
        Me.pnlRates.Controls.Add(Me.ucSummonScroll)
        Me.pnlRates.Controls.Add(Me.ucSummonFactionScroll)
        Me.pnlRates.Controls.Add(Me.ucSummonDiamond)
        Me.pnlRates.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRates.Location = New System.Drawing.Point(0, 38)
        Me.pnlRates.Name = "pnlRates"
        Me.pnlRates.Size = New System.Drawing.Size(388, 170)
        Me.pnlRates.TabIndex = 0
        '
        'ucSummonFriendship
        '
        Me.ucSummonFriendship._Type = WindowsApp1.ucSummonType.eType.friendship
        Me.ucSummonFriendship.BackColor = System.Drawing.Color.Transparent
        Me.ucSummonFriendship.Location = New System.Drawing.Point(0, 0)
        Me.ucSummonFriendship.Name = "ucSummonFriendship"
        Me.ucSummonFriendship.Size = New System.Drawing.Size(194, 85)
        Me.ucSummonFriendship.TabIndex = 0
        '
        'ucSummonScroll
        '
        Me.ucSummonScroll._Type = WindowsApp1.ucSummonType.eType.scroll
        Me.ucSummonScroll.BackColor = System.Drawing.Color.Transparent
        Me.ucSummonScroll.Location = New System.Drawing.Point(194, 0)
        Me.ucSummonScroll.Name = "ucSummonScroll"
        Me.ucSummonScroll.Size = New System.Drawing.Size(194, 85)
        Me.ucSummonScroll.TabIndex = 1
        '
        'ucSummonFactionScroll
        '
        Me.ucSummonFactionScroll._Type = WindowsApp1.ucSummonType.eType.factionScroll
        Me.ucSummonFactionScroll.BackColor = System.Drawing.Color.Transparent
        Me.ucSummonFactionScroll.Location = New System.Drawing.Point(3, 85)
        Me.ucSummonFactionScroll.Name = "ucSummonFactionScroll"
        Me.ucSummonFactionScroll.Size = New System.Drawing.Size(194, 85)
        Me.ucSummonFactionScroll.TabIndex = 2
        '
        'ucSummonDiamond
        '
        Me.ucSummonDiamond._Type = WindowsApp1.ucSummonType.eType.diamond
        Me.ucSummonDiamond.BackColor = System.Drawing.Color.Transparent
        Me.ucSummonDiamond.Location = New System.Drawing.Point(194, 85)
        Me.ucSummonDiamond.Name = "ucSummonDiamond"
        Me.ucSummonDiamond.Size = New System.Drawing.Size(194, 85)
        Me.ucSummonDiamond.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.bg2
        Me.ClientSize = New System.Drawing.Size(388, 872)
        Me.Controls.Add(Me.pnlMiddle)
        Me.Controls.Add(Me.pnlRates)
        Me.Controls.Add(Me.pnlOption)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "VolkinApp"
        CType(Me.picFont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlOption.ResumeLayout(False)
        Me.pnlOption.PerformLayout()
        CType(Me.picMinus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRates.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picFont As PictureBox
    Friend WithEvents picTool As PictureBox
    Friend WithEvents pnlMiddle As Panel
    Friend WithEvents pnlOption As Panel
    Friend WithEvents picMinus As PictureBox
    Friend WithEvents picPlus As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlRates As Panel
    Friend WithEvents ucSummonFriendship As ucSummonType
    Friend WithEvents ucSummonScroll As ucSummonType
    Friend WithEvents ucSummonDiamond As ucSummonType
    Friend WithEvents ucSummonFactionScroll As ucSummonType
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents menuHideOptions As ToolStripMenuItem
    Friend WithEvents menuHideRates As ToolStripMenuItem
    Friend WithEvents chkKeyBinding As CheckBox
End Class
