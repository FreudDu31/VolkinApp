Public Class ucSummonType
    Public Enum eType
        friendship
        scroll
        factionScroll
        diamond
    End Enum
    Public Event radTypeCheckedChanged()
    Private __Type As eType
    Private iCmpt As Integer

    Public Property _Type As eType
        Get
            Return __Type
        End Get
        Set(value As eType)
            __Type = value
            Select Case value
                Case eType.friendship : radType.Image = My.Resources.Friendship
                Case eType.scroll : radType.Image = My.Resources.Scroll
                Case eType.factionScroll : radType.Image = My.Resources.FactionScroll
                Case eType.diamond : radType.Image = My.Resources.Diamond
            End Select
        End Set
    End Property

    Private Sub radType_CheckedChanged(sender As Object, e As EventArgs) Handles radType.CheckedChanged
        RaiseEvent radTypeCheckedChanged()
    End Sub

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
            Dim a = 100 / CInt(lblValue.Text) * iCmpt
            lblRate.Text = "Rates: " & Format(a, "0.00") & "%"
        End If
    End Sub
End Class
