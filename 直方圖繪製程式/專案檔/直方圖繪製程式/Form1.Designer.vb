<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.貼上圖片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.復原ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.一般直方圖等化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.彩色直方圖等化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.繪製直方圖ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.視窗一ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.視窗二ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.視窗三ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.載入圖片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.載入圖片ToolStripMenuItem, Me.貼上圖片ToolStripMenuItem, Me.復原ToolStripMenuItem, Me.一般直方圖等化ToolStripMenuItem, Me.彩色直方圖等化ToolStripMenuItem, Me.繪製直方圖ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1125, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '貼上圖片ToolStripMenuItem
        '
        Me.貼上圖片ToolStripMenuItem.Name = "貼上圖片ToolStripMenuItem"
        Me.貼上圖片ToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.貼上圖片ToolStripMenuItem.Text = "貼上圖片"
        '
        '復原ToolStripMenuItem
        '
        Me.復原ToolStripMenuItem.Name = "復原ToolStripMenuItem"
        Me.復原ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.復原ToolStripMenuItem.Text = "復原"
        '
        '一般直方圖等化ToolStripMenuItem
        '
        Me.一般直方圖等化ToolStripMenuItem.Name = "一般直方圖等化ToolStripMenuItem"
        Me.一般直方圖等化ToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.一般直方圖等化ToolStripMenuItem.Text = "一般直方圖等化"
        '
        '彩色直方圖等化ToolStripMenuItem
        '
        Me.彩色直方圖等化ToolStripMenuItem.Name = "彩色直方圖等化ToolStripMenuItem"
        Me.彩色直方圖等化ToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.彩色直方圖等化ToolStripMenuItem.Text = "彩色直方圖等化"
        '
        '繪製直方圖ToolStripMenuItem
        '
        Me.繪製直方圖ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.視窗一ToolStripMenuItem, Me.視窗二ToolStripMenuItem, Me.視窗三ToolStripMenuItem})
        Me.繪製直方圖ToolStripMenuItem.Name = "繪製直方圖ToolStripMenuItem"
        Me.繪製直方圖ToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.繪製直方圖ToolStripMenuItem.Text = "繪製直方圖"
        '
        '視窗一ToolStripMenuItem
        '
        Me.視窗一ToolStripMenuItem.Name = "視窗一ToolStripMenuItem"
        Me.視窗一ToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.視窗一ToolStripMenuItem.Text = "視窗一"
        '
        '視窗二ToolStripMenuItem
        '
        Me.視窗二ToolStripMenuItem.Name = "視窗二ToolStripMenuItem"
        Me.視窗二ToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.視窗二ToolStripMenuItem.Text = "視窗二"
        '
        '視窗三ToolStripMenuItem
        '
        Me.視窗三ToolStripMenuItem.Name = "視窗三ToolStripMenuItem"
        Me.視窗三ToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.視窗三ToolStripMenuItem.Text = "視窗三"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        '載入圖片ToolStripMenuItem
        '
        Me.載入圖片ToolStripMenuItem.Name = "載入圖片ToolStripMenuItem"
        Me.載入圖片ToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.載入圖片ToolStripMenuItem.Text = "載入圖片"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1125, 622)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "彩色直方圖等化"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 貼上圖片ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 繪製直方圖ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 視窗一ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 視窗二ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 視窗三ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents 一般直方圖等化ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 復原ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 彩色直方圖等化ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 載入圖片ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
