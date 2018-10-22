Imports System.Windows.Forms

Public Class MenuPrincipal
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir del Sistema", MsgBoxStyle.Question + vbYesNo, "Mensaje del Sistema") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroToolStripMenuItem.Click
        registro.Show()

    End Sub
End Class
