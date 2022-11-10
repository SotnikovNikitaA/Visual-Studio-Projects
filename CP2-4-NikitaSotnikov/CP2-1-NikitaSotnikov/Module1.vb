'MIS 322
'Nikita Sotnikov 
'CP2-4 W01493818
'27/05/2021

Option Explicit On
Option Strict On
Module Module1
    'Declare variables for future calculations
    Public prov, dop, inc, term, inr As Double
    Public usnam, pas, curuse, st As String
    Public perm As Integer = 0
    'Make a loan approval independent function
    Public Function LoanApproval(ByVal prov As Double, ByVal dop As Double,
                                 ByVal inc As Double, ByVal term As Double,
                                 ByVal inr As Double, ByVal st As String) As Boolean
        Dim moni, loan As Double

        loan = (prov - dop)
        moni = Financial.Pmt(inr, term, -loan)

        'If everything is OK then form will approved
        If moni > (0.25 * inc) Then
            Return False
        ElseIf loan > (0.8 * prov) And (st = "Washington" Or st = "Oregon") Then
            Return False
        ElseIf loan > (0.9 * prov) And st = "California" Then
            Return False
        Else
            Return True
        End If
    End Function

End Module
