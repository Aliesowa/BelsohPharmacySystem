Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation




Public Class main2



    'Dim connection As New SqlConnection("Server = 192.168.88.253; Database = Belsoh; User = Alie; Password = 1234")

    Public currency As String

    Public sum As Double

    Public connection As New SqlConnection("server = '" & My.Settings.Dbserver & "'; User = '" & My.Settings.Dbuser & "' ;Password = '" & My.Settings.Dbpassword & "'; 
                                    Database = '" & My.Settings.Dbdatabase & "' ")



    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        BarStaticItem4.Caption = DateTime.Now

        connection.Open()
        Dim cmd As New SqlCommand("select FirstName + ' '+ LastName as Username from Users where Username = '" & login.username.Text & "' ", connection)

        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader

        While rd.Read()
            BarStaticItem3.Caption = rd("Username")
        End While

        rd.Close()
        connection.Close()


        Try
            connect()
            filluserlist()
            reset()
            PurchaseReset()
            exresets()

            stockremain.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            connection.Close()
        End Try

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
    Sub datagrid()

        If ConnectionState.Open Then
            connection.Close()
        End If
        connection.Open()
        Dim tb As New DataTable

        Dim adpt As New SqlDataAdapter("select sales_date as Date,Item,Quantity,Price,Discount,Total,salesid as ID  From Sales where sales_date = '" & DateTimePicker1.Value.ToShortDateString & "'  ", connection)

        adpt.Fill(tb)

        DataGridView1.DataSource = tb
        adpt.Dispose()

        connection.Close()

    End Sub

    Sub exdatagrid()
        connection.Open()
        Dim tbe As New DataTable

        'Dim adpt As New SqlDataAdapter("select sales_date as 'Date',  From Sales where sales_date like '%" & DateTimePicker1.Value.ToShortDateString & "%' ", connection)
        Dim adp As New SqlDataAdapter("select expendID as ID,expendate as Date,Amount, Purpose From Expenditure where expendate = '" & exPicker2.Value.ToShortDateString & "'  ", connection)

        adp.Fill(tbe)


        DataGridView2.DataSource = tbe
        connection.Close()

    End Sub

    Sub purchasesdatagrid()
        If ConnectionState.Open Then
            connection.Close()
        End If


        Dim tbe As New DataTable

        'Dim adpt As New SqlDataAdapter("select sales_date as 'Date',  From Sales where sales_date like '%" & DateTimePicker1.Value.ToShortDateString & "%' ", connection)
        Dim adp As New SqlDataAdapter("select purchaseDate as Date, product_name as Product, expiryDate as Expiry, Quantity, Price, Discount, Total, 
                                        Description, proid From purchases where purchaseDate = '" & purchasesDate.Value.ToShortDateString & "'  ", connection)
        connection.Open()

        adp.Fill(tbe)


        PurchasesgridVew.DataSource = tbe

        connection.Close()

    End Sub
    Sub connect()

        If ConnectionState.Open Then

            BarStaticItem2.Caption = "Connected"
            BarStaticItem2.ItemAppearance.Normal.BackColor = Color.Green




        Else
            BarStaticItem2.Caption = "Disconnected"
            BarStaticItem2.ItemAppearance.Normal.BackColor = Color.Red
        End If




    End Sub
    Sub salestotal()
        If ConnectionState.Open Then
            connection.Close()

        End If
        Try
            Dim cmds As New SqlCommand("select * from Sales where sales_date = '" & DateTimePicker1.Value.ToShortDateString & "' ", connection)

            Dim rds As SqlDataReader
            connection.Open()

            rds = cmds.ExecuteReader

            'if there is a record then it performs he calculation
            If rds.HasRows Then
                rds.Close()

                Dim cmd As New SqlCommand
                cmd.Connection = connection

                cmd.CommandText = "select  sum(total) as Totalsales from Sales where sales_date = '" & DateTimePicker1.Value.ToShortDateString & "' "

                Dim rd As SqlDataReader

                currency = ComboBox2.Text

                rd = cmd.ExecuteReader

                If rd.HasRows Then
                    While rd.Read()
                        grandtotal.Text = currency + " " + rd("Totalsales").ToString

                    End While

                    rd.Close()



                End If

            End If




            connection.Close()



        Catch e As Exception
            MsgBox(e.Message)

        Finally
            connection.Close()
        End Try

    End Sub
    Sub expendtotal()

        ' check first if there is record of purchases as at the date in the database before it calculate the total

        If ConnectionState.Open Then
            connection.Close()
        End If

        Try
            Dim cmds As New SqlCommand("select * from Expenditure where expendate = '" & exPicker2.Value.ToShortDateString & "' ", connection)

            Dim rds As SqlDataReader
            connection.Open()

            rds = cmds.ExecuteReader

            'if there is a record then it performs he calculation
            If rds.HasRows Then
                rds.Close()

                Dim cmd As New SqlCommand
                cmd.Connection = connection

                cmd.CommandText = "select  sum(Amount) as Totalexpenditure from Expenditure where expendate = '" & exPicker2.Value.ToShortDateString & "' "

                Dim rd As SqlDataReader

                currency = ComboBox1.Text

                rd = cmd.ExecuteReader

                If rd.HasRows Then
                    While rd.Read()
                        expentxt.Text = currency + " " + rd("Totalexpenditure").ToString

                    End While

                    rd.Close()
                End If

            End If


            connection.Close()
        Catch e As Exception
            MsgBox(e.Message)

        Finally
            connection.Close()
        End Try

    End Sub

    Sub purchaseTotals()
        ' check first if there is record of purchases as at the date in the database before it calculate the total

        If ConnectionState.Open Then
            connection.Close()
        End If

        Dim cmd As New SqlCommand("select * from purchases where purchaseDate = '" & purchasesDate.Value.ToShortDateString & "' ", connection)

        Dim rds As SqlDataReader

        connection.Open()

        rds = cmd.ExecuteReader

        'if there is a record then it performs he calculation

        If rds.HasRows Then
            rds.Close()


            cmd.Connection = connection

            cmd.CommandText = "select  sum(Total) as 'Total Purchases' from purchases where purchaseDate = '" & purchasesDate.Value.ToShortDateString & "' "

            Dim rd As SqlDataReader

            currency = PurchasePricecurr.Text

            rd = cmd.ExecuteReader

            If rd.HasRows Then
                While rd.Read()
                    TotalPurchases.Text = currency + " " + rd("Total Purchases").ToString

                End While

                rd.Close()
                connection.Close()


            End If

        End If



        connection.Close()


    End Sub
    Sub combo()

        If ConnectionState.Closed Then
            connection.Open()
        End If

        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select * From stock", connection)

        adpt.Fill(tb)
        itembox.DataSource = tb
        itembox.DisplayMember = "productName"
        itembox.ValueMember = "stockID"

        itembox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        itembox.AutoCompleteSource = AutoCompleteSource.ListItems

        purchaseItem.DataSource = tb
        purchaseItem.DisplayMember = "productName"
        purchaseItem.ValueMember = "stockID"

        purchaseItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        purchaseItem.AutoCompleteSource = AutoCompleteSource.ListItems

        connection.Close()
    End Sub
    Sub reset()

        quantity.ResetText()
        price.ResetText()
        grandtotal.Clear()
        total.ResetText()
        discount.ResetText()
        id.Clear()
        DateTimePicker1.Value = DateTime.Now
        id.Visible = False
        combo()
        stockremain.ResetText()



    End Sub

    Sub PurchaseReset()
        connection.Close()

        purchaseItem.ResetText()
        purchasePrice.ResetText()
        purchasesQuantity.ResetText()
        purchasesDiscount.ResetText()
        purchasesDiscountYes.Checked = False
        purchaseDiscountNo.Checked = False
        purchasesDate.Value = DateTime.Now
        purchaseTotal.ResetText()
        Descript.ResetText()
        expirydate.Value = DateTime.Now.ToShortDateString
        purchaseID.Clear()
        stocklist()
        purchaseID.Visible = False
        purchaseDiscountcurren.Visible = False
        purchasesDiscount.Visible = False
        purdiscountlbl.Visible = False
        combo()

    End Sub

    Sub exresets()
        exid.Visible = False
        exid.Clear()
        purpose.Clear()
        examount.ResetText()
        exPicker2.Value = DateTime.Now

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles resetbtn.Click

        reset()

    End Sub

    Private Sub quantity_EditValueChanged(sender As Object, e As EventArgs) Handles quantity.Spin
        Dim sum As Double
        currency = ComboBox2.Text



        sum = (price.Value * quantity.Value) - discount.Value
        total.Text = currency + " " + sum.ToString



    End Sub

    Private Sub purchasesQuantity_EditValueChanged(sender As Object, e As EventArgs) Handles purchasesQuantity.EditValueChanged

        'assign a new value to the currency from the selected nav combo box
        currency = PurchasePricecurr.Text
        If purchasesDiscountYes.Checked = True And purchaseDiscountNo.Checked = False Then
            sum = purchasePrice.Value * purchasesQuantity.Value
            purchaseTotal.Value = currency + " " + sum.ToString
        Else
            sum = purchasePrice.Value * purchasesQuantity.Value
            purchaseTotal.Text = currency + " " + sum.ToString
        End If
    End Sub

    'Private Sub price_EditValueChanged(sender As Object, e As EventArgs) Handles price.EditValueChanged
    '    Dim sum As Double
    '    Currency = ComboBox2.Text
    '    If discountYes.Checked = True And discountNo.Checked = False Then
    '        sum = price.Value * quantity.Value - discount.Value
    '        total.Text = currency + " " + sum.ToString
    '    Else
    '        sum = price.Value * quantity.Value
    '        total.Text = currency + " " + sum.ToString
    '    End If
    'End Sub

    Private Sub purchasePrice_EditValueChanged(sender As Object, e As EventArgs) Handles purchasePrice.EditValueChanged
        Dim sum As Double
        currency = PurchasePricecurr.Text
        If purchasesDiscountYes.Checked = True And purchaseDiscountNo.Checked = False Then

            purchaseTotal.Value = sum
        Else
            sum = purchasePrice.Value * purchasesQuantity.Value
            purchaseTotal.Text = currency + " " + sum.ToString
        End If
    End Sub

    Private Sub discount_EditValueChanged(sender As Object, e As EventArgs) Handles discount.EditValueChanged
        Dim sum As Double
        currency = ComboBox2.Text

        sum = (price.Value * quantity.Value) - discount.Value
        total.Text = currency + " " + sum.ToString

    End Sub

    Private Sub purchasesDiscount_EditValueChanged(sender As Object, e As EventArgs) Handles purchasesDiscount.EditValueChanged
        Dim sum As Double
        currency = PurchasePricecurr.Text
        If purchasesDiscountYes.Checked = True And purchaseDiscountNo.Checked = False Then
            sum = purchasePrice.Value * purchasesQuantity.Value
            purchaseTotal.Value = sum
        Else
            sum = purchasePrice.Value * purchasesQuantity.Value
            purchaseTotal.Value = currency + " " + sum
        End If
    End Sub


    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If ConnectionState.Open Then
            connection.Close()
        End If

        connection.Open()

        Dim cmdss As New SqlCommand
        cmdss.Connection = connection
        cmdss.CommandText = "select instock as 'stock' from stock where productName = '" & itembox.Text & "' "


        Dim stockvalue As Integer = cmdss.ExecuteScalar()

        If stockvalue = 0 Then

            MsgBox("Out of stock")

        Else

            Try
                Dim rd As SqlDataReader
                Dim cmd As New SqlCommand
                cmd.Connection = connection

                If id.Text = Nothing Then

                    cmd.CommandText = "Insert into Sales Values('" & DateTimePicker1.Value + login.username.Text & "', '" & DateTimePicker1.Value & "', 
                    '" & itembox.Text & "','" & quantity.Value & "','" & price.Value & "','" & discount.Value & "' ) "

                    rd = cmd.ExecuteReader
                    rd.Close()

                    cmd.CommandText = "select * from stock where productName = '" & itembox.Text & "' "

                    rd = cmd.ExecuteReader
                    If rd.HasRows Then
                        rd.Close()
                        cmd.CommandText = "update stock set instock = instock -'" & quantity.Value & "' where productName = '" & itembox.Text & "' "
                        rd = cmd.ExecuteReader
                        rd.Close()
                    End If
                    MessageBox.Show("Saved Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    reset()

                Else
                    cmd.CommandText = "update Sales set sales_date = '" & DateTimePicker1.Value.ToShortDateString & "', 
                                    item ='" & itembox.Text & "', quantity = '" & quantity.Value & "',price ='" & price.Value & "',
                                     discount = '" & discount.Value & "' 
                                    where salesid = '" & id.Text & "' "

                    rd = cmd.ExecuteReader
                    rd.Close()

                    cmd.CommandText = "select * from stock where productName = '" & itembox.Text & "' "

                    rd = cmd.ExecuteReader

                    If rd.HasRows Then
                        rd.Close()
                        cmd.CommandText = "update stock set instock = instock - '" & quantity.Value & "' where productName = '" & itembox.Text & "' "
                        rd = cmd.ExecuteReader
                        rd.Close()
                    End If

                    MessageBox.Show("Updated Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)



                    connection.Close()
                    reset()

                End If




            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                connection.Close()

            End Try

        End If


        reset()
        connection.Open()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            id.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value '1st column
            itembox.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value '2nd column
            quantity.Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            price.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            discount.Value = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            total.Text = "Le " + DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString

            'Set the textbox3 text to the cell value the user just clicked on
            'Textbox3.Text = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            id.Visible = True

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        datagrid()
        salestotal()

    End Sub



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Dim rd As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = connection
            connection.Open()

            If id.Text = Nothing Then

                MessageBox.Show("Please select a record and Try Again!!!")
            Else
                MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If DialogResult = DialogResult.Yes Then
                    cmd.CommandText = "Delete from Sales where salesid = '" & id.Text & "' "

                    rd = cmd.ExecuteReader
                    rd.Close()
                    MessageBox.Show("Deleted Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    id.Visible = False
                End If
                connection.Close()
                reset()
            End If

            connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try

    End Sub


    Private Sub exreset_Click(sender As Object, e As EventArgs) Handles exreset.Click

        exresets()

    End Sub

    Private Sub exsave_Click(sender As Object, e As EventArgs) Handles exsave.Click

        Try
            Dim rd As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = connection


            If exid.Text = Nothing Then

                connection.Open()
                cmd.CommandText = "Insert into Expenditure Values('" & exPicker2.Value + login.username.Text & "', '" & exPicker2.Value & "', 
                    '" & examount.Value & "','" & purpose.Text & "' ) "

                rd = cmd.ExecuteReader
                rd.Close()
                connection.Close()

                MessageBox.Show("Saved Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                exresets()

            Else
                cmd.CommandText = "Update Expenditure set expendate = '" & exPicker2.Value.ToShortDateString & "', 
                                    Amount ='" & examount.Value & "', purpose = '" & purpose.Text & "'
                                    where expendID = '" & exid.Text & "' "

                rd = cmd.ExecuteReader
                rd.Close()

                MessageBox.Show("Updated Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)


                connection.Close()
                exresets()



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        Finally
            connection.Close()


        End Try

    End Sub

    Private Sub exdel_Click(sender As Object, e As EventArgs) Handles exdel.Click
        Try
            Dim rd As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = connection
            connection.Open()

            If exid.Text = Nothing Then

                MessageBox.Show("Please select a record and Try Again!!!")
            Else
                MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


                If DialogResult = DialogResult.Yes Then
                    cmd.CommandText = "Delete from Expenditure where expendID = '" & exid.Text & "' "

                    rd = cmd.ExecuteReader
                    rd.Close()
                    MessageBox.Show("Deleted Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    exid.Visible = False


                End If
                connection.Close()
                exresets()
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()

        Finally
            connection.Close()
        End Try


    End Sub



    Private Sub exPicker2_ValueChanged(sender As Object, e As EventArgs) Handles exPicker2.ValueChanged
        exdatagrid()

        expendtotal()

    End Sub

    Private Sub purchasesDate_ValueChanged(sender As Object, e As EventArgs) Handles purchasesDate.ValueChanged, expirydate.ValueChanged
        purchasesdatagrid()

        purchaseTotals()

    End Sub
    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            exid.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            exPicker2.Value = DataGridView2.Rows(e.RowIndex).Cells(1).Value '1st column
            examount.Value = DataGridView2.Rows(e.RowIndex).Cells(2).Value '2nd column
            purpose.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value


            'Set the textbox3 text to the cell value the user just clicked on
            'Textbox3.Text = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            exid.Visible = True

        End If
    End Sub


    Private Sub PurchasesgridVew_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchasesgridVew.CellDoubleClick

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then

            purchasesDate.Value = PurchasesgridVew.Rows(e.RowIndex).Cells(0).Value
            purchaseID.Text = PurchasesgridVew.Rows(e.RowIndex).Cells(8).Value
            purchaseItem.Text = PurchasesgridVew.Rows(e.RowIndex).Cells(1).Value '1st column
            purchasePrice.Value = PurchasesgridVew.Rows(e.RowIndex).Cells(4).Value
            purchasesQuantity.Value = PurchasesgridVew.Rows(e.RowIndex).Cells(3).Value
            purchasesDiscount.Value = PurchasesgridVew.Rows(e.RowIndex).Cells(5).Value
            Descript.Text = PurchasesgridVew.Rows(e.RowIndex).Cells(7).Value
            expirydate.Value = PurchasesgridVew.Rows(e.RowIndex).Cells(2).Value

            purchaseTotal.Text = PurchasesgridVew.Rows(e.RowIndex).Cells(6).Value


            'Set the textbox3 text to the cell value the user just clicked on
            'Textbox3.Text = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            purchaseID.Visible = True



        End If
    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles purchasesDiscountYes.CheckedChanged
        If purchasesDiscountYes.Checked Then
            purchaseDiscountcurren.Visible = True
            purchasesDiscount.Visible = True
            purdiscountlbl.Visible = True

        Else
            purchaseDiscountcurren.Visible = False
            purchasesDiscount.Visible = False
        End If
    End Sub

    Private Sub purchaseDiscountNo_CheckedChanged(sender As Object, e As EventArgs) Handles purchaseDiscountNo.CheckedChanged
        Dim sum As Double

        If purchaseDiscountNo.Checked Then
            purchaseDiscountcurren.Visible = False
            purchasesDiscount.Visible = False
            purdiscountlbl.Visible = False

            sum = purchasePrice.Value * purchasesQuantity.Value
            purchaseTotal.Value = sum
        End If
    End Sub


    Private Sub PurchasesSave_Click(sender As Object, e As EventArgs) Handles PurchasesSave.Click

        If ConnectionState.Open Then
            connection.Close()
        End If

        Dim cmds As New SqlCommand
        Dim cmdss As New SqlCommand
        cmds.Connection = connection
        cmdss.Connection = connection
        Dim rds As SqlDataReader
        Dim rdss As SqlDataReader

        connection.Open()

        'adding new record in puchases and stock

        If purchaseID.Text = Nothing Then


            cmdss.CommandText = "Insert into purchases Values( '" & purchasesDate.Value & "', 
                    '" & purchaseItem.Text & "','" & Descript.Text & "' ,'" & expirydate.Value & "' ,'" & purchasesQuantity.Value & "',
                    '" & purchasePrice.Value & "','" & purchasesDiscount.Value & "' ) "

            rdss = cmdss.ExecuteReader
            rdss.Close()


            cmds.CommandText = "select * from stock where productName = '" & purchaseItem.Text & "' "


            rds = cmds.ExecuteReader


            If rds.HasRows Then
                rds.Close()

                cmdss.CommandText = "update stock set productQuantity = instock + '" & purchasesQuantity.Value & "', instock = instock +  '" & purchasesQuantity.Value & "',
                                    expirydate = '" & expirydate.Value & "' where productName = '" & purchaseItem.Text & "' "
                rdss = cmdss.ExecuteReader
                rdss.Close()

            Else
                rds.Close()

                cmdss.Connection = connection
                cmdss.CommandText = "Insert into stock (productName, expirydate, productQuantity, instock) Values('" & purchaseItem.Text & "',  
                                                '" & expirydate.Value & "',  '" & purchasesQuantity.Value & "' ,  '" & purchasesQuantity.Value & "'  ) "
                rds = cmdss.ExecuteReader
                rds.Close()


            End If


            ''bring the total sold items
            'Dim cmd1 As New SqlCommand
            'cmd1.Connection = connection

            'cmd1.CommandText = "select  coalesce (sum(quantity),0) as 'Totalsold' from Sales where Item = '" & purchaseItem.Text & "' "

            'Dim sold As Integer
            'sold = cmd1.ExecuteScalar()

            ''add or substract to the stock value
            'cmds.CommandText = "select * from stock where productName = '" & purchaseItem.Text & "' "
            'rds = cmds.ExecuteReader


            'If rds.HasRows Then
            '    rds.Close()

            '    cmdss.CommandText = "update stock set instock = productQuantity - '" & sold & "'  "

            '    rdss = cmdss.ExecuteReader
            '    rdss.Close()

            MessageBox.Show("Saved Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            PurchaseReset()





        Else

            'updating records of purchases and stock
            Dim rd As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = connection

            cmd.CommandText = "update purchases set purchaseDate =  '" & purchasesDate.Value & "', product_name ='" & purchaseItem.Text & "',
                                    Description = '" & Descript.Text & "' , Quantity ='" & purchasesQuantity.Value & "', Price ='" & purchasePrice.Value & "',
                                        discount = '" & purchasesDiscount.Value & "'  where proid = '" & purchaseID.Text & "' "

            rd = cmd.ExecuteReader
            rd.Close()

            cmd.Connection = connection
            cmd.CommandText = "update stock set productName = '" & purchaseItem.Text & "', expirydate ='" & expirydate.Value & "', 
                                    productQuantity = '" & purchasesQuantity.Value & "' where productName = '" & purchaseItem.Text & "'  "
            rd = cmd.ExecuteReader
            rd.Close()

            Dim cmd1 As New SqlCommand
            cmd1.Connection = connection

            cmd1.CommandText = "select coalesce (sum(quantity),0 ) as 'Totalsold' from Sales where Item = '" & purchaseItem.Text & "' "

            Dim sold As Integer
            sold = cmd1.ExecuteScalar()

            'add or substract to the stock value
            cmds.CommandText = "select * from stock where productName = '" & purchaseItem.Text & "' "
            rds = cmds.ExecuteReader


            If rds.HasRows Then
                rds.Close()

                cmdss.CommandText = "update stock set instock = productQuantity -'" & sold & "' where productName = '" & purchaseItem.Text & "' "

                rdss = cmdss.ExecuteReader
                rdss.Close()


            End If

            MessageBox.Show("Updated Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            PurchaseReset()



        End If


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    connection.Close()
        'End Try
        connection.Close()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stockbox.SelectedIndexChanged

        If ConnectionState.Open Then
            connection.Close()
        End If

        connection.Open()
        Dim stocklist As String = stockbox.SelectedValue.ToString()

        'count the items sold and display in stock sold textbox
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = connection

            cmd.CommandText = "select coalesce (sum(Quantity),0)  from Sales where Item = '" & stocklist & "' "

            Dim sold As Integer

            sold = cmd.ExecuteScalar()

            stocksold.Text = sold.ToString


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

        'Try

        'get the selected value from the listbox in stock and display total stock and stock available

        Dim cmds As New SqlCommand

        cmds.Connection = connection

        Label25.Text = stocklist

        cmds.CommandText = "select * from stock where productName = '" & stocklist & "' "



        Dim rds As SqlDataReader
        connection.Open()

        rds = cmds.ExecuteReader
        'displaying to the textbox in stock
        While rds.Read

            stockid.Text = rds("stockID")

            totalstock.Text = rds("productQuantity")
            stockavail.Text = rds("instock")
            currentprice.Text = "Le " + rds("currentPrice").ToString()

        End While

        rds.Close()


    End Sub

    Private Sub purchasesReset_Click(sender As Object, e As EventArgs) Handles purchasesReset.Click
        PurchaseReset()

    End Sub



    Private Sub stockremain_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles stockremain.LinkClicked


        Dim pro As Integer = itembox.SelectedIndex




        dashboard.SelectNextPage()
        dashboard.SelectNextPage()
        dashboard.SelectNextPage()

        stockbox.SelectedIndex = pro




    End Sub

    'flashing label display remaining in stock

    Private Async Sub flash()
        While True
            Await Task.Delay(2000)
            stockremain.Visible = Not stockremain.Visible

        End While
    End Sub
    'flashing label display remaining in stock
    'fast flashing
    Private Async Sub flashout()
        While True
            Await Task.Delay(500)
            stockremain.Visible = Not stockremain.Visible

        End While
    End Sub

    Private Sub itembox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles itembox.Validating
        If ConnectionState.Open Then
            connection.Close()
        End If

        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        cmd.Connection = connection

        cmd.CommandText = "select  sum(instock) as 'Totalstock'  from stock where productName = '" & itembox.Text & "' "

        connection.Open()
        rd = cmd.ExecuteReader

        Try
            While rd.Read

                Dim value As Integer = rd("Totalstock")

                stockremain.Visible = True



                If value > 5 Then

                    stockremain.Text = value.ToString + " available"
                    stockremain.LinkColor = Color.DarkGreen

                ElseIf value <= 5 And value >= 1 Then

                    stockremain.LinkColor = Color.DarkOrange
                    stockremain.Text = value.ToString + " available"

                    flash()

                ElseIf value = 0 Then

                    stockremain.Text = "Out of Stock"
                    stockremain.LinkColor = Color.Red
                    flashout()

                Else
                    stockremain.Visible = False

                End If

            End While

            rd.Close()




        Catch ex As Exception
            MsgBox("Product not registerd")

            reset()

        Finally
            connection.Close()

        End Try
        Try

            currency = ComboBox2.Text
            connection.Open()
            cmd.CommandText = " select  currentPrice as 'price'  from stock where productName = '" & itembox.Text & "' "



            price.Value = cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox("Price not registered")
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub quantity_EditValueChanged_1(sender As Object, e As EventArgs) Handles quantity.EditValueChanged
        Dim sum As Double
        currency = ComboBox2.Text


        sum = (price.Value * quantity.Value) - discount.Value
        total.Text = currency + " " + sum.ToString


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        currency = ComboBox2.Text
    End Sub

    Private Sub changePrice_Click(sender As Object, e As EventArgs) Handles changePrice.Click
        chngeprice.ShowDialog()

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click



        If password.Properties.UseSystemPasswordChar = True Then
            password.Properties.UseSystemPasswordChar = False
            SimpleButton4.ImageOptions.Image = My.Resources.show_32x32



        ElseIf password.Properties.UseSystemPasswordChar = False Then
            password.Properties.UseSystemPasswordChar = True
            SimpleButton4.ImageOptions.Image = My.Resources.hide_32x32


        End If
    End Sub

    Private Sub accountsave_Click(sender As Object, e As EventArgs) Handles accountsave.Click
        If ConnectionState.Open Then
            connection.Close()
        End If

        connection.Open()



        Try
            Dim rd As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = connection

            If accountID.Text = Nothing Then

                cmd.CommandText = "Insert into Users Values('" & fname.Text & "', '" & oname.Text & "', 
                    '" & lastname.Text & "','" & usergender.Text & "','" & username.Text & "','" & password.Text & "',
                                '" & userhint.Text & "','" & usertype.Text & "' ) "

                rd = cmd.ExecuteReader
                rd.Close()

                MessageBox.Show("Saved Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()

            Else
                cmd.CommandText = "update Users set FirstName = '" & fname.Text & "', MiddleName = '" & oname.Text & "', 
                    LastName = '" & lastname.Text & "', Gender = '" & usergender.Text & "', Username = '" & username.Text & "',
                 pass_word = '" & password.Text & "',hint = '" & userhint.Text & "', userType = '" & usertype.Text & "'  where UserId = '" & accountID.Text & "') "

                rd = cmd.ExecuteReader
                rd.Close()

                MessageBox.Show("Updated Successfully", "Belsoh Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            connection.Close()
        End Try


    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        clear()

    End Sub

    Sub clear()
        fname.ResetText()
        oname.ResetText()
        lastname.ResetText()
        usergender.ResetText()
        userhint.ResetText()
        usertype.ResetText()
        username.ResetText()
        password.ResetText()
        accountID.ResetText()
        userlist.ResetText()
    End Sub

    Private Sub userlist_SelectedIndexChanged(sender As Object, e As EventArgs)

        If ConnectionState.Open Then
            connection.Close()
        End If

        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        cmd.Connection = connection

        cmd.CommandText = "select * from Users where Username = '" & userlist.Text & "' "

        connection.Open()
        rd = cmd.ExecuteReader

        Try
            While rd.Read
                accountID.Text = rd("UserId ")
                fname.Text = rd("FiestName ")
                oname.Text = rd("MiddleName ")
                lastname.Text = rd("LastName ")
                usergender.Text = rd("Gender ")
                username.Text = rd("Username ")
                password.Text = rd("pass_word ")
                userhint.Text = rd("hint")
                usertype.Text = rd("userType ")


            End While
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            connection.Close()
        End Try
    End Sub

    Sub filluserlist()
        'dropdown box for user in general setting
        If ConnectionState.Closed Then
            connection.Open()
        End If

        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select Username, FirstName  From Users", connection)

        adpt.Fill(tb)
        userlist.Properties.DataSource = tb
        userlist.Properties.DisplayMember = "Username, FirstName "
        userlist.Properties.ValueMember = "UserId"

        userlist.CascadingOwner = userlist

    End Sub


    Private Sub userlist_EditValueChanged(sender As Object, e As EventArgs) Handles userlist.EditValueChanged
        If ConnectionState.Open Then
            connection.Close()
        End If

        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        cmd.Connection = connection

        cmd.CommandText = "select * from Users where Username = '" & userlist.Text & "' "

        connection.Open()
        rd = cmd.ExecuteReader

        Try
            While rd.Read
                accountID.Text = rd("UserId ")
                fname.Text = rd("FiestName ")
                oname.Text = rd("MiddleName ")
                lastname.Text = rd("LastName ")
                usergender.Text = rd("Gender ")
                username.Text = rd("Username ")
                password.Text = rd("pass_word ")
                userhint.Text = rd("hint")
                usertype.Text = rd("userType ")


            End While
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub itembox_SelectionChangeCommitted(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles itembox.Validating

    End Sub



    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub



    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub SearchControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchControl1.TextChanged, SearchControl2.TextChanged

        If SearchControl1.Text <> String.Empty Then


            Dim index As Integer = stockbox.FindString(SearchControl1.Text)
            ' Determine if a valid index is returned. Select the item if it is valid. 
            If index <> -1 Then
                stockbox.SetSelected(index, True)
            Else

            End If
        End If
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
