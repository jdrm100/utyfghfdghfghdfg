Public Class Filtrar

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        If porRepresRbt.Checked = True Then
            Antiguedad()
        End If

        If porGestorRbt.Checked = True Then
            AntiguedadPorGestor()
        End If

    End Sub


    Public Sub Antiguedad()
        Dim _Buscar As New Ccc_Antiguedad
        Dim _Lista As List(Of Eantiguedadsaldo) = _Buscar.AntiguedaddeSaldo(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

        Dim _Mostrar As New Reporte_de_Antiguedad(_Lista)
        _Mostrar.Show()

    End Sub

    Public Sub AntiguedadPorGestor()
        Dim _Buscar As New Ccc_AntiguedadGestor
        Dim _Lista As List(Of Eantiguedadsaldogestor) = _Buscar.AntiguedaddeSaldoGestor(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

        Dim _Mostrar As New frm_antiguedadgestor(_Lista)
        _Mostrar.Show()

    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles porGestorRbt.CheckedChanged

    End Sub

    Private Sub Filtrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        porRepresRbt.Checked = True
        dtp_FechaInicial.Value = "19/06/2009"
    End Sub
End Class