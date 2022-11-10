'MIS 322
'Nikita Sotnikov W01493818
'LAP 5
'18/05/2021

Option Explicit On
Option Strict On
Module Module1
    'Declare a variables
    Public numot, gop, dep, idd, falp As Integer
    Public count As Integer = 0
    Public defr, testa, num As Double
    Public random As New Random
    Public bol As Boolean
    Public test As String

    'Create a function for defect
    Public Function ProductDefect(ByVal num As Double) As Boolean
        If num <= defr Then Return True
        If num > defr Then Return False
    End Function
    'Create a function for inspection
    Public Function ProductInspection(ByVal num As Double, ByVal bol As Boolean) As String
        If bol = True And testa >= num Then Return "found defect"
        If bol = True And testa < num Then Return "missed defect"
        If bol = False And testa <= num Then Return "false positive"
        If bol = False And testa > num Then Return "no defect"
    End Function
End Module
