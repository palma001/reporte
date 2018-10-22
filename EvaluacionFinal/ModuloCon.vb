Option Explicit On
Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text

Module ModuloCon

    Public Conexion As New Data.OleDb.OleDbConnection
    Public Comandos As New Data.OleDb.OleDbCommand
    Public CadenaSQL As String

    Sub principal()
        Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & AppDomain.CurrentDomain.BaseDirectory() & "\proveedor.mdb"
        Comandos.CommandType = CommandType.Text
        Comandos.CommandText = CadenaSQL
        Comandos.Connection = Conexion
    End Sub

    Public Function abrir() As Boolean

        abrir = False

        Try
            If cerrar() = True Then
                principal()
                Conexion.Open()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Mensaje del sistema")
        End Try
    End Function

    Public Function cerrar() As Boolean
        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If
        Return True
    End Function


End Module
