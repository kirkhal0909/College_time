Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case 50 '2
                B1.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B1
            Case 49 '1
                B2.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B2
            Case 81 'Q
                B3.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B3
            Case 65 'A
                B4.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B4
            Case 90 'Z
                B5.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B5
            Case 88 'X
                B6.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B6
            Case 68 'D
                B7.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B7
            Case 67 'C
                B8.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B8
            Case 70 'F
                B9.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B9
            Case 86 'V
                B10.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B10
            Case 71 'G
                B11.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B11
            Case 66 'B
                B12.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B12
            Case 78 'N
                B13.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B13
            Case 74 'J
                B14.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B14
            Case 77 'M
                B15.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B15
            Case 75 'K
                B16.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B16
            Case 188 ',
                B17.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B17
            Case 190 '.
                B18.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B18
            Case 186 ';
                B19.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B19
            Case 191 '/
                B20.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B20
            Case 222 ''
                B21.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B21
            Case 97 '1
                B22.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B22
            Case 101 '5
                B23.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B23
            Case 99 '3
                B24.Invoke(New EventHandler(AddressOf B3_Click))
                ActiveControl = B24
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        TB1.Text = CStr(0)
        TB2.Text = CStr(1050)
        B1.Text = "2"
        B2.Text = "1"
        B3.Text = "Q"
        B4.Text = "A"
        B5.Text = "Z"
        B6.Text = "X"
        B7.Text = "D"
        B8.Text = "C"
        B9.Text = "F"
        B10.Text = "V"
        B11.Text = "G"
        B12.Text = "B"
        B13.Text = "N"
        B14.Text = "J"
        B15.Text = "M"
        B16.Text = "K"
        B17.Text = ","
        B18.Text = "."
        B19.Text = ";"
        B20.Text = "/"
        B21.Text = "'"
        B22.Text = "1"
        B23.Text = "5"
        B24.Text = "3"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B24.Click, B23.Click, B22.Click, B21.Click, B2.Click, B20.Click, B19.Click, B18.Click, B17.Click, B16.Click, B15.Click, B14.Click, B13.Click, B12.Click, B10.Click, B1.Click, B11.Click
        Dim note, i As Integer
        Dim s As String
        s = sender.name
        For i = 1 To Len(s) - 1
            note = note * 10 + Val(s(i))
        Next

        Console.Beep(440 * System.Math.Exp((System.Math.Log(2) * (Val(TB1.Text) - (10 - note) / 12))), Val(TB2.Text))
    End Sub

    Private Sub НастройкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НастройкиToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class
