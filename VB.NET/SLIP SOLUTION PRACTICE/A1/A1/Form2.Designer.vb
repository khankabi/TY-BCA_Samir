<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Name = New System.Windows.Forms.Label()
        Me.Salary = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Idtxt = New System.Windows.Forms.TextBox()
        Me.Nametxt = New System.Windows.Forms.TextBox()
        Me.Salarytxt = New System.Windows.Forms.TextBox()
        Me.NewBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(38, 29)
        Me.Name.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(26, 18)
        Me.Name.TabIndex = 0
        Me.Name.Text = "ID"
        '
        'Salary
        '
        Me.Salary.AutoSize = True
        Me.Salary.Location = New System.Drawing.Point(38, 83)
        Me.Salary.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(54, 18)
        Me.Salary.TabIndex = 1
        Me.Salary.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salary"
        '
        'Idtxt
        '
        Me.Idtxt.Location = New System.Drawing.Point(160, 25)
        Me.Idtxt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Idtxt.Name = "Idtxt"
        Me.Idtxt.Size = New System.Drawing.Size(164, 26)
        Me.Idtxt.TabIndex = 3
        '
        'Nametxt
        '
        Me.Nametxt.Location = New System.Drawing.Point(160, 79)
        Me.Nametxt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(164, 26)
        Me.Nametxt.TabIndex = 4
        '
        'Salarytxt
        '
        Me.Salarytxt.Location = New System.Drawing.Point(160, 141)
        Me.Salarytxt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Salarytxt.Name = "Salarytxt"
        Me.Salarytxt.Size = New System.Drawing.Size(164, 26)
        Me.Salarytxt.TabIndex = 5
        '
        'NewBtn
        '
        Me.NewBtn.Location = New System.Drawing.Point(43, 216)
        Me.NewBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(125, 32)
        Me.NewBtn.TabIndex = 6
        Me.NewBtn.Text = "New"
        Me.NewBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(178, 216)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(125, 32)
        Me.SaveBtn.TabIndex = 7
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ShowBtn
        '
        Me.ShowBtn.Location = New System.Drawing.Point(313, 216)
        Me.ShowBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(125, 32)
        Me.ShowBtn.TabIndex = 8
        Me.ShowBtn.Text = "Show"
        Me.ShowBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(178, 256)
        Me.ExitBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(125, 32)
        Me.ExitBtn.TabIndex = 9
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(473, 361)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ShowBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.NewBtn)
        Me.Controls.Add(Me.Salarytxt)
        Me.Controls.Add(Me.Nametxt)
        Me.Controls.Add(Me.Idtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.Name)
        Me.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Name As Label
    Friend WithEvents Salary As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Idtxt As TextBox
    Friend WithEvents Nametxt As TextBox
    Friend WithEvents Salarytxt As TextBox
    Friend WithEvents NewBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents ShowBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
