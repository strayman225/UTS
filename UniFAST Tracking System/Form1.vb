Public Class Form1
    Private Sub HeisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HeisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HeisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Heis_DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Heis_DataSet.heis' table. You can move, or remove it, as needed.
        Me.HeisTableAdapter.Fill(Me.Heis_DataSet.heis)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Voucher_Form.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Add_Grantee_Form.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ADA_Form.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        DV_Form.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Liquidation_Form.Show()

    End Sub
End Class
