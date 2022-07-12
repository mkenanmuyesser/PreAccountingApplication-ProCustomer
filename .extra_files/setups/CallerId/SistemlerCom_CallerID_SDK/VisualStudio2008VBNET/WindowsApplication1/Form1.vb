Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxCIDv51.Hide()
        AxCIDv51.Start()



        ' Nesne başlatıldıktan sonra tekrar başlatılmaya çalışılırsa her hangi bir zararı veya faydası olmaz. Fakat anlamı da yoktur.
        ' Cihazın algılanması otomatiktir.
        ' Başka bir program cihazla bağlantı sağlamışsa, 
        ' Bu progrogram cihazla haberleşemez, numarayı gösteremez.
        ' Çalışan diğer program kapatılırsa otomatik bağlantı sağlanır.
        ' Program numarayı göstermeye başlar

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Durum As String
        Durum = AxCIDv51.Command("devicemodel") 'cihaz modelini almaya yarar

        If Durum = "" Then
            Label1.Text = "Bağlantı yok"
        Else
            Label1.Text = "Cihaz Modeli : " + Durum + " Seri no : " + AxCIDv51.Command("serial")
        End If
        
    End Sub

    Private Sub AxCIDv51_OnCallerID(ByVal sender As System.Object, ByVal e As Axcidv5callerid.ICIDv5Events_OnCallerIDEvent) Handles AxCIDv51.OnCallerID
        Label2.Text = e.phoneNumber

        TextBox1.Text = " Hat no: " + e.line + " - Zaman: " + Now + " Arayan: " + e.phoneNumber + Chr(13) + Chr(10) + TextBox1.Text
        'TextBox1.Text = " Hat no: " + e.line + " - Zaman: " + e.dateTime + " Arayan: " + e.phoneNumber + Chr(13) + Chr(10) + TextBox1.Text
        'e.dateTime Telefon santrali tarafından gönderilen zaman bilgisidir. 
        'PC zamanından bağımsızdır. Gerekirse kullanılabilir.
        'Nesne .start  ile başlatılmışsa ve numara algılanmışsa, bu olay tetiklenir.

    End Sub

    Private Sub AxCIDv51_OnSignalA(ByVal sender As System.Object, ByVal e As Axcidv5callerid.ICIDv5Events_OnSignalAEvent) Handles AxCIDv51.OnSignalA
        ProgressBar1.Value = e.level1
        ProgressBar2.Value = e.level2
        ProgressBar3.Value = e.level3
        ProgressBar4.Value = e.level4
        ' Bu göstergeleri kullanmak isteğe bağlıdır. Kablo bağlantısının doğru olup olmadığını anlamaya yarar. Test amaçlıdır. 
        ' Bu olay periyodik olarak tetiklenmektedir.
        ' level4 den sonrakiler anlamlı değildir.
        ' Çünkü  V5 serisi cihazlar 4 hatlı üretilmektedir. 8 hatlı v5 cihaz yoktur.

    End Sub
End Class
