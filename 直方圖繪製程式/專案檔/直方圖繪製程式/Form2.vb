Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.白紙
        Dim pic1s As Image = PictureBox1.Image
        Dim drawImage As New Bitmap(pic1s, pic1s.Width, pic1s.Height)
        Dim g As Graphics = Graphics.FromImage(drawImage)
        Dim myPen As New Pen(Color.FromArgb(255, 255, 0, 0), 3)
        Dim myPen2 As New Pen(Color.FromArgb(255, 0, 255, 0), 3)
        Dim myPen3 As New Pen(Color.FromArgb(255, 0, 0, 255), 3)
        Dim wi As Integer = (pic1s.Width / PictureBox1.Width)
        Dim he As Integer = (pic1s.Width / PictureBox1.Width)
        myPen.StartCap = Drawing2D.LineCap.Round '此行必要，否則線會斷
        myPen2.StartCap = Drawing2D.LineCap.Round '此行必要，否則線會斷
        myPen3.StartCap = Drawing2D.LineCap.Round '此行必要，否則線會斷
        For i = 0 To 255
            g.DrawLine(myPen, i, 300, i, 300 - (Form1.r(i) * 100))
        Next
        For i = 0 To 255
            g.DrawLine(myPen2, i + 258, 300, i + 258, 300 - (Form1.g(i) * 100))
        Next
        For i = 0 To 255
            g.DrawLine(myPen3, i + 258 + 258, 300, i + 258 + 258, 300 - (Form1.b(i) * 100))
        Next
        g.Dispose()
        PictureBox1.Image = drawImage
    End Sub
End Class