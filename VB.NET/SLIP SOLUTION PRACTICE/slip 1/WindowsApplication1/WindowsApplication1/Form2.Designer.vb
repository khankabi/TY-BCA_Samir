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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPDataSet = New WindowsApplication1.EMPDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EmpTableAdapter = New WindowsApplication1.EMPDataSetTableAdapters.EmpTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 179)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(179, 20)
        Me.TextBox3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EnoDataGridViewTextBoxColumn, Me.EnameDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(362, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'EnoDataGridViewTextBoxColumn
        '
        Me.EnoDataGridViewTextBoxColumn.DataPropertyName = "Eno"
        Me.EnoDataGridViewTextBoxColumn.HeaderText = "Eno"
        Me.EnoDataGridViewTextBoxColumn.Name = "EnoDataGridViewTextBoxColumn"
        '
        'EnameDataGridViewTextBoxColumn
        '
        Me.EnameDataGridViewTextBoxColumn.DataPropertyName = "Ename"
        Me.EnameDataGridViewTextBoxColumn.HeaderText = "Ename"
        Me.EnameDataGridViewTextBoxColumn.Name = "EnameDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'EmpBindingSource
        '
        Me.EmpBindingSource.DataMember = "Emp"
        Me.EmpBindingSource.DataSource = Me.EMPDataSet
        '
        'EMPDataSet
        '
        Me.EMPDataSet.DataSetName = "EMPDataSet"
        Me.EMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EmpTableAdapter
        '
        Me.EmpTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Eno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ename"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "salary"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents EMPDataSet As EMPDataSet
    Friend WithEvents EmpBindingSource As BindingSource
    Friend WithEvents EmpTableAdapter As EMPDataSetTableAdapters.EmpTableAdapter
    Friend WithEvents EnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
