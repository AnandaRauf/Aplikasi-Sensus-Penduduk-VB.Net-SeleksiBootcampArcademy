﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registeradmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registeradmin))
        Me.GroupBoxRegister = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.QuitBut = New System.Windows.Forms.Button()
        Me.RegBut = New System.Windows.Forms.Button()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.PassLBL = New System.Windows.Forms.Label()
        Me.UserLBL = New System.Windows.Forms.Label()
        Me.GroupBoxRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRegister
        '
        Me.GroupBoxRegister.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBoxRegister.Controls.Add(Me.LinkLabel1)
        Me.GroupBoxRegister.Controls.Add(Me.QuitBut)
        Me.GroupBoxRegister.Controls.Add(Me.RegBut)
        Me.GroupBoxRegister.Controls.Add(Me.PassBox)
        Me.GroupBoxRegister.Controls.Add(Me.EmailBox)
        Me.GroupBoxRegister.Controls.Add(Me.PassLBL)
        Me.GroupBoxRegister.Controls.Add(Me.UserLBL)
        Me.GroupBoxRegister.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxRegister.Name = "GroupBoxRegister"
        Me.GroupBoxRegister.Size = New System.Drawing.Size(463, 239)
        Me.GroupBoxRegister.TabIndex = 1
        Me.GroupBoxRegister.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MediumBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(125, 184)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(173, 15)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Have Account ? Klik Here !"
        '
        'QuitBut
        '
        Me.QuitBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBut.Location = New System.Drawing.Point(305, 173)
        Me.QuitBut.Name = "QuitBut"
        Me.QuitBut.Size = New System.Drawing.Size(96, 34)
        Me.QuitBut.TabIndex = 5
        Me.QuitBut.Text = "Quit"
        Me.QuitBut.UseVisualStyleBackColor = True
        '
        'RegBut
        '
        Me.RegBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegBut.Location = New System.Drawing.Point(23, 173)
        Me.RegBut.Name = "RegBut"
        Me.RegBut.Size = New System.Drawing.Size(96, 34)
        Me.RegBut.TabIndex = 4
        Me.RegBut.Text = "Register"
        Me.RegBut.UseVisualStyleBackColor = True
        '
        'PassBox
        '
        Me.PassBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassBox.Location = New System.Drawing.Point(133, 105)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(242, 26)
        Me.PassBox.TabIndex = 3
        '
        'EmailBox
        '
        Me.EmailBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailBox.Location = New System.Drawing.Point(133, 27)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(192, 26)
        Me.EmailBox.TabIndex = 2
        '
        'PassLBL
        '
        Me.PassLBL.AutoSize = True
        Me.PassLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLBL.Location = New System.Drawing.Point(19, 105)
        Me.PassLBL.Name = "PassLBL"
        Me.PassLBL.Size = New System.Drawing.Size(100, 21)
        Me.PassLBL.TabIndex = 1
        Me.PassLBL.Text = "Password :"
        '
        'UserLBL
        '
        Me.UserLBL.AutoSize = True
        Me.UserLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLBL.Location = New System.Drawing.Point(19, 27)
        Me.UserLBL.Name = "UserLBL"
        Me.UserLBL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserLBL.Size = New System.Drawing.Size(69, 21)
        Me.UserLBL.TabIndex = 0
        Me.UserLBL.Text = "Email :"
        '
        'registeradmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(847, 360)
        Me.Controls.Add(Me.GroupBoxRegister)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registeradmin"
        Me.Text = "Register Admin"
        Me.GroupBoxRegister.ResumeLayout(False)
        Me.GroupBoxRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxRegister As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents QuitBut As Button
    Friend WithEvents RegBut As Button
    Friend WithEvents PassBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents PassLBL As Label
    Friend WithEvents UserLBL As Label
End Class
