Imports MySql.Data.MySqlClient

Public Class add_medicine
    Private Sub Add_medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        loadtable()
    End Sub

    'BUTTONS

    'add medicine
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        Dim med As String = txt_Med.Text

        If txt_Med.Text = "" Then
            MessageBox.Show("Please Enter Medicine Name!", "Empty Medicine Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf ifmedexist(med) Then
            MessageBox.Show("This medicine already exist", "Medicine Exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'add new user

            Dim con As New MYDB_CONNECTION
            Dim command As New MySqlCommand("INSERT INTO medicine (medicine_name) values (@med)", con.GetConnection())

            command.Parameters.Add("@med", MySqlDbType.VarChar).Value = med

            con.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then
                Clear_Click()
                loadtable()
                Umbrella_Corp.loadmed()
                Add_Patient.loadmed()
                MessageBox.Show("Medicine Added", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.ClosedConnection()

            End If
        End If
    End Sub

    'Delete Medicine in Table
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("Do you want to delete {0}?", row.Cells("medicine_name").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
                    Using cmd As New MySqlCommand("DELETE FROM medicine WHERE medicine_name = @medicine_name", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@medicine_name", row.Cells("medicine_name").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                loadtable()
                Umbrella_Corp.loadmed()
                Add_Patient.loadmed()
            End If
        End If
    End Sub

    'FUNCTIONS

    'Load Datagrid
    Private Function loadtable()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT medicine_name FROM medicine", con)
        adapter.Fill(table)
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = table
        DataGridView1.Columns.Item("medicine_name").Width = 263
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

    'Textbox Reset
    Private Function Clear_Click()
        txt_Med.Text = ""
        Return 0
    End Function

    'Check if Medicine Already Exist
    Public Function ifmedexist(ByVal med As String) As Boolean
        Dim con As New MYDB_CONNECTION()
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM medicine where medicine_name=@txt_Med", con.GetConnection())

        command.Parameters.Add("@txt_Med", MySqlDbType.VarChar).Value = med
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
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
        Me.Close()
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

    Private Sub Txt_Med_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Med.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Add.PerformClick()
        End If
    End Sub
End Class