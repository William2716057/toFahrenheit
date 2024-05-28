Imports System
Imports System.Transactions

Module TemperatureConversion
	Sub main()
		' prompt user
		Console.WriteLine("Enter temperature in celsius: ")
		Dim celsius As Double = CDbl(Console.ReadLine())
		' Convert to Fahrenheit
		Dim Fahrenheit As Double = (celsius * 9 / 5) + 32

		'display 
		Console.WriteLine("Converted to Fahrenheit: " & Fahrenheit)
	End Sub
End Module