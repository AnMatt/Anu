﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.STUDENTDataSet = New WindowsApplication16.STUDENTDataSet()
        Me.REGISTRATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGISTRATIONTableAdapter = New WindowsApplication16.STUDENTDataSetTableAdapters.REGISTRATIONTableAdapter()
        Me.FNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTRATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LName"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(155, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(155, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FNAMEDataGridViewTextBoxColumn, Me.LNAMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.REGISTRATIONBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(113, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'STUDENTDataSet
        '
        Me.STUDENTDataSet.DataSetName = "STUDENTDataSet"
        Me.STUDENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REGISTRATIONBindingSource
        '
        Me.REGISTRATIONBindingSource.DataMember = "REGISTRATION"
        Me.REGISTRATIONBindingSource.DataSource = Me.STUDENTDataSet
        '
        'REGISTRATIONTableAdapter
        '
        Me.REGISTRATIONTableAdapter.ClearBeforeFill = True
        '
        'FNAMEDataGridViewTextBoxColumn
        '
        Me.FNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn.Name = "FNAMEDataGridViewTextBoxColumn"
        '
        'LNAMEDataGridViewTextBoxColumn
        '
        Me.LNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn.Name = "LNAMEDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 422)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTRATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents STUDENTDataSet As STUDENTDataSet
    Friend WithEvents REGISTRATIONBindingSource As BindingSource
    Friend WithEvents REGISTRATIONTableAdapter As STUDENTDataSetTableAdapters.REGISTRATIONTableAdapter
    Friend WithEvents FNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
