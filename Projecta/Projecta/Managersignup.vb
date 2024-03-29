Imports System.Data.OleDb

Public Class Managersignup
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

    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\amera\OneDrive\Documents\Efent.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
        If Txtcompanyname.Text = Nothing Or Txtpassword.Text = Nothing Or Txtemailaddress.Text = Nothing Or Txtlocation.Text = Nothing Or Txtphonenumber.Text = Nothing Then
            MsgBox("Enter Credentials please", MsgBoxStyle.Critical)
        Else
            If myconnection.State = ConnectionState.Closed Then
                    myconnection.Open()
                End If
            Dim cmd As New OleDbCommand("Insert into Managers values(@Email,@Company_name,@Phone_number,@Location,@Password)", myconnection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Txtemailaddress.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Txtcompanyname.Text
                cmd.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = Txtphonenumber.Text
                cmd.Parameters.AddWithValue("@4", OleDbType.VarChar).Value = Txtlocation.Text
            cmd.Parameters.AddWithValue("@5", OleDbType.VarChar).Value = Txtpassword.Text

            cmd.ExecuteNonQuery()

            Managerlogin.Show()
            Me.Close()
        End If
        myconnection.Close()

    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Txtphonenumber_TextChanged(sender As Object, e As EventArgs) Handles Txtphonenumber.TextChanged

    End Sub
End Class