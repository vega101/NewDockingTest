Imports System.Windows
Imports System.Windows.Threading

Partial Public Class NotificationWindow
    Public Sub New()
        InitializeComponent()

        Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, New Action(Sub()
                                                                                  Dim workingArea = System.Windows.SystemParameters.WorkArea
                                                                                  Dim transform = PresentationSource.FromVisual(Me).CompositionTarget.TransformFromDevice
                                                                                  Dim corner = transform.Transform(New Point(workingArea.Right, workingArea.Bottom))

                                                                                  Me.Left = corner.X - Me.ActualWidth - 100
                                                                                  Me.Top = corner.Y - Me.ActualHeight

                                                                              End Sub))
    End Sub

    Private Sub Storyboard_Completed_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
