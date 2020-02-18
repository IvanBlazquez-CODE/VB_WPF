Public Class MainViewModel
    Dim modelo As WpfMateriales.DaniDBEntities
    Public Sub New(model As WpfMateriales.DaniDBEntities)
        modelo = model
    End Sub

    Public ReadOnly Property ListaMateriales As List(Of WpfMateriales.Materiales)
        Get
            Return modelo.Materiales.ToList
        End Get
    End Property
End Class
