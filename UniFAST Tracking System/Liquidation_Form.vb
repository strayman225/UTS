Imports System.IO
Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Liquidation_Form
    Private Sub VoucherBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VoucherBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Voucher_DataSet)

    End Sub

    Private Sub Liquidation_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Liquidation_DataSet.Liquidation' table. You can move, or remove it, as needed.
        'Me.LiquidationTableAdapter.Fill(Me.Liquidation_DataSet.Liquidation)
        'TODO: This line of code loads data into the 'Heis_DataSet.heis' table. You can move, or remove it, as needed.
        Me.HeisTableAdapter.Fill(Me.Heis_DataSet.heis)
        'TODO: This line of code loads data into the 'Voucher_DataSet.Voucher' table. You can move, or remove it, as needed.
        'Me.VoucherTableAdapter.Fill(Me.Voucher_DataSet.Voucher)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VoucherTableAdapter.FillByhei_acad_sem_Ada(Me.Voucher_DataSet.Voucher, ComboBox1.SelectedValue, AcadyearComboBox.Text, SemesterComboBox.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LiquidationEntry_Form.Show()
        LiquidationEntry_Form.ToolStripLabel2.Text = Me.ToolStripLabel2.Text

        LiquidationEntry_Form.ToolStripLabel3.Text = Me.ComboBox1.Text
        LiquidationEntry_Form.ToolStripLabel4.Text = Me.AcadyearComboBox.Text
        LiquidationEntry_Form.ToolStripLabel5.Text = Me.SemesterComboBox.Text
        LiquidationEntry_Form.ToolStripLabel6.Text = Me.VoucherDataGridView.CurrentRow.Cells(3).Value.ToString




        If LiquidationEntry_Form.ToolStripLabel2.Text = "School" Then

        Else

            LiquidationEntry_Form.LiquidationDataGridView.Columns(8).ReadOnly = False
            LiquidationEntry_Form.LiquidationDataGridView.Columns(9).ReadOnly = False
            LiquidationEntry_Form.LiquidationDataGridView.Columns(10).ReadOnly = False
            LiquidationEntry_Form.LiquidationDataGridView.Columns(11).ReadOnly = False
            LiquidationEntry_Form.LiquidationDataGridView.Columns(12).ReadOnly = False


        End If



        LiquidationEntry_Form.Label4.Text = VoucherDataGridView.CurrentRow.Cells(3).Value.ToString
        LiquidationEntry_Form.Label12.Text = FormatDateTime(VoucherDataGridView.CurrentRow.Cells(2).Value, DateFormat.ShortDate)
        LiquidationEntry_Form.Label6.Text = VoucherDataGridView.CurrentRow.Cells(4).Value.ToString
        LiquidationEntry_Form.Label6.Text = FormatNumber(LiquidationEntry_Form.Label6.Text)

        LiquidationEntry_Form.LiquidationTableAdapter.FillByVoucherID(LiquidationEntry_Form.Liquidation_DataSet.Liquidation, VoucherDataGridView.CurrentRow.Cells(0).Value)
        LiquidationEntry_Form.Label3.Text = VoucherDataGridView.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub VoucherDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VoucherDataGridView.CellContentClick

    End Sub

    Private Sub VoucherDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles VoucherDataGridView.DataBindingComplete
        If VoucherDataGridView.Rows.Count > 0 Then
            Button3.Visible = True

            Dim totalADA As Integer = 0
            Dim totalliquidated As Integer = 0

            For i As Integer = 0 To Val(VoucherDataGridView.Rows.Count) - 1
                If IsDBNull(VoucherDataGridView.Rows(i).Cells(4).Value) = False Then
                    totalADA += CDbl(VoucherDataGridView.Rows(i).Cells(4).Value)
                End If

                If IsDBNull(VoucherDataGridView.Rows(i).Cells(5).Value) = False Then
                    totalliquidated += CDbl(VoucherDataGridView.Rows(i).Cells(5).Value)
                End If

            Next
            Label3.Text = totalADA
            Label2.Text = totalliquidated

            Label5.Text = CDbl(Label3.Text) - CDbl(Label2.Text)




            Label2.Text = FormatNumber(Label2.Text)
            Label3.Text = FormatNumber(Label3.Text)
            Label5.Text = FormatNumber(Label5.Text)




        Else
            Button3.Visible = False

        End If
    End Sub

    Private Sub ChangePassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePassToolStripMenuItem.Click
        ChangePass_Form.Show()
        ChangePass_Form.UtsusersTableAdapter.FillByHEI_Uii(ChangePass_Form.User_DataSet.utsusers, ComboBox1.SelectedValue)
    End Sub
End Class