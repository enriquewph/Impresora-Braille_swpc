Class TrabajoActual_c
    Private _hojas As Integer

    Public Sub New()
        _hojas = 1
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