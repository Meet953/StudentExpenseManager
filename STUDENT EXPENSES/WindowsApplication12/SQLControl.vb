Imports System.Data.SqlClient
Imports System.IO
Public Class SQLControl
    Dim Sqlcn As New SqlConnection With {.ConnectionString = "Data Source=DELL;Initial Catalog=logindata;Integrated Security=True"}
    Dim Sqlcmd As New SqlCommand
    Dim Sqlda As New SqlDataAdapter
    Dim Sqlds As New DataSet

    Public Function HasConnection() As Boolean
        Try
            Sqlcn.Open()
            Sqlcn.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False

    End Function

End Class
