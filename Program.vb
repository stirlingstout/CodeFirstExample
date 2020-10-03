Imports System
Imports Model
Imports DataAccess

Module Program
    Sub Main(args As String())
        InsertDestination()
    End Sub

    Sub InsertDestination()
        Dim destination = New Destination() With
        {
        .Country = "Indonesia",
        .Description = "EcoTourism at its best in exquisite Bali",
        .Name = "Bali"
        }

        Using context As New BreakAwayContext()
            context.Destinations.Add(destination)
            context.SaveChanges()
        End Using

    End Sub
End Module
