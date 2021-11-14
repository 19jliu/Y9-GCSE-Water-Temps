'Program that asks user for water temperature input with a couple of options and returning the state of water
'JunJia Liu
'03/11/2021

Imports System

Public Module MainModule

	'Setting up variables
	Dim tempInput As Integer
	Dim waterTemperature As Integer
	Dim userName As String
	Dim menuOptionsInput As String
	Dim inputConfirmation As String

	'------------------------------------------------------------
	'The main subprocedure (starting point) - Displays program title
	Public Sub Main()
		Write("Water Temps GCSE Project - Attempt 1", ConsoleColor.Gray, ConsoleColor.Black, True)
		Write("Hello! What's your name?", ConsoleColor.Gray, ConsoleColor.Black, True)
		userName = Console.ReadLine()
		Write("Hello, ", ConsoleColor.Gray, ConsoleColor.Black, False)
		Write(userName, ConsoleColor.Cyan, ConsoleColor.Black, False)
		Write(" !", ConsoleColor.Gray, ConsoleColor.Black, True)

		Write("This is a program that asks for your water temperature and returns the state of the water!", ConsoleColor.Gray, ConsoleColor.Black, True)

		Menu()
	End Sub
	'------------------------------------------------------------

	'------------------------------------------------------------
	'The menu subprocedure - Gives the users a list of options (i.e. starting the temperature function)
	Public Sub Menu()

		Write("This is the main menu for ", ConsoleColor.Gray, ConsoleColor.Black, False)
		Write("Water Temps Program ", ConsoleColor.Blue, ConsoleColor.Black, False)
		Write(". Please select an option, ", ConsoleColor.Gray, ConsoleColor.Black, False)
		Write(userName, ConsoleColor.Cyan, ConsoleColor.Black, False)
		Write(". VALID CHOICES: start, exit", ConsoleColor.Gray, ConsoleColor.Black, True)

		menuOptionsInput = Console.ReadLine()

		'------------------------------------------------------------
		'Available Menu Options IF ELSE Statements. Returns to menu again (recalls the subprocedure) if the inputted option is INVALID
		If menuOptionsInput = "exit" Then
			End
		ElseIf menuOptionsInput <> "start" Then
			Write("Invalid Option! Please make sure you typed the correct option.", ConsoleColor.DarkRed, ConsoleColor.Red, True)

			Menu()
		End If

		mainProgram()
	End Sub
	'------------------------------------------------------------

	'------------------------------------------------------------
	'Core subprocedure - does everything such as giving the state of water temp, etc
	Public Sub mainProgram()
		'------------------------------------------------------------
		'Asks user water temperature
		Write("What is the temperature of your water, ", ConsoleColor.Gray, ConsoleColor.Black, False)
		Write(userName, ConsoleColor.Cyan, ConsoleColor.Black, False)
		Write("? Write out the temperature to the nearest integer (whole number).", ConsoleColor.Gray, ConsoleColor.Black, True)
		tempInput = Console.ReadLine()

		If IsNumeric(tempInput) Then
			waterTemperature = CInt(tempInput)
		Else
			Write("Input rejected! Are you sure you only inputted a FULL whole number in celsius? ACCEPTED: 26, WILL REJECT: 26C", ConsoleColor.DarkRed, ConsoleColor.Red, True)
		End If
		'------------------------------------------------------------

		'------------------------------------------------------------
		'Confirms user's input
		Write("You inputted " & waterTemperature & " for the temperature of your water. Are you sure you want to proceed, " & userName & "? Please input Y or N.", ConsoleColor.Gray, ConsoleColor.Black, True)
		inputConfirmation = Console.ReadLine()

		If inputConfirmation = "N" Then
			mainProgram()
		ElseIf inputConfirmation <> "Y" Then
			Write("Invalid Option! Please make sure you typed the correct option.", ConsoleColor.DarkRed, ConsoleColor.Red, True)
		End If

		Write("Computing input...", ConsoleColor.Gray, ConsoleColor.Black, True)
		Write("Sample Water Temperature: ", ConsoleColor.Gray, ConsoleColor.Black, False)
		Write(waterTemperature, ConsoleColor.DarkBlue, ConsoleColor.Black, True)
		'------------------------------------------------------------


		'------------------------------------------------------------
		'Finding out the range of water temp
		If waterTemperature <= 0 Then
			Write("State of Sample Water: ", ConsoleColor.Gray, ConsoleColor.Black, False)
			Write("FROZEN", ConsoleColor.Blue, ConsoleColor.White, True)
		ElseIf waterTemperature >= 0 And waterTemperature <= 26 Then
			Write("State of Sample Water: ", ConsoleColor.Gray, ConsoleColor.Black, False)
			Write("WARM", ConsoleColor.Green, ConsoleColor.White, True)
		ElseIf waterTemperature >= 26 And waterTemperature <= 66 Then
			Write("State of Sample Water: ", ConsoleColor.Gray, ConsoleColor.Black, False)
			Write("HOT", ConsoleColor.Yellow, ConsoleColor.Black, True)
		ElseIf waterTemperature >= 66 And waterTemperature <= 100 Then
			Write("State of Sample Water: ", ConsoleColor.Gray, ConsoleColor.Black, False)
			Write("VERY HOT", ConsoleColor.Red, ConsoleColor.White, True)
		ElseIf waterTemperature >= 100 Then
			Write("State of Sample Water: ", ConsoleColor.Gray, ConsoleColor.Black, False)
			Write("BOILING", ConsoleColor.DarkRed, ConsoleColor.White, True)
		End If
		'------------------------------------------------------------

		'------------------------------------------------------------
		Write("Are you happy with your result, " & userName & "? Y - Yes, return to main menu; N - No, re-enter my sample water temperature.", ConsoleColor.Gray, ConsoleColor.Black, True)
		inputConfirmation = Console.ReadLine()

		If inputConfirmation = "N" Then
			Write("Okay, returning to temperature input...", ConsoleColor.Gray, ConsoleColor.Black, True)
			mainProgram()
		ElseIf inputConfirmation <> "Y" Then
			Write("Invalid Option! Please make sure you typed the correct option.", ConsoleColor.Gray, ConsoleColor.Black, True)
		End If

		Write("Okay, returning to main menu...", ConsoleColor.Gray, ConsoleColor.Black, True)
		Menu()
		'------------------------------------------------------------

		Console.ReadLine()
	End Sub
	'------------------------------------------------------------

	'------------------------------------------------------------
	'Subprocedure that easily allows you to call it and write console lines with colours, reducing CLUTTER
	Public Sub Write(Text, FColour, BColour, newLine)
		Console.BackgroundColor = BColour
		Console.ForegroundColor = FColour

		If newLine Then
			Console.WriteLine(Text)
		Else
			Console.Write(Text)
		End If

		Console.ResetColor()
	End Sub
	'------------------------------------------------------------

End Module