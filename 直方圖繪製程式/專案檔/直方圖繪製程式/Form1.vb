Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class Form1
    Dim pic2 As Image
    Public r(255), g(255), b(255) As Single
    Private Sub 視窗二ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 視窗二ToolStripMenuItem.Click
        Form3.Close()
        Dim start_time As Date = Now
        Dim Width As Integer, Height As Integer
        Dim mBitmap As Bitmap
        Try
            mBitmap = New Bitmap(PictureBox1.Image)
            Width = mBitmap.Width
            Height = mBitmap.Height
            Dim rect As New Rectangle(0, 0, Width, Height)
            Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
            Dim ptr As IntPtr = bmpData.Scan0
            Dim bytes As Integer = bmpData.Stride * Height
            Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
            Dim rgbValues(bytes - 1) As Byte
            Marshal.Copy(ptr, rgbValues, 0, bytes)
            For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                b(rgbValues(k)) += 1
                g(rgbValues(k + 1)) += 1
                r(rgbValues(k + 2)) += 1
            Next
            For i = 0 To 255
                g(i) = (g(i) / ((Height) * (Width))) * 100%
                r(i) = (r(i) / ((Height) * (Width))) * 100%
                b(i) = (b(i) / ((Height) * (Width))) * 100%
            Next
            Marshal.Copy(rgbValues, 0, ptr, bytes)
            mBitmap.UnlockBits(bmpData)
            Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        System.GC.Collect()
        Form3.Show()
    End Sub
    Private Sub 視窗三ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 視窗三ToolStripMenuItem.Click
        Form4.Close()
        Dim start_time As Date = Now
        Dim Width As Integer, Height As Integer
        Dim mBitmap As Bitmap
        Try
            mBitmap = New Bitmap(PictureBox1.Image)
            Width = mBitmap.Width
            Height = mBitmap.Height
            Dim rect As New Rectangle(0, 0, Width, Height)
            Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
            Dim ptr As IntPtr = bmpData.Scan0
            Dim bytes As Integer = bmpData.Stride * Height
            Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
            Dim rgbValues(bytes - 1) As Byte
            Marshal.Copy(ptr, rgbValues, 0, bytes)
            For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                b(rgbValues(k)) += 1
                g(rgbValues(k + 1)) += 1
                r(rgbValues(k + 2)) += 1
            Next
            For i = 0 To 255
                g(i) = (g(i) / ((Height) * (Width))) * 100%
                r(i) = (r(i) / ((Height) * (Width))) * 100%
                b(i) = (b(i) / ((Height) * (Width))) * 100%
            Next
            Marshal.Copy(rgbValues, 0, ptr, bytes)
            mBitmap.UnlockBits(bmpData)
            Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        System.GC.Collect()
        Form4.Show()
    End Sub
    Private Sub 一般直方圖等化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 一般直方圖等化ToolStripMenuItem.Click
        Dim start_time As Date = Now
        Dim Width As Integer, Height As Integer
        Dim mBitmap As Bitmap
        Dim rs(255), gs(255), bs(255) As Integer
        Dim rs1(255), gs1(255), bs1(255) As Integer
        Try
            mBitmap = New Bitmap(PictureBox1.Image)
            Width = mBitmap.Width
            Height = mBitmap.Height
            Dim rect As New Rectangle(0, 0, Width, Height)
            Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
            Dim ptr As IntPtr = bmpData.Scan0
            Dim bytes As Integer = bmpData.Stride * Height
            Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
            Dim rgbValues(bytes - 1) As Byte
            Marshal.Copy(ptr, rgbValues, 0, bytes)
            For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                rs1(rgbValues(k + 2)) += 1
                gs1(rgbValues(k + 1)) += 1
                bs1(rgbValues(k)) += 1
            Next

            Dim rrrs, gggs, bbbs As Integer
            For d = 0 To 255 - 1
                For f = 0 To 255 - 1
                    If bs(f) > bs(f + 1) Then
                        bbbs = bs(f)
                        bs(f) = bs(f + 1)
                        bs(f + 1) = bbbs
                    End If
                    If rs(f) > rs(f + 1) Then
                        rrrs = rs(f)
                        rs(f) = rs(f + 1)
                        rs(f + 1) = rrrs
                    End If
                    If gs(f) > gs(f + 1) Then
                        gggs = gs(f)
                        gs(f) = gs(f + 1)
                        gs(f + 1) = gggs
                    End If
                Next f
            Next d
            For i = 1 To 255
                rs(i) += rs1(i)
                rs(i) += rs(i - 1)
            Next
            For i = 1 To 255
                gs(i) += gs1(i)
                gs(i) += gs(i - 1)
            Next
            For i = 1 To 255
                bs(i) += bs1(i)
                bs(i) += bs(i - 1)
            Next
            Dim rrs(255), ggs(255), bbs(255) As Integer
            For i = 0 To 255
                rrs(i) = Math.Round(((rs(i) - rs(0)) / (((Height - 1) * (Width - 1)) - rs(0))) * 255)
                ggs(i) = Math.Round(((gs(i) - gs(0)) / (((Height - 1) * (Width - 1)) - gs(0))) * 255)
                bbs(i) = Math.Round(((bs(i) - bs(0)) / (((Height - 1) * (Width - 1)) - bs(0))) * 255)
                If rrs(i) > 255 Then rrs(i) = 255
                If ggs(i) > 255 Then ggs(i) = 255
                If bbs(i) > 255 Then bbs(i) = 255
                If rrs(i) < 0 Then rrs(i) = 0
                If ggs(i) < 0 Then ggs(i) = 0
                If bbs(i) < 0 Then bbs(i) = 0
            Next
            For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                rgbValues(k) = bbs(rgbValues(k))
                rgbValues(k + 1) = ggs(rgbValues(k + 1))
                rgbValues(k + 2) = rrs(rgbValues(k + 2))
            Next
            Marshal.Copy(rgbValues, 0, ptr, bytes)
            mBitmap.UnlockBits(bmpData)
            Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        PictureBox1.Image = mBitmap
        System.GC.Collect()
    End Sub
    Private Sub 復原ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 復原ToolStripMenuItem.Click
        PictureBox1.Image = pic2
    End Sub
    Private Sub 彩色直方圖等化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 彩色直方圖等化ToolStripMenuItem.Click
        Dim rgb127 As Byte = 127
        Dim r127 As Byte = 127
        Dim g127 As Byte = 127
        Dim b127 As Byte = 127
        Dim rr127 As Byte = 127
        Dim gg127 As Byte = 127
        Dim bb127 As Byte = 127
        Dim start_time As Date = Now
        Dim r, g, b As Integer
        Dim rr, gg, bb As Long
        Dim rgb As Integer = 127
        Dim Width As Integer, Height As Integer
        Dim mBitmap As Bitmap
        Try
            mBitmap = New Bitmap(PictureBox1.Image)
            Width = mBitmap.Width
            Height = mBitmap.Height
            Dim rect As New Rectangle(0, 0, Width, Height)
            Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
            Dim ptr As IntPtr = bmpData.Scan0
            Dim bytes As Integer = bmpData.Stride * Height
            With bmpData
            End With
            Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
            Dim rgbValues(bytes - 1) As Byte
            Marshal.Copy(ptr, rgbValues, 0, bytes)
            For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                bb += rgbValues(k)
                gg += rgbValues(k + 1)
                rr += rgbValues(k + 2)
            Next
            rr = rr / (rgbValues.Length / 4)
            gg = gg / (rgbValues.Length / 4)
            bb = bb / (rgbValues.Length / 4)
            Marshal.Copy(rgbValues, 0, ptr, bytes)
            mBitmap.UnlockBits(bmpData)
            Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        System.GC.Collect()
        rgb = (rr + gg + bb) / 3
        If rgb < rgb127 Then
            Dim tra As Single = rr127 / rr
            Dim tra2 As Single = gg127 / gg
            Dim tra3 As Single = bb127 / bb
            Try
                mBitmap = New Bitmap(PictureBox1.Image)
                Width = mBitmap.Width
                Height = mBitmap.Height
                Dim rect As New Rectangle(0, 0, Width, Height)
                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                Dim ptr As IntPtr = bmpData.Scan0
                Dim bytes As Integer = bmpData.Stride * Height
                With bmpData
                End With
                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                Dim rgbValues(bytes - 1) As Byte
                Marshal.Copy(ptr, rgbValues, 0, bytes)
                For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                    b = rgbValues(k)
                    g = rgbValues(k + 1)
                    r = rgbValues(k + 2)
                    r = r * tra
                    g = g * tra2
                    b = b * tra3
                    If r > 255 Then
                        r = 255
                    End If
                    If g > 255 Then
                        g = 255
                    End If
                    If b > 255 Then
                        b = 255
                    End If
                    If r < 0 Then
                        r = 0
                    End If
                    If g < 0 Then
                        g = 0
                    End If
                    If b < 0 Then
                        b = 0
                    End If
                    rgbValues(k) = b
                    rgbValues(k + 1) = g
                    rgbValues(k + 2) = r
                Next
                Marshal.Copy(rgbValues, 0, ptr, bytes)
                mBitmap.UnlockBits(bmpData)
                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            Dim tra As Single = (255 - rr127) / (255 - rr)
            Dim tra2 As Single = (255 - gg127) / (255 - gg)
            Dim tra3 As Single = (255 - bb127) / (255 - bb)
            Try
                mBitmap = New Bitmap(PictureBox1.Image)
                Width = mBitmap.Width
                Height = mBitmap.Height
                Dim rect As New Rectangle(0, 0, Width, Height)
                Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
                Dim ptr As IntPtr = bmpData.Scan0
                Dim bytes As Integer = bmpData.Stride * Height
                With bmpData
                End With
                Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
                Dim rgbValues(bytes - 1) As Byte
                Marshal.Copy(ptr, rgbValues, 0, bytes)
                For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                    b = 255 - rgbValues(k)
                    g = 255 - rgbValues(k + 1)
                    r = 255 - rgbValues(k + 2)
                    r = r * tra
                    g = g * tra2
                    b = b * tra3
                    If r > 255 Then
                        r = 255
                    End If
                    If g > 255 Then
                        g = 255
                    End If
                    If b > 255 Then
                        b = 255
                    End If
                    If r < 0 Then
                        r = 0
                    End If
                    If g < 0 Then
                        g = 0
                    End If
                    If b < 0 Then
                        b = 0
                    End If
                    rgbValues(k) = 255 - b
                    rgbValues(k + 1) = 255 - g
                    rgbValues(k + 2) = 255 - r
                Next
                Marshal.Copy(rgbValues, 0, ptr, bytes)
                mBitmap.UnlockBits(bmpData)
                Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        PictureBox1.Image = mBitmap
        System.GC.Collect()
    End Sub
    Private Sub 載入圖片ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 載入圖片ToolStripMenuItem.Click
        OpenFileDialog1.Filter = "圖片檔 (*.png;*.jpg;*.bmp;*.gif;*.tif)|*.png;*.jpg;*.bmp;*.gif;*.tif"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim a As New Bitmap(OpenFileDialog1.FileName)
            PictureBox1.Image = a
            pic2 = a
        End If
    End Sub
    Private Sub 視窗一ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 視窗一ToolStripMenuItem.Click
        Form2.Close()
        Dim start_time As Date = Now
        Dim Width As Integer, Height As Integer
        Dim mBitmap As Bitmap
        Try
            mBitmap = New Bitmap(PictureBox1.Image)
            Width = mBitmap.Width
            Height = mBitmap.Height
            Dim rect As New Rectangle(0, 0, Width, Height)
            Dim bmpData As BitmapData = mBitmap.LockBits(rect, ImageLockMode.ReadWrite, mBitmap.PixelFormat)
            Dim ptr As IntPtr = bmpData.Scan0
            Dim bytes As Integer = bmpData.Stride * Height
            Dim Bpx As Byte = bmpData.Stride \ mBitmap.Width
            Dim rgbValues(bytes - 1) As Byte
            Marshal.Copy(ptr, rgbValues, 0, bytes)
            For k As Integer = 0 To rgbValues.Length - Bpx Step Bpx
                b(rgbValues(k)) += 1
                g(rgbValues(k + 1)) += 1
                r(rgbValues(k + 2)) += 1
            Next
            For i = 0 To 255
                g(i) = (g(i) / ((Height) * (Width))) * 100%
                r(i) = (r(i) / ((Height) * (Width))) * 100%
                b(i) = (b(i) / ((Height) * (Width))) * 100%
            Next
            Marshal.Copy(rgbValues, 0, ptr, bytes)
            mBitmap.UnlockBits(bmpData)
            Dim elapsed_time As TimeSpan = Now.Subtract(start_time)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        System.GC.Collect()
        Form2.Show()
    End Sub
    Private Sub 貼上圖片ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 貼上圖片ToolStripMenuItem.Click
        Try
            Dim a As New Bitmap(My.Computer.Clipboard.GetImage)
            PictureBox1.Image = a
            pic2 = a
        Catch
            MsgBox("貼上圖片失敗，請確認剪貼簿中是否有圖片")
        End Try
    End Sub
End Class
