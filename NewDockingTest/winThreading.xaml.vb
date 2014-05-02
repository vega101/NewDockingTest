Imports System.ComponentModel
Imports System.IO
Imports MiniDumpApp

Public Class winThreading
    Implements INotifyPropertyChanged

    Private _IsBusy As Boolean

    Public Property IsBusy() As Boolean
        Get
            Return Me._IsBusy
        End Get
        Set(value As Boolean)
            Me._IsBusy = Value
            NotifyPropertyChanged("IsBusy")
        End Set
    End Property

    Private WithEvents busyWorker As BackgroundWorker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim currentDomain As AppDomain = AppDomain.CurrentDomain
        AddHandler currentDomain.UnhandledException, AddressOf MyHandler

        Me.DataContext = Me

    End Sub




    Sub MyHandler(sender As Object, args As UnhandledExceptionEventArgs)
        'Dim e As Exception = DirectCast(args.ExceptionObject, Exception)
        'Console.WriteLine("MyHandler caught : " + e.Message)
        'Console.WriteLine("Runtime terminating: {0}", args.IsTerminating)

        Dim currentDateTime As String = String.Format("{0:dd-MM-yyyy_HH-mm-ss}", DateTime.Now)

        Dim fileName As String = "AMPMiniDump_" & currentDateTime & ".mdmp"
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName)
        Dim x = 1
        'MessageBox.Show("Writing Dump")
        'Dim ex As Exception = DirectCast(args.ExceptionObject, Exception)
        'Dim stackTrace As String = ex.StackTrace
        'Dim currentDateTime As String = String.Format("{0:dd-MM-yyyy_HH-mm-ss}", DateTime.Now)
        'Dim fileName As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), String.Format("AMPMiniDump_{0}.mdmp"), currentDateTime)
        'Using fs As FileStream = New FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.Write)
        '    MiniDump.Write(fs.SafeFileHandle, MiniDump.Option.WithFullMemory, MiniDump.ExceptionInfo.Present)
        'End Using
        'MessageBox.Show("Writing Dump Complete")

    End Sub

    Private Sub btnGo_Click_1(sender As Object, e As RoutedEventArgs)

        Dim data As mData

        data.Name = "Ray"

        busyWorker = New BackgroundWorker

        IsBusy = True

        busyWorker.RunWorkerAsync()
    End Sub

    Private Sub entityCreator_DoWork(sender As Object, e As DoWorkEventArgs) Handles busyWorker.DoWork

        System.Threading.Thread.Sleep(5000)

    End Sub

    Private Sub entityCreator_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles busyWorker.RunWorkerCompleted

        IsBusy = False

    End Sub


    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Public Sub NotifyPropertyChanged(info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub



End Class
