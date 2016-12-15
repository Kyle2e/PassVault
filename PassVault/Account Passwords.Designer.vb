<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountPasswordsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountPasswordsFrm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordList = New System.Windows.Forms.ListBox()
        Me.AddPasswordbtn = New System.Windows.Forms.Button()
        Me.LogOutBtn = New System.Windows.Forms.Button()
        Me.Showbtn = New System.Windows.Forms.Button()
        Me.Hidebtn = New System.Windows.Forms.Button()
        Me.Copybtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 39)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PassVault"
        '
        'PasswordList
        '
        Me.PasswordList.AccessibleRole = System.Windows.Forms.AccessibleRole.List
        Me.PasswordList.BackColor = System.Drawing.Color.Bisque
        Me.PasswordList.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordList.FormattingEnabled = True
        Me.PasswordList.ItemHeight = 18
        Me.PasswordList.Location = New System.Drawing.Point(55, 66)
        Me.PasswordList.Name = "PasswordList"
        Me.PasswordList.Size = New System.Drawing.Size(388, 220)
        Me.PasswordList.TabIndex = 8
        '
        'AddPasswordbtn
        '
        Me.AddPasswordbtn.BackColor = System.Drawing.Color.White
        Me.AddPasswordbtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPasswordbtn.Location = New System.Drawing.Point(311, 292)
        Me.AddPasswordbtn.Name = "AddPasswordbtn"
        Me.AddPasswordbtn.Size = New System.Drawing.Size(128, 34)
        Me.AddPasswordbtn.TabIndex = 9
        Me.AddPasswordbtn.Text = "Add Password"
        Me.AddPasswordbtn.UseVisualStyleBackColor = False
        '
        'LogOutBtn
        '
        Me.LogOutBtn.BackColor = System.Drawing.Color.White
        Me.LogOutBtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutBtn.Location = New System.Drawing.Point(222, 292)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.Size = New System.Drawing.Size(83, 34)
        Me.LogOutBtn.TabIndex = 11
        Me.LogOutBtn.Text = "Log Out"
        Me.LogOutBtn.UseVisualStyleBackColor = False
        '
        'Showbtn
        '
        Me.Showbtn.BackColor = System.Drawing.Color.White
        Me.Showbtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Showbtn.Location = New System.Drawing.Point(141, 292)
        Me.Showbtn.Name = "Showbtn"
        Me.Showbtn.Size = New System.Drawing.Size(75, 34)
        Me.Showbtn.TabIndex = 12
        Me.Showbtn.Text = "Show"
        Me.Showbtn.UseVisualStyleBackColor = False
        '
        'Hidebtn
        '
        Me.Hidebtn.BackColor = System.Drawing.Color.White
        Me.Hidebtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hidebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Hidebtn.Location = New System.Drawing.Point(60, 292)
        Me.Hidebtn.Name = "Hidebtn"
        Me.Hidebtn.Size = New System.Drawing.Size(75, 34)
        Me.Hidebtn.TabIndex = 14
        Me.Hidebtn.Text = "Hide"
        Me.Hidebtn.UseVisualStyleBackColor = False
        '
        'Copybtn
        '
        Me.Copybtn.BackColor = System.Drawing.Color.White
        Me.Copybtn.Enabled = False
        Me.Copybtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copybtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Copybtn.Location = New System.Drawing.Point(55, 26)
        Me.Copybtn.Name = "Copybtn"
        Me.Copybtn.Size = New System.Drawing.Size(75, 34)
        Me.Copybtn.TabIndex = 15
        Me.Copybtn.Text = "Copy"
        Me.Copybtn.UseCompatibleTextRendering = True
        Me.Copybtn.UseVisualStyleBackColor = False
        Me.Copybtn.Visible = False
        '
        'AccountPasswordsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(499, 336)
        Me.Controls.Add(Me.Copybtn)
        Me.Controls.Add(Me.Hidebtn)
        Me.Controls.Add(Me.Showbtn)
        Me.Controls.Add(Me.LogOutBtn)
        Me.Controls.Add(Me.AddPasswordbtn)
        Me.Controls.Add(Me.PasswordList)
        Me.Controls.Add(Me.Label2)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Name = "AccountPasswordsFrm"
        Me.Text = "Account Passwords"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PasswordList As System.Windows.Forms.ListBox
    Friend WithEvents AddPasswordbtn As System.Windows.Forms.Button
    Friend WithEvents LogOutBtn As System.Windows.Forms.Button
    Friend WithEvents Showbtn As System.Windows.Forms.Button
    Friend WithEvents Hidebtn As System.Windows.Forms.Button
    Friend WithEvents Copybtn As System.Windows.Forms.Button
End Class
