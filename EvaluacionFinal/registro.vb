Public Class registro

    Private proveedor As New Cproveedor

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProveedorDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ProveedorDataSet.cliente)
    End Sub

    Private Function limpiar() As Integer
        txtrif.Text = "" '  Coloca todas las cajas de texto en blanco
        txtnombre.Text = ""
        txttlf.Text = ""
        txtdireccion.Text = ""
        txtrepre.Text = ""
        txtemail.Text = ""

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If ((txtrif.Text) = "") Then
            MsgBox("El campo (RIF) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtnombre.Text) = "") Then
            MsgBox("El campo (NOMBRE) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txttlf.Text) = "") Then
            MsgBox("El campo (TELEFONO) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtdireccion.Text) = "") Then
            MsgBox("El campo (DIRECCION) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtrepre.Text) = "") Then
            MsgBox("El campo (REPRESENTANTE) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtrepre.Text) = "") Then
            MsgBox("El campo (EMAIL) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        Else
            If (proveedor.Guardar(txtrif.Text, txtnombre.Text, txttlf.Text, txtdireccion.Text, txtrepre.Text, txtemail.Text) = True) Then
                MsgBox("Proveedor agregado con exito", MsgBoxStyle.Information, "Mensaje del Sistema")
                limpiar()
                proveedor.consultarTodo()
            Else
                MsgBox("Proveedor ya tiene este Rif", MsgBoxStyle.Information, "Mensaje del Sistema")

            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If ((txtrif.Text) = "") Then
            MsgBox("El campo (RIF) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        Else
            If (proveedor.consultarRif(txtrif.Text) = True) Then
                txtnombre.Text = proveedor.Datos.Rows(0).Item("Nombre").ToString
                txttlf.Text = proveedor.Datos.Rows(0).Item("Telefono").ToString
                txtdireccion.Text = proveedor.Datos.Rows(0).Item("Direccion").ToString
                txtrepre.Text = proveedor.Datos.Rows(0).Item("Representante").ToString
                txtemail.Text = proveedor.Datos.Rows(0).Item("Email").ToString
            Else
                MsgBox("Proveedor no Existe", MsgBoxStyle.Information, "Mensaje del Sistema")

            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If ((txtrif.Text) = "") Then
            MsgBox("El campo (RIF) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtnombre.Text) = "") Then
            MsgBox("El campo (NOMBRE) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txttlf.Text) = "") Then
            MsgBox("El campo (TELEFONO) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtdireccion.Text) = "") Then
            MsgBox("El campo (DIRECCION) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtrepre.Text) = "") Then
            MsgBox("El campo (REPRESENTANTE) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        ElseIf ((txtrepre.Text) = "") Then
            MsgBox("El campo (EMAIL) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        Else
            proveedor.Modificar(txtrif.Text, txtnombre.Text, txttlf.Text, txtdireccion.Text, txtrepre.Text, txtemail.Text)
            MsgBox("Proveedor modificado con exito", MsgBoxStyle.Information, "Mensaje del Sistema")

            limpiar()
            proveedor.consultarTodo()

        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If ((txtrif.Text) = "") Then
            MsgBox("El campo (RIF) no puede quedar vacío!!", MsgBoxStyle.Critical, "Mensaje de erro del Sistema ")
        Else
            proveedor.Eliminar(txtrif.Text)
            MsgBox("Proveedor eliminado con exito", MsgBoxStyle.Information, "Mensaje del Sistema")
            limpiar()
            proveedor.consultarTodo()
        End If
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.ClienteTableAdapter.Fill(Me.ProveedorDataSet.cliente)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverReporte.Click
        Reporte.Show()
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.ClienteTableAdapter.Update(Me.ProveedorDataSet.cliente)

    End Sub


    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click

    End Sub
End Class

