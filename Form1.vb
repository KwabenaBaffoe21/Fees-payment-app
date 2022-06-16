Imports MySql.Data.MySqlClient

Public Class Form1
    'Create MySQL objects.
    Private reader As MySqlDataReader
    Private command As New MySqlCommand
    Private myConnectionString As String
    Private sql As String
    Private dbinput, dbinput2, balance, fees As Double
    Private creditcard As Integer

    Private Sub dbread()
        'Create a connection object.
        myConnectionString = "server=localhost;" _
              & "uid=root;" _
              & "pwd=Emma@21*GCTU;" _
              & "database=dummystudents"

        Try

            'open the connection
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(myConnectionString)
            conn.Open()

            'create a command object.
            sql = "SELECT fees,idstudents FROM students WHERE idstudents= " & txtStudentID.Text
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()

            'fetching data from database
            reader.Read()
            dbinput = dbinput & reader.GetString(0)
            dbinput2 = dbinput2 & reader.GetString(1)

            'calculating fees
            If dbinput2 = txtStudentID.Text Then
                If rbntwentyfive.Checked = True Then
                    fees = dbinput * 0.25
                ElseIf rbnfifty.Checked = True Then
                    fees = dbinput * 0.5
                ElseIf rbnsixty.Checked = True Then
                    fees = dbinput * 0.6
                Else
                    fees = dbinput * 1
                End If

                icardverify(fees)

                'outputting result
                txtAmountpaid.Text = fees.ToString("C2")
                txtBalance.Text = balance.ToString("C2")
            End If
            'Close connection
            conn.Close()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Your student ID doesn't exist.")
        End Try
    End Sub

    Private Sub dbupdate()
        'Create a connection object.
        myConnectionString = "server=localhost;" _
              & "uid=root;" _
              & "pwd=Emma@21*GCTU;" _
              & "database=dummystudents"

        Try
            'open the connection
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(myConnectionString)
            conn.Open()

            'decimal variable
            Dim dbvalue As Decimal = Decimal.Parse(balance).ToString("#,###.00")

            'create a command object.
            sql = "UPDATE students SET fees = " & dbvalue & "WHERE idstudents = " & txtStudentID.Text
            command = New MySqlCommand(sql, conn)
            command.ExecuteNonQuery()
            'Close connection
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub icardverify(ByVal schoolfees As Double)
        'Create a connection object.
        myConnectionString = "server=localhost;" _
              & "uid=root;" _
              & "pwd=Emma@21*GCTU;" _
              & "database=dummycard"

        Try

            'open the connection
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(myConnectionString)
            conn.Open()

            creditcard = InputBox("Enter your Credit card number: ", "Verification")
            'create a command object.
            sql = "SELECT cardID,pin,amount FROM card WHERE cardID= " & creditcard
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()

            'fetching data from database
            reader.Read()
            Dim pin As Integer = pin & reader.GetString(1)
            Dim amount As Double = amount & reader.GetString(2)
            Dim cardID As Integer = cardID & reader.GetString(0)

            If cardID = creditcard Then
                Dim creditcardpin As Integer = InputBox("Enter your pin: ", "Confirm Credit Card")
                If amount >= schoolfees Then
                    balance = amount - schoolfees
                Else
                    MessageBox.Show("Insufficient Balance")
                End If
            Else
                MessageBox.Show("Card number is incorrect")
            End If

        Catch ex As Exception
            MessageBox.Show("Connection Faulty")
        End Try

        cardupdate()

    End Sub
    Private Sub cardupdate()
        'Create a connection object.
        myConnectionString = "server=localhost;" _
              & "uid=root;" _
              & "pwd=Emma@21*GCTU;" _
              & "database=dummycard"

        Try
            'open the connection
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(myConnectionString)
            conn.Open()

            'decimal variable
            Dim dbvalue As Decimal = Decimal.Parse(balance).ToString("#,###.00")

            'create a command object.
            sql = "UPDATE card SET amount = " & dbvalue & "WHERE cardID = " & creditcard
            command = New MySqlCommand(sql, conn)
            command.ExecuteNonQuery()
            'Close connection
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbread()
        dbupdate()
    End Sub
End Class