Public Class Form4

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdAddExpense.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAddIncome.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "How much Money you want to Add"
        OBJ.AddPass = "Income"
        OBJ.NotePass = "IncoNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim balan As New Form12
        balan.Show()
        balan.Close()
        LblBal.Text = FinBalance
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Main.Show()
        Me.Close()
    End Sub
End Class