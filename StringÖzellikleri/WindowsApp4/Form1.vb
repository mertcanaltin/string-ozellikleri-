Public Class Form1
    Private Sub diziyazButton1_Click(sender As Object, e As EventArgs) Handles diziyazButton1.Click
        Dim iller As String() = {"muğla", "aydın", "denizli", "izmir"}
        Dim metinhalinde As String
        '  metinhalinde = String.Join("-", iller) ' tüm dizi elemalarının arasına tire (-) koyarak tek bir metin haline getirir 
        metinhalinde = String.Join(",", iller, 0, 2) 'muğla ve aydın ı alır 
        metin2TextBox2.Text = metinhalinde
    End Sub

    Private Sub metinaraButton1_Click(sender As Object, e As EventArgs) Handles metinaraButton1.Click
        Dim metin, aranan As String
        Dim bulunanyer As Integer
        metin = metin1TextBox.Text
        aranan = metin2TextBox2.Text
        bulunanyer = metin.IndexOf(aranan)
        'bulunanyer = metin.IndexOf(aranan,5,3)
        If bulunanyer > -1 Then
            MsgBox(String.Format("aradığınız {0} metni {1}. karakter konumunda.", aranan, bulunanyer + 1))
        Else
            MsgBox(String.Concat(aranan, " metni ", metin, "metni içerinde bulunamadı."))
        End If


    End Sub

    Private Sub sondanaraButton1_Click(sender As Object, e As EventArgs) Handles sondanaraButton1.Click
        Dim metin, aranan As String
        Dim bulunanyer As Integer
        metin = metin1TextBox.Text
        aranan = metin2TextBox2.Text
        bulunanyer = metin.LastIndexOf(aranan)
        If bulunanyer > -1 Then
            MsgBox(String.Format("aradığınız {0} metni {1}. karakter konumunda.", aranan, bulunanyer + 1))
        Else
            MsgBox(String.Concat(aranan, " metni ", metin, "metni içerinde bulunamadı."))
        End If
    End Sub

    Private Sub metinekleButton1_Click(sender As Object, e As EventArgs) Handles metinekleButton1.Click
        Dim metin1, metin2, sonuc As String
        metin1 = metin1TextBox.Text
        metin2 = metin2TextBox2.Text
        sonuc = metin1.Insert(4, metin2)
        MsgBox(sonuc)
    End Sub

    Private Sub metinuzunluguButton1_Click(sender As Object, e As EventArgs) Handles metinuzunluguButton1.Click
        Dim metin As String
        If metin1TextBox.Text.Length > 0 Then
            metin = metin1TextBox.Text
            '  metin2TextBox2.Text = metin.Length 
            metin2TextBox2.Text = Len(metin) ' buda aynısını verir metinin uzunluğunu 
        End If
    End Sub

    Private Sub metnitamamlaButton1_Click(sender As Object, e As EventArgs) Handles metnitamamlaButton1.Click
        Dim sayi As Integer
        If IsNumeric(metin1TextBox.Text) Then
            sayi = metin1TextBox.Text
            metin2TextBox2.Text = sayi.ToString.PadLeft(3, "0") 'sola karekter tamamlar 
            metin2TextBox2.Text = CStr(sayi).PadRight(3, "#")  'sağa karakter tamamlar
        End If

    End Sub

    Private Sub parcasilButton1_Click(sender As Object, e As EventArgs) Handles parcasilButton1.Click

        If metin1TextBox.Text.Length > 5 Then
            '   metin2TextBox2.Text = metin1TextBox.Text.Remove(3) ' 3. index numarasından sonrasını siler 
            metin2TextBox2.Text = metin1TextBox.Text.Remove(3, 2) ' 3. index numarasından başlar 2 karekteri siler
        End If
    End Sub

    Private Sub metindegistirButton1_Click(sender As Object, e As EventArgs) Handles metindegistirButton1.Click
        Dim metin As String = metin1TextBox.Text
        Dim sonuc As String
        sonuc = metin.Replace("ğ", "g")
        metin2TextBox2.Text = sonuc
    End Sub
End Class
