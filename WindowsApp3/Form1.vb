Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.ForeColor = Color.Green
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Label1.Text = 15
            Timer1.Start()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 500

        If Label1.Text = 5 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
        ElseIf Label1.Text = 0 Then
            Timer1.Enabled = False
            Beep()
            Dim resposta = MsgBox("Nao conseguiste atingir todos os alvos a tempo, Tentar Novamente ?", vbYesNo, "Novo Jogo")
            If resposta = vbNo Then Return
            Application.Restart()
        Else
            Label1.Text = Val(Label1.Text) - 1

        End If
    End Sub


    Private Sub verificar()
        If um.Visible = False And dois.Visible = False And tres.Visible = False And quatro.Visible = False And cinco.Visible = False And seis.Visible = False And sete.Visible = False And oito.Visible = False And nove.Visible = False And dez.Visible = False And onze.Visible = False And doze.Visible = False And treze.Visible = False And quatorze.Visible = False And quinze.Visible = False And dezasseis.Visible = False And dezasete.Visible = False And dezoito.Visible = False Then
            Timer1.Stop()
            MsgBox("Parabens, Atingiste todos os alvos a tempo")
            Dim resposta = MsgBox("Parabens quer voltar a jogar ?", vbYesNo, "Novo Jogo")
            If resposta = vbNo Then Return
            Application.Restart()
        End If
    End Sub

    Private Sub Um_Click(sender As Object, e As EventArgs) Handles um.Click
        um.Visible = False
        verificar()
    End Sub

    Private Sub Dois_Click(sender As Object, e As EventArgs) Handles dois.Click
        dois.Visible = False
        verificar()
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles tres.Click
        tres.Visible = False
        verificar()
    End Sub

    Private Sub Quatro_Click(sender As Object, e As EventArgs) Handles quatro.Click
        quatro.Visible = False
        verificar()
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        cinco.Visible = False
        verificar()
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        seis.Visible = False
        verificar()
    End Sub

    Private Sub Sete_Click(sender As Object, e As EventArgs) Handles sete.Click
        sete.Visible = False
        verificar()
    End Sub

    Private Sub Oito_Click(sender As Object, e As EventArgs) Handles oito.Click
        oito.Visible = False
        verificar()
    End Sub

    Private Sub Nove_Click(sender As Object, e As EventArgs) Handles nove.Click
        nove.Visible = False
        verificar()
    End Sub

    Private Sub Dez_Click(sender As Object, e As EventArgs) Handles dez.Click
        dez.Visible = False
        verificar()
    End Sub

    Private Sub Onze_Click(sender As Object, e As EventArgs) Handles onze.Click
        onze.Visible = False
        verificar()
    End Sub

    Private Sub Doze_Click(sender As Object, e As EventArgs) Handles doze.Click
        doze.Visible = False
        verificar()
    End Sub

    Private Sub Treze_Click(sender As Object, e As EventArgs) Handles treze.Click
        treze.Visible = False
        verificar()
    End Sub

    Private Sub Quatorze_Click(sender As Object, e As EventArgs) Handles quatorze.Click
        quatorze.Visible = False
        verificar()
    End Sub

    Private Sub Quinze_Click(sender As Object, e As EventArgs) Handles quinze.Click
        quinze.Visible = False
        verificar()
    End Sub

    Private Sub Dezasseis_Click(sender As Object, e As EventArgs) Handles dezasseis.Click
        dezasseis.Visible = False
        verificar()
    End Sub

    Private Sub Dezasete_Click(sender As Object, e As EventArgs) Handles dezasete.Click
        dezasete.Visible = False
        verificar()
    End Sub

    Private Sub Dezoito_Click(sender As Object, e As EventArgs) Handles dezoito.Click
        dezoito.Visible = False
        verificar()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Beep()
        Dim resposta = MsgBox("Tem a Certeza", vbYesNo, "Novo Jogo")
        If resposta = vbNo Then Return
        Application.Restart()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.Cross
    End Sub
End Class
