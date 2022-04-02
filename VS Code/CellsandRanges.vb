
## USING CELLS AND RANGES

Sub DQAnalysis()
    Worksheets("DQ Analysis").Activate

    Range("A1").Value = "DAQO (Ticker: DQ)"
    
    Cells(3, 1).Value = "Year"
    Cells(3, 2).Value = "Total Daily Volume"
    Cells(3, 3).Value = "Return"

End Sub


## USING JUST CELLS 
Sub DQAnalysis()
    Worksheets("DQ Analysis").Activate

    Cells(1,1).Value = "DAQO (Ticker: DQ)"
    
    Cells(3, 1).Value = "Year"
    Cells(3, 2).Value = "Total Daily Volume"
    Cells(3, 3).Value = "Return"
    Cells(3,4).Value = "Volume"

End Sub

## USING JUST RANGE

Sub DQAnalysis()
    Worksheets("DQ Analysis").Activate

    Range("A1").Value = "DAQO (Ticker: DQ)"
    
    Range("A3").Value = "Year"
    Range("B3").Value = "Total Daily Volume"
    Range("C3").Value = "Return"
    Range("D3").Value = "Volume"

End Sub
