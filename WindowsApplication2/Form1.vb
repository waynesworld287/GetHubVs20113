Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Form1
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadGridData()

    End Sub

    Private Sub LoadGridData()

        Dim sSql As String

        sSql = "select 'Music Detail' as 'Select Detail', mi.MusicId,  mi.MusicTitle, comp.Composer, ph.PerformanceDate" _
            & " from MusicInventory as mi" _
            & " inner join Composer as comp on mi.Composer = comp.ComposerId" _
            & " left outer join PerformanceHistory as ph on mi.MusicId = ph.MusicId" _
            & " order by mi.MusicTitle"

        Dim con As SqlConnection = New SqlConnection("Data Source=myOLDGATEWAY\waynesdb;Initial Catalog=MusicData;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand(sSql, con)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        con.Open()

        Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim myDataSet As DataSet = New DataSet()
        myDA.Fill(myDataSet, "MyTable")


        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView

        DataGridView1.Columns(1).Visible = False

        con.Close()
        con = Nothing

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex > -1 Then     'The title row has a row index of -1 and will throw an error

            Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value 'The MusicId is in the second field hence .Cell(1)

            If e.ColumnIndex = 0 Then  'View Detail

                Dim sMusicIndex As String = value.ToString

                Dim sSql As String

                sSql = "select mi.MusicTitle, mi.composer, mi.PublishingCompany, mi.Price, mi.NumberOfCopies, mi.VoiceType, mi.AdditionalNote, mi.CoverPhoto, mi.PageOnePhoto" _
                    & " from MusicInventory mi" _
                    & " where mi.MusicId = " & sMusicIndex

                Dim con As SqlConnection = New SqlConnection("Data Source=myOLDGATEWAY\waynesdb;Initial Catalog=MusicData;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand(sSql, con)

                con.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader

                Dim frm As New frmMusicInv

                Do While reader.HasRows

                    Do While reader.Read

                        With frm

                            .lblMusicId.Text = sMusicIndex
                            .txtTitle.Text = reader.GetString(0)

                            'SelectedValue items for comboboxes are loaded to public variables to be loaded in the form load event.
                            .gsComposer = reader.GetValue(1).ToString
                            .gsPublish = reader.GetValue(2).ToString

                            If Not reader.IsDBNull(3) Then

                                .txtPrice.Text = FormatCurrency(reader.GetValue(3).ToString)

                            End If

                            If Not reader.IsDBNull(4) Then

                                .txtCopy.Text = reader.GetValue(4).ToString

                            End If


                            .gsVoice = reader.GetValue(5).ToString

                            If Not reader.IsDBNull(6) Then

                                .txtNote.Text = reader.GetString(6)

                            End If

                            If Not reader.IsDBNull(7) Then

                                Dim ms As New MemoryStream(CType(reader.GetValue(7), Byte()))

                                .pbCover.Image = Image.FromStream(ms)

                            End If

                            If Not reader.IsDBNull(8) Then

                                Dim ms1 As New MemoryStream(CType(reader.GetValue(8), Byte()))

                                .pbFirstPage.Image = Image.FromStream(ms1)

                            End If

                        End With

                        'MsgBox(reader.GetString(0) & " and " & reader.GetString(1))

                        reader.NextResult()

                    Loop

                Loop

                reader.Close()

                frm.ShowDialog()

                If frm.DialogResult = Windows.Forms.DialogResult.OK Then    'Save the info on form


                    cmd = New SqlCommand("Update MusicInventory SET MusicTitle = '" & frm.txtTitle.Text & "', Composer = " & frm.cboComposer.SelectedValue & ", " _
                        & "PublishingCompany = " & frm.cboPublish.SelectedValue & ", Price = " & frm.txtPrice.Text & ", NumberOfCopies = " & frm.txtCopy.Text & ", " _
                        & "VoiceType = " & frm.cboVoice.SelectedValue & ", AdditionalNote = '" & frm.txtNote.Text & "' Where MusicId = " & sMusicIndex, con)

                    cmd.ExecuteNonQuery()

                    Dim iReturn As Integer

                    If frm.gbCoverIsDirty Then

                        iReturn = UpdateImage(frm.pbCover.Image, sMusicIndex, "CoverPhoto", con)

                        'Dim img As Byte()

                        'img = ConvertImage(frm.pbCover.Image)

                        'cmd = New SqlCommand("Update MusicInventory SET CoverPhoto = @Cover Where MusicId = " & sMusicIndex, con)

                        'cmd.Parameters.Add(New SqlParameter("@Cover", SqlDbType.Image)).Value = img

                        'cmd.ExecuteNonQuery()

                    End If

                    If frm.gbFirstPageIsDirty Then

                        iReturn = UpdateImage(frm.pbFirstPage.Image, sMusicIndex, "PageOnePhoto", con)

                    End If

                End If

                con.Close()
                con = Nothing

                frm.Dispose()   'Gets rid of frm

            End If



        End If

    End Sub

    Public Function ConvertImage(ByVal myImage As Image) As Byte()

        Dim mstream As New MemoryStream
        myImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim myBytes(mstream.Length - 1) As Byte
        mstream.Position = 0

        mstream.Read(myBytes, 0, mstream.Length)

        Return myBytes

    End Function

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click

        Dim frm As New frmMusicInv

        frm.gsComposer = "New"
        frm.gsPublish = "New"
        frm.gsVoice = "1"   'Choose SATB by default

        frm.txtPrice.Text = FormatCurrency(".5")
        frm.txtCopy.Text = "20"

        frm.cboComposer.SelectedItem = ""

        frm.ShowDialog()

        If frm.DialogResult = Windows.Forms.DialogResult.OK Then    'Save the new data

            Dim iReturn As Integer

            Dim sSql As String = "INSERT INTO MusicInventory (MusicTitle, Composer, PublishingCompany, Price, NumberOfCopies, VoiceType, AdditionalNote) " _
                & "VALUES ('" & frm.txtTitle.Text & "', " & frm.cboComposer.SelectedValue & ", " & frm.cboPublish.SelectedValue & ", " & frm.txtPrice.Text & ", " _
                & frm.txtCopy.Text & ", " & frm.cboVoice.SelectedValue & ", '" & frm.txtNote.Text & "')"

            Dim con As SqlConnection = New SqlConnection("Data Source=myOLDGATEWAY\waynesdb;Initial Catalog=MusicData;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand(sSql, con)

            con.Open()

            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("SELECT MAX(MusicId) FROM MusicInventory", con)    'The largest MusicId should be the one just created.

            Dim reader As SqlDataReader = cmd.ExecuteReader

            reader.Read()

            Dim sMusicId As String = reader.GetInt32(0).ToString

            reader.Close()

            If frm.gbCoverIsDirty Then

                iReturn = UpdateImage(frm.pbCover.Image, sMusicId, "CoverPhoto", con)

            End If

            If frm.gbFirstPageIsDirty Then

                iReturn = UpdateImage(frm.pbFirstPage.Image, sMusicId, "PageOnePhoto", con)

            End If

        End If

        frm.Dispose()

    End Sub

    Private Function UpdateImage(imgUpdate As Image, sUpdateId As String, sUpdateField As String, Conn As SqlConnection) As Integer
        'This takes the parameters and inserts images into MusicInventory.  Conn is passed as an open sql connection.
        'Returns 1 now, but could be improved if errors occur.

        Dim img As Byte()

        img = ConvertImage(imgUpdate)

        Dim cmd As SqlCommand = New SqlCommand("Update MusicInventory SET " & sUpdateField & " = @UpdateImage Where MusicId = " & sUpdateId, Conn)

        cmd.Parameters.Add(New SqlParameter("@UpdateImage", SqlDbType.Image)).Value = img

        cmd.ExecuteNonQuery()

        Return 1

    End Function

    
    Private Sub cmdAddPerform_Click(sender As Object, e As EventArgs) Handles cmdAddPerform.Click

        If DataGridView1.CurrentRow.Index > -1 Then     'The title row has a row index of -1 and will throw an error

            Dim value As Object = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value 'The MusicId is in the second field hence .Cell(1)

            Dim sMusicIndex As String = value.ToString

            Dim frm As New Performance

            frm.lblMusicId.Text = sMusicIndex

            frm.txtTitle.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString  'Music Title

            Dim dtToday As System.DateTime = System.DateTime.Now

            frm.txtDate.Text = dtToday.AddDays(-CInt(Date.Today.DayOfWeek)).ToShortDateString

            frm.lblDateLast.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value.toshortdatestring  'Last Performance

            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then        'save the data

                Dim sSql As String = "INSERT INTO PerformanceHistory (PerformanceDate, MusicId, PerformanceNote) " _
                    & "VALUES ('" & frm.txtDate.Text & "', " & frm.lblMusicId.Text & ", '" & frm.txtNote.Text & "')"

                Dim con As SqlConnection = New SqlConnection("Data Source=myOLDGATEWAY\waynesdb;Initial Catalog=MusicData;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand(sSql, con)

                con.Open()

                cmd.ExecuteNonQuery()

                Call LoadGridData()

            End If

            frm.Dispose()

        End If

    End Sub
End Class
