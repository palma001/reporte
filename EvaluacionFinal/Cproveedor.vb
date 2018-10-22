Public Class Cproveedor
    Public Datos As New Data.DataTable


    Public Function consultarRif(ByVal Rif As String) As Boolean
        ModuloCon.CadenaSQL = "Select * From cliente where Rif='" & Rif & "';"

        ModuloCon.abrir()
        Datos.Clear()
        Datos.Load(ModuloCon.Comandos.ExecuteReader)
        ModuloCon.cerrar()
        If Datos.Rows.Count > 0 Then
            consultarRif = True
        Else
            consultarRif = False
        End If
    End Function

    Public Function consultarTodo() As Integer
        ModuloCon.CadenaSQL = "Select * From cliente;"
        ModuloCon.abrir()
        Datos.Clear()
        Datos.Load(ModuloCon.Comandos.ExecuteReader)
        ModuloCon.cerrar()
        consultarTodo = Datos.Rows.Count

    End Function

    Public Function Guardar(ByVal Rif As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Direccion As String, ByVal representante As String, ByVal Email As String) As Boolean
        If (consultarRif(Rif) = False) Then
            ModuloCon.CadenaSQL = ("Insert Into cliente(Rif, Nombre, Telefono, Direccion, Representante, Email) Values ('" & Rif & "', '" & Nombre & "', '" & Telefono & "', '" & Direccion & "', '" & representante & "', '" & Email & "');") '  Sentencia SQL que Guarda los Datos en la tabla
            ModuloCon.abrir()
            Comandos.ExecuteNonQuery()
            ModuloCon.cerrar()
            Guardar = True
        Else
            Guardar = False
        End If

    End Function

    Public Function Modificar(ByVal Rif As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Direccion As String, ByVal Representante As String, ByVal Email As String) As Boolean
        If (consultarRif(Rif) = True) Then
            ModuloCon.CadenaSQL = "update cliente set Nombre = '" & Nombre & "', Telefono= '" & Telefono & "', Direccion='" & Direccion & "', Representante='" & Representante & "', Email='" & Email & "' Where Rif = '" & Rif & "';" '  Sentencia SQL que Modifica los Datos en la tabla
            ModuloCon.abrir()
            Comandos.ExecuteNonQuery()
            ModuloCon.cerrar()
            Modificar = True
        Else
            Modificar = False
        End If

    End Function

    Public Function Eliminar(ByVal Rif As String) As Boolean
        If (consultarRif(Rif) = True) Then
            ModuloCon.CadenaSQL = "delete * From cliente Where Rif='" & Rif & "';"
            ModuloCon.abrir()
            Comandos.ExecuteNonQuery()
            ModuloCon.cerrar()

            Eliminar = True
        Else
            Eliminar = False
        End If

    End Function
End Class

