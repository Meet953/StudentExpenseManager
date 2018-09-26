Imports System.Data.SqlClient
Imports System.IO

Public Class Form8
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

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim pass As String = TxtPass.Text
        Dim passw As String = TxtPassw.Text

        If (String.Compare(pass, passw) = 0) Then

            If Not Sqlcn.State = ConnectionState.Open Then
                'OPEN CONNECTION IF IT IS NOT YET OPEN'
                Sqlcn.Open()
            End If

            Try


                'ADD DATA TO THE TABLE'
                Dim strInsert As String = "INSERT INTO [login]([User ID], [UserName], [Password], [E-mail]) " & " VALUES('" &
                Me.TxtID.Text & "','" &
                Me.TxtUser.Text & "','" &
                Me.TxtPass.Text & "','" &
                Me.TxtEmail.Text & "')"

                Sqlcmd = New SqlCommand(strInsert, Sqlcn)
                Sqlcmd.ExecuteNonQuery()

                'CLOSE CONNECTION'
                Sqlcn.Close()

                'CALL ANOTHER FORM'
                Form9.Show()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Passwords Do Not match", MsgBoxStyle.OkOnly, "Error!")
            TxtID.Text = ""
            TxtUser.Text = ""
            TxtPass.Text = ""
            TxtPassw.Text = ""
            TxtEmail.Text = ""

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.Show()
        Me.Close()

    End Sub
End Class