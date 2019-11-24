Class TrabajoActual_c
    Private _hojas As Integer
    Public listaHojas As List(Of Hoja_c)
    Public hojaActual As Integer
    Public nuevaHoja As Boolean
    Public hojas_procesadas As Boolean
    Public LineasTotales As Integer
    Public LineaActual As Integer

    Public Sub New()
        _hojas = 1
        hojas_procesadas = False
    End Sub

    Public Property Hojas As Integer
        Get
            Return _hojas
        End Get
        Set(value As Integer)
            _hojas = value
        End Set
    End Property
End Class