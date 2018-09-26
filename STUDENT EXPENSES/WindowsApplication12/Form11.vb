Imports System.Data.SqlClient

Public Class Form11
    Dim Sqlcn As New SqlConnection With {.ConnectionString = "Data Source=DELL;Initial Catalog=logindata;Integrated Security=True"}
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dt As New DataTable

    Public Property CadetPass As String

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

    Public Function Evaluation() As Boolean
        Dim eval As String = CadetPass
        If eval = "Category" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNm.Text = UsrNam
        LblCad1.Text = CadetPass
        Evaluation()
        If Evaluation() = True Then
            PanelCtgry.Show()
            PanelDate.Hide()
            DGVCat.Show()
            DGVDate.Hide()
        End If
        If Evaluation() = False Then
            PanelDate.Show()
            DGVCat.Hide()
            DGVDate.Show()
            PanelCtgry.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Evaluation() = True Then
            'SEARCHING CATEGORY-WISE
            Dim catg As String = ddlCat.SelectedItem
            Dim notg As String

            If catg = "Food" Then
                notg = "FoodNote"
            ElseIf catg = "Clothes" Then
                notg = "ClotNote"
            ElseIf catg = "Stationary" Then
                notg = "StatNote"
            ElseIf catg = "Market" Then
                notg = "MarkNote"
            ElseIf catg = "Entertainment" Then
                notg = "EnteNote"
            ElseIf catg = "Medical" Then
                notg = "MediNote"
            ElseIf catg = "Transport" Then
                notg = "TranNote"
            ElseIf catg = "Others" Then
                notg = "OtheNote"
            ElseIf catg = "Income" Then
                notg = "IncoNote"
            Else
                notg = " "
            End If

            Dim db As String = Identity
            If HasConnection() = True Then
                If Not Sqlcn.State = ConnectionState.Open Then
                    'OPEN CONNECTION IF IT IS NOT YET OPEN
                    Sqlcn.Open()
                End If

                If ds IsNot Nothing Then
                    ds.Clear()
                End If

                Try
                    'To Select Desired fields from table
                    Dim Sqlcmd As SqlCommand = New SqlCommand("SELECT [Date], [" & catg & "],[" & notg & "]" &
                                                          "FROM [" & db & "]", Sqlcn)
                    da = New SqlDataAdapter(Sqlcmd)
                    ds = New DataSet
                    da.Fill(ds)
                    Sqlcn.Close()

                    DGVCat.DataSource = ds.Tables(0)
                    DGVCat.Refresh()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

        '--------------------------------------------------------------------------------------------------------------------

        If Evaluation() = False Then
            'SEARCHING DATE-WISE

            If HasConnection() = True Then
                If Not Sqlcn.State = ConnectionState.Open Then
                    'OPEN CONNECTION IF IT IS NOT YET OPEN
                    Sqlcn.Open()
                End If

                If ds IsNot Nothing Then
                    ds.Clear()
                End If

                If TxtDate.Text = "" Then
                    MsgBox("Please Enter a valid Date", MsgBoxStyle.OkOnly)
                Else
                    Dim doe As Date = TxtDate.Text
                    Dim db As String = Identity
                    Try
                        'To Select Desired fields from table
                        Dim Sqlcmd As SqlCommand = New SqlCommand("SELECT * " &
                                                          "FROM [" & db & "]" &
                                                          "WHERE [Date] = '" & doe & "' ", Sqlcn)
                        da = New SqlDataAdapter(Sqlcmd)
                        ds = New DataSet
                        da.Fill(ds)
                        Sqlcn.Close()

                        DGVDate.DataSource = ds.Tables(0)
                        DGVDate.Refresh()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub PanelDate_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TxtDate_ValueChanged(sender As Object, e As EventArgs) Handles TxtDate.ValueChanged

    End Sub
End Class