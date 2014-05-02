Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.Windows
Imports System.Windows.Threading


Public Class ADTest

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim users As New List(Of String)

        Dim context As PrincipalContext = New PrincipalContext(ContextType.Domain, "Exdome")

        Dim mySearcher As PrincipalSearcher = New PrincipalSearcher(New UserPrincipal(context))

        For Each result As Principal In mySearcher.FindAll
            Dim de As DirectoryEntry = result.GetUnderlyingObject

            users.Add(de.Name)
            users.Add(de.Username)
            users.Add(de.Properties("givenName").Value)
            For Each item In de.Properties.PropertyNames
                Dim x = item
            Next
        Next




    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

        'Dim win As New NotificationWindow
        'win.Show()

        Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, New Action(Sub()
                                                                                  Dim win As New NotificationWindow
                                                                                  win.Show()
                                                                              End Sub))
    

    End Sub
End Class
