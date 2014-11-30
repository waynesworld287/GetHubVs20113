<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMusicInv
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
        Me.lblMusicId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboComposer = New System.Windows.Forms.ComboBox()
        Me.ComposerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicDataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicDataDataSet = New WindowsApplication2.MusicDataDataSet()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.ComposerTableAdapter = New WindowsApplication2.MusicDataDataSetTableAdapters.ComposerTableAdapter()
        Me.cboPublish = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCopy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboVoice = New System.Windows.Forms.ComboBox()
        Me.pbCover = New System.Windows.Forms.PictureBox()
        Me.pbFirstPage = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdBrowseCover = New System.Windows.Forms.Button()
        Me.cmdBrowsePage1 = New System.Windows.Forms.Button()
        Me.cmdAddLookup = New System.Windows.Forms.Button()
        CType(Me.ComposerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFirstPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Music Id:"
        '
        'lblMusicId
        '
        Me.lblMusicId.AutoSize = True
        Me.lblMusicId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMusicId.Location = New System.Drawing.Point(114, 35)
        Me.lblMusicId.Name = "lblMusicId"
        Me.lblMusicId.Size = New System.Drawing.Size(31, 15)
        Me.lblMusicId.TabIndex = 1
        Me.lblMusicId.Text = "New"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Music Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(248, 34)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(552, 20)
        Me.txtTitle.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Composer:"
        '
        'cboComposer
        '
        Me.cboComposer.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComposerBindingSource, "ComposerId", True))
        Me.cboComposer.DisplayMember = "ComposerId"
        Me.cboComposer.FormattingEnabled = True
        Me.cboComposer.Location = New System.Drawing.Point(110, 78)
        Me.cboComposer.Name = "cboComposer"
        Me.cboComposer.Size = New System.Drawing.Size(224, 21)
        Me.cboComposer.TabIndex = 5
        Me.cboComposer.ValueMember = "ComposerId"
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
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(658, 457)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(121, 37)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(658, 264)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(121, 37)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'ComposerTableAdapter
        '
        Me.ComposerTableAdapter.ClearBeforeFill = True
        '
        'cboPublish
        '
        Me.cboPublish.DisplayMember = "ComposerId"
        Me.cboPublish.FormattingEnabled = True
        Me.cboPublish.Location = New System.Drawing.Point(456, 78)
        Me.cboPublish.Name = "cboPublish"
        Me.cboPublish.Size = New System.Drawing.Size(344, 21)
        Me.cboPublish.TabIndex = 9
        Me.cboPublish.ValueMember = "ComposerId"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Publishing Company:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(110, 124)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(66, 20)
        Me.txtPrice.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Music Price:"
        '
        'txtCopy
        '
        Me.txtCopy.Location = New System.Drawing.Point(301, 124)
        Me.txtCopy.Name = "txtCopy"
        Me.txtCopy.Size = New System.Drawing.Size(66, 20)
        Me.txtCopy.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Number of Copies:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Performance Voice:"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(110, 182)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(690, 64)
        Me.txtNote.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Music Notes"
        '
        'cboVoice
        '
        Me.cboVoice.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComposerBindingSource, "ComposerId", True))
        Me.cboVoice.DisplayMember = "ComposerId"
        Me.cboVoice.FormattingEnabled = True
        Me.cboVoice.Location = New System.Drawing.Point(498, 124)
        Me.cboVoice.Name = "cboVoice"
        Me.cboVoice.Size = New System.Drawing.Size(224, 21)
        Me.cboVoice.TabIndex = 18
        Me.cboVoice.ValueMember = "ComposerId"
        '
        'pbCover
        '
        Me.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCover.Location = New System.Drawing.Point(46, 280)
        Me.pbCover.Name = "pbCover"
        Me.pbCover.Size = New System.Drawing.Size(241, 249)
        Me.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCover.TabIndex = 19
        Me.pbCover.TabStop = False
        '
        'pbFirstPage
        '
        Me.pbFirstPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFirstPage.Location = New System.Drawing.Point(348, 280)
        Me.pbFirstPage.Name = "pbFirstPage"
        Me.pbFirstPage.Size = New System.Drawing.Size(241, 249)
        Me.pbFirstPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFirstPage.TabIndex = 20
        Me.pbFirstPage.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cover Image"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(345, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "First Page Image"
        '
        'cmdBrowseCover
        '
        Me.cmdBrowseCover.Location = New System.Drawing.Point(169, 252)
        Me.cmdBrowseCover.Name = "cmdBrowseCover"
        Me.cmdBrowseCover.Size = New System.Drawing.Size(118, 25)
        Me.cmdBrowseCover.TabIndex = 23
        Me.cmdBrowseCover.Text = "Browse for Image"
        Me.cmdBrowseCover.UseVisualStyleBackColor = True
        '
        'cmdBrowsePage1
        '
        Me.cmdBrowsePage1.Location = New System.Drawing.Point(471, 252)
        Me.cmdBrowsePage1.Name = "cmdBrowsePage1"
        Me.cmdBrowsePage1.Size = New System.Drawing.Size(118, 25)
        Me.cmdBrowsePage1.TabIndex = 24
        Me.cmdBrowsePage1.Text = "Browse for Image"
        Me.cmdBrowsePage1.UseVisualStyleBackColor = True
        '
        'cmdAddLookup
        '
        Me.cmdAddLookup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddLookup.Location = New System.Drawing.Point(658, 321)
        Me.cmdAddLookup.Name = "cmdAddLookup"
        Me.cmdAddLookup.Size = New System.Drawing.Size(121, 37)
        Me.cmdAddLookup.TabIndex = 26
        Me.cmdAddLookup.Text = "&Edit Lookup Data"
        Me.cmdAddLookup.UseVisualStyleBackColor = True
        '
        'frmMusicInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 541)
        Me.Controls.Add(Me.cmdAddLookup)
        Me.Controls.Add(Me.cmdBrowsePage1)
        Me.Controls.Add(Me.cmdBrowseCover)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pbFirstPage)
        Me.Controls.Add(Me.pbCover)
        Me.Controls.Add(Me.cboVoice)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCopy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboPublish)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cboComposer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMusicId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMusicInv"
        Me.Text = "Music Inventory Details"
        CType(Me.ComposerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFirstPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMusicId As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboComposer As System.Windows.Forms.ComboBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents MusicDataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MusicDataDataSet As WindowsApplication2.MusicDataDataSet
    Friend WithEvents ComposerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComposerTableAdapter As WindowsApplication2.MusicDataDataSetTableAdapters.ComposerTableAdapter
    Friend WithEvents cboPublish As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCopy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pbCover As System.Windows.Forms.PictureBox
    Friend WithEvents pbFirstPage As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowseCover As System.Windows.Forms.Button
    Friend WithEvents cmdBrowsePage1 As System.Windows.Forms.Button
    Friend WithEvents cboVoice As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAddLookup As System.Windows.Forms.Button
End Class
