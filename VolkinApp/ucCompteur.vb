Imports System.IO

Public Class ucCompteur
    Public iCompteur As Integer
    Public Sub New(ByVal iCompteur As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.iCompteur = iCompteur
    End Sub

    Public Event DeleteCounter(ByVal uc As ucCompteur)
    Public Event EventUpDown(ByVal bUp As Boolean)

    Private Sub ucCompteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblObjectif_Click(sender As Object, e As EventArgs) Handles lblObjectif.Click

    End Sub

    Private Sub lblObjectif_MouseClick(sender As Object, e As MouseEventArgs) Handles lblObjectif.MouseClick
        If e.Button = MouseButtons.Right Then
            If lblObjectif.Text <> "∞" Then
                If lblObjectif.Text = "1" Then
                    lblObjectif.Text = "∞"
                Else
                    lblObjectif.Text = CType(CInt(lblObjectif.Text) - 1, String)
                End If
            End If
        ElseIf e.Button = MouseButtons.Left Then
            If lblObjectif.Text = "∞" Then
                lblObjectif.Text = "1"
            Else
                lblObjectif.Text = CType(CInt(lblObjectif.Text) + 1, String)
            End If
        End If
    End Sub

    Private Sub lblCurrent_MouseClick(sender As Object, e As MouseEventArgs) Handles lblCurrent.MouseClick
        If e.Button = MouseButtons.Right Then
            UpDownCount(False)
        ElseIf e.Button = MouseButtons.Left Then
            UpDownCount(True)
        End If
    End Sub

    Public Sub UpDownCount(ByVal bUp As Boolean)
        If bUp Then
            lblCurrent.Text = CType(CInt(lblCurrent.Text) + 1, String)
            RaiseEvent EventUpDown(bUp)
        Else
            If lblCurrent.Text <> "0" Then
                RaiseEvent EventUpDown(bUp)
                lblCurrent.Text = CType(CInt(lblCurrent.Text) - 1, String)
            End If
        End If
    End Sub

    Private Sub picImg_MouseClick(sender As Object, e As MouseEventArgs) Handles picImg.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim f As New frmTool(frmTool.eMode.img)
            If f.ShowDialog = DialogResult.OK Then
                If File.Exists(f.txtBG.Text) Then
                    Try
                        picImg.Image = New Bitmap(f.txtBG.Text)
                    Catch ex As Exception

                    End Try
                End If
            End If
        Else
            If MsgBox("Do you want to delete this counter?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                RaiseEvent DeleteCounter(Me)
            End If
        End If
    End Sub
End Class
