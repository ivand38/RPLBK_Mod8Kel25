Imports TempConv

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objConv As New TempConv.TempConvComp
        Dim c As Double
        Dim o As Double
        c = CDbl(TextBox1.Text)
        o = objConv.cToR(c)
        TextBox2.Text = o
        Label4.Text = "C To R"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim objConv As New TempConv.TempConvComp
        Dim c As Double
        Dim o As Double
        c = CDbl(TextBox1.Text)
        o = objConv.cToF(c)
        TextBox2.Text = o
        Label4.Text = "C To F"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim objConv As New TempConv.TempConvComp
        Dim c As Double
        Dim o As Double
        c = CDbl(TextBox1.Text)
        o = objConv.cToK(c)
        TextBox2.Text = o
        Label4.Text = "C To K"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim objConv As New TempConv.TempConvComp
        Dim r As Double
        Dim o As Double
        r = CDbl(TextBox1.Text)
        o = objConv.rToC(r)
        TextBox2.Text = o
        Label4.Text = "R To C"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Dim objConv As New TempConv.TempConvComp
        Dim r As Double
        Dim o As Double
        r = CDbl(TextBox1.Text)
        o = objConv.rToF(r)
        TextBox2.Text = o
        Label4.Text = "R To F"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        Dim objConv As New TempConv.TempConvComp
        Dim r As Double
        Dim o As Double
        r = CDbl(TextBox1.Text)
        o = objConv.rToK(r)
        TextBox2.Text = o
        Label4.Text = "R To K"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        Dim objConv As New TempConv.TempConvComp
        Dim f As Double
        Dim o As Double
        f = CDbl(TextBox1.Text)
        o = objConv.fToC(f)
        TextBox2.Text = o
        Label4.Text = "F To C"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        Dim objConv As New TempConv.TempConvComp
        Dim f As Double
        Dim o As Double
        f = CDbl(TextBox1.Text)
        o = objConv.fToR(f)
        TextBox2.Text = o
        Label4.Text = "F To R"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click


        Dim objConv As New TempConv.TempConvComp
        Dim f As Double
        Dim o As Double
        f = CDbl(TextBox1.Text)
        o = objConv.fToK(f)
        TextBox2.Text = o
        Label4.Text = "F To K"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click


        Dim objConv As New TempConv.TempConvComp
        Dim k As Double
        Dim o As Double
        k = CDbl(TextBox1.Text)
        o = objConv.kToC(k)
        TextBox2.Text = o
        Label4.Text = "K To C"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click


        Dim objConv As New TempConv.TempConvComp
        Dim k As Double
        Dim o As Double
        k = CDbl(TextBox1.Text)
        o = objConv.kToR(k)
        TextBox2.Text = o
        Label4.Text = "K To R"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click


        Dim objConv As New TempConv.TempConvComp
        Dim k As Double
        Dim o As Double
        k = CDbl(TextBox1.Text)
        o = objConv.kToF(k)
        TextBox2.Text = o
        Label4.Text = "K To F"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
