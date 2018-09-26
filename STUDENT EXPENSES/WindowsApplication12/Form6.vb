Imports System.Data.SqlClient
Public Class Form6
    Dim Sqlcn As New SqlConnection With {.ConnectionString = "Data Source=DELL;Initial Catalog=logindata;Integrated Security=True"}
    Dim Sqlcmd As New SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Public Property StringPass As String
    Public Property AddPass As String
    Public Property NotePass As String

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

    Public Function CheckDate() As Boolean
        'Check whether Entry for this Date exists or not

        If Not Sqlcn.State = ConnectionState.Open Then
            'OPEN CONNECTION IF IT IS NOT YET OPEN
            Sqlcn.Open()
        End If
        If ds IsNot Nothing Then
            ds.Clear()
        End If
        Dim db As String = Identity
        Dim doe As Date = TxtDate.Text

        Try
            Dim check As SqlCommand = New SqlCommand("SELECT Count(Date) As Ucount " &
                                                "FROM [" & db & "] " &
                                                "WHERE Date='" & doe & "' ", Sqlcn)

            da = New SqlDataAdapter(check)
            ds = New DataSet
            da.Fill(ds)
            Sqlcn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If ds.Tables(0).Rows(0).Item("Ucount") = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label7.Text = StringPass

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("   dd-MM-yyyy")
        Label6.Text = Date.Now.ToString("   hh:mm:ss")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtMoney.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim money As String = TxtMoney.Text
        Dim doe As Date = TxtDate.Text
        Dim note As String = TxtNote.Text
        Dim db As String = Identity
        Dim ca As String = AddPass
        Dim ne As String = NotePass
        If HasConnection() = True Then

            If CheckDate() = True Then
                'Entry for this date already exists
                Try
                    If Not Sqlcn.State = ConnectionState.Open Then
                        'OPEN CONNECTION IF IT IS NOT YET OPEN
                        Sqlcn.Open()
                    End If

                    'UPDATE TABLE WITH DATA
                    Dim strUpdate As String = "UPDATE [" & db & "] SET [" & ca & "] = '" & money & "' ,[" & ne & "] = '" & note &
                                               "' WHERE [Date] = '" & doe & "' "

                    Sqlcmd = New SqlCommand(strUpdate, Sqlcn)
                    Sqlcmd.ExecuteNonQuery()

                    'CLOSE CONNECTION'
                    Sqlcn.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

            '----------------------------------------------------------------------------------------------------------------

            If CheckDate() = False Then
                ''Entry for this date does not exists
                Try

                    If Not Sqlcn.State = ConnectionState.Open Then
                        'OPEN CONNECTION IF IT IS NOT YET OPEN
                        Sqlcn.Open()
                    End If

                    'ADD DATA TO THE TABLE'
                    Dim strInsert As String = "INSERT INTO [" & db & "]( [Date], [" & ca & "], [" & ne & "]) " & " VALUES('" &
                                                 doe & "','" &
                                                 money & "','" &
                                                 note & "')"

                    Sqlcmd = New SqlCommand(strInsert, Sqlcn)
                    Sqlcmd.ExecuteNonQuery()

                    'CLOSE CONNECTION'
                    Sqlcn.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

            Form10.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class