<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPass))
        Me.txt_AdminCode = New System.Windows.Forms.TextBox()
        Me.lbl_AdminCode = New System.Windows.Forms.Label()
        Me.btn_Enter = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_AdminCode
        '
        Me.txt_AdminCode.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_AdminCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_AdminCode.Location = New System.Drawing.Point(118, 27)
        Me.txt_AdminCode.Name = "txt_AdminCode"
        Me.txt_AdminCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_AdminCode.Size = New System.Drawing.Size(132, 22)
        Me.txt_AdminCode.TabIndex = 1
        '
        'lbl_AdminCode
        '
        Me.lbl_AdminCode.AutoSize = True
        Me.lbl_AdminCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_AdminCode.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_AdminCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_AdminCode.Location = New System.Drawing.Point(20, 27)
        Me.lbl_AdminCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_AdminCode.Name = "lbl_AdminCode"
        Me.lbl_AdminCode.Size = New System.Drawing.Size(96, 20)
        Me.lbl_AdminCode.TabIndex = 0
        Me.lbl_AdminCode.Text = "Admin Code"
        '
        'btn_Enter
        '
        Me.btn_Enter.AutoSize = True
        Me.btn_Enter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enter.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Enter.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_Enter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Enter.Location = New System.Drawing.Point(158, 61)
        Me.btn_Enter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Enter.Name = "btn_Enter"
        Me.btn_Enter.Size = New System.Drawing.Size(92, 27)
        Me.btn_Enter.TabIndex = 2
        Me.btn_Enter.Text = "Enter"
        Me.btn_Enter.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Cancel.Location = New System.Drawing.Point(24, 61)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 27)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'AdminPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(270, 100)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Enter)
        Me.Controls.Add(Me.lbl_AdminCode)
        Me.Controls.Add(Me.txt_AdminCode)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "AdminPass"
        Me.Text = "Admin Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_AdminCode As TextBox
    Friend WithEvents lbl_AdminCode As Label
    Friend WithEvents btn_Enter As Button
    Friend WithEvents btn_Cancel As Button
End Class
