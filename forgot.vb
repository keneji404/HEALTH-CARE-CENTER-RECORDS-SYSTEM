Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Recover
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider

    Private Sub Forgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txt_RecoverCode.UseSystemPasswordChar = True
        txt_Password.UseSystemPasswordChar = True
    End Sub

    'BUTTONS

    'Check the Recovery Code and if Correct, it will show you your Current Username & Password
    Private Sub Btn_Recover_Click(sender As Object, e As EventArgs) Handles btn_Recover.Click
        Dim number As String = txt_RecoverCode.Text
        Dim password As String = txt_Password.Text
        Dim con As New MYDB_CONNECTION

        If number.Trim() = "" Then
            MessageBox.Show("Please type the Recovery Code to recover password", "Enter Recovery Code!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else
            Dim command As New MySqlCommand("SELECT * FROM admin where Recoverynumber=@number", con.GetConnection)
            command.Parameters.Add("@number", MySqlDbType.Int64).Value = number
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            If table.Rows.Count > 0 Then 'placing the search data from mysql into the fields
                MessageBox.Show("Recovery Code Confirmed.", "Password Recovered!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lbl_User.Visible = True
                txt_User.Visible = True
                lbl_Password.Visible = True
                txt_Password.Visible = True
                pic_Eye2.Visible = True
                txt_User.Text = table(0)(1)
                txt_Password.Text = Decrypt(table(0)(2), "abc")

            Else
                lbl_User.Visible = False
                txt_User.Visible = False
                lbl_Password.Visible = False
                txt_Password.Visible = False
                pic_Eye2.Visible = False
                MessageBox.Show("Recovery Code not found!", "Wrong Recovery Code!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If
    End Sub

    'Back to Login Screen
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        loginform.password.Text = ""
        loginform.Show()
    End Sub

    'Disable or Enable Character Block (for Recovery Code)
    Private Sub Pic_Eye_Click(sender As Object, e As EventArgs) Handles pic_Eye.Click
        If txt_RecoverCode.UseSystemPasswordChar = True Then
            pic_Eye.Image = My.Resources.hide_password
            pic_Eye.SizeMode = PictureBoxSizeMode.Zoom
            txt_RecoverCode.UseSystemPasswordChar = False
        Else
            pic_Eye.Image = My.Resources.show_password
            pic_Eye.SizeMode = PictureBoxSizeMode.Zoom
            txt_RecoverCode.UseSystemPasswordChar = True
        End If
    End Sub

    'Disable or Enable Character Block (for Password)
    Private Sub Pic_Eye2_Click(sender As Object, e As EventArgs) Handles pic_Eye2.Click
        If txt_Password.UseSystemPasswordChar = True Then
            pic_Eye2.Image = My.Resources.hide_password
            pic_Eye2.SizeMode = PictureBoxSizeMode.Zoom
            txt_Password.UseSystemPasswordChar = False
        Else
            pic_Eye2.Image = My.Resources.show_password
            pic_Eye2.SizeMode = PictureBoxSizeMode.Zoom
            txt_Password.UseSystemPasswordChar = True
        End If
    End Sub

    'FUNCTIONS

    'Decrypt Password
    Function MD5Hash(ByVal pass As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass))
    End Function

    Private Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
        Try
            des.Key = Me.MD5Hash(key)
            des.Mode = CipherMode.ECB
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show("Invalid Key", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return 0
    End Function

    'VARIOUS OPTIONS

    'Enter Key Shortcut
    Private Sub Txt_RecoverCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RecoverCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Recover.PerformClick()
        End If
    End Sub

    'FORM CONTROLS

    'Minimize and Exit Controls
    Private Sub Pic_Minimize_MouseHover(sender As Object, e As EventArgs) Handles pic_Minimize.MouseHover
        pic_Minimize.Image = My.Resources.minimize1
        pic_Minimize.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Minimize_MouseLeave(sender As Object, e As EventArgs) Handles pic_Minimize.MouseLeave
        pic_Minimize.Image = My.Resources.minimize2
        pic_Minimize.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Exit_MouseHover(sender As Object, e As EventArgs) Handles pic_Exit.MouseHover
        pic_Exit.Image = My.Resources.exit1
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Exit_MouseLeave(sender As Object, e As EventArgs) Handles pic_Exit.MouseLeave
        pic_Exit.Image = My.Resources.exit2
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Exit_Click(sender As Object, e As EventArgs) Handles pic_Exit.Click
        Application.Exit()
    End Sub

    Private Sub Pic_Minimize_Click(sender As Object, e As EventArgs) Handles pic_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Form Drag
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub MenuStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub MenuStrip1_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseUp
        drag = False
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Please Enter your current Recovery Code.", "Remember IT!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class