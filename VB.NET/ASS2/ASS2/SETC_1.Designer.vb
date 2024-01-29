<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SETC_1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rd40 = New System.Windows.Forms.RadioButton()
        Me.rd1940 = New System.Windows.Forms.RadioButton()
        Me.rd18 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkright = New System.Windows.Forms.CheckBox()
        Me.chkcant = New System.Windows.Forms.CheckBox()
        Me.chkcan = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdcustom = New System.Windows.Forms.RadioButton()
        Me.rdfemale = New System.Windows.Forms.RadioButton()
        Me.rdmale = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 376)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rd40)
        Me.GroupBox4.Controls.Add(Me.rd1940)
        Me.GroupBox4.Controls.Add(Me.rd18)
        Me.GroupBox4.Location = New System.Drawing.Point(209, 83)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(123, 125)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Age"
        '
        'rd40
        '
        Me.rd40.AutoSize = True
        Me.rd40.Location = New System.Drawing.Point(6, 88)
        Me.rd40.Name = "rd40"
        Me.rd40.Size = New System.Drawing.Size(88, 20)
        Me.rd40.TabIndex = 2
        Me.rd40.TabStop = True
        Me.rd40.Text = "Above 40"
        Me.rd40.UseVisualStyleBackColor = True
        '
        'rd1940
        '
        Me.rd1940.AutoSize = True
        Me.rd1940.Location = New System.Drawing.Point(6, 62)
        Me.rd1940.Name = "rd1940"
        Me.rd1940.Size = New System.Drawing.Size(65, 20)
        Me.rd1940.TabIndex = 1
        Me.rd1940.TabStop = True
        Me.rd1940.Text = "19-40"
        Me.rd1940.UseVisualStyleBackColor = True
        '
        'rd18
        '
        Me.rd18.AutoSize = True
        Me.rd18.Location = New System.Drawing.Point(6, 36)
        Me.rd18.Name = "rd18"
        Me.rd18.Size = New System.Drawing.Size(111, 20)
        Me.rd18.TabIndex = 0
        Me.rd18.TabStop = True
        Me.rd18.Text = "Less than 18"
        Me.rd18.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkright)
        Me.GroupBox3.Controls.Add(Me.chkcant)
        Me.GroupBox3.Controls.Add(Me.chkcan)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(123, 125)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Right"
        '
        'chkright
        '
        Me.chkright.AutoSize = True
        Me.chkright.Location = New System.Drawing.Point(6, 88)
        Me.chkright.Name = "chkright"
        Me.chkright.Size = New System.Drawing.Size(80, 20)
        Me.chkright.TabIndex = 2
        Me.chkright.Text = "All Right"
        Me.chkright.UseVisualStyleBackColor = True
        '
        'chkcant
        '
        Me.chkcant.AutoSize = True
        Me.chkcant.Location = New System.Drawing.Point(6, 62)
        Me.chkcant.Name = "chkcant"
        Me.chkcant.Size = New System.Drawing.Size(99, 20)
        Me.chkcant.TabIndex = 1
        Me.chkcant.Text = "Can't Drive"
        Me.chkcant.UseVisualStyleBackColor = True
        '
        'chkcan
        '
        Me.chkcan.AutoSize = True
        Me.chkcan.Location = New System.Drawing.Point(6, 36)
        Me.chkcan.Name = "chkcan"
        Me.chkcan.Size = New System.Drawing.Size(87, 20)
        Me.chkcan.TabIndex = 0
        Me.chkcan.Text = "Drive Car"
        Me.chkcan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdcustom)
        Me.GroupBox2.Controls.Add(Me.rdfemale)
        Me.GroupBox2.Controls.Add(Me.rdmale)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(123, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gender"
        '
        'rdcustom
        '
        Me.rdcustom.AutoSize = True
        Me.rdcustom.Location = New System.Drawing.Point(6, 88)
        Me.rdcustom.Name = "rdcustom"
        Me.rdcustom.Size = New System.Drawing.Size(75, 20)
        Me.rdcustom.TabIndex = 2
        Me.rdcustom.TabStop = True
        Me.rdcustom.Text = "Custom"
        Me.rdcustom.UseVisualStyleBackColor = True
        '
        'rdfemale
        '
        Me.rdfemale.AutoSize = True
        Me.rdfemale.Location = New System.Drawing.Point(6, 62)
        Me.rdfemale.Name = "rdfemale"
        Me.rdfemale.Size = New System.Drawing.Size(72, 20)
        Me.rdfemale.TabIndex = 1
        Me.rdfemale.TabStop = True
        Me.rdfemale.Text = "Female"
        Me.rdfemale.UseVisualStyleBackColor = True
        '
        'rdmale
        '
        Me.rdmale.AutoSize = True
        Me.rdmale.Location = New System.Drawing.Point(6, 36)
        Me.rdmale.Name = "rdmale"
        Me.rdmale.Size = New System.Drawing.Size(56, 20)
        Me.rdmale.TabIndex = 0
        Me.rdmale.TabStop = True
        Me.rdmale.Text = "Male"
        Me.rdmale.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(118, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'SETC_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 389)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SETC_1"
        Me.Text = "SETC_1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rd40 As RadioButton
    Friend WithEvents rd1940 As RadioButton
    Friend WithEvents rd18 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkright As CheckBox
    Friend WithEvents chkcant As CheckBox
    Friend WithEvents chkcan As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdcustom As RadioButton
    Friend WithEvents rdfemale As RadioButton
    Friend WithEvents rdmale As RadioButton
End Class
