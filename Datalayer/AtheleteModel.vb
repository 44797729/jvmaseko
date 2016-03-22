Public Class AtheleteModel

    Private _Athleteid As Guid

    Public Property Athleteid() As Guid
        Get
            Return _Athleteid
        End Get
        Set(ByVal value As Guid)
            _Athleteid = value
        End Set
    End Property



    Private _AthleteFirstname As String

    Public Property AthleteFirstname() As String
        Get
            Return _AthleteFirstname
        End Get
        Set(ByVal value As String)
            _AthleteFirstname = value
        End Set
    End Property




    Private _AthleteSurname As String

    Public Property AthleteSurname() As String
        Get
            Return _AthleteSurname
        End Get
        Set(ByVal value As String)
            _AthleteSurname = value
        End Set
    End Property

    Private _AthleteAddress As String

    Public Property AthleteAddress() As String
        Get
            Return _AthleteAddress
        End Get
        Set(ByVal value As String)
            _AthleteAddress = value
        End Set
    End Property


    Private _AthleteGender As String

    Public Property AthleteGender() As String
        Get
            Return _AthleteGender
        End Get
        Set(ByVal value As String)
            _AthleteGender = value
        End Set
    End Property



    Private _AthleteDateofBirth As Date


    Public Property AthleteDateofBirth() As Date
        Get
            Return _AthleteDateofBirth
        End Get
        Set(ByVal value As Date)
            _AthleteDateofBirth = value
        End Set
    End Property


    Private _Datejoined As Date


    Public Property Datejoined() As Date
        Get
            Return _Datejoined
        End Get
        Set(ByVal value As Date)
            _Datejoined = value
        End Set
    End Property


    Private _amountdue As Decimal


    Public Property amountdue() As Decimal
        Get
            Return _amountdue
        End Get
        Set(ByVal value As Decimal)
            _amountdue = value
        End Set
    End Property




 
End Class
