Public Class AtheleteEventsModel

    Private _Eventid As Guid

    Public Property Eventid() As Guid
        Get
            Return _Eventid
        End Get
        Set(ByVal value As Guid)
            _Eventid = value
        End Set
    End Property



    Private _Membershipnumber As String

    Public Property Membershipnumber() As String
        Get
            Return _Membershipnumber
        End Get
        Set(ByVal value As String)
            _Membershipnumber = value
        End Set
    End Property

 

    Private _EventResults As String

    Public Property EventResults() As String
        Get
            Return _EventResults
        End Get
        Set(ByVal value As String)
            _EventResults = value
        End Set
    End Property


    Private _EventDate As Date


    Public Property EventDate() As Date
        Get
            Return _EventDate
        End Get
        Set(ByVal value As Date)
            _EventDate = value
        End Set
    End Property

 

End Class
