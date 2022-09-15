Imports System
Imports System.Data
Imports Npgsql
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Add_Grantee_Form
    Private Sub Add_Grantee_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Students_DataSet.students' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Voucher_DataSet.Voucher' table. You can move, or remove it, as needed.
        Me.VoucherTableAdapter.Fill(Me.Voucher_DataSet.Voucher)
        'TODO: This line of code loads data into the 'Heis_DataSet.heis' table. You can move, or remove it, as needed.
        Me.HeisTableAdapter.Fill(Me.Heis_DataSet.heis)

        doConnect()
        con.Close()


    End Sub

    Sub lodbranch()
        If con.State = ConnectionState.Closed Then con.Open()
        cmd = New NpgsqlCommand("", con)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()


    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VoucherTableAdapter.FillByhei_acad_sem(Me.Voucher_DataSet.Voucher, ComboBox1.SelectedValue, AcadyearComboBox.Text, SemesterComboBox.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "excel|*.xls;*xlsx"
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
        Dim filepath As String = TextBox1.Text
        Dim connstring As String = String.Empty
        If filepath.EndsWith(".xls") Then
            connstring = String.Format("Provider=Microsoft.Jet.Oledb.4.0;" & "Data Source={0};Extended Properties = 'Excel 8.0;HDR=yes'", filepath)
        Else
            connstring = String.Format("Provider=Microsoft.Ace.Oledb.12.0;" & "Data Source={0};Extended Properties = 'Excel 8.0;HDR=yes'", filepath)
        End If
        Dim conn As New OleDbConnection(connstring)
        conn.Open()
        ComboBox2.DataSource = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        ComboBox2.DisplayMember = "Table_Name"
        ComboBox2.ValueMember = "Table_Name"
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filepath As String = TextBox1.Text
        Dim connstring As String = String.Empty
        If filepath.EndsWith(".xls") Then
            connstring = String.Format("Provider=Microsoft.Jet.Oledb.4.0;" & "Data Source={0};Extended Properties = 'Excel 8.0;HDR=yes'", filepath)
        Else
            connstring = String.Format("Provider=Microsoft.Ace.Oledb.12.0;" & "Data Source={0};Extended Properties = 'Excel 8.0;HDR=yes'", filepath)
        End If
        Dim cmd As New OleDbDataAdapter("Select * from[" & ComboBox2.Text & "" & "]", connstring)
        cmd.TableMappings.Add("Table", "Table")
        Dim dt As New DataSet
        cmd.Fill(dt)
        DataGridView1.DataSource = dt.Tables(0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click




        Try
            Dim i As Integer
            'MsgBox("Are you sure you want to Save these records?", vbYesNo + vbQuestion = vbYes)

            Dim answer As Integer
            answer = MsgBox("Are You Sure to Save to Database?", vbQuestion + vbYesNo + vbDefaultButton2, "Message Box Title")
            If answer = vbYes Then


                Me.StudentsTableAdapter.DeleteQueryVoucherID(VoucherIDTextBox.Text)

                For i = 0 To DataGridView1.RowCount - 1


                    If con.State = ConnectionState.Closed Then con.Open()

                    cmd = New NpgsqlCommand("insert into Students(voucherid, awardnumber, lastname) values ('" & VoucherIDTextBox.Text & "', '" & DataGridView1.Rows(i).Cells(0).Value.ToString & "', '" & DataGridView1.Rows(i).Cells(1).Value.ToString & "')", con)
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()


                    'cmd = New NpgsqlCommand("insert into listing(VoucherID, Award_number, lastname,firstname,midname,degree,year_level,tes1,tes2,total,reason) VALUES ('" + TextBox3.Text.ToString + "','" + DataGridView1.Rows(i).Cells(0).Value.ToString + "','" + DataGridView1.Rows(i).Cells(1).Value.ToString + "','" + DataGridView1.Rows(i).Cells(2).Value.ToString + "','" + DataGridView1.Rows(i).Cells(3).Value + "','" + DataGridView1.Rows(i).Cells(4).Value.ToString + "','" + DataGridView1.Rows(i).Cells(5).Value.ToString + "','" + DataGridView1.Rows(i).Cells(6).Value.ToString + "','" + DataGridView1.Rows(i).Cells(7).Value.ToString + "','" + DataGridView1.Rows(i).Cells(8).Value.ToString + "','" + DataGridView1.Rows(i).Cells(9).Value.ToString + "') ", con)
                    'cmd = New NpgsqlCommand("INSERT INTO Listing(lastname) VALUES ('" + TextBox3.Text.ToString() + "')", con)




                    'cmd.CommandText = "insert into El(hei_uii,lastname,firstname,middlename,suffix,sy,semester,program,major,year_level,subjectcode,subjectdescription,lectureunit,laboratoryunit,totalunit,status) values ('" + ComboBox1.SelectedValue + "','" + DataGridView1.Rows(i).Cells(1).Value + "','" + DataGridView1.Rows(i).Cells(2).Value + "','" + DataGridView1.Rows(i).Cells(3).Value + "','" + DataGridView1.Rows(i).Cells(4).Value + "','" + DataGridView1.Rows(i).Cells(5).Value + "','" + DataGridView1.Rows(i).Cells(6).Value + "','" + DataGridView1.Rows(i).Cells(7).Value + "','" + DataGridView1.Rows(i).Cells(8).Value + "','" + DataGridView1.Rows(i).Cells(9).Value + "','" + DataGridView1.Rows(i).Cells(10).Value + "','" + DataGridView1.Rows(i).Cells(11).Value + "','" + DataGridView1.Rows(i).Cells(12).Value + "','" + DataGridView1.Rows(i).Cells(13).Value + "','" + DataGridView1.Rows(i).Cells(14).Value + "','" + "Enrolled" + "')"
                    ','" + DataGridView1.Rows(i).Cells(13).Value + "','" + DataGridView1.Rows(i).Cells(14).Value + "','" + "Enrolled" + "'








                Next


                'If con.State = ConnectionState.Closed Then con.Open()

                'cmd = New NpgsqlCommand("UPDATE HEI.Voucher	SET  totalgrantees= textbox2.text WHERE voucherid=textbox3.text", con)
                'cmd.CommandType = CommandType.Text
                'cmd.ExecuteNonQuery()



                'Me.VoucherTableAdapter.UpdateQuery_Listing(Label4.Text, Label6.Text)
                MsgBox("Record has been successfully saved!", vbInformation)
                'EL_Print.ToolStripLabel1.Text = lblHei_Uii.Text
                'EL_Print.ToolStripLabel2.Text = ComboBox2.Text
                'EL_Print.ToolStripLabel3.Text = ComboBox3.Text
                'EL_Print.Show()

            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.StudentsTableAdapter.FillByVoucherid(Me.Students_DataSet.students, VoucherIDTextBox.Text)
    End Sub

    Private Sub StudentsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDataGridView.CellContentClick

    End Sub

    Private Sub StudentsDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles StudentsDataGridView.DataBindingComplete
        Label3.Text = StudentsDataGridView.Rows.Count
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        Label4.Text = DataGridView1.Rows.Count

    End Sub
End Class