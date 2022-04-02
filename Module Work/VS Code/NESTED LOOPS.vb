NESTED LOOPS

Sub NestLoops()

' This only does 1-10 of column J and row 10 - WHY?!
For i = 1 To 10

Cells(10, i).Value = "1"

    For j = 1 To 10
    Cells(i, 10).Value = "1"
       
    Next j
    
Next i

' This does what we want it to do, but I am not sure I REALLY understand it...
