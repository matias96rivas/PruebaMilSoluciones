Imports System.Data.SqlClient

Public Class EirInfo

    Private Sub EirInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using cn As New SqlConnection("Server=LAPTOP-NGF8T436; Database=360Movil; Integrated Security= True;")
            cn.Open()

            Dim cmd As New SqlCommand("sp_view_info_eir", cn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@eir_code", Convert.ToInt32(Module1.eirCode))

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                txtEir.Text = Convert.ToString(dr("eir"))
                txtContenedor.Text = Convert.ToString(dr("contenedor"))
                txtSello.Text = Convert.ToString(dr("sello"))
                txtResponsable.Text = Convert.ToString(dr("responsable_nombre"))
                txtEmpresa.Text = Convert.ToString(dr("empresa_nombre"))
            Else
                MessageBox.Show("No se encuentran registros en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Application.Restart()
            End If
        End Using

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Application.Restart()

    End Sub
End Class