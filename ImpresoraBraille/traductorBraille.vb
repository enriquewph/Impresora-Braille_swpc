Public Class TraductorBraille
    Public Function TraducirTexto(InputString As String) As String
        Dim ModoNumeros As Boolean = False
        Dim OutputString As String = ""

        Dim inputArray As Char() = InputString.ToCharArray

        For i As Integer = 0 To inputArray.GetUpperBound(0)
            Dim letra As Char = inputArray(i)
            Dim letra_ant As Char
            Dim letra_sig As Char

            If (i > 0) Then
                letra_ant = inputArray(i - 1)
            Else
                letra_ant = vbNewLine
            End If

            If (i < inputArray.GetUpperBound(0)) Then
                letra_sig = inputArray(i + 1)
            Else
                letra_sig = vbNewLine
            End If


            If Char.IsUpper(letra) Then
                OutputString += "⠨"
            End If

            If Char.IsNumber(letra) Then
                If ModoNumeros = False Then
                    ModoNumeros = True
                    'Se detecto el comienzo de un numero nuevo, incluir indicador numerico
                    OutputString += "⠼"
                End If
            Else
                ModoNumeros = False
            End If

            OutputString += CharToBraille(letra, letra_ant, letra_sig)
        Next

        Return OutputString
    End Function

    Public Function CharToBraille(ch As Char, charAnterior As Char, charSiguiente As Char) As String
        Dim OutputChar As String = ch
        Dim InputChar As String = ch.ToString.ToLower


        '   ⠁	⠃	⠉	⠙	⠑	⠋	⠛	⠓	⠊	⠚	⠈	⠘
        '⠄	⠅	⠇	⠍	⠝	⠕	⠏	⠟	⠗	⠎	⠞	⠌	⠜
        '⠤	⠥	⠧	⠭	⠽	⠵	⠯	⠿	⠷	⠮	⠾	⠬	⠼
        '⠠	⠡	⠣	⠩	⠹	⠱	⠫	⠻	⠳	⠪	⠺	⠨	⠸
        '⠀	⠂	⠆	⠒	⠲	⠢	⠖	⠶	⠦	⠔	⠴	⠐	⠰



        If Char.IsNumber(InputChar) Then
            Select Case InputChar
                Case "0"
                    OutputChar = "⠚"
                Case "1"
                    OutputChar = "⠁"
                Case "2"
                    OutputChar = "⠃"
                Case "3"
                    OutputChar = "⠉"
                Case "4"
                    OutputChar = "⠙"
                Case "5"
                    OutputChar = "⠑"
                Case "6"
                    OutputChar = "⠋"
                Case "7"
                    OutputChar = "⠛"
                Case "8"
                    OutputChar = "⠓"
                Case "9"
                    OutputChar = "⠊"
            End Select

            Return OutputChar
        End If

        Select Case InputChar
            Case " "
                OutputChar = " "
            Case "a"
                OutputChar = "⠁"
            Case "b"
                OutputChar = "⠃"
            Case "c"
                OutputChar = "⠉"
            Case "d"
                OutputChar = "⠙"
            Case "e"
                OutputChar = "⠑"
            Case "f"
                OutputChar = "⠋"
            Case "g"
                OutputChar = "⠛"
            Case "h"
                OutputChar = "⠓"
            Case "i"
                OutputChar = "⠊"
            Case "j"
                OutputChar = "⠚"
            Case "k"
                OutputChar = "⠅"
            Case "l"
                OutputChar = "⠇"
            Case "m"
                OutputChar = "⠍"
            Case "n"
                OutputChar = "⠝"
            Case "ñ"
                OutputChar = "⠻"
            Case "o"
                OutputChar = "⠕"
            Case "p"
                OutputChar = "⠏"
            Case "q"
                OutputChar = "⠟"
            Case "r"
                OutputChar = "⠗"
            Case "s"
                OutputChar = "⠎"
            Case "t"
                OutputChar = "⠞"
            Case "u"
                OutputChar = "⠥"
            Case "v"
                OutputChar = "⠧"
            Case "w"
                OutputChar = "⠺"
            Case "x"
                If (Char.IsNumber(charAnterior) And Char.IsNumber(charSiguiente)) Then
                    OutputChar = "⠦"
                Else
                    OutputChar = "⠭"
                End If
            Case "y"
                OutputChar = "⠽"
            Case "z"
                OutputChar = "⠵"
            Case "á"
                OutputChar = "⠷"
            Case "é"
                OutputChar = "⠮"
            Case "í"
                OutputChar = "⠌"
            Case "ó"
                OutputChar = "⠬"
            Case "ú"
                OutputChar = "⠾"
            Case "ü"
                OutputChar = "⠳"
            Case "."
                If (Char.IsNumber(charAnterior) And Char.IsNumber(charSiguiente)) Then
                    OutputChar = "⠦"
                Else
                    OutputChar = "⠄"
                End If
            Case ","
                OutputChar = "⠂"
            Case ";"
                OutputChar = "⠆"
            Case ":"
                If (Char.IsNumber(charAnterior) And Char.IsNumber(charSiguiente)) Then
                    OutputChar = "⠲"
                Else
                    OutputChar = "⠒"
                End If
            Case "?"
                OutputChar = "⠢"
            Case "¿"
                OutputChar = "⠢"
            Case "!"
                OutputChar = "⠖"
            Case "¡"
                OutputChar = "⠖"
            Case """"
                OutputChar = "⠦"
            Case "““"
                OutputChar = "⠦"
            Case "””"
                OutputChar = "⠦"
            Case "«"
                OutputChar = "⠦"
            Case "»"
                OutputChar = "⠦"
            Case "‘"
                OutputChar = "⠠⠦"
            Case "’"
                OutputChar = "⠠⠦"
            Case "<"
                OutputChar = "⠠⠦"
            Case ">"
                OutputChar = "⠠⠦"
            Case "("
                OutputChar = "⠣"
            Case ")"
                OutputChar = "⠜"
            Case "["
                OutputChar = "⠷"
            Case "]"
                OutputChar = "⠾"
            Case "{"
                OutputChar = "⠐⠇"
            Case "}"
                OutputChar = "⠸⠂"
            Case "-"
                OutputChar = "⠤"
            Case "_"
                OutputChar = "⠤⠤"
            Case "*"
                If (Char.IsNumber(charAnterior) And Char.IsNumber(charSiguiente)) Then
                    OutputChar = "⠦"
                Else
                    OutputChar = "⠔"
                End If
            Case "'"
                If (Char.IsLetter(charAnterior) And Char.IsLetter(charSiguiente)) Then
                    OutputChar = "⠄"
                Else
                    OutputChar = "⠦"
                End If
            Case "/"
                If (charAnterior <> "/") Then
                    If charSiguiente <> "/" Then
                        If (Char.IsNumber(charAnterior) And Char.IsNumber(charSiguiente)) Then
                            OutputChar = "⠲"
                        Else
                            OutputChar = "⠠⠂"
                        End If
                    Else
                        OutputChar = "⠠⠢⠂"
                    End If
                Else
                    OutputChar = ""
                End If
            Case "\"
                If (charAnterior <> "\") Then
                    If charSiguiente <> "\" Then
                        OutputChar = "⠐⠄"
                    Else
                        OutputChar = "⠐⠔⠄"
                    End If
                Else
                    OutputChar = ""
                End If
            Case "|"
                If (charAnterior <> "|") Then
                    If charSiguiente <> "|" Then
                        OutputChar = "⠸ "
                    Else
                        OutputChar = "⠸⠇"
                    End If
                Else
                    OutputChar = ""
                End If
            Case "+"
                OutputChar = "⠖"
            Case "÷"
                OutputChar = "⠲"
            Case "="
                OutputChar = "⠶"
            Case "%"
                OutputChar = "⠸⠴"
            Case "‰"
                OutputChar = "⠸⠴⠴"
            Case "©"
                OutputChar = "⠣⠨⠉⠜"
            Case "℗"
                OutputChar = "⠣⠨⠏⠜"
            Case "®"
                OutputChar = "⠣⠨⠗⠜"
            Case "™"
                OutputChar = "⠣⠨⠞⠨⠍⠜"
            Case "℠"
                OutputChar = "⠣⠨⠎⠨⠍⠜"
            Case "&"
                OutputChar = "⠠⠯"
            Case "@"
                OutputChar = "⠐"
            Case "±"
                OutputChar = "⠖⠒⠤"
            Case "†"
                OutputChar = "⠐⠗"
            Case "#"
                OutputChar = "⠼⠐"
            Case "§"
                OutputChar = "⠬"
            Case "¶"
                OutputChar = "⠩"
            Case "€"
                OutputChar = "⠸⠑"
            Case "$"
                OutputChar = "⠸⠎"
            Case "¢"
                OutputChar = "⠘⠉"
            Case "£"
                OutputChar = "⠐⠮"
            Case "¥"
                OutputChar = "⠸⠽"
            Case Else
                OutputChar = ""
        End Select


        '   ⠁	⠃	⠉	⠙	⠑	⠋	⠛	⠓	⠊	⠚	⠈	⠘
        '⠄	⠅	⠇	⠍	⠝	⠕	⠏	⠟	⠗	⠎	⠞	⠌	⠜
        '⠤	⠥	⠧	⠭	⠽	⠵	⠯	⠿	⠷	⠮	⠾	⠬	⠼
        '⠠	⠡	⠣	⠩	⠹	⠱	⠫	⠻	⠳	⠪	⠺	⠨	⠸
        '⠀	⠂	⠆	⠒	⠲	⠢	⠖	⠶	⠦	⠔	⠴	⠐	⠰

        Return OutputChar
    End Function

    'Invalidaciones, obviarlas.
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
End Class
