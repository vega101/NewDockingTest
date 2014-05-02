Public Class Window1

    Private Sub dashboardDocking1_PreviewShowCompass_1(sender As Object, e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)

    End Sub

    Private Sub dashboardDocking_PreviewShowCompass_1(sender As Object, e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)
        'e.Compass.IsLeftIndicatorVisible = False
        e.Compass.IsTopIndicatorVisible = False
        'e.Compass.IsRightIndicatorVisible = False
        e.Compass.IsBottomIndicatorVisible = False
        e.Compass.IsCenterIndicatorVisible = False
    End Sub
End Class
