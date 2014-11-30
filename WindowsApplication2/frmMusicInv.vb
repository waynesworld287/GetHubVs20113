Imports System.Data
Imports System.Data.SqlClient

Public Class frmMusicInv

    Public gbCoverIsDirty As Boolean
    Public gbFirstPageIsDirty As Boolean

    Public gsComposer As String
    Public gsPublish As String
    Public gsVoice As String


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If Len(Trim(txtTitle.Text)) < 1 Then

            MsgBox("A music title is required.", MsgBoxStyle.OkOnly, "A title is required")

            txtTitle.Focus()

            Exit Sub

        End If

        If cboComposer.SelectedIndex = -1 Then

            MsgBox("Composer is required.  Use the Add Lookup Data button to add as needed.", MsgBoxStyle.OkOnly, "Composer is required")

            cboComposer.Focus()

            Exit Sub

        End If

        If cboPublish.SelectedIndex = -1 Then

            MsgBox("Publishing Company is required.  Use the Add Lookup Data button to add as needed.", MsgBoxStyle.OkOnly, "Publishing Company is required")

            cboPublish.Focus()

            Exit Sub

        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub frmMusicInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As SqlConnection = New SqlConnection("Data Source=myOLDGATEWAY\waynesdb;Initial Catalog=MusicData;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("Select * From Composer", con)

        con.Open()

        Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim myDataSet As DataSet = New DataSet()

        'Fill Composer combobox
        myDA.Fill(myDataSet, "MyComposer")

        Me.cboComposer.DataSource = myDataSet.Tables("MyComposer").DefaultView

        Me.cboComposer.DisplayMember = "Composer"
        Me.cboComposer.ValueMember = "ComposerId"

        If gsComposer = "New" Then

            cboComposer.SelectedText = "Please select a composer .........."
            cboComposer.SelectedIndex = -1

        Else

            Me.cboComposer.SelectedValue = gsComposer

        End If

        'Fill Publish Company combobox
        cmd = New SqlCommand("Select * From PublishingCompany", con)

        myDA = New SqlDataAdapter(cmd)

        myDA.Fill(myDataSet, "MyPublish")

        Me.cboPublish.DataSource = myDataSet.Tables("MyPublish").DefaultView
        Me.cboPublish.DisplayMember = "Name"
        Me.cboPublish.ValueMember = "PcId"

        If gsPublish = "New" Then

            cboPublish.SelectedText = "Please select a publishing company ..........."
            cboPublish.SelectedIndex = -1

        Else

            Me.cboPublish.SelectedValue = gsPublish

        End If

        'Fill Performance Voice combobox
        cmd = New SqlCommand("Select * From MiscLookup", con)

        myDA = New SqlDataAdapter(cmd)

        myDA.Fill(myDataSet, "MyLookup")

        Me.cboVoice.DataSource = myDataSet.Tables("MyLookup").DefaultView
        Me.cboVoice.DisplayMember = "LookupData"
        Me.cboVoice.ValueMember = "LookupId"
        Me.cboVoice.ValueMember = gsVoice

    End Sub

    Private Sub cmdBrowseCover_Click(sender As Object, e As EventArgs) Handles cmdBrowseCover.Click

        Dim MyFileDialog As New OpenFileDialog

        MyFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.GIF|All files (*.*)|*.*"

        If MyFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'msCoverLoc = MyFileDialog.FileName

            pbCover.Image = Image.FromFile(MyFileDialog.FileName)

            gbCoverIsDirty = True

        End If

    End Sub

    Private Sub cmdBrowsePage1_Click(sender As Object, e As EventArgs) Handles cmdBrowsePage1.Click

        Dim MyFileDialog As New OpenFileDialog

        MyFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.GIF|All files (*.*)|*.*"

        If MyFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'msFirstPageLoc = MyFileDialog.FileName

            pbFirstPage.Image = Image.FromFile(MyFileDialog.FileName)

            gbFirstPageIsDirty = True

        End If

    End Sub

   

    Private Sub cmdAddLookup_Click(sender As Object, e As EventArgs) Handles cmdAddLookup.Click

        frmAddLookup.ShowDialog()

        frmAddLookup.Dispose()

    End Sub
End Class