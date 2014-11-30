<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddLookup
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvComposer = New System.Windows.Forms.DataGridView()
        Me.ComposerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComposerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComposerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicDataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicDataDataSet = New WindowsApplication2.MusicDataDataSet()
        Me.cmdComposer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvPublish = New System.Windows.Forms.DataGridView()
        Me.PcIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishingCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvMisc = New System.Windows.Forms.DataGridView()
        Me.LookupIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LookupTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LookupDataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiscLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ComposerTableAdapter = New WindowsApplication2.MusicDataDataSetTableAdapters.ComposerTableAdapter()
        Me.PublishingCompanyTableAdapter = New WindowsApplication2.MusicDataDataSetTableAdapters.PublishingCompanyTableAdapter()
        Me.MiscLookupTableAdapter = New WindowsApplication2.MusicDataDataSetTableAdapters.MiscLookupTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvComposer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComposerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPublish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishingCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.dgvComposer)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 385)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Composer Lookup"
        '
        'dgvComposer
        '
        Me.dgvComposer.AutoGenerateColumns = False
        Me.dgvComposer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComposer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ComposerIdDataGridViewTextBoxColumn, Me.ComposerDataGridViewTextBoxColumn})
        Me.dgvComposer.DataSource = Me.ComposerBindingSource
        Me.dgvComposer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvComposer.Location = New System.Drawing.Point(3, 16)
        Me.dgvComposer.Name = "dgvComposer"
        Me.dgvComposer.Size = New System.Drawing.Size(357, 366)
        Me.dgvComposer.TabIndex = 0
        '
        'ComposerIdDataGridViewTextBoxColumn
        '
        Me.ComposerIdDataGridViewTextBoxColumn.DataPropertyName = "ComposerId"
        Me.ComposerIdDataGridViewTextBoxColumn.HeaderText = "ComposerId"
        Me.ComposerIdDataGridViewTextBoxColumn.Name = "ComposerIdDataGridViewTextBoxColumn"
        Me.ComposerIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComposerDataGridViewTextBoxColumn
        '
        Me.ComposerDataGridViewTextBoxColumn.DataPropertyName = "Composer"
        Me.ComposerDataGridViewTextBoxColumn.HeaderText = "Composer"
        Me.ComposerDataGridViewTextBoxColumn.Name = "ComposerDataGridViewTextBoxColumn"
        '
        'ComposerBindingSource
        '
        Me.ComposerBindingSource.DataMember = "Composer"
        Me.ComposerBindingSource.DataSource = Me.MusicDataDataSetBindingSource
        '
        'MusicDataDataSetBindingSource
        '
        Me.MusicDataDataSetBindingSource.DataSource = Me.MusicDataDataSet
        Me.MusicDataDataSetBindingSource.Position = 0
        '
        'MusicDataDataSet
        '
        Me.MusicDataDataSet.DataSetName = "MusicDataDataSet"
        Me.MusicDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdComposer
        '
        Me.cmdComposer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComposer.Location = New System.Drawing.Point(496, 452)
        Me.cmdComposer.Name = "cmdComposer"
        Me.cmdComposer.Size = New System.Drawing.Size(270, 40)
        Me.cmdComposer.TabIndex = 1
        Me.cmdComposer.Text = "Update All Lookup Data"
        Me.cmdComposer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.dgvPublish)
        Me.GroupBox2.Location = New System.Drawing.Point(436, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 385)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Publishing Company Lookup"
        '
        'dgvPublish
        '
        Me.dgvPublish.AutoGenerateColumns = False
        Me.dgvPublish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPublish.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PcIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.dgvPublish.DataSource = Me.PublishingCompanyBindingSource
        Me.dgvPublish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPublish.Location = New System.Drawing.Point(3, 16)
        Me.dgvPublish.Name = "dgvPublish"
        Me.dgvPublish.Size = New System.Drawing.Size(357, 366)
        Me.dgvPublish.TabIndex = 1
        '
        'PcIdDataGridViewTextBoxColumn
        '
        Me.PcIdDataGridViewTextBoxColumn.DataPropertyName = "PcId"
        Me.PcIdDataGridViewTextBoxColumn.HeaderText = "PcId"
        Me.PcIdDataGridViewTextBoxColumn.Name = "PcIdDataGridViewTextBoxColumn"
        Me.PcIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PublishingCompanyBindingSource
        '
        Me.PublishingCompanyBindingSource.DataMember = "PublishingCompany"
        Me.PublishingCompanyBindingSource.DataSource = Me.MusicDataDataSetBindingSource
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox3.Controls.Add(Me.dgvMisc)
        Me.GroupBox3.Location = New System.Drawing.Point(844, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 385)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Voice Type Lookup"
        '
        'dgvMisc
        '
        Me.dgvMisc.AutoGenerateColumns = False
        Me.dgvMisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMisc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LookupIdDataGridViewTextBoxColumn, Me.LookupTypeDataGridViewTextBoxColumn, Me.LookupDataDataGridViewTextBoxColumn})
        Me.dgvMisc.DataSource = Me.MiscLookupBindingSource
        Me.dgvMisc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMisc.Location = New System.Drawing.Point(3, 16)
        Me.dgvMisc.Name = "dgvMisc"
        Me.dgvMisc.Size = New System.Drawing.Size(357, 366)
        Me.dgvMisc.TabIndex = 1
        '
        'LookupIdDataGridViewTextBoxColumn
        '
        Me.LookupIdDataGridViewTextBoxColumn.DataPropertyName = "LookupId"
        Me.LookupIdDataGridViewTextBoxColumn.HeaderText = "LookupId"
        Me.LookupIdDataGridViewTextBoxColumn.Name = "LookupIdDataGridViewTextBoxColumn"
        Me.LookupIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LookupTypeDataGridViewTextBoxColumn
        '
        Me.LookupTypeDataGridViewTextBoxColumn.DataPropertyName = "LookupType"
        Me.LookupTypeDataGridViewTextBoxColumn.HeaderText = "LookupType"
        Me.LookupTypeDataGridViewTextBoxColumn.Name = "LookupTypeDataGridViewTextBoxColumn"
        '
        'LookupDataDataGridViewTextBoxColumn
        '
        Me.LookupDataDataGridViewTextBoxColumn.DataPropertyName = "LookupData"
        Me.LookupDataDataGridViewTextBoxColumn.HeaderText = "LookupData"
        Me.LookupDataDataGridViewTextBoxColumn.Name = "LookupDataDataGridViewTextBoxColumn"
        '
        'MiscLookupBindingSource
        '
        Me.MiscLookupBindingSource.DataMember = "MiscLookup"
        Me.MiscLookupBindingSource.DataSource = Me.MusicDataDataSetBindingSource
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(1031, 452)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(173, 40)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "&close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'ComposerTableAdapter
        '
        Me.ComposerTableAdapter.ClearBeforeFill = True
        '
        'PublishingCompanyTableAdapter
        '
        Me.PublishingCompanyTableAdapter.ClearBeforeFill = True
        '
        'MiscLookupTableAdapter
        '
        Me.MiscLookupTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Highlight a record and press the <Delete> key to delete that record."
        '
        'frmAddLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 515)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdComposer)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmAddLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Lookup Data Tables"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvComposer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComposerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvPublish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishingCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvMisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvComposer As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MusicDataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MusicDataDataSet As WindowsApplication2.MusicDataDataSet
    Friend WithEvents ComposerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComposerTableAdapter As WindowsApplication2.MusicDataDataSetTableAdapters.ComposerTableAdapter
    Friend WithEvents ComposerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComposerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPublish As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMisc As System.Windows.Forms.DataGridView
    Friend WithEvents PublishingCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PublishingCompanyTableAdapter As WindowsApplication2.MusicDataDataSetTableAdapters.PublishingCompanyTableAdapter
    Friend WithEvents PcIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiscLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiscLookupTableAdapter As WindowsApplication2.MusicDataDataSetTableAdapters.MiscLookupTableAdapter
    Friend WithEvents LookupIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LookupTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LookupDataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdComposer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
