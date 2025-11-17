<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choose
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(choose))
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.btn_Admin = New System.Windows.Forms.Button()
        Me.lbl_Create = New System.Windows.Forms.Label()
        Me.lbl_Admin = New System.Windows.Forms.Label()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Create
        '
        Me.btn_Create.AutoSize = True
        Me.btn_Create.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.user_14_512_cropped
        Me.btn_Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Create.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Create.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Create.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Create.Location = New System.Drawing.Point(109, 12)
        Me.btn_Create.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.Size(81, 63)
        Me.btn_Create.TabIndex = 2
        Me.btn_Create.UseVisualStyleBackColor = True
        '
        'btn_Admin
        '
        Me.btn_Admin.AutoSize = True
        Me.btn_Admin.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.pngtube_com_admin_png_3919167
        Me.btn_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Admin.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Admin.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Admin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Admin.Location = New System.Drawing.Point(208, 12)
        Me.btn_Admin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Admin.Name = "btn_Admin"
        Me.btn_Admin.Size = New System.Drawing.Size(81, 63)
        Me.btn_Admin.TabIndex = 3
        Me.btn_Admin.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_Admin.UseVisualStyleBackColor = True
        '
        'lbl_Create
        '
        Me.lbl_Create.AutoSize = True
        Me.lbl_Create.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Create.Location = New System.Drawing.Point(103, 78)
        Me.lbl_Create.Name = "lbl_Create"
        Me.lbl_Create.Size = New System.Drawing.Size(95, 16)
        Me.lbl_Create.TabIndex = 3
        Me.lbl_Create.Text = "Create Account"
        '
        'lbl_Admin
        '
        Me.lbl_Admin.AutoSize = True
        Me.lbl_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Admin.Location = New System.Drawing.Point(204, 78)
        Me.lbl_Admin.Name = "lbl_Admin"
        Me.lbl_Admin.Size = New System.Drawing.Size(90, 16)
        Me.lbl_Admin.TabIndex = 3
        Me.lbl_Admin.Text = "Admin Window"
        '
        'btn_Login
        '
        Me.btn_Login.AutoSize = True
        Me.btn_Login.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.Artboard_9_512
        Me.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Login.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Login.Location = New System.Drawing.Point(11, 12)
        Me.btn_Login.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(81, 63)
        Me.btn_Login.TabIndex = 1
        Me.btn_Login.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Login.Location = New System.Drawing.Point(14, 78)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(76, 16)
        Me.lbl_Login.TabIndex = 3
        Me.lbl_Login.Text = "Login Screen"
        '
        'choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 100)
        Me.Controls.Add(Me.lbl_Login)
        Me.Controls.Add(Me.lbl_Admin)
        Me.Controls.Add(Me.lbl_Create)
        Me.Controls.Add(Me.btn_Create)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.btn_Admin)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "choose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Create As Button
    Friend WithEvents btn_Admin As Button
    Friend WithEvents lbl_Create As Label
    Friend WithEvents lbl_Admin As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents lbl_Login As Label
End Class
