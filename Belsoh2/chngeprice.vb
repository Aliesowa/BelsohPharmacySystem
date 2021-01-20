
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation

Public Class chngeprice

    Dim connection As New SqlConnection("server=ADMINRG-RKGDBT7\SQLEXPRESS ; Database = Belsoh; integrated security = true")

    Private Sub chngeprice_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        connection.Open()
        Dim cmd As New SqlCommand("select FirstName + ' '+ LastName as 'Username' from Users where Username = '" & login.username.Text & "' ", connection)

        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader

        While rd.Read()
            BarStaticItem2.Caption = rd("Username")
        End While

        rd.Close()
        connect()

        connection.Close()

        stocklist()




    End Sub

    Sub connect()

        If ConnectionState.Open Then

            BarStaticItem1.Caption = "Connected"
            BarStaticItem1.ItemAppearance.Normal.BackColor = Color.Green




        Else
            BarStaticItem1.Caption = "Disconnected"
            BarStaticItem1.ItemAppearance.Normal.BackColor = Color.Red
        End If




    End Sub

    Sub stocklist()

        If ConnectionState.Open Then
            connection.Close()

        End If

        Try


            connection.Open()
            Dim tb As New DataTable
            Dim adpt As New SqlDataAdapter("select * From stock", connection)

            adpt.Fill(tb)
            stockbox.DataSource = tb
            stockbox.DisplayMember = "productName"
            stockbox.ValueMember = "productName"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            connection.Close()
        End Try

    End Sub

    Sub populate_list()

        If ConnectionState.Open Then
            connection.Close()
        End If

        connection.Open()
        Dim stocklist As String = stockbox.SelectedValue.ToString()
        Dim cmds As New SqlCommand

        cmds.Connection = connection

        cmds.CommandText = "select * from stock where productName = '" & stocklist & "' "

        If ConnectionState.Open Then
            connection.Close()
        End If

        Dim rds As SqlDataReader
        connection.Open()

        rds = cmds.ExecuteReader
        'displaying to the textbox in stock
        While rds.Read

            currentprice.Text = "Le " + rds("currentPrice").ToString()

        End While

        rds.Close()
        connection.Close()
    End Sub

    Private Sub stockbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stockbox.SelectedIndexChanged
        populate_list()

    End Sub

    Private Sub changePrice2_Click(sender As Object, e As EventArgs) Handles changePrice2.Click
        currentprice.Text = newprice.Text

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If ConnectionState.Open Then
            connection.Close()
        End If

        Try


            connection.Open()
            Dim stocklist As String = stockbox.SelectedValue.ToString()
            Dim cmds As New SqlCommand

            cmds.Connection = connection

            cmds.CommandText = "update stock set  currentPrice = '" & currentprice.Text & "' where productName = '" & stocklist & "' "

            Dim rds As SqlDataReader


            rds = cmds.ExecuteReader


            MessageBox.Show("Updated Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            connection.Close()

        End Try

    End Sub

    Private Sub BarEditItem1_ShownEditor(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles searchprice.ShownEditor

    End Sub



    Private Sub BarEditItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarEditItem1.ItemClick

    End Sub




    Private Sub SearchControl1_TextChanged(sender As Object, e As EventArgs) Handles SearchControl1.TextChanged
        If SearchControl1.Text <> String.Empty Then


            Dim index As Integer = stockbox.FindString(SearchControl1.Text)
            ' Determine if a valid index is returned. Select the item if it is valid. 
            If index <> -1 Then
                stockbox.SetSelected(index, True)
            Else

            End If
        End If
    End Sub
End Class