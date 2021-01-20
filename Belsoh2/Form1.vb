
Imports System.Data.SqlClient


Public Class login

    Public connection As New SqlConnection("server = '" & My.Settings.Dbserver & "'; User = '" & My.Settings.Dbuser & "' ;Password = '" & My.Settings.Dbpassword & "'; 
                                    Database = '" & My.Settings.Dbdatabase & "' ")




    'Dim connection As New SqlConnection("Server = 192.168.88.253; Database = Belsoh; User = Alie; Password = 1234")

    'Dim connection As New SqlConnection("server=ADMINRG-RKGDBT7\SQLEXPRESS ; Database = Belsoh; integrated security = true")
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = DateAndTime.Now()

        'Try
        '    If connection.State = ConnectionState.Closed Then

        '        connection.Open()
        '        Label6.Text = "Connected"
        '        Label6.BackColor = Color.Green
        '        Label6.Visible = True

        '        'MessageBox.Show("Database Connected", "", MessageBoxButtons.OK)

        '    End If
        'Catch ex As Exception
        '    Label6.Text = "Disconnected"
        '    Label6.BackColor = Color.Red
        '    Label6.Visible = True

        'End Try
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim user As String
            Dim pass As String

            user = username.Text()
            pass = userpass.Text()



            If (username.Text() = Nothing) Then
                MessageBox.Show("Please enter Username", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            ElseIf (userpass.Text() = Nothing) Then
                MessageBox.Show("Please enter " + user + "'s" + " password", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


            End If


            Dim cmd As New SqlCommand
            cmd.Connection = connection

            cmd.CommandText = "select * from Users where Username = '" & username.Text & "' and Pass_word = '" & userpass.Text & "' "

            Dim rd As SqlDataReader

            connection.Open()


            rd = cmd.ExecuteReader

            If rd.HasRows Then
                Me.Hide()
                main2.Show()

            Else
                Label5.Visible = True
                Label5.Text = "Wrong Username or Password"
                rd.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            'RadioButton1.Text = "Disconnected"
            'RadioButton1.BackColor = Color.Red
            'RadioButton1.Checked = False
        End Try


    End Sub



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If userpass.UseSystemPasswordChar = True Then
            userpass.UseSystemPasswordChar = False
            SimpleButton1.ImageOptions.Image = My.Resources.show_32x32



        ElseIf userpass.UseSystemPasswordChar = False Then
            userpass.UseSystemPasswordChar = True
            SimpleButton1.ImageOptions.Image = My.Resources.hide_32x32


        End If



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Configsetting.ShowDialog()
    End Sub
End Class
