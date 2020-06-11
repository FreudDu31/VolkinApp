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
        Me.txtValue = New WindowsApp1.CustomTextbox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.radType = New System.Windows.Forms.RadioButton()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.Transparent
        Me.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValue.Location = New System.Drawing.Point(82, 3)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(112, 20)
        Me.txtValue.TabIndex = 2
        '
        'lblRate
        '
        Me.lblRate.Location = New System.Drawing.Point(0, 40)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(182, 37)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rates: N/A"
        '
        'radType
        '
        Me.radType.Image = Global.WindowsApp1.My.Resources.Resources.Friendship
        Me.radType.Location = New System.Drawing.Point(3, 4)
        Me.radType.Name = "radType"
        Me.radType.Size = New System.Drawing.Size(73, 33)
        Me.radType.TabIndex = 0
        Me.radType.TabStop = True
        Me.radType.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(82, 4)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(112, 33)
        Me.lblValue.TabIndex = 3
        Me.lblValue.Text = "0"
        '
        'ucSummonType
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.radType)
        Me.Controls.Add(Me.lblValue)
        Me.Name = "ucSummonType"
        Me.Size = New System.Drawing.Size(194, 86)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radType As RadioButton
    Friend WithEvents txtValue As CustomTextbox
    Friend WithEvents lblRate As Label
    Friend WithEvents lblValue As Label
End Class
