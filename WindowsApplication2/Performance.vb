Public Class Performance

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub
End Class