Imports System.Data.SqlClient
Public Class Login
    Dim Sqlcn As New SqlConnection With {.ConnectionString = "Data Source=DELL;Initial Catalog=logindata;Integrated Security=True"}

    Dim Sqlda As SqlDataAdapter
    Dim Sqlds As DataSet
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim Usr As String

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProgressBar1.Hide()
        Pic.Hide()
    End Sub


    Public Sub info()
        If Not Sqlcn.State = ConnectionState.Open Then
            'OPEN CONNECTION IF IT IS NOT YET OPEN
            Sqlcn.Open()
        End If
        If Sqlds IsNot Nothing Then
            Sqlds.Clear()
        End If

        Try
            Dim info As SqlCommand = New SqlCommand("SELECT [User ID] " &
                                                "FROM [login] " &
                                                "WHERE UserName='" & Usr & "' ", Sqlcn)

            da = New SqlDataAdapter(info)
            ds = New DataSet
            da.Fill(ds)
            Sqlcn.Close()

            UsrID = ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub CreateTable()
        Dim SQLCn As New SqlConnection With {.ConnectionString = "Data Source=DELL;Initial Catalog=logindata;Integrated Security=True"}
        SQLCn.Open()
        Try
            Dim db As String = UsrID
            Identity = UsrID
            Dim SQLCmd As New SqlCommand("CREATE TABLE" & "[" & db & " ]" & "(" &
                                           "Date VARCHAR(30), " &
                                           "Income money, " &
                                           "Food money, " &
                                           "Stationary money, " &
                                           "Clothes money, " &
                                           "Market money, " &
                                           "Entertainment money, " &
                                           "Medical money, " &
                                           "Transport money, " &
                                           "Others money, " &
                                           "FoodNote text, " &
                                           "StatNote text, " &
                                           "ClotNote text, " &
                                           "MarkNote text, " &
                                           "EnteNote text, " &
                                           "MediNote text, " &
                                           "TranNote text, " &
                                           "OtheNote text, " &
                                           "IncoNote text" &
                                           ")", SQLCn)

            SQLCmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Progress()
        Pic.Show()
        ProgressBar1.Show()
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(40)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Main.Show()
            ProgressBar1.Value = 0
            ProgressBar1.Hide()
            Pic.Hide()
            TxtPassword.Text = ""
            TxtUserName.Text = ""
            Me.Hide()
        End If
    End Sub

    Private Sub CmdAdminLogin_Click_2(sender As Object, e As EventArgs) Handles CmdAdminLogin.Click
        If HasConnection() = True Then
            If Not Sqlcn.State = ConnectionState.Open Then
                'OPEN CONNECTION IF IT IS NOT YET OPEN
                Sqlcn.Open()
            End If
            If Sqlds IsNot Nothing Then
                Sqlds.Clear()
            End If

            Try

                'TO SELECT USERNAME AND PASSWORD
                Dim Sqlcmd As SqlCommand = New SqlCommand("SELECT Count(UserName) As Usercount " &
                                                             "FROM [login]" &
                                                             "WHERE [UserName]='" & Me.TxtUserName.Text & "' " &
                                                             " AND [Password] = '" & Me.TxtPassword.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS ", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmd)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                Sqlcn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Following will check matches
            If Sqlds.Tables(0).Rows(0).Item("Usercount") = 1 Then
                Usr = TxtUserName.Text
                UsrNam = Usr
                info()
                CreateTable()
                Progress()

            Else
                MsgBox("Invalid UserName or Password", MsgBoxStyle.Critical, "LOGIN FAILED")
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub CmdAdmincancel_Click_1(sender As Object, e As EventArgs) Handles CmdAdmincancel.Click
        End
    End Sub
End Class