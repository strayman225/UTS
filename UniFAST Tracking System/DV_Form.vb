Public Class DV_Form
    Private Sub VoucherBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VoucherBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Voucher_DataSet)

    End Sub

    Private Sub DV_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Heis_DataSet.heis' table. You can move, or remove it, as needed.
        Me.HeisTableAdapter.Fill(Me.Heis_DataSet.heis)
        'TODO: This line of code loads data into the 'Voucher_DataSet.Voucher' table. You can move, or remove it, as needed.
        Me.VoucherTableAdapter.Fill(Me.Voucher_DataSet.Voucher)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.VoucherTableAdapter.FillByNoDV(Me.Voucher_DataSet.Voucher)
        Else
            Me.VoucherTableAdapter.Fill(Me.Voucher_DataSet.Voucher)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Voucher_DataSet)
        MsgBox("DV Updated", vbInformation)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub VoucherDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VoucherDataGridView.CellContentClick

    End Sub
End Class