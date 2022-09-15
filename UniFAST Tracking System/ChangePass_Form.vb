Imports System.Security.Cryptography
Imports System.Text

Public Class ChangePass_Form
    Public Function md5fromstring(ByVal source As String) As String
        Dim bytes() As Byte
        Dim sb As New StringBuilder()
        If String.IsNullOrEmpty(source) Then
            ' MsgBox("Please Input Password", vbCritical)


        End If
        bytes = Encoding.Default.GetBytes(source)
        bytes = MD5.Create().ComputeHash(bytes)
        For x As Integer = 0 To bytes.Length - 1
            sb.Append(bytes(x).ToString("x2"))


        Next
        Return sb.ToString
    End Function
    Private Sub UtsusersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UtsusersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtsusersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User_DataSet)

    End Sub

    Private Sub ChangePass_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_DataSet.utsusers' table. You can move, or remove it, as needed.
        TextBox1.Text = ""


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PasswTextBox.Text = TextBox1.Text Then


            Dim HashCode As UserRegistration_Form
            HashCode = New UserRegistration_Form()
            TextBox1.Text = HashCode.md5fromstring(TextBox1.Text)
            PasswTextBox.Text = HashCode.md5fromstring(PasswTextBox.Text)

            Me.Validate()
            Me.UtsusersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.User_DataSet)
            MsgBox("Password Updated!", vbInformation)
            Me.Close()

        Else
            MsgBox("Password not matched!", vbExclamation)
        End If

    End Sub
End Class