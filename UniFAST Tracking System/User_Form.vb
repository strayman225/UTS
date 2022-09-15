Imports System.Security.Cryptography
Imports System
Imports System.Data
Imports Npgsql
Public Class User_Form
    Private Sub User_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_DataSet.utsusers' table. You can move, or remove it, as needed.
        Me.UtsusersTableAdapter.Fill(Me.User_DataSet.utsusers)
        'TODO: This line of code loads data into the 'User_DataSet.utsusers' table. You can move, or remove it, as needed.
        Me.UtsusersTableAdapter.Fill(Me.User_DataSet.utsusers)
        doConnect()
        con.Close()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim HashCode As UserRegistration_Form
        HashCode = New UserRegistration_Form()

        ' MsgBox(HashCode.md5fromstring(TextBoxpassword.Text))
        TextBox2.Text = HashCode.md5fromstring(TextBox2.Text)


        If con.State = ConnectionState.Closed Then con.Open()

        cmd = New NpgsqlCommand("Select * from utsusers where hei_uii = '" & TextBox1.Text & "' And passw = '" & TextBox2.Text & "'", con)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()

        Dim sda As NpgsqlDataAdapter = New NpgsqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        Me.UtsusersTableAdapter.FillByHEI_Uii(Me.User_DataSet.utsusers, TextBox1.Text)

        If (dt.Rows.Count > 0) Then
            TextBox2.Text = ""

            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If AccesslevelLabel1.Text = "School" Then

                Liquidation_Form.Show()
                Liquidation_Form.ComboBox1.SelectedValue = TextBox1.Text
                Liquidation_Form.ToolStripLabel2.Text = "School"


            Else

                Main_Form.Show()
                Liquidation_Form.ToolStripLabel2.Text = "UniFAST"
            End If


            Me.Close()

        Else
            MessageBox.Show("Login Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox2.Text = ""


        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim HashCode As UserRegistration_Form
            HashCode = New UserRegistration_Form()

            ' MsgBox(HashCode.md5fromstring(TextBoxpassword.Text))
            TextBox2.Text = HashCode.md5fromstring(TextBox2.Text)


            If con.State = ConnectionState.Closed Then con.Open()

            cmd = New NpgsqlCommand("Select * from utsusers where hei_uii = '" & TextBox1.Text & "' And passw = '" & TextBox2.Text & "'", con)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            Dim sda As NpgsqlDataAdapter = New NpgsqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            Me.UtsusersTableAdapter.FillByHEI_Uii(Me.User_DataSet.utsusers, TextBox1.Text)

            If (dt.Rows.Count > 0) Then
                TextBox2.Text = ""

                MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If AccesslevelLabel1.Text = "School" Then

                    Liquidation_Form.Show()
                    Liquidation_Form.ComboBox1.SelectedValue = TextBox1.Text
                    Liquidation_Form.ToolStripLabel2.Text = "School"


                Else

                    Main_Form.Show()
                    Main_Form.ToolStripLabel2.Text = "UniFAST"
                End If


                Me.Close()

            Else
                MessageBox.Show("Login Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        End If
    End Sub

    Private Sub UtsusersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UtsusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User_DataSet)

    End Sub

    Private Sub UtsusersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UtsusersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtsusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User_DataSet)

    End Sub
End Class