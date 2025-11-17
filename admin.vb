Imports MySql.Data.MySqlClient

Public Class Admin
    Dim table As New DataTable
    Dim con As New MYDB_CONNECTION
    Dim adapter As New MySqlDataAdapter
    Dim code As String
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtable()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")

        code = AdminPass.txt_AdminCode.Text
        Me.CenterToScreen()
    End Sub

    'BUTTONS

    'Logout to Login Screen
    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        If MessageBox.Show("Do you want to Log Out and go back to Login Screen?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            loginform.Show()
            Me.Close()
            AdminPass.Close()
        Else
            Me.Show()
        End If
    End Sub

    'Delete Doctor in Table
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("Do you want to delete {0}?", row.Cells("UserName").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
                    Using cmd As New MySqlCommand("DELETE FROM admin WHERE UserName = @UserName", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@UserName", row.Cells("UserName").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using

                loadtable()
            End If
        End If
    End Sub

    'Disable or Enable Character Block (For Current Code)
    Private Sub Pic_Eye_Click(sender As Object, e As EventArgs) Handles pic_Eye.Click
        If txt_Current.UseSystemPasswordChar = True Then
            pic_Eye.Image = My.Resources.hide_password
            pic_Eye.SizeMode = PictureBoxSizeMode.Zoom
            txt_Current.UseSystemPasswordChar = False
        Else
            pic_Eye.Image = My.Resources.show_password
            pic_Eye.SizeMode = PictureBoxSizeMode.Zoom
            txt_Current.UseSystemPasswordChar = True
        End If
    End Sub

    'Disable or Enable Character Block (For New Code Code)
    Private Sub Pic_Eye2_Click(sender As Object, e As EventArgs) Handles pic_Eye2.Click
        If txt_New.UseSystemPasswordChar = True Then
            pic_Eye2.Image = My.Resources.hide_password
            pic_Eye2.SizeMode = PictureBoxSizeMode.Zoom
            txt_New.UseSystemPasswordChar = False
        Else
            pic_Eye2.Image = My.Resources.show_password
            pic_Eye2.SizeMode = PictureBoxSizeMode.Zoom
            txt_New.UseSystemPasswordChar = True
        End If
    End Sub

    'FUNCTIONS

    'Load Datagrid
    Private Function loadtable()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
        Dim adapter As New MySqlDataAdapter("SELECT UserName FROM admin", con)
        adapter.Fill(table)
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = table
        DataGridView1.Columns.Item("UserName").Width = 262
        DataGridView1.AllowUserToAddRows = False

        'add delete button in table
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()

        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Insert(1, buttonColumn)

        Return DataGridView1.DataSource
    End Function

    'back to admin view
    Private Function Cancel()
        ChangeCodeToolStripMenuItem.Visible = True
        lbl_Accounts.Show()
        DataGridView1.Show()
        lbl_Change.Hide()
        lbl_Current.Hide()
        lbl_New.Hide()
        lbl_Confirm.Hide()
        txt_Current.Hide()
        txt_New.Hide()
        txt_Confirm.Hide()
        pic_Eye.Hide()
        pic_Eye2.Hide()
        btn_Cancel.Hide()
        btn_Change.Hide()
        Return 0
    End Function

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

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCodeToolStripMenuItem.Click
        ChangeCodeToolStripMenuItem.Visible = False
        lbl_Accounts.Hide()
        DataGridView1.Hide()
        lbl_Change.Show()
        lbl_Current.Show()
        lbl_New.Show()
        lbl_Confirm.Show()
        txt_Current.Show()
        txt_New.Show()
        txt_Confirm.Show()
        pic_Eye.Show()
        pic_Eye2.Show()
        btn_Cancel.Show()
        btn_Change.Show()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Cancel()
    End Sub

    'VARIOUS OPTIONS

    Private Sub Txt_Current_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_New.KeyDown, txt_Current.KeyDown, txt_Confirm.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Change.PerformClick()
        End If
    End Sub

    Private Sub Btn_Change_Click(sender As Object, e As EventArgs) Handles btn_Change.Click
        Dim current As String = txt_Current.Text
        Dim newc As String = txt_New.Text
        Dim confirm As String = txt_Confirm.Text
        If (current = "" Or newc = "" Or confirm = "") Then
            MessageBox.Show("One or more fields are empty", "FYI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (current <> code) Then
            MessageBox.Show("Invalid Current Code", "FYI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (newc <> confirm) Then
            MessageBox.Show("Code not Matched", "FYI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Using con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
                Using cmd As New MySqlCommand("UPDATE activate_admin SET code = '" & confirm & "' WHERE code = '" & code & "'", con)
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Code Changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
            Cancel()
        End If

    End Sub

End Class