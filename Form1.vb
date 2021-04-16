'By Sarvesh Anand Mankar ~~194009
Public Class Form1

    Dim i, n2 As String
    Dim n1 As String
    Dim o As String
    Sub Main()

        n1 = 0

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i = TextBox1.Text.ToString() + "0".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        i = TextBox1.Text.ToString() + ".".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        i = TextBox1.Text.ToString() + "1".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        i = TextBox1.Text.ToString() + "2".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        i = TextBox1.Text.ToString() + "3".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        i = TextBox1.Text.ToString() + "4".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        i = TextBox1.Text.ToString() + "5".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        i = TextBox1.Text.ToString() + "6".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        i = TextBox1.Text.ToString() + "7".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        i = TextBox1.Text.ToString() + "8".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        i = TextBox1.Text.ToString() + "9".ToString()
        TextBox1.Text = i
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If n1 = 0 Then
            n1 = TextBox1.Text
            TextBox1.Text = ""

        Else
            n2 = CDec(Val(n1)) + TextBox1.Text
            n1 = n2
            TextBox1.Text = ""
            n2 = 0
        End If

        o = "add"

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If o = "add" Then
            n2 = CDec(Val(n1)) + TextBox1.Text
            n1 = n2
            TextBox1.Text = n2
            n2 = 0
            n1 = 0
            o = ""

        ElseIf o = "subtract" Then
            n2 = CDec(Val(n1)) - TextBox1.Text
            n1 = n2
            TextBox1.Text = n2
            n2 = 0
            n1 = 0
            o = ""

        ElseIf o = "Multiply" Then
            n2 = CDec(Val(n1)) * TextBox1.Text
            n1 = n2
            TextBox1.Text = n2
            n2 = 0
            n1 = 0
            o = ""

        ElseIf o = "Divide" Then
            n2 = CDec(Val(n1)) / TextBox1.Text
            n1 = n2
            TextBox1.Text = n2
            n2 = 0
            n1 = 0
            o = ""

        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If n1 = 0 Then
            n1 = TextBox1.Text
            TextBox1.Text = ""

        Else
            n2 = CDec(Val(n1)) - TextBox1.Text
            n1 = n2
            TextBox1.Text = ""
            n2 = 0
        End If

        o = "subtract"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If n1 = 0 Then
            n1 = TextBox1.Text
            TextBox1.Text = ""

        Else
            n2 = CDec(Val(n1)) * TextBox1.Text
            n1 = n2
            TextBox1.Text = ""
            n2 = 0
        End If

        o = "Multiply"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If n1 = 0 Then
            n1 = TextBox1.Text
            TextBox1.Text = ""

        Else
            n2 = CDec(Val(n1)) / TextBox1.Text
            n1 = n2
            TextBox1.Text = ""
            n2 = 0
        End If

        o = "Divide"
    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
    End Sub

End Class
