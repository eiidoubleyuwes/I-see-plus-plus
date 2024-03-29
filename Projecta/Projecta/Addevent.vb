Imports System.Data.OleDb
Public Class Addevent
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
    Private Sub Btnsubmitevent_Click(sender As Object, e As EventArgs) Handles Btnsubmitevent.Click
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\amera\OneDrive\Documents\Efent.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
        If Txteventdetails.Text = Nothing Or Txteventlocation.Text = Nothing Or Txteventname.Text = Nothing Or Txteventprice.Text = Nothing Then
            MsgBox("Enter Credentials please", MsgBoxStyle.Critical)
        Else
            If myconnection.State = ConnectionState.Closed Then
                myconnection.Open()
            End If
            Dim cmd As New OleDbCommand("Insert into Events values(@Event_name,@Event_price,@Event_location,@Event_details)", myconnection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Txteventname.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Txteventprice.Text
            cmd.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = Txteventlocation.Text
            cmd.Parameters.AddWithValue("@4", OleDbType.VarChar).Value = Txteventdetails.Text

            cmd.ExecuteNonQuery()

            userpage.Show()
            Me.Close()
        End If
        myconnection.Close()

    End Sub

    Private Sub BtnClose4_Click(sender As Object, e As EventArgs) Handles BtnClose4.Click
        Me.Close()
    End Sub
End Class