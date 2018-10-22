<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Creporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Creporte
        '
        Me.Creporte.ActiveViewIndex = -1
        Me.Creporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Creporte.DisplayGroupTree = False
        Me.Creporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Creporte.Location = New System.Drawing.Point(0, 0)
        Me.Creporte.Name = "Creporte"
        Me.Creporte.SelectionFormula = ""
        Me.Creporte.Size = New System.Drawing.Size(881, 625)
        Me.Creporte.TabIndex = 0
        Me.Creporte.ViewTimeSelectionFormula = ""
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 625)
        Me.Controls.Add(Me.Creporte)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Creporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
