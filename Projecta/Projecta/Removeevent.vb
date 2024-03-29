Imports System.Data.OleDb
Public Class Removeevent
    Dim conString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim str As String
    Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
    Private Sub Removeevent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txteventname.TextChanged

    End Sub

    Private Sub Btncloze_Click(sender As Object, e As EventArgs) Handles Btncloze.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\amera\OneDrive\Documents\Efent.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
        Dim str As String
        If Txteventname.Text = Nothing Then
            MsgBox("Enter Event name please", MsgBoxStyle.Critical)
        Else
            If myconnection.State = ConnectionState.Closed Then
                myconnection.Open()
            End If
            str = "Delete * from Events Where [Event_name] = " & Txteventname.Text & ""
            Dim cmd As New OleDbCommand(str, myconnection)

            cmd.ExecuteNonQuery()

            userpage.Show()
            Me.Close()
        End If
        myconnection.Close()
    End Sub
End Class