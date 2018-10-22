Public Class Reporte


    Private cliente As New Cproveedor
    Private ReporteGeneral As New ReporteProveedor '  Variables asociadas a las clases

    Public Function General() As Integer
        Me.Show()
        If cliente.consultarTodo() > 0 Then
            ReporteGeneral.SetDataSource(cliente.Datos)
            Me.Creporte.ReportSource = ReporteGeneral
            ReporteGeneral.Refresh()
        End If
        Return 0
    End Function


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        General()
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
        Me.Hide()
    End Sub

    Private Sub Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class