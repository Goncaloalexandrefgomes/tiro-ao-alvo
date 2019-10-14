Public Class Form1
    Private stopwatch As New Stopwatch
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Stopwatch.Elapsed
        Label1.Text = String.Format("{0: 00}:{1:00}:{2:00}:{3:00}",
                                    Math.Floor(elapsed.TotalHours),
                                    elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            Timer1.Start()
            stopwatch.Start()
            Button1.Text = "Stop"
            Button3.Enabled = False
        Else
            Timer1.Stop()
            stopwatch.Stop()
            Button1.Text = "Start"
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add(ListBox1.Items.Count + 1 & ". " & Label1.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stopwatch.Reset()
        Label1.Text = "00:00:00:00"
    End Sub

    Private Sub Um_Click(sender As Object, e As EventArgs) Handles um.Click
        um.Visible = False
    End Sub

    Private Sub Dois_Click(sender As Object, e As EventArgs) Handles dois.Click
        dois.Visible = False
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles tres.Click
        tres.Visible = False
    End Sub

    Private Sub Quatro_Click(sender As Object, e As EventArgs) Handles quatro.Click
        quatro.Visible = False
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        cinco.Visible = False
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        seis.Visible = False
    End Sub

    Private Sub Sete_Click(sender As Object, e As EventArgs) Handles sete.Click
        sete.Visible = False
    End Sub

    Private Sub Oito_Click(sender As Object, e As EventArgs) Handles oito.Click
        oito.Visible = False
    End Sub

    Private Sub Nove_Click(sender As Object, e As EventArgs) Handles nove.Click
        nove.Visible = False
    End Sub

    Private Sub Dez_Click(sender As Object, e As EventArgs) Handles dez.Click
        dez.Visible = False
    End Sub

    Private Sub Onze_Click(sender As Object, e As EventArgs) Handles onze.Click
        onze.Visible = False
    End Sub

    Private Sub Doze_Click(sender As Object, e As EventArgs) Handles doze.Click
        doze.Visible = False
    End Sub

    Private Sub Treze_Click(sender As Object, e As EventArgs) Handles treze.Click
        treze.Visible = False
    End Sub

    Private Sub Quatorze_Click(sender As Object, e As EventArgs) Handles quatorze.Click
        quatorze.Visible = False
    End Sub

    Private Sub Quinze_Click(sender As Object, e As EventArgs) Handles quinze.Click
        quinze.Visible = False
    End Sub

    Private Sub Dezasseis_Click(sender As Object, e As EventArgs) Handles dezasseis.Click
        dezasseis.Visible = False
    End Sub

    Private Sub Dezasete_Click(sender As Object, e As EventArgs) Handles dezasete.Click
        dezasete.Visible = False
    End Sub

    Private Sub Dezoito_Click(sender As Object, e As EventArgs) Handles dezoito.Click
        dezoito.Visible = False
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Beep()
        Dim resposta = MsgBox("Tem a Certeza", vbYesNo, "Novo Jogo")
        If resposta = vbNo Then Return
        inicializa()
    End Sub
End Class
