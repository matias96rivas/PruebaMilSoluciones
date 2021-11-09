Public Class SearchEir
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim eir As String
        eir = txtSearchEir.Text

        If eir = "" Then
            MessageBox.Show("Debe ingresar el código de eir que desea buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Module1.eirCode = txtSearchEir.Text

            EirInfo.Show()
            Me.Hide()

        End If

    End Sub
End Class
