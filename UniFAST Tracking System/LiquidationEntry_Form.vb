Imports System.IO
Imports System.Data.OleDb
Imports System.Net.Mail

Public Class LiquidationEntry_Form
    Private Sub LiquidationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LiquidationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LiquidationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Liquidation_DataSet)

    End Sub

    Private Sub LiquidationEntry_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Voucher_DataSet.Voucher' table. You can move, or remove it, as needed.
        'Me.VoucherTableAdapter.Fill(Me.Voucher_DataSet.Voucher)
        'TODO: This line of code loads data into the 'Liquidation_DataSet.Liquidation' table. You can move, or remove it, as needed.
        'Me.LiquidationTableAdapter.Fill(Me.Liquidation_DataSet.Liquidation)


        InvoicedateDateTimePicker.Value = Now




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Using img1 As OpenFileDialog = New OpenFileDialog()
            img1.Filter = " choose image(*.jpg;*.png;*.gif;)|*.jpg;*.png;*.gif;"

            If img1.ShowDialog() = DialogResult.OK Then
                Label1.Text = Path.GetFileName(img1.FileName)
                Me.PictureBox1.Image = Image.FromFile(img1.FileName)

            End If
        End Using

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ZoomAttachment_form.Show()
        ZoomAttachment_form.PictureBox1.Image = PictureBox1.Image
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 


    End Sub

    Private Sub LiquidationDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub LiquidationDataGridView_SelectionChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LiquidationDataGridView_Validated(sender As Object, e As EventArgs)


    End Sub

    Private Sub LiquidationDataGridView_RowLeave(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub LiquidationDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles LiquidationDataGridView.DefaultValuesNeeded
        e.Row.Cells(1).Value = Val(Label3.Text)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_TextChanged(sender As Object, e As EventArgs)


    End Sub



    Private Sub LiquidationDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles LiquidationDataGridView.DataBindingComplete
        Dim utilized As Integer = 0
        Dim liquidated As Integer = 0
        Dim balance As Integer = 0
        For i As Integer = 0 To Val(LiquidationDataGridView.Rows.Count) - 1
            utilized += CDbl(LiquidationDataGridView.Rows(i).Cells(7).Value)
            liquidated += CDbl(LiquidationDataGridView.Rows(i).Cells(9).Value)
        Next
        Label10.Text = utilized
        Label11.Text = liquidated

        TextBox1.Text = CDbl(Label6.Text) - CDbl(Label11.Text)




        Label10.Text = FormatNumber(Label10.Text)
        Label11.Text = FormatNumber(Label11.Text)
        TextBox1.Text = FormatNumber(TextBox1.Text)

        Label11.Text = FormatNumber(Label11.Text)
    End Sub



    Private Sub LiquidationDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles LiquidationDataGridView.CellEnter
        If IsDBNull(LiquidationDataGridView.CurrentRow.Cells(13).Value) Then
            Button2.Visible = True
        Else
            Button2.Visible = False


        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim price As Decimal, total As Decimal

        price = String.Format("{0:C2}", PriceTextBox.Text)
        total = String.Format("{0:C2}", TotalTextBox.Text)

        If CategoryComboBox.Text <> "" And String.IsNullOrWhiteSpace(ParticularTextBox.Text) = False And String.IsNullOrWhiteSpace(QtyTextBox.Text) = False And String.IsNullOrWhiteSpace(PriceTextBox.Text) = False And String.IsNullOrWhiteSpace(TotalTextBox.Text) = False Then
            Me.LiquidationTableAdapter.InsertQueryLiquidation(Val(Label3.Text), InvoicedateDateTimePicker.Value, CategoryComboBox.Text, ParticularTextBox.Text, Val(QtyTextBox.Text), price, total)
            LiquidationTableAdapter.FillByVoucherID(Me.Liquidation_DataSet.Liquidation, Label3.Text)
            MsgBox("Item Added! Please add Attachment", vbInformation)


            'Dim emailto As String = dgvRow.Cells(7).Value.ToString
            'Dim namesend As String = dgvRow.Cells(1).Value.ToString & ", " & dgvRow.Cells(2).Value.ToString & " " & dgvRow.Cells(3).Value.ToString & vbCrLf & "Username: " & dgvRow.Cells(4).Value.ToString & vbCrLf & "Password: " & dgvRow.Cells(5).Value.ToString & vbCrLf & vbCrLf
            '"Username: " & dgvRow.Cells(8).Value.ToString & vbCrLf & "Password: " & dgvRow.Cells(9).Value.ToString

            Try


                Dim Mail As New MailMessage
                Mail.Subject = "Liquidation -  " & Me.ToolStripLabel3.Text
                Mail.To.Add("phdiaz@ched.gov.ph, blmalas@ched.gov.ph")
                Mail.From = New MailAddress("unifastro10@ched.gov.ph")
                'Mail.From = New MailAddress("unifast.regionx@gmail.com")
                Mail.Body = Me.ToolStripLabel6.Text & " | " & Me.ToolStripLabel4.Text & " | " & Me.ToolStripLabel5.Text & " | " & CategoryComboBox.Text & " | " & ParticularTextBox.Text & " | " & TotalTextBox.Text


                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.UseDefaultCredentials = False
                SMTP.Credentials = New System.Net.NetworkCredential("vluzana@ched.gov.ph", "viza0225")
                'SMTP.Credentials = New System.Net.NetworkCredential("unifast.regionx@gmail.com", "regionx.unifast")
                SMTP.EnableSsl = True
                SMTP.Port = "587"
                SMTP.Send(Mail)


                'Me.New_EmailsTableAdapter.UpdateQuery("Email Sent", dgvRow.Cells(0).Value)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                'MsgBox("Problem with Email Server", vbInformation)


            End Try




        Else
            MsgBox("Please check missing entries", vbExclamation)

            CategoryComboBox.SelectedIndex = -1
            ParticularTextBox.Text = ""
            PriceTextBox.Text = ""
            QtyTextBox.Text = ""
            TotalTextBox.Text = ""

        End If
    End Sub

    Private Sub QtyTextBox_TextChanged(sender As Object, e As EventArgs) Handles QtyTextBox.TextChanged
        If QtyTextBox.Text <> "" And PriceTextBox.Text <> "" Then
            TotalTextBox.Text = CDbl(QtyTextBox.Text) * CDbl(PriceTextBox.Text)
            TotalTextBox.Text = FormatNumber(TotalTextBox.Text)
        End If
    End Sub

    Private Sub QtyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QtyTextBox.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                e.Handled = True

            End If
        End If

    End Sub

    Private Sub PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles PriceTextBox.TextChanged
        If QtyTextBox.Text <> "" And PriceTextBox.Text <> "" Then
            TotalTextBox.Text = CDbl(QtyTextBox.Text) * CDbl(PriceTextBox.Text)
            TotalTextBox.Text = FormatNumber(TotalTextBox.Text)
        End If
    End Sub

    Private Sub PriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceTextBox.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                e.Handled = True

            End If
        End If


    End Sub

    Private Sub LiquidationDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles LiquidationDataGridView.CellContentClick

    End Sub

    Private Sub LiquidationDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LiquidationDataGridView.CellDoubleClick
        LiquidationDataGridView.CurrentRow.Cells(10).Value = Now.Date
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.LiquidationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Liquidation_DataSet)

        Dim liquidated As Decimal
        liquidated = String.Format("{0:C2}", Label11.Text)

        Me.VoucherTableAdapter.UpdateQueryLiquidatedAmount(liquidated, Label3.Text)

        MsgBox("Liquidation Updated!", vbInformation)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        'PrintPreviewDialog1.ShowDialog()

    End Sub

    Private mrow As Integer = 0
    Private newpage As Boolean = True

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'PrintDocument1.DefaultPageSettings.Landscape = True

        'Dim format As New StringFormat
        'format.Alignment = StringAlignment.Center
        'e.Graphics.DrawString("Liquidation Status of " & ToolStripLabel3.Text, New Font("Calibre", 20, FontStyle.Bold), Brushes.Black, New Point(400, 20), format)

        'Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        'fmt.LineAlignment = StringAlignment.Center
        'fmt.Trimming = StringTrimming.EllipsisPath
        'fmt.Alignment = StringAlignment.Center



        'Dim y As Integer = 100
        'Dim x As Integer = 10
        'Dim h As Integer = 0
        'Dim rc As Rectangle
        'Dim row As DataGridViewRow

        'If newpage Then
        '    row = LiquidationDataGridView.Rows(mrow)
        '    x = 10
        '    For Each cell As DataGridViewCell In row.Cells
        '        If cell.Visible Then
        '            rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
        '            e.Graphics.FillRectangle(Brushes.LightGray, rc)
        '            e.Graphics.DrawRectangle(Pens.Black, rc)
        '            e.Graphics.DrawString(LiquidationDataGridView.Columns(cell.ColumnIndex).HeaderText, LiquidationDataGridView.Font, Brushes.Black, rc, fmt)
        '            x += rc.Width
        '            h = Math.Max(h, rc.Height)
        '        End If
        '    Next
        '    y += h
        'End If

        'newpage = False
        'Dim displaynow As Integer
        'For displaynow = mrow To LiquidationDataGridView.Rows.Count - 1
        '    row = LiquidationDataGridView.Rows(displaynow)
        '    x = 150
        '    h = 0

        '    For Each cell As DataGridViewCell In row.Cells
        '        If cell.Visible Then
        '            rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
        '            e.Graphics.DrawRectangle(Pens.Black, rc)
        '            fmt.Alignment = StringAlignment.Near
        '            rc.Offset(10, 0)
        '            e.Graphics.DrawString(cell.FormattedValue.ToString(), LiquidationDataGridView.Font, Brushes.Black, rc, fmt)
        '            x += rc.Width
        '            h = Math.Max(h, rc.Height)


        '        End If
        '    Next
        '    y += h
        'Next

    End Sub
End Class