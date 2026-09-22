Public Class Bank Account 
   Private _balance As Decimal
   Private ReadOnly Property
Balance As Decimal
        Get
            Return _balance
        End Get
    End Property
End Class
Public Sub Deposit(amount As Decimal)

     If amount < 0 Then
        Throw New
ArgumentException("Deposit amount cannot be negative.")
        End If

        _balance += amount
End Sub