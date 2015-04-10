Module ProductsList
    Function MyProductList() As List(Of Product)
        Dim prodList As New List(Of Product)
        For count = 1 To 5
            Dim prod As New Product
            prod.Name = "Product" & count
            prod.Brand = "Brand" & count
            prod.Color = "Color" & count
            prodList.Add(prod)
        Next
        For count = 6 To 10
            Dim prod As New Product
            prod.Name = "Product" & count
            prod.Brand = "Brand"
            prod.Color = "Color" & count
            prodList.Add(prod)
        Next
        Return prodList
    End Function
End Module
