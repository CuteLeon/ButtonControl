<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XYButton
    Inherits System.Windows.Forms.UserControl

    'UserControl1 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XYButton))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonImageList
        '
        Me.ButtonImageList.ImageStream = CType(resources.GetObject("ButtonImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ButtonImageList.Images.SetKeyName(0, "Button_N.png")
        Me.ButtonImageList.Images.SetKeyName(1, "Button_P.png")
        Me.ButtonImageList.Images.SetKeyName(2, "Button_FN.png")
        '
        'ButtonText
        '
        Me.ButtonText.ForeColor = System.Drawing.Color.White
        Me.ButtonText.Location = New System.Drawing.Point(0, 0)
        Me.ButtonText.Name = "ButtonText"
        Me.ButtonText.Size = New System.Drawing.Size(140, 36)
        Me.ButtonText.TabIndex = 0
        Me.ButtonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'XYButton
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.ButtonText)
        Me.Name = "XYButton"
        Me.Size = New System.Drawing.Size(140, 36)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonImageList As System.Windows.Forms.ImageList
    Friend WithEvents ButtonText As System.Windows.Forms.Label

End Class
