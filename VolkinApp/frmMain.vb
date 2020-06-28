Imports System.IO

Public Class frmMain
    Private fd As New FontDialog
    Private listCount As New List(Of ucCount)
    Private iCount As Integer
    Private listU As New List(Of ucSummonType)
    Private WithEvents kb As New KeyBinding

    Private Sub UpDown(ByVal i As Integer, ByVal bUp As Boolean)
        If listCount.Count > i Then
            listCount(i).UpDownCount(bUp)
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object,
                        ByVal e As System.EventArgs) Handles MyBase.Load
        fd.ShowColor = True
        fd.Font = My.Settings.font
        fd.Color = My.Settings.color
        chkKeyBinding.Checked = My.Settings.KeyBinding
        SetBackground(My.Settings.BackGround)
        AddSummonToList(ucSummonFriendship)
        AddSummonToList(ucSummonScroll)
        AddSummonToList(ucSummonFactionScroll)
        AddSummonToList(ucSummonDiamond)
        AddSummonToList(UcSummonStargaze)
        AddSummonToList(UcSummonPurpleFragment)
        ucSummonFriendship.Checked = True
        ApplyFont()
    End Sub

    Private Sub AddSummonToList(u As ucSummonType)
        listU.Add(u)
        AddHandler u.TypeCheckedChanged, AddressOf UncheckAllTheOther
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object,
                        ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                        Handles MyBase.FormClosing
        My.Settings.font = fd.Font
        My.Settings.color = fd.Color
        My.Settings.KeyBinding = chkKeyBinding.Checked
        My.Settings.Save()
        kb.UnsetHook()
    End Sub

    Private Sub kb_UpDown(ByVal i As Integer, ByVal bUp As Boolean) Handles kb.UpDown
        UpDown(i, bUp)
    End Sub

    Private Sub picOption_Click(sender As Object, e As EventArgs) Handles picFont.Click
        If fd.ShowDialog = DialogResult.OK Then
            ApplyFont()
        End If
    End Sub

    Private Sub picTool_Click(sender As Object, e As EventArgs) Handles picTool.Click
        Dim f As New frmTool(frmTool.eMode.bg)
        If f.ShowDialog = DialogResult.OK Then
            If f.chkTranparent.Checked Then
                Me.BackColor = Color.LimeGreen
                Me.TransparencyKey = Color.LimeGreen
                Me.BackgroundImage = Nothing
            Else
                SetBackground(f.txtBG.Text)
            End If
        End If
    End Sub

    Private Sub SetBackground(ByVal szFile As String)
        If File.Exists(szFile) Then
            Try
                Me.BackgroundImage = New Bitmap(szFile)
                My.Settings.BackGround = szFile
            Catch ex As Exception
                My.Settings.BackGround = ""
            End Try
        End If
    End Sub

    Private Sub ApplyFont()
        For Each u In listCount
            u.Font = fd.Font
            u.ForeColor = fd.Color
        Next
        For Each u In listU
            u.ApplyFont(fd.Font, fd.Color)
        Next
        chkKeyBinding.Font = fd.Font
        chkKeyBinding.ForeColor = fd.Color
    End Sub

    Private Sub picPlus_Click(sender As Object, e As EventArgs) Handles picPlus.Click
        If listCount.Count < 10 Then
            iCount += 1
            Dim u As New ucCount(iCount)
            pnlMiddle.Controls.Add(u)
            u.Dock = DockStyle.Top
            u.BringToFront()
            u.Font = fd.Font
            u.ForeColor = fd.Color
            AddHandler u.DeleteCounter, AddressOf u_DeleteCounter
            AddHandler u.EventUpDown, AddressOf u_EventUpDown
            listCount.Add(u)
        End If
    End Sub

    Private Sub u_EventUpDown(bUp As Boolean)
        Dim x = listU.First(Function(a) a.Checked)
        If bUp Then
            x.AddOnePurple()
        Else
            x.RemoveOnePurple()
        End If
    End Sub

    Private Sub u_DeleteCounter(uc As ucCount)
        pnlMiddle.Controls.Remove(uc)
        Dim u = listCount.FirstOrDefault(Function(a) a.iCompteur = uc.iCompteur)
        u.Dispose()
        listCount.Remove(u)
    End Sub

    Private Sub picMinus_Click(sender As Object, e As EventArgs) Handles picMinus.Click
        If listCount.Count > 0 Then
            pnlMiddle.Controls.Remove(listCount.Last)
            listCount.Last.Dispose()
            listCount.RemoveAt(listCount.Count - 1)
        End If
    End Sub

    Private Sub UncheckAllTheOther(ByVal e As ucSummonType.eType)
        For Each u In listU.Where(Function(a) a._Type <> e).ToList
            u.Checked = False
        Next
    End Sub

    Private Sub menuHideOptions_Click(sender As Object, e As EventArgs) Handles menuHideOptions.Click
        menuHideOptions.Checked = Not menuHideOptions.Checked
        pnlOption.Visible = Not menuHideOptions.Checked
    End Sub

    Private Sub menuHideRates_Click(sender As Object, e As EventArgs) Handles menuHideRates.Click
        menuHideRates.Checked = Not menuHideRates.Checked
        pnlRates.Visible = Not menuHideRates.Checked
    End Sub

    Private Sub chkKeyBinding_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeyBinding.CheckedChanged
        If chkKeyBinding.Checked Then
            kb.SetHook()
        Else
            kb.UnsetHook()
        End If
    End Sub
End Class