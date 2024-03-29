Imports System.Data.OleDb

Public Class Form1
    Dim pro As String
    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim Qry As String
    ' Dim C As New conection
    Dim cmd As OleDbCommand

    Private Sub ConDB()
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\amera\OneDrive\Documents\Efent.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub
    Private Sub Btnexito_Click(sender As Object, e As EventArgs) Handles Btnexito.Click
        Me.Close()

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\amera\OneDrive\Documents\Efent.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
        If Txtusername.Text = Nothing Or Txtpassword.Text = Nothing Then
            MsgBox("Enter Credentials please", MsgBoxStyle.Exclamation)
        Else
            If myconnection.State = ConnectionState.Closed Then
                myconnection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from Managers where Company_name=? and Password=?", myconnection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Txtusername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Txtpassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If (count > 0) Then
                MsgBox("Login succeess", MsgBoxStyle.Information)
                Managerlogin.Show()

            Else
                MsgBox("Account not found check credentials", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Btnsignup_Click(sender As Object, e As EventArgs) Handles Btnsignup.Click
        managersignup.Show()

    End Sub

    Private Sub Btnuser_Click(sender As Object, e As EventArgs) Handles Btnuser.Click
        userpage.Show()
    End Sub
End Class
