Public Class choose
    Private Sub Choose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    'BUTTONS

    'Create Account Window
    Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        loginform.AdminToolStripMenuItem.Text = "Deactivate Admin Mode"
        loginform.btn_Create.Visible = True
        loginform.btn_Login.Visible = False
        loginform.btn_Login.Enabled = False
        loginform.btn_Forgot.Visible = False
        loginform.lbl_RecoverCode.Visible = True
        loginform.txt_RecoverCode.Visible = True
        loginform.pic_Eye2.Visible = True
        loginform.LoginToolStripMenuItem.Text = "CREATE NEW ACCOUNT"
        loginform.username.Text = ""
        loginform.password.Text = ""
        Me.Close()
        AdminPass.Close()
    End Sub

    'Admin Window
    Private Sub Btn_Admin_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click
        loginform.Hide()
        Me.Close()
        Admin.Show()
    End Sub

    'Login Screen
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Me.Close()
        AdminPass.Close()
    End Sub

    'FORM CONTROLS

    'Form Drag
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Choose_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Choose_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Choose_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Btn_Login_MouseHover(sender As Object, e As EventArgs) Handles btn_Login.MouseHover
        My.Computer.Audio.Play("C:\Users\User\Desktop\sfx\misc_menu.wav")
    End Sub
End Class