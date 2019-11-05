Imports System.Drawing.Printing
Public Class Preview_c
    Public PreviewDocument As PrintDocument
    Private SenderObj As ImpresoraBraille
    Private NumeroDeHoja As Integer = 1

    ' Se debe llamar de nuevo cada vez que se cambie el texto y se desee imprimir...
    Public Sub New(ByVal sender As ImpresoraBraille)
        SenderObj = sender

        Dim PrintController_vistaPrevia As New StandardPrintController

        Dim PaperSize_Braille As New PaperSize("A4", 827, 1169) With {
            .PaperName = PaperKind.A4,
            .RawKind = PaperKind.A4
        }

        Dim PageSettings_Braille As New PageSettings() With {
            .Color = False,
            .Landscape = False,
            .Margins = New Margins(0, 0, 0, 0),
            .PaperSize = PaperSize_Braille
        }

        PreviewDocument = New PrintDocument With {
            .DocumentName = "Traduccion Braille",
            .PrintController = PrintController_vistaPrevia,
            .DefaultPageSettings = PageSettings_Braille
        }

        AddHandler PreviewDocument.PrintPage, AddressOf PrintPage
        NumeroDeHoja = 1
    End Sub

    Public Sub Guardar()
        PreviewDocument.Print()
    End Sub

    Private Sub PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        DibujarHoja(SenderObj.ListaHojas(NumeroDeHoja - 1), e)

        If NumeroDeHoja < SenderObj.ListaHojas.Count Then
            e.HasMorePages = True
            NumeroDeHoja = NumeroDeHoja + 1
        Else
            e.HasMorePages = False
        End If

    End Sub

    Private Sub DibujarHoja(hoja As Hoja_c, ByRef e As PrintPageEventArgs)
        e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Dim margenIzquierdo As Single = 25
        Dim margenSuperior As Single = 25
        Dim dotSize As New SizeF(1.2, 1.2)
        Dim separacion_entre_puntos As Single = 2.5
        Dim separacion_entre_caracteres_x As Single = 3.5
        Dim separacion_entre_renglones_y As Single = 5.0

        Dim cuentaCaracteres As Integer = 1
        Dim cuentaRenglones As Integer = 1

        Dim cor_x As Single = 0
        Dim cor_y As Single = 0


        For y As Integer = hoja.BitMatrix.GetLowerBound(1) To hoja.BitMatrix.GetUpperBound(1)
            cuentaCaracteres = 1
            For x As Integer = hoja.BitMatrix.GetLowerBound(0) To hoja.BitMatrix.GetUpperBound(0)
                If (hoja.BitMatrix(x, y)) Then
                    e.Graphics.FillEllipse(Brushes.Black, margenIzquierdo + cor_x, margenSuperior + cor_y, dotSize.Width, dotSize.Height)
                End If

                If (cuentaCaracteres = 2) Then
                    cor_x = cor_x + separacion_entre_caracteres_x
                    cuentaCaracteres = 0
                Else
                    cor_x = cor_x + separacion_entre_puntos
                End If
                cuentaCaracteres = cuentaCaracteres + 1
            Next
            cor_x = 0
            If (cuentaRenglones = 3) Then
                cor_y = cor_y + separacion_entre_renglones_y
                cuentaRenglones = 0
            Else
                cor_y = cor_y + separacion_entre_puntos
            End If
            cuentaRenglones = cuentaRenglones + 1
        Next

    End Sub
End Class