Public Class ucSummonType
    Public Enum eType
        friendship
        scroll
        factionScroll
        diamond
        stargaze
        purpleFragment
    End Enum
    Public Event TypeCheckedChanged(e As eType)
    Private __Type As eType
    Private iCmpt As Integer
    Private _Checked As Boolean
    Private ReadOnly Property dblCohesive As Double
        Get
            Select Case __Type
                Case eType.diamond : Return 270
                Case eType.friendship : Return 10
                Case Else : Return 1
            End Select
        End Get
    End Property
    Public Property Checked As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            If value Then
                RaiseEvent TypeCheckedChanged(__Type)
                pnlBottom.BackColor = Color.FromArgb(25, 159, 154)
                pnlLeft.BackColor = Color.FromArgb(25, 159, 154)
                pnlRight.BackColor = Color.FromArgb(25, 159, 154)
                pnlTop.BackColor = Color.FromArgb(25, 159, 154)
            Else
                pnlBottom.BackColor = Color.Transparent
                pnlLeft.BackColor = Color.Transparent
                pnlRight.BackColor = Color.Transparent
                pnlTop.BackColor = Color.Transparent
            End If
        End Set
    End Property

    Public Property _Type As eType
        Get
            Return __Type
        End Get
        Set(value As eType)
            __Type = value
            Select Case value
                Case eType.friendship : picType.Image = My.Resources.Friendship
                Case eType.scroll : picType.Image = My.Resources.Scroll
                Case eType.factionScroll : picType.Image = My.Resources.FactionScroll
                Case eType.diamond : picType.Image = My.Resources.Diamond
                Case eType.stargaze : picType.Image = My.Resources.Stargaze
                Case eType.purpleFragment
                    picType.Image = My.Resources.PurpleFragment
                    lblRate.Visible = False
                    txtValue.Visible = False
                    lblValue.Visible = False
            End Select
        End Set
    End Property

    Private Sub ucSummonType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblValue.BringToFront()
    End Sub

    Private Sub lblValue_Click(sender As Object, e As EventArgs) Handles lblValue.Click
        txtValue.BringToFront()
        txtValue.Text = lblValue.Text
        txtValue.Focus()
    End Sub

    Private Sub txtValue_Leave(sender As Object, e As EventArgs) Handles txtValue.Leave
        lblValue.Text = txtValue.Text
        lblValue.BringToFront()
        If Not IsNumeric(lblValue.Text) OrElse CInt(lblValue.Text) < 0 Then
            lblValue.Text = "0"
        End If
    End Sub

    Public Sub ApplyFont(ByVal f As Font, ByVal c As Color)
        Me.Font = f
        Me.ForeColor = c
        lblValue.SetBounds(txtValue.Bounds.X, txtValue.Bounds.Y, txtValue.Bounds.Width, txtValue.Bounds.Height)
    End Sub

    Private Sub txtValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValue.KeyPress
        If e.KeyChar = vbCr Then
            lblValue.Focus()
        End If
    End Sub

    Public Sub AddOnePurple()
        iCmpt += 1
        DoTheMath()
    End Sub

    Public Sub RemoveOnePurple()
        iCmpt -= 1
        DoTheMath()
    End Sub

    Private Sub DoTheMath()
        If iCmpt = 0 OrElse lblValue.Text = "0" Then
            lblRate.Text = "Rates: N/A"
        Else
            Dim a = 100 / (CInt(lblValue.Text) / dblCohesive) * iCmpt
            lblRate.Text = "Rates: " & Format(a, "0.00") & "%"
        End If
    End Sub

    Private Sub picType_Click(sender As Object, e As EventArgs) Handles picType.Click
        Checked = True
    End Sub
End Class
