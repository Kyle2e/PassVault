<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccountFrm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Createbtn = New System.Windows.Forms.Button()
        Me.CreatePasswordlbl = New System.Windows.Forms.Label()
        Me.CheckPasswordlbl = New System.Windows.Forms.Label()
        Me.RetypePasswordtxt = New System.Windows.Forms.TextBox()
        Me.CreatePasswordtxt = New System.Windows.Forms.TextBox()
        Me.CreateUserNametxt = New System.Windows.Forms.TextBox()
        Me.CreateUserNamelbl = New System.Windows.Forms.Label()
        Me.CreateBackbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Trajan Pro", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PassVault"
        '
        'Createbtn
        '
        Me.Createbtn.BackColor = System.Drawing.Color.White
        Me.Createbtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Createbtn.Location = New System.Drawing.Point(276, 213)
        Me.Createbtn.Name = "Createbtn"
        Me.Createbtn.Size = New System.Drawing.Size(75, 38)
        Me.Createbtn.TabIndex = 7
        Me.Createbtn.Text = "Create"
        Me.Createbtn.UseVisualStyleBackColor = False
        '
        'CreatePasswordlbl
        '
        Me.CreatePasswordlbl.AutoSize = True
        Me.CreatePasswordlbl.BackColor = System.Drawing.Color.Bisque
        Me.CreatePasswordlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CreatePasswordlbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatePasswordlbl.Location = New System.Drawing.Point(182, 128)
        Me.CreatePasswordlbl.Name = "CreatePasswordlbl"
        Me.CreatePasswordlbl.Size = New System.Drawing.Size(88, 20)
        Me.CreatePasswordlbl.TabIndex = 8
        Me.CreatePasswordlbl.Text = "Password:"
        '
        'CheckPasswordlbl
        '
        Me.CheckPasswordlbl.AutoSize = True
        Me.CheckPasswordlbl.BackColor = System.Drawing.Color.Bisque
        Me.CheckPasswordlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CheckPasswordlbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPasswordlbl.Location = New System.Drawing.Point(125, 166)
        Me.CheckPasswordlbl.Name = "CheckPasswordlbl"
        Me.CheckPasswordlbl.Size = New System.Drawing.Size(145, 20)
        Me.CheckPasswordlbl.TabIndex = 9
        Me.CheckPasswordlbl.Text = "Retype Password:"
        '
        'RetypePasswordtxt
        '
        Me.RetypePasswordtxt.Location = New System.Drawing.Point(274, 167)
        Me.RetypePasswordtxt.Name = "RetypePasswordtxt"
        Me.RetypePasswordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RetypePasswordtxt.Size = New System.Drawing.Size(100, 20)
        Me.RetypePasswordtxt.TabIndex = 10
        '
        'CreatePasswordtxt
        '
        Me.CreatePasswordtxt.Location = New System.Drawing.Point(274, 128)
        Me.CreatePasswordtxt.Name = "CreatePasswordtxt"
        Me.CreatePasswordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CreatePasswordtxt.Size = New System.Drawing.Size(100, 20)
        Me.CreatePasswordtxt.TabIndex = 11
        '
        'CreateUserNametxt
        '
        Me.CreateUserNametxt.Location = New System.Drawing.Point(274, 91)
        Me.CreateUserNametxt.Name = "CreateUserNametxt"
        Me.CreateUserNametxt.Size = New System.Drawing.Size(100, 20)
        Me.CreateUserNametxt.TabIndex = 12
        '
        'CreateUserNamelbl
        '
        Me.CreateUserNamelbl.AutoSize = True
        Me.CreateUserNamelbl.BackColor = System.Drawing.Color.Bisque
        Me.CreateUserNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CreateUserNamelbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateUserNamelbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CreateUserNamelbl.Location = New System.Drawing.Point(173, 91)
        Me.CreateUserNamelbl.Name = "CreateUserNamelbl"
        Me.CreateUserNamelbl.Size = New System.Drawing.Size(97, 20)
        Me.CreateUserNamelbl.TabIndex = 13
        Me.CreateUserNamelbl.Text = "User Name:"
        '
        'CreateBackbtn
        '
        Me.CreateBackbtn.BackColor = System.Drawing.Color.White
        Me.CreateBackbtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateBackbtn.Location = New System.Drawing.Point(195, 213)
        Me.CreateBackbtn.Name = "CreateBackbtn"
        Me.CreateBackbtn.Size = New System.Drawing.Size(75, 38)
        Me.CreateBackbtn.TabIndex = 14
        Me.CreateBackbtn.Text = "Back"
        Me.CreateBackbtn.UseVisualStyleBackColor = False
        '
        'CreateAccountFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(499, 336)
        Me.Controls.Add(Me.CreateBackbtn)
        Me.Controls.Add(Me.CreateUserNamelbl)
        Me.Controls.Add(Me.CreateUserNametxt)
        Me.Controls.Add(Me.CreatePasswordtxt)
        Me.Controls.Add(Me.RetypePasswordtxt)
        Me.Controls.Add(Me.CheckPasswordlbl)
        Me.Controls.Add(Me.CreatePasswordlbl)
        Me.Controls.Add(Me.Createbtn)
        Me.Controls.Add(Me.Label2)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Name = "CreateAccountFrm"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Createbtn As System.Windows.Forms.Button
    Friend WithEvents CreatePasswordlbl As System.Windows.Forms.Label
    Friend WithEvents CheckPasswordlbl As System.Windows.Forms.Label
    Friend WithEvents RetypePasswordtxt As System.Windows.Forms.TextBox
    Friend WithEvents CreatePasswordtxt As System.Windows.Forms.TextBox
    Friend WithEvents CreateUserNametxt As System.Windows.Forms.TextBox
    Friend WithEvents CreateUserNamelbl As System.Windows.Forms.Label
    Friend WithEvents CreateBackbtn As System.Windows.Forms.Button
End Class
