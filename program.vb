Module Program

    Sub Main()

        Dim account As New
BankAccount() 

         account.Deposit(50000)


Console.WriteLine("Balance after deposit: " & account.Balance)

        account.Withdraw(20000)


Console.WriteLine("Balance after withdrawal: " & account.Balance)

        Console.ReadLine()
    End Sub
End Module
