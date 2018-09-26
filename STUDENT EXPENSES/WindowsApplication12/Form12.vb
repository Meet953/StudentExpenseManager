Imports System.Data.SqlClient
Public Class Form12
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

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNam.Text = UsrNam

        Dim db As String = Identity
        Dim TotFood As String
        Dim TotMedic As String
        Dim TotMark As String
        Dim TotEnter As String
        Dim TotCloth As String
        Dim TotOther As String
        Dim TotTrans As String
        Dim TotStat As String
        Dim TotI As String
        Dim TotIncome As String
        Dim TotExpense As String
        Dim balance As String

        If HasConnection() = True Then

            Try

                If Not Sqlcn.State = ConnectionState.Open Then
                    'OPEN CONNECTION IF IT IS NOT YET OPEN
                    Sqlcn.Open()
                End If

                'FOR FOOD
                Sqlds.Clear()

                Dim Sqlcmdfo As SqlCommand = New SqlCommand("SELECT isnull(SUM(Food),0) As TotFo " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdfo)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotFood = Sqlds.Tables(0).Rows(0).Item(0)
                TxtFood.Text = TotFood

                'FOR CLOTHES
                Sqlds.Clear()

                Dim Sqlcmdcl As SqlCommand = New SqlCommand("SELECT isnull(SUM(Clothes),0) As TotCl " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdcl)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotCloth = Sqlds.Tables(0).Rows(0).Item(0)
                TxtCloth.Text = TotCloth

                'FOR STATIONARY
                Sqlds.Clear()

                Dim Sqlcmdst As SqlCommand = New SqlCommand("SELECT isnull(SUM(Stationary),0) As TotSt " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdst)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotStat = Sqlds.Tables(0).Rows(0).Item(0)
                TxtStat.Text = TotStat

                'FOR MARKET
                Sqlds.Clear()

                Dim Sqlcmdma As SqlCommand = New SqlCommand("SELECT isnull(SUM(Market),0) As TotMa " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdma)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotMark = Sqlds.Tables(0).Rows(0).Item(0)
                TxtMarket.Text = TotMark

                'FOR ENTERTAINMENT
                Sqlds.Clear()

                Dim Sqlcmden As SqlCommand = New SqlCommand("SELECT isnull(SUM(Entertainment),0) As TotEn " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmden)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotEnter = Sqlds.Tables(0).Rows(0).Item(0)
                TxtEntertain.Text = TotEnter

                'FOR MEDICAL
                Sqlds.Clear()

                Dim Sqlcmdme As SqlCommand = New SqlCommand("SELECT isnull(SUM(Medical),0) As TotMe " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdme)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotMedic = Sqlds.Tables(0).Rows(0).Item(0)
                TxtMedic.Text = TotMedic

                'FOR TRANSPORT
                Sqlds.Clear()

                Dim Sqlcmdtr As SqlCommand = New SqlCommand("SELECT isnull(SUM(Transport),0) As Tottr " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdtr)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotTrans = Sqlds.Tables(0).Rows(0).Item(0)
                TxtTrans.Text = TotTrans

                'FOR OTHERS
                Sqlds.Clear()

                Dim Sqlcmdot As SqlCommand = New SqlCommand("SELECT isnull(SUM(Others),0) As TotOt " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdot)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotOther = Sqlds.Tables(0).Rows(0).Item(0)
                TxtOther.Text = TotOther

                'FOR Income
                Sqlds.Clear()

                Dim Sqlcmdinc As SqlCommand = New SqlCommand("SELECT isnull(SUM(Income),0) As TotInc " &
                                                                "FROM [" & db & " ]", Sqlcn)


                Sqlda = New SqlDataAdapter(Sqlcmdinc)
                Sqlds = New DataSet
                Sqlda.Fill(Sqlds)
                TotI = Sqlds.Tables(0).Rows(0).Item(0)
                TxtIncome.Text = TotI

                'FOR OVERALL BALANCE
                TotExpense = Val(TotFood) + Val(TotCloth) + Val(TotEnter) + Val(TotMark) + Val(TotMedic) + Val(TotOther) + Val(TotStat) + Val(TotTrans)
                TxtExpenses.Text = TotExpense
                TotIncome = Val(TotI)
                balance = TotIncome - TotExpense
                FinBalance = balance
                TxtBal.Text = balance

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        Sqlcn.Close()

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Main.Show()
        Me.Close()
    End Sub
End Class