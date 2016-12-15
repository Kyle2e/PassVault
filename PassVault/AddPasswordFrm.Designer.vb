<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPasswordFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPasswordFrm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AccountNamelbl = New System.Windows.Forms.Label()
        Me.UserNamelbl = New System.Windows.Forms.Label()
        Me.Passwordlbl = New System.Windows.Forms.Label()
        Me.AccountNametxt = New System.Windows.Forms.TextBox()
        Me.UserNametxt = New System.Windows.Forms.TextBox()
        Me.Passwordtxt = New System.Windows.Forms.TextBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 39)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PassVault"
        '
        'AccountNamelbl
        '
        Me.AccountNamelbl.AutoSize = True
        Me.AccountNamelbl.BackColor = System.Drawing.Color.Bisque
        Me.AccountNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AccountNamelbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountNamelbl.Location = New System.Drawing.Point(46, 90)
        Me.AccountNamelbl.Name = "AccountNamelbl"
        Me.AccountNamelbl.Size = New System.Drawing.Size(129, 20)
        Me.AccountNamelbl.TabIndex = 8
        Me.AccountNamelbl.Text = "Account Name : "
        '
        'UserNamelbl
        '
        Me.UserNamelbl.AutoSize = True
        Me.UserNamelbl.BackColor = System.Drawing.Color.Bisque
        Me.UserNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserNamelbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNamelbl.Location = New System.Drawing.Point(70, 130)
        Me.UserNamelbl.Name = "UserNamelbl"
        Me.UserNamelbl.Size = New System.Drawing.Size(105, 20)
        Me.UserNamelbl.TabIndex = 9
        Me.UserNamelbl.Text = "User Name : "
        '
        'Passwordlbl
        '
        Me.Passwordlbl.AutoSize = True
        Me.Passwordlbl.BackColor = System.Drawing.Color.Bisque
        Me.Passwordlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Passwordlbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordlbl.Location = New System.Drawing.Point(83, 170)
        Me.Passwordlbl.Name = "Passwordlbl"
        Me.Passwordlbl.Size = New System.Drawing.Size(92, 20)
        Me.Passwordlbl.TabIndex = 10
        Me.Passwordlbl.Text = "Password :"
        '
        'AccountNametxt
        '
        Me.AccountNametxt.Location = New System.Drawing.Point(181, 91)
        Me.AccountNametxt.Name = "AccountNametxt"
        Me.AccountNametxt.Size = New System.Drawing.Size(100, 20)
        Me.AccountNametxt.TabIndex = 11
        '
        'UserNametxt
        '
        Me.UserNametxt.Location = New System.Drawing.Point(181, 131)
        Me.UserNametxt.Name = "UserNametxt"
        Me.UserNametxt.Size = New System.Drawing.Size(100, 20)
        Me.UserNametxt.TabIndex = 12
        '
        'Passwordtxt
        '
        Me.Passwordtxt.Location = New System.Drawing.Point(181, 171)
        Me.Passwordtxt.Name = "Passwordtxt"
        Me.Passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passwordtxt.Size = New System.Drawing.Size(100, 20)
        Me.Passwordtxt.TabIndex = 13
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.White
        Me.Addbtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.Location = New System.Drawing.Point(173, 216)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(80, 30)
        Me.Addbtn.TabIndex = 14
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.White
        Me.Back.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(74, 216)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 30)
        Me.Back.TabIndex = 15
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'AddPasswordFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(326, 337)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Passwordtxt)
        Me.Controls.Add(Me.UserNametxt)
        Me.Controls.Add(Me.AccountNametxt)
        Me.Controls.Add(Me.Passwordlbl)
        Me.Controls.Add(Me.UserNamelbl)
        Me.Controls.Add(Me.AccountNamelbl)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AddPasswordFrm"
        Me.Text = "AddPasswordFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AccountNamelbl As System.Windows.Forms.Label
    Friend WithEvents UserNamelbl As System.Windows.Forms.Label
    Friend WithEvents Passwordlbl As System.Windows.Forms.Label
    Friend WithEvents AccountNametxt As System.Windows.Forms.TextBox
    Friend WithEvents UserNametxt As System.Windows.Forms.TextBox
    Friend WithEvents Passwordtxt As System.Windows.Forms.TextBox
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
End Class
