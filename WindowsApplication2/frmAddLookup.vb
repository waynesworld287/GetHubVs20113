Imports System.Data
Imports System.Data.SqlClient

Public Class frmAddLookup

    Private Sub frmAddLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As SqlConnection = New SqlConnection("Data Source=myOLDGATEWAY\waynesdb;Initial Catalog=MusicData;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Composer ORDER BY Composer", con)

        con.Open()

        Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim myDataSet As DataSet = New DataSet()

        'TODO: This line of code loads data into the 'MusicDataDataSet.MiscLookup' table. You can move, or remove it, as needed.
        Me.MiscLookupTableAdapter.Fill(Me.MusicDataDataSet.MiscLookup)
        'TODO: This line of code loads data into the 'MusicDataDataSet.PublishingCompany' table. You can move, or remove it, as needed.
        Me.PublishingCompanyTableAdapter.Fill(Me.MusicDataDataSet.PublishingCompany)
        'TODO: This line of code loads data into the 'MusicDataDataSet.Composer' table. You can move, or remove it, as needed.
        Me.ComposerTableAdapter.Fill(Me.MusicDataDataSet.Composer)

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub cmdComposer_Click(sender As Object, e As EventArgs) Handles cmdComposer.Click

        Me.ComposerTableAdapter.Update(Me.MusicDataDataSet.Composer)

        Me.PublishingCompanyTableAdapter.Update(Me.MusicDataDataSet.PublishingCompany)

        MiscLookupTableAdapter.Update(Me.MusicDataDataSet.MiscLookup)

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    
End Class