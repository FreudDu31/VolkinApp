Imports System.Runtime.InteropServices
Public Class KeyBinding

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

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private _proc As LowLevelKeyboardProc = AddressOf HookCallback
    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Private _hookID As IntPtr = IntPtr.Zero

    Public Event UpDown(ByVal i As Integer, ByVal bUp As Boolean)

    Private Function HookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso wParam = CType(WM_KEYDOWN, IntPtr) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            Dim bUp As Boolean = If(Keys.Control = Control.ModifierKeys, False, True)
            Select Case CType(vkCode, Keys)
                Case Keys.NumPad0 : RaiseEvent UpDown(0, bUp)
                Case Keys.NumPad1 : RaiseEvent UpDown(1, bUp)
                Case Keys.NumPad2 : RaiseEvent UpDown(2, bUp)
                Case Keys.NumPad3 : RaiseEvent UpDown(3, bUp)
                Case Keys.NumPad4 : RaiseEvent UpDown(4, bUp)
                Case Keys.NumPad5 : RaiseEvent UpDown(5, bUp)
                Case Keys.NumPad6 : RaiseEvent UpDown(6, bUp)
                Case Keys.NumPad7 : RaiseEvent UpDown(7, bUp)
                Case Keys.NumPad8 : RaiseEvent UpDown(8, bUp)
                Case Keys.NumPad9 : RaiseEvent UpDown(9, bUp)
            End Select
        End If

        Return CallNextHookEx(_hookID, nCode, wParam, lParam)
    End Function

    Public Sub SetHook()
        Using curProcess As Process = Process.GetCurrentProcess()

            Using curModule As ProcessModule = curProcess.MainModule
                _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, GetModuleHandle(curModule.ModuleName), 0)
            End Using
        End Using
    End Sub

    Public Sub UnsetHook()
        UnhookWindowsHookEx(_hookID)
    End Sub
End Class
