Imports System.IO
Public Class Form3

    Dim m As MsgBoxResult
    Dim t As String

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        Try
            If File.Exists(t & ".txt") = True Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                LblHeading.Enabled = False
                LblHeading.Hide()
                TxtNote.Enabled = True
                TxtNote.Show()
                cmdSave.Enabled = True
                cmdSave.Show()
                cmdBack.Enabled = True
                cmdBack.Show()
                TxtNote.Text = File.ReadAllText(t & ".txt")

            Else
                m = MsgBox("Would you like to add Notes for this Date ?", MsgBoxStyle.YesNo)
                If m = MsgBoxResult.Yes Then
                    MonthCalendar1.Enabled = False
                    MonthCalendar1.Hide()
                    LblHeading.Enabled = False
                    LblHeading.Hide()
                    TxtNote.Enabled = True
                    TxtNote.Show()
                    cmdSave.Enabled = True
                    cmdSave.Show()
                    cmdBack.Enabled = True
                    cmdBack.Show()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        TxtNote.Enabled = False
        TxtNote.Hide()
        cmdSave.Enabled = False
        cmdSave.Hide()
        cmdBack.Enabled = False
        cmdBack.Hide()
        MonthCalendar1.Enabled = True
        MonthCalendar1.Show()
        LblHeading.Enabled = True
        LblHeading.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            If TxtNote.Text = "" Then
                If File.Exists(t & ".txt") = True Then
                    File.Delete(t & ".txt")
                    MsgBox("Note was deleted Successfully. Press Back to Continue")
                End If
            End If

            If TxtNote.Text.Length > 0 Then
                File.WriteAllText(t & ".txt", TxtNote.Text)
                MsgBox("Note was added Successfully. Press Back to Continue")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m1 As MsgBoxResult
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        If Date.Today = MonthCalendar1.TodayDate And File.Exists(t & ".txt") = True Then
            m1 = MsgBox("View Today's Events ?", MsgBoxStyle.YesNo)
            If m1 = MsgBoxResult.Yes Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                LblHeading.Enabled = False
                LblHeading.Hide()
                TxtNote.Enabled = True
                TxtNote.Show()
                cmdSave.Enabled = True
                cmdSave.Show()
                cmdBack.Enabled = True
                cmdBack.Show()
                TxtNote.Text = File.ReadAllText(t & ".txt")

            End If
        End If

    End Sub

End Class