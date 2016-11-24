Public Class Form1
    Dim coma As Boolean
    Dim cDecimal As Integer
    Dim Dollars As Double
    Dim Yens As Double
    Dim LliuresEsterlines As Double
    Dim Dragmes As Double
    Dim bDollars As Boolean = False
    Dim bYens As Boolean = False
    Dim bLliuresEsterlines As Boolean = False
    Dim bDragmes As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button4.Click, Button3.Click, Button2.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button10.Click
        If Label1.Text.Equals("0") Then
            Label1.Text = ""
        End If

        If (coma = True And cDecimal < 2) Then
            cDecimal = cDecimal + 1
            Label1.Text = Label1.Text + CType(sender, Button).Text
        End If
        If (Label1.Text.Length < 14 And coma = False) Then
            Label1.Text = Label1.Text + CType(sender, Button).Text
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub



    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (coma = False) Then
            Label1.Text = Label1.Text + CType(sender, Button).Text
            coma = True
        Else
            MsgBox("No puedes introducir otra coma")

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (Label1.Text > 1) Then
            If Label1.Text.Substring(Label1.Text.Length - 1, 1).Equals(",") Then
                coma = False
            End If
            If (coma = True) Then
                cDecimal = cDecimal - 1
            End If
            Label1.Text = Label1.Text.Substring(0, Label1.Text.Length - 1)
        Else

            Label1.Text = "0"
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If coma = True Then
            cDecimal = 0
        End If
        coma = False
        Label1.Text = "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim respuesta As String
        If (ComboBox1.SelectedIndex = 0) Then
            If bDollars = False Then
                respuesta = InputBox("Introduce el valor del dollar", "Imprimir")
                If respuesta <> "" Then
                    Dollars = CDbl(respuesta)
                    bDollars = True
                Else
                    MsgBox("No has introducido ningun valor", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            Label1.Text = Math.Round(CDbl(Label1.Text) * Dollars, 2)
        Else
            If (ComboBox1.SelectedIndex = 1) Then
                If bYens = False Then
                    respuesta = InputBox("Introduce el valor del los Yens", "Imprimir")
                    If respuesta <> "" Then
                        Yens = CDbl(respuesta)
                        bYens = True
                    Else
                        MsgBox("No has introducido ningun valor", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
                Label1.Text = Math.Round(CDbl(Label1.Text) * Yens, 2)
            Else
                If (ComboBox1.SelectedIndex = 2) Then
                    If bLliuresEsterlines = False Then
                        respuesta = InputBox("Introduce el valor del los Lliures Esterlines", "Imprimir")
                        If respuesta <> "" Then
                            LliuresEsterlines = CDbl(respuesta)
                            bLliuresEsterlines = True
                        Else
                            MsgBox("No has introducido ningun valor", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                    Label1.Text = Math.Round(CDbl(Label1.Text) * LliuresEsterlines, 2)
                Else
                    If (ComboBox1.SelectedIndex = 3) Then
                        If bYens = False Then
                            respuesta = InputBox("Introduce el valor del los Dragmes", "Imprimir")
                            If respuesta <> "" Then
                                Dragmes = CDbl(respuesta)
                                bDragmes = True
                            Else
                                MsgBox("No has introducido ningun valor", MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        End If
                        Label1.Text = Math.Round(CDbl(Label1.Text) * Dragmes, 2)
                    End If
                End If

            End If

        End If

    End Sub
End Class
