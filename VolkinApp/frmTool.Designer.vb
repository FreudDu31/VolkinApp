<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTool
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTool))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.txtBG = New System.Windows.Forms.TextBox()
        Me.btnBG = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.chkTranparent = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(12, 17)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(65, 13)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Background"
        '
        'txtBG
        '
        Me.txtBG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBG.Location = New System.Drawing.Point(83, 14)
        Me.txtBG.Name = "txtBG"
        Me.txtBG.Size = New System.Drawing.Size(308, 20)
        Me.txtBG.TabIndex = 1
        '
        'btnBG
        '
        Me.btnBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBG.Location = New System.Drawing.Point(398, 12)
        Me.btnBG.Name = "btnBG"
        Me.btnBG.Size = New System.Drawing.Size(28, 23)
        Me.btnBG.TabIndex = 2
        Me.btnBG.Text = "..."
        Me.btnBG.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(141, 66)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(222, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chkTranparent
        '
        Me.chkTranparent.AutoSize = True
        Me.chkTranparent.Location = New System.Drawing.Point(15, 40)
        Me.chkTranparent.Name = "chkTranparent"
        Me.chkTranparent.Size = New System.Drawing.Size(143, 17)
        Me.chkTranparent.TabIndex = 5
        Me.chkTranparent.Text = "Transparent background"
        Me.chkTranparent.UseVisualStyleBackColor = True
        Me.chkTranparent.Visible = False
        '
        'frmTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 104)
        Me.Controls.Add(Me.chkTranparent)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnBG)
        Me.Controls.Add(Me.txtBG)
        Me.Controls.Add(Me.lblTitre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lblTitre As Label
    Friend WithEvents txtBG As TextBox
    Friend WithEvents btnBG As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents chkTranparent As CheckBox
End Class
