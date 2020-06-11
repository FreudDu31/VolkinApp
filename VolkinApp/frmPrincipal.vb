Imports System.IO
Imports System.Runtime.InteropServices
Imports WindowsApp1

Public Class frmPrincipal

    'Public Const MOD_ALT As Integer = &H1
    'Public Const MOD_CRTL As Integer = &H2
    'Public Const MOD_SHIFT As Integer = &H4
    'Public Const WM_HOTKEY As Integer = &H312
    Private fd As New FontDialog
    Private listCompteur As New List(Of ucCompteur)
    Private iCompteur As Integer

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private _proc As LowLevelKeyboardProc = AddressOf HookCallback
    Private _hookID As IntPtr = IntPtr.Zero

    Private Function SetHook(ByVal proc As LowLevelKeyboardProc) As IntPtr
        Using curProcess As Process = Process.GetCurrentProcess()

            Using curModule As ProcessModule = curProcess.MainModule
                Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0)
            End Using
        End Using
    End Function

    Private listU As New List(Of ucSummonType)

    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Function HookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso wParam = CType(WM_KEYDOWN, IntPtr) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            Dim bUp As Boolean = If(Keys.Control = Control.ModifierKeys, False, True)
            Select Case CType(vkCode, Keys)
                Case Keys.NumPad0 : UpDown(0, bUp)
                Case Keys.NumPad1 : UpDown(1, bUp)
                Case Keys.NumPad2 : UpDown(2, bUp)
                Case Keys.NumPad3 : UpDown(3, bUp)
                Case Keys.NumPad4 : UpDown(4, bUp)
                Case Keys.NumPad5 : UpDown(5, bUp)
                Case Keys.NumPad6 : UpDown(6, bUp)
                Case Keys.NumPad7 : UpDown(7, bUp)
                Case Keys.NumPad8 : UpDown(8, bUp)
                Case Keys.NumPad9 : UpDown(9, bUp)
            End Select
        End If

        Return CallNextHookEx(_hookID, nCode, wParam, lParam)
    End Function

    Private Sub UpDown(ByVal i As Integer, ByVal bUp As Boolean)
        If listCompteur.Count > i Then
            listCompteur(i).UpDownCount(bUp)
        End If
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr

    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As Boolean

    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr

    End Function





    '<DllImport("User32.dll")>
    'Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr,
    '                    ByVal id As Integer, ByVal fsModifiers As Integer,
    '                    ByVal vk As Integer) As Integer
    'End Function

    '<DllImport("User32.dll")>
    'Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr,
    '                    ByVal id As Integer) As Integer
    'End Function

    Private Sub Form1_Load(ByVal sender As System.Object,
                        ByVal e As System.EventArgs) Handles MyBase.Load
        _hookID = SetHook(_proc)
        fd.ShowColor = True
        fd.Font = My.Settings.font
        fd.Color = My.Settings.color
        ucSummonFriendship.ApplyFont(My.Settings.font, My.Settings.color)
        ucSummonScroll.ApplyFont(My.Settings.font, My.Settings.color)
        ucSummonScroll.radType.Checked = False
        ucSummonFactionScroll.ApplyFont(My.Settings.font, My.Settings.color)
        ucSummonFactionScroll.radType.Checked = False
        ucSummonDiamond.ApplyFont(My.Settings.font, My.Settings.color)
        ucSummonDiamond.radType.Checked = False
        ApplyFont()
        listU.Add(ucSummonFriendship)
        listU.Add(ucSummonScroll)
        listU.Add(ucSummonFactionScroll)
        listU.Add(ucSummonDiamond)
    End Sub

    'Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
    '    If m.Msg = WM_HOTKEY Then
    '        Dim id As IntPtr = m.WParam
    '        If CInt(id) < 0 Then
    '            listCompteur((CInt(id) * -1) - 1).UpDownCount(False)
    '        Else
    '            listCompteur(CInt(id) - 1).UpDownCount(True)
    '        End If
    '    End If
    '    MyBase.WndProc(m)
    'End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object,
                        ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                        Handles MyBase.FormClosing
        My.Settings.font = fd.Font
        My.Settings.color = fd.Color
        My.Settings.Save()
        UnhookWindowsHookEx(_hookID)
        'UnregisterHotKey(Me.Handle, 100)
        'UnregisterHotKey(Me.Handle, 200)
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
                If File.Exists(f.txtBG.Text) Then
                    Try
                        Me.BackgroundImage = New Bitmap(f.txtBG.Text)
                    Catch ex As Exception

                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub ApplyFont()
        For Each u In listCompteur
            u.Font = fd.Font
            u.ForeColor = fd.Color
        Next
    End Sub

    Private Sub picPlus_Click(sender As Object, e As EventArgs) Handles picPlus.Click
        If listCompteur.Count < 10 Then
            iCompteur += 1
            Dim u As New ucCompteur(iCompteur)
            pnlMiddle.Controls.Add(u)
            u.Dock = DockStyle.Top
            u.BringToFront()
            u.Font = fd.Font
            u.ForeColor = fd.Color
            AddHandler u.DeleteCounter, AddressOf u_DeleteCounter
            AddHandler u.EventUpDown, AddressOf u_EventUpDown
            listCompteur.Add(u)
            'AddKeyBinding()
        End If
    End Sub

    Private Sub u_EventUpDown(bUp As Boolean)
        Dim x = listU.First(Function(a) a.radType.Checked)
        If bUp Then
            x.AddOnePurple()
        Else
            x.RemoveOnePurple()
        End If
    End Sub

    'Private Sub AddKeyBinding()
    '    Select Case listCompteur.Count
    '        Case 1
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad0)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad0)
    '        Case 2
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad1)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad1)
    '        Case 3
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad2)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad2)
    '        Case 4
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad3)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad3)
    '        Case 5
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad4)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad4)
    '        Case 6
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad5)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad5)
    '        Case 7
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad6)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad6)
    '        Case 8
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad7)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad7)
    '        Case 9
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad8)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad8)
    '        Case 10
    '            RegisterHotKey(Me.Handle, listCompteur.Count, 0, Keys.NumPad9)
    '            RegisterHotKey(Me.Handle, listCompteur.Count * -1, MOD_ALT, Keys.NumPad9)
    '    End Select
    'End Sub


    Private Sub u_DeleteCounter(uc As ucCompteur)
        pnlMiddle.Controls.Remove(uc)
        Dim u = listCompteur.FirstOrDefault(Function(a) a.iCompteur = uc.iCompteur)
        u.Dispose()
        listCompteur.Remove(u)
    End Sub

    Private Sub picMinus_Click(sender As Object, e As EventArgs) Handles picMinus.Click
        If listCompteur.Count > 0 Then
            pnlMiddle.Controls.Remove(listCompteur.Last)
            listCompteur.Last.Dispose()
            listCompteur.RemoveAt(listCompteur.Count - 1)
        End If
    End Sub

    Private Sub ucSummonScroll_radTypeCheckedChanged() Handles ucSummonScroll.radTypeCheckedChanged
        If ucSummonScroll.radType.Checked = True Then
            ucSummonFriendship.radType.Checked = False
            ucSummonFactionScroll.radType.Checked = False
            ucSummonDiamond.radType.Checked = False
        End If
    End Sub

    Private Sub ucSummonFriendship_radTypeCheckedChanged() Handles ucSummonFriendship.radTypeCheckedChanged
        If ucSummonFriendship.radType.Checked = True Then
            ucSummonScroll.radType.Checked = False
            ucSummonFactionScroll.radType.Checked = False
            ucSummonDiamond.radType.Checked = False
        End If
    End Sub

    Private Sub ucSummonFactionScroll_radTypeCheckedChanged() Handles ucSummonFactionScroll.radTypeCheckedChanged
        If ucSummonFactionScroll.radType.Checked = True Then
            ucSummonFriendship.radType.Checked = False
            ucSummonScroll.radType.Checked = False
            ucSummonDiamond.radType.Checked = False
        End If
    End Sub

    Private Sub ucSummonDiamond_radTypeCheckedChanged() Handles ucSummonDiamond.radTypeCheckedChanged
        If ucSummonDiamond.radType.Checked = True Then
            ucSummonFriendship.radType.Checked = False
            ucSummonFactionScroll.radType.Checked = False
            ucSummonScroll.radType.Checked = False
        End If
    End Sub

    Private Sub menuHideOptions_Click(sender As Object, e As EventArgs) Handles menuHideOptions.Click
        menuHideOptions.Checked = Not menuHideOptions.Checked
        pnlOption.Visible = Not menuHideOptions.Checked
    End Sub

    Private Sub menuHideRates_Click(sender As Object, e As EventArgs) Handles menuHideRates.Click
        menuHideRates.Checked = Not menuHideRates.Checked
        pnlRates.Visible = Not menuHideRates.Checked
    End Sub
End Class