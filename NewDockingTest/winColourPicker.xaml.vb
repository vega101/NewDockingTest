Imports System.Windows.Media

Public Class winColourPicker

    Private SelectedColour As Color

    Private ColourString As String

    Private Sub btnStoreColour_Click_1(sender As Object, e As RoutedEventArgs)
        SelectedColour = colourPicker.SelectedColor
        ColourString = SelectedColour.ToString
    End Sub

    Private Sub btnClearColour_Click_1(sender As Object, e As RoutedEventArgs)
        colourPicker.SelectedColor = Nothing
    End Sub

    Private Sub btnLoadColour_Click_1(sender As Object, e As RoutedEventArgs)
        colourPicker.SelectedColor = ColorConverter.ConvertFromString(ColourString)
    End Sub
End Class
