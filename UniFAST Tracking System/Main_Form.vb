Public Class Main_Form
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UserRegistration_Form.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Liquidation_Form.Show()
        Liquidation_Form.ToolStripLabel2.Text = Me.ToolStripLabel2.Text
        Liquidation_Form.ComboBox1.Enabled = True
        Liquidation_Form.ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        User_Form.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Voucher_Form.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Add_Grantee_Form.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ADA_Form.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DV_Form.Show()

    End Sub
End Class