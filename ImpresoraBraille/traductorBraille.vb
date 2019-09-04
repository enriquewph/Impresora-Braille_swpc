Public Class TraductorBraille


    Public Function TraducirTexto(InputString As String) As String
        Dim OutputString As String = ""

        For Each letra As Char In InputString
            If Char.IsUpper(letra) Then
                OutputString += "⠨"
            End If
            OutputString += LetraABraille(letra)
        Next

        Return OutputString
    End Function

    Public Function LetraABraille(InputChar As Char) As Char
        Dim OutputChar As Char = ""
        Select Case InputChar.ToString.ToLower
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
                OutputChar = "⠭"
            Case "y"
                OutputChar = "⠽"
            Case "z"
                OutputChar = "⠵"

            Case " "
                OutputChar = " "
        End Select
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
