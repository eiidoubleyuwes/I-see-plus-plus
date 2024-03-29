Imports System.Data.OleDb
Public Class userpage
    Dim con As New OleDbConnection
    Private Sub userpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\amera\OneDrive\Documents\Efent.mdb"
        con.Open()
        showItems()
    End Sub
    Private Sub showItems()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT *  FROM Events", con)
        da.Fill(dt)
        Lnklblevent1.Text = dt.Rows(1).Item(0)
        Lnklblevent2.Text = dt.Rows(2).Item(0)
        Lnklblevent3.Text = dt.Rows(3).Item(0)
        Lnklblevent4.Text = dt.Rows(0).Item(0)
        Lnklblevent5.Text = dt.Rows(4).Item(0)
        con.Close()
    End Sub

    Private Sub Lnklblevent1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnklblevent1.LinkClicked
        MsgBox("All are welcome to Wachira hub,an online event aimed at celebrating all the popular corn videos(including how to make and eat corn).The link price is 3,500", MsgBoxStyle.Information)

    End Sub

    Private Sub Picbx1_Click(sender As Object, e As EventArgs) Handles Picbx1.Click
        MsgBox("All are welcome to Wachira hub,an online event aimed at celebrating all the popular corn videos(including how to make and eat corn).The link price is 3,500", MsgBoxStyle.Information)


    End Sub

    Private Sub Lnklblevent2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnklblevent2.LinkClicked
        MsgBox("All are welcome to Daystar Ihub,entrance is absolutely free,the venue is at the amphitheatre.", MsgBoxStyle.Information)
    End Sub

    Private Sub Picbx3_Click(sender As Object, e As EventArgs) Handles Picbx3.Click
        MsgBox("Not everyone is welcome to Sol fest,entrance fees range from 4500 to 10000 depending on class level,the venue is on Thika Road", MsgBoxStyle.Information)

    End Sub

    Private Sub Btnclose1_5_Click(sender As Object, e As EventArgs) Handles Btnclose1_5.Click
        Me.Close()
    End Sub

    Private Sub Picbx2_Click(sender As Object, e As EventArgs) Handles Picbx2.Click
        MsgBox("All are welcome to Daystar Ihub,entrance is absolutely free,the venue is at the amphitheatre.", MsgBoxStyle.Information)

    End Sub

    Private Sub Lnklblevent3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnklblevent3.LinkClicked
        MsgBox("Not everyone is welcome to Sol fest,entrance fees range from 4500 to 10000 depending on class level,the venue is on Thika Road", MsgBoxStyle.Information)

    End Sub

    Private Sub Picbx4_Click(sender As Object, e As EventArgs) Handles Picbx4.Click
        MsgBox("Everyone is welcome to the annual Abused Animal Sanctuary Expo,where we meet to celebrate animals #savetheanimals ", MsgBoxStyle.Information)

    End Sub

    Private Sub Lnklblevent4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnklblevent4.LinkClicked
        MsgBox("Everyone is welcome to the annual Abused Animal Sanctuary Expo,where we meet to celebrate animals #savetheanimals ", MsgBoxStyle.Information)

    End Sub

    Private Sub Picbx5_Click(sender As Object, e As EventArgs) Handles Picbx5.Click

    End Sub
End Class