Imports System
Imports System.IO


Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub maganhangzovizsgalatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maganhangzovizsgalatButton.Click
        Dim mgh() As Char = {"a", "e", "i", "o", "u"}
        Dim beirt As String
        Dim beirtkaraktertomb() As Char
        Dim beirtkarakterszam As Integer
        Dim i, j As Integer
        Dim nincs As Boolean

        beirt = maganhangzovizsgalatTextBox.Text
        beirtkaraktertomb = beirt.ToCharArray
        beirtkarakterszam = beirtkaraktertomb.Length

        'Console.Write(beirtkarakterszam)
        'Console.Write(mgh(j))
        'Console.Write(beirtkaraktertomb(0))
        nincs = True
        For j = 0 To 4


            For i = 0 To beirtkarakterszam - 1

                If mgh(j) = beirtkaraktertomb(i) Then
                    maganhangzovalaszTextBox.Text = "Van benne magánhangzó"
                    Console.Write(mgh(j))
                    nincs = False

                End If
            Next

        Next

        If nincs = True Then
            maganhangzovalaszTextBox.Text = "Nincs benne magánhangzó"
        End If




    End Sub

    Private Sub beolvasButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beolvasButton.Click
        Dim FILE_NAME As String = "szoveg.txt"
        Dim TextLine As String
        TextLine = ""
        Dim szavaktomb() As String
        Dim cseresztring As String
        Dim sorszamlalo As Long
        sorszamlalo = 0

        Dim beolvasottsor As String
        beolvasottsor = ""
        Dim beolvasottsor_leghosszabb As String
        beolvasottsor_leghosszabb = ""
        Dim hossz As Integer
        Dim elozohossz As Integer
        Dim legnagyobb_hossz As Integer


        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader1 As New System.IO.StreamReader(FILE_NAME)

            Do While objReader1.Peek() <> -1

                beolvasottsor = objReader1.ReadLine()

                sorszamlalo = sorszamlalo + 1


                'Console.Write(sorszamlalo & vbNewLine)

            Loop

            ReDim szavaktomb(sorszamlalo)


            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            sorszamlalo = 0

            Do While objReader.Peek() <> -1

                elozohossz = hossz

                'beolvasottsor_elozo = beolvasottsor
                beolvasottsor = objReader.ReadLine()
                szavaktomb(sorszamlalo) = beolvasottsor


                hossz = beolvasottsor.Length

                


                TextLine = TextLine & CStr(sorszamlalo) & Chr(32) & CStr(hossz) & vbNewLine & beolvasottsor & vbNewLine
                sorszamlalo = sorszamlalo + 1

            Loop

            'leghosszabbTextBox.Text = beolvasottsor_leghosszabb
            beolvasottTextBox.Text = TextLine

            Console.Write(szavaktomb(0) & vbNewLine)
            Console.Write(szavaktomb(1) & vbNewLine)
            Console.Write(szavaktomb(2) & vbNewLine)
            Console.Write(szavaktomb(3) & vbNewLine)


            'ciklus i=1-től n-1-ig
            '   ciklus j=i+1-tıl n-ig
            '       ha x(i)>x(j) akkor
            '           csere: x(i), x(j)
            '       elágazás(vége)
            '   ciklus(vége)
            'ciklus(vége)

            For i = 1 To sorszamlalo - 2
                For j = i + 1 To sorszamlalo - 1
                    If szavaktomb(i).Length > szavaktomb(j).Length Then
                        cseresztring = szavaktomb(i)
                        szavaktomb(i) = szavaktomb(j)
                        szavaktomb(j) = cseresztring

                    End If
                Next
            Next

            Console.Write(szavaktomb(sorszamlalo - 4) & vbNewLine)
            Console.Write(szavaktomb(sorszamlalo - 3) & vbNewLine)
            Console.Write(szavaktomb(sorszamlalo - 2) & vbNewLine)
            Console.Write(szavaktomb(sorszamlalo - 1) & vbNewLine)


            leghosszabbTextBox.Text = szavaktomb(sorszamlalo - 1)
            katakterekszamaTextBox.Text = CStr(szavaktomb(sorszamlalo - 1).Length)


            

        End If






    End Sub

    
    
    Private Sub tesztTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
