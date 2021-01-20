
Imports System.Data.SqlClient

Public Class Configsetting



    'Dim connection As New SqlConnection(" Persist Security Info=False; User ID='" & My.Settings.Dbuser & " '; Initial Catalog='" & My.Settings.Dbdatabase & "'; 
    'Data Source = '" & My.Settings.Dbserver & "';Initial File Name="";Server SPN=""")



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        My.Settings.Dbserver = TextBox1.Text
        My.Settings.Dbuser = TextBox3.Text
        My.Settings.Dbpassword = TextBox4.Text
        My.Settings.Dbdatabase = TextBox2.Text




        My.Settings.Save()

        My.Settings.Reload()

        Try
            connection.Open()
            If ConnectionState.Open Then
                MsgBox("Connected")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public connection As New SqlConnection("server = '" & My.Settings.Dbserver & "'; User = '" & My.Settings.Dbuser & "' ;Password = '" & My.Settings.Dbpassword & "'; 
                                    Database = '" & My.Settings.Dbdatabase & "' ")

End Class