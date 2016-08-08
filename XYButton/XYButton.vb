Public Class XYButton
    Public Shadows Event Click(sender As Object, e As EventArgs)
    Public Shadows Event MouseClick(sender As Object, e As MouseEventArgs)
    Public Shadows Event MouseDown(sender As Object, e As MouseEventArgs)
    Public Shadows Event MouseEnter(sender As Object, e As EventArgs)
    Public Shadows Event MouseLeave(sender As Object, e As EventArgs)
    Public Shadows Event MouseUp(sender As Object, e As MouseEventArgs)

    Public Sub SetCaption(ByVal CaptionString As String)
        ButtonText.Text = CaptionString
    End Sub

    Private Sub XiaoYanButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = ButtonImageList.Images(0)
        ButtonText.Text = Me.Name
    End Sub

    Private Sub XYButton_Click(sender As Object, e As EventArgs) Handles ButtonText.Click
        Me.BackgroundImage = ButtonImageList.Images(1)
        RaiseEvent Click(sender, e)
    End Sub

    Private Sub XiaoYanButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ButtonText.MouseClick
        Me.BackgroundImage = ButtonImageList.Images(1)
        RaiseEvent MouseClick(sender, e)
    End Sub

    Private Sub XiaoYanButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonText.MouseDown
        Me.BackgroundImage = ButtonImageList.Images(2)
        RaiseEvent MouseDown(sender, e)
    End Sub

    Private Sub XiaoYanButton_MouseEnter(sender As Object, e As EventArgs) Handles ButtonText.MouseEnter
        Me.BackgroundImage = ButtonImageList.Images(1)
        RaiseEvent MouseEnter(sender, e)
    End Sub

    Private Sub XiaoYanButton_MouseLeave(sender As Object, e As EventArgs) Handles ButtonText.MouseLeave
        Me.BackgroundImage = ButtonImageList.Images(0)
        RaiseEvent MouseLeave(sender, e)
    End Sub

    Private Sub XiaoYanButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonText.MouseUp
        Me.BackgroundImage = ButtonImageList.Images(1)
        RaiseEvent MouseUp(sender, e)
    End Sub

    Private Sub XiaoYanButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.OnBackgroundImageChanged(e)
        ButtonText.Size = Me.Size
        'Me.Size = ButtonImageList.ImageSize
    End Sub



End Class
