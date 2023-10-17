Public Class frmMain

    'Program Name: Academic Letter Generator
    'Author: Jacob Gosling
    'Description: Creates a list of student names and whether they require a commendation letter, no letter or an at risk letter.
    'Author Note: Was the amount of documenation necessary, maybe not, however it is very easy to understand now.


    Dim intPercentage As Integer = 0
    Dim strLetter As String = ""
    Dim intI As Integer = 0
    Dim strUserName As String = ""
    Dim strTempName As String = ""
    Dim intNumber As Integer
    Dim dblTempNum As Double = 0
    Dim intIterations As Integer = 0

    Sub Letter()
        If IsNumeric(strTempName) = True Then 'Makes sure that the input is a number to prevent crashes, because it is an integer it will round the number
            Select Case intNumber
                Case 0 To 20 : strTempName = " - Produce At Risk Letter" 'This is later added onto the line for each student if their scores are below or equal to 20
                Case 21 To 80 : strTempName = " - Produce No Letter" 'This is later added onto the line if their score is between 20 and 79
                Case 81 To 100 : strTempName = " - Produce Commendation Letter" 'This is added on if the grade is above 80
            End Select
        End If
    End Sub

    Sub AskName()
        intI = 1 'Resets the counter
        strUserName = "" 'Resets the strUserName string for use again
        strTempName = "" 'Resets the strTempName string which is used for validation before adding to the strUserName string
        If String.IsNullOrEmpty(txtIterations.Text) = True Or IsNumeric(txtIterations.Text) = False Then
            txtIterations.Focus() 'Focus the cursor on the text box to make editing easier
            MessageBox.Show("Please enter the number of iterations.") 'Message box to warn the user
        ElseIf txtIterations.Text < 1 Or txtIterations.Text > 10 Then 'Makes sure the value of txtIteration is between 1 and 10
            txtIterations.Focus() 'Focus the cursor on the text box to make editing easier
            MessageBox.Show("Number of iterations must be between 1 and 10.") 'Message box to warn the user
        Else
            intIterations = txtIterations.Text 'Sets the value of the intIterations variable to the value of txtIterations which has already been validated as an integer it will round the input to the nearest whole number
            For i = 1 To intIterations 'Begins a For Loop which will run for x iterations where x is equal to the value of the number inside the txtIterations box before executing the next code
                strTempName = InputBox("First Name:", "Enter First Name", "") 'Opens an input box which asks for the first name
                Do While String.IsNullOrEmpty(strTempName) = True Or IsNumeric(strTempName) = True 'Checks that the input exists and is not a number
                    strTempName = InputBox("First Name:", "Please Reenter First Name", "") 'If the input is invalid the user is asked for their information again
                Loop
                strUserName &= strTempName 'Adds the strTempName string to the strUserName string without replacing it
                strTempName = InputBox("Last Name:", "Enter Last Name", "") 'Opens an input box which asks for the last name
                Do While String.IsNullOrEmpty(strTempName) = True Or IsNumeric(strTempName) = True 'Checks for validation on the last name
                    strTempName = InputBox("Last Name:", "Please Reenter Last Name", "") 'Reasks for information if it is invalid
                Loop
                strUserName &= " " & strTempName 'Adds the last name to the string adding space between, because the string is replaced before it does not need to be reset
                strTempName = InputBox("Grade:", "Enter Grade", "") 'Asks for the grade of the user
                dblTempNum = 0
                If IsNumeric(strTempName) = True And String.IsNullOrEmpty(strTempName) Then 'Makes sure that strTempName is a number and not empty before setting dblTempNum to it
                    dblTempNum = strTempName 'Sets the double variable to the value of the grade
                End If
                Do While dblTempNum < 0 Or dblTempNum > 100 Or String.IsNullOrEmpty(strTempName) = True Or IsNumeric(strTempName) = False 'Checks if the dblTempNum variable is below zero or above 100 and if strTempName is empty or not a number
                    strTempName = InputBox("Grade:", "Please Reenter Grade", "")
                    If IsNumeric(strTempName) = True Then 'Makes sure that the new input is numeric before setting dblTempNum to it to prevent crashes
                        dblTempNum = strTempName 'Sets dblTempNum to strTempName after validating it's a number
                    End If
                Loop
                intNumber = strTempName 'Sets the intNumber integer which is used for the Letter Sub
                strUserName &= ": " & intNumber 'Adds the grade to the list
                Call Letter() 'Calls (runs) the Letter Sub
                strUserName &= strTempName 'Adds the letter recommendation to the row
                strUserName &= vbCrLf 'Creates a new line for future iterations
            Next
            MessageBox.Show(strUserName) 'Shows the final result
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click 'Runs the inside code when the btnCreate button is pressed
        Call AskName() 'Runs the grade getting code when the button is pressed
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End 'Exits the program
    End Sub
End Class
