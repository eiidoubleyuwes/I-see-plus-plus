Public Class Managerlogin
    Private Sub Btnaddevent_Click(sender As Object, e As EventArgs) Handles Btnaddevent.Click
        Addevent.Show()
        Me.Close()
    End Sub

    Private Sub Btnclose3_Click(sender As Object, e As EventArgs) Handles Btnclose3.Click
        Me.Close()
    End Sub

    Private Sub Btnremoveevent_Click(sender As Object, e As EventArgs) Handles Btnremoveevent.Click
        Removeevent.Show()
        Me.Close()

    End Sub


End Class