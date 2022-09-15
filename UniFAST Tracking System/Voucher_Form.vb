Public Class Voucher_Form
    Private Sub VoucherBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VoucherBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Voucher_DataSet)

    End Sub

    Private Sub Voucher_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Heis_DataSet.heis' table. You can move, or remove it, as needed.
        Me.HeisTableAdapter.Fill(Me.Heis_DataSet.heis)
        'TODO: This line of code loads data into the 'Voucher_DataSet.Voucher' table. You can move, or remove it, as needed.
        Me.VoucherTableAdapter.Fill(Me.Voucher_DataSet.Voucher)

    End Sub

    Private Sub VoucherdateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VoucherdateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles VoucherdateDateTimePicker.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VoucherTableAdapter.FillByhei_acad_sem(Me.Voucher_DataSet.Voucher, ComboBox1.SelectedValue, AcadyearComboBox.Text, SemesterComboBox.Text)
    End Sub

    Private Sub SemesterLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SemesterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SemesterComboBox.SelectedIndexChanged

    End Sub

    Private Sub AcadyearComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AcadyearComboBox.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Hei_UiiLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AcadyearLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class