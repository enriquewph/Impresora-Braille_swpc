Public Class Hoja_c
    Private _texto As String
    Private _bitMatrix(55, 71) As Boolean
    Private _numero As UShort

    Public Sub New(Texto As String, Numero As UShort)
        _texto = Texto
        _numero = Numero
    End Sub

    Public Property Texto As String
        Get
            Return _texto
        End Get
        Set(value As String)
            _texto = value
        End Set
    End Property

    Public Property BitMatrix As Boolean(,)
        Get
            Return _bitMatrix
        End Get
        Set(value As Boolean(,))
            _bitMatrix = value
        End Set
    End Property

    Public Property Numero As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            _numero = value
        End Set
    End Property
End Class

Public Class Hoja_Funciones_c
    Public Sub TransponerTextoABitArray(ByRef Hoja As Hoja_c)

    End Sub

    Public Sub TransponerTextoABitArray_DEPRECATED(ByRef Hoja As Hoja_c)
        '   ⠁	⠃	⠉	⠙	⠑	⠋	⠛	⠓	⠊	⠚	⠈	⠘
        '⠄	⠅	⠇	⠍	⠝	⠕	⠏	⠟	⠗	⠎	⠞	⠌	⠜
        '⠤	⠥	⠧	⠭	⠽	⠵	⠯	⠿	⠷	⠮	⠾	⠬	⠼
        '⠠	⠡	⠣	⠩	⠹	⠱	⠫	⠻	⠳	⠪	⠺	⠨	⠸
        '⠀	⠂	⠆	⠒	⠲	⠢	⠖	⠶	⠦	⠔	⠴	⠐	⠰
        Dim Cord_X As Integer = 0
        Dim Cord_Y As Integer = 0

        For Each bit As Boolean In Hoja.BitMatrix
            bit = 0
        Next



        For char_index As Integer = 0 To Hoja.Texto.Length() - 1
            MarcarPuntos(Hoja.Texto.Chars(char_index), Cord_X, Cord_Y, Hoja)

            Cord_X = Cord_X + 2

            If (Cord_X > 52) Then
                Cord_X = 0
                Cord_Y = Cord_Y + 3
            End If
        Next
    End Sub

    Public Sub MarcarPuntos(inputChar As Char, x As Integer, y As Integer, ByRef Hoja As Hoja_c)
        Dim Dot_TL As Boolean = 0 ' SUPERIOR IZQUIERDO
        Dim Dot_TR As Boolean = 0 ' SUPERIOR DERECHO
        Dim Dot_ML As Boolean = 0 ' MEDIO IZQUIERDA
        Dim Dot_MR As Boolean = 0 ' MEDIO DERECHA
        Dim Dot_BL As Boolean = 0 ' BASE IZQUIERDO
        Dim Dot_BR As Boolean = 0 ' BASE DERECHO

        '   ⠁	⠃	⠉	⠙	⠑	⠋	⠛	⠓	⠊	⠚	⠈	⠘
        '⠄	⠅	⠇	⠍	⠝	⠕	⠏	⠟	⠗	⠎	⠞	⠌	⠜
        '⠤	⠥	⠧	⠭	⠽	⠵	⠯	⠿	⠷	⠮	⠾	⠬	⠼
        '⠠	⠡	⠣	⠩	⠹	⠱	⠫	⠻	⠳	⠪	⠺	⠨	⠸
        '⠀	⠂	⠆	⠒	⠲	⠢	⠖	⠶	⠦	⠔	⠴	⠐	⠰

        Select Case inputChar
            Case "⠀"

            Case "⠁"
                Dot_TL = 1
            Case "⠃"
                Dot_TL = 1
                Dot_ML = 1
            Case "⠉"
                Dot_TL = 1
                Dot_TR = 1
            Case "⠙"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
            Case "⠑"
                Dot_TL = 1
                Dot_MR = 1
            Case "⠋"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
            Case "⠛"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
            Case "⠓"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
            Case "⠊"
                Dot_TR = 1
                Dot_ML = 1
            Case "⠚"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
            Case "⠈"
                Dot_TR = 1
            Case "⠘"
                Dot_TR = 1
                Dot_MR = 1
            Case "⠄"
                Dot_BL = 1
            Case "⠅"
                Dot_TL = 1
                Dot_BL = 1
            Case "⠇"
                Dot_TL = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠍"
                Dot_TL = 1
                Dot_TR = 1
                Dot_BL = 1
            Case "⠝"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠕"
                Dot_TL = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠏"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠟"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠗"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠎"
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠞"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
            Case "⠌"
                Dot_TR = 1
                Dot_BL = 1
            Case "⠜"
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠤"
                Dot_BL = 1
                Dot_BR = 1
            Case "⠥"
                Dot_BL = 1
                Dot_BR = 1
                Dot_TL = 1
            Case "⠧"
                Dot_TL = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠭"
                Dot_TL = 1
                Dot_TR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠽"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠵"
                Dot_TL = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠯"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠿"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠷"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠮"
                Dot_TR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠾"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠬"
                Dot_TR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠼"
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠠"
                Dot_BR = 1
            Case "⠡"
                Dot_TL = 1
                Dot_BR = 1
            Case "⠣"
                Dot_TL = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠩"
                Dot_TL = 1
                Dot_TR = 1
                Dot_BR = 1
            Case "⠹"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_BR = 1
            Case "⠱"
                Dot_TL = 1
                Dot_MR = 1
                Dot_BR = 1
            Case "⠫"
                Dot_TL = 1
                Dot_TR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠻"
                Dot_TL = 1
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠳"
                Dot_TL = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠪"
                Dot_TR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠺"
                Dot_TR = 1
                Dot_MR = 1
                Dot_ML = 1
                Dot_BR = 1
            Case "⠨"
                Dot_TR = 1
                Dot_BR = 1
            Case "⠸"
                Dot_TR = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠂"
                Dot_ML = 1
            Case "⠆"
                Dot_ML = 1
                Dot_BL = 1
            Case "⠒"
                Dot_ML = 1
                Dot_MR = 1
            Case "⠲"
                Dot_ML = 1
                Dot_MR = 1
                Dot_BR = 1
            Case "⠢"
                Dot_ML = 1
                Dot_BR = 1
            Case "⠖"
                Dot_ML = 1
                Dot_MR = 1
                Dot_BL = 1
            Case "⠶"
                Dot_ML = 1
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠦"
                Dot_ML = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠔"
                Dot_MR = 1
                Dot_BL = 1
            Case "⠴"
                Dot_MR = 1
                Dot_BL = 1
                Dot_BR = 1
            Case "⠐"
                Dot_MR = 1
            Case "⠰"
                Dot_MR = 1
                Dot_BR = 1
        End Select

        Hoja.BitMatrix(x, y) = Dot_TL
        Hoja.BitMatrix(x, y + 1) = Dot_ML
        Hoja.BitMatrix(x, y + 2) = Dot_BL

        Hoja.BitMatrix(x + 1, y) = Dot_TR
        Hoja.BitMatrix(x + 1, y + 1) = Dot_MR
        Hoja.BitMatrix(x + 1, y + 2) = Dot_BR

    End Sub
End Class