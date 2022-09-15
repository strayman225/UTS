Public Class ADA_Form
    Private Sub VoucherBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VoucherBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Voucher_DataSet)

    End Sub

    Private Sub ADA_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Heis_DataSet.heis' table. You can move, or remove it, as needed.
        Me.HeisTableAdapter.Fill(Me.Heis_DataSet.heis)
        'TODO: This line of code loads data into the 'Voucher_DataSet.Voucher' table. You can move, or remove it, as needed.
        Me.VoucherTableAdapter.FillByADA(Me.Voucher_DataSet.Voucher)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Voucher_DataSet)
        MsgBox("ADA Updated!", vbInformation)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.VoucherTableAdapter.FillByNoADA(Me.Voucher_DataSet.Voucher)
        Else
            Me.VoucherTableAdapter.FillByADA(Me.Voucher_DataSet.Voucher)
        End If
    End Sub
End Class