Public Class Form5
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Food"
        OBJ.AddPass = "Food"
        OBJ.NotePass = "FoodNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Others"
        OBJ.AddPass = "Others"
        OBJ.NotePass = "OtheNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Transport"
        OBJ.AddPass = "Transport"
        OBJ.NotePass = "TranNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Medical"
        OBJ.AddPass = "Medical"
        OBJ.NotePass = "MediNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Entertainment"
        OBJ.AddPass = "Entertainment"
        OBJ.NotePass = "EnteNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Market"
        OBJ.AddPass = "Market"
        OBJ.NotePass = "MarkNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Clothes"
        OBJ.AddPass = "Clothes"
        OBJ.NotePass = "ClotNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New Form6
        OBJ.StringPass = "Enter the Money spent on Stationary"
        OBJ.AddPass = "Stationary"
        OBJ.NotePass = "StatNote"
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class