Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mat1, Mat2, Mat3, Mat4, Mat5, Mat6, Mat7, Mat8, Mat9, Mat10, Mat11, Mat12, Mat13 As Double
        Dim promedio As Double

        Mat1 = Val(Materia1.Text)
        Mat2 = Val(Materia2.Text)
        Mat3 = Val(Materia3.Text)
        Mat4 = Val(Materia4.Text)
        Mat5 = Val(Materia5.Text)
        Mat6 = Val(Materia6.Text)
        Mat7 = Val(Materia7.Text)
        Mat8 = Val(Materia8.Text)
        Mat9 = Val(Materia9.Text)
        Mat10 = Val(Materia10.Text)
        Mat11 = Val(Materia11.Text)
        Mat12 = Val(Materia12.Text)
        Mat13 = Val(Materia13.Text)

        promedio = (Mat1 + Mat2 + Mat3 + Mat4 + Mat5 + Mat6 + Mat7 + Mat8 + Mat9 + Mat10 + Mat11 + Mat12 + Mat13) / 13

        resultado.text = promedio.ToString()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
