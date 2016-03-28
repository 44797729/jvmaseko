Public Class EventsModel

    Private _Eventid As Guid

    Public Property Eventid() As Guid
        Get
            Return _Eventid
        End Get
        Set(ByVal value As Guid)
            _Eventid = value
        End Set
    End Property



    Private _Eventname As String

    Public Property Eventname() As String
        Get
            Return _Eventname
        End Get
        Set(ByVal value As String)
            _Eventname = value
        End Set
    End Property

     
    Private _Eventlocation As String

    Public Property Eventlocation() As String
        Get
            Return _Eventlocation
        End Get
        Set(ByVal value As String)
            _Eventlocation = value
        End Set
    End Property

    Private _EventDistance As String

    Public Property EventDistance() As String
        Get
            Return _EventDistance
        End Get
        Set(ByVal value As String)
            _EventDistance = value
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
     
    Private _EventRegistrationfee As Decimal


    Public Property EventRegistrationfee() As Decimal
        Get
            Return _EventRegistrationfee
        End Get
        Set(ByVal value As Decimal)
            _EventRegistrationfee = value
        End Set
    End Property

End Class
