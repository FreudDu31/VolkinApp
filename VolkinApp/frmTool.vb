Public Class frmTool
    Private Sub btnBG_Click(sender As Object, e As EventArgs) Handles btnBG.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            txtBG.Text = ofd.FileName
        End If
    End Sub

    Private Sub frmTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Enum eMode
        bg
        img
    End Enum

    Public Sub New(ByVal mode As eMode)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Select Case mode
            Case eMode.bg : lblTitre.Text = "Background"
            Case Else : lblTitre.Text = "Picture"
        End Select
    End Sub
End Class