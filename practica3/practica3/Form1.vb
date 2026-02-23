Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mat1, Mat2, Mat3, Mat4, Mat5 As Double
        Dim promedio As Double

        Mat1 = Val(Materia1.Text)
        Mat2 = Val(Materia2.Text)
        Mat3 = Val(Materia3.Text)
        Mat4 = Val(Materia4.Text)
        Mat5 = Val(Materia5.Text)

        promedio = (Mat1 + Mat2 + Mat3 + Mat4 + Mat5) / 5

        resultado.text = promedio.ToString()

    End Sub
End Class
