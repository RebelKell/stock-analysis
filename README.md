# Stock Analysis

## Overview
Our firm was hired by Steve to analyze the performance of green stocks (that is, environmentally friendly businesses like renewable energy) so that he may provide guidance to his clients on which stocks they should invest in. 
<br>
<br>
To do this analysis we looked at data from the years 2017 and 2018 that showed  information about 12 different stocks including their open and close price, high and low price, adjusted close price and total volume of trades made daily throughout the year. 
<br>
<br>
Our analysis focused on two key metrics:
<br>
<br>
### **Total Daily Volume**
The total number of shares traded throughout the day; it measures how actively a stock is traded.
<br>

### **Yearly Return**
This measures the percentage increase or decrease in price over the year indicating how much an investment either grew or shrunk. 
<br>
<br>
By evaluating these two metrics we are confident that Steve can provide insight to his clients on which stocks are best to invest in.
<br>
<br>


## Approach


### The Code
For this analysis we knew that we would have to run through all the lines of the data and perform some analysis (sums, comparisons, etc.) so we used for loops, nested for loops and conditionals to systematically run through the data to pull the outcomes we needed. 

Our approach to writing the code was to first map out what we needed that code to do before diving into actually writing it. This helped us take a step-by-step approach, knowing what we had to solve for. 

We did two passes at writing this code. The first pass was to get the data the "simplest" way by hard coding some of the variables like which spreadsheet or ticket to evaluate. In our refactored code we leveraged an indices and arrays to tell the code what to look for adding effiency to the code, allowing it run faster. 

[Adding Indices and Arrays](LINK)

The first pass code took, on average, 0.61 seconds to run while the refactored code took an average of 0.11 seconds across the 2017 and 2018 analysis - an 81% decrease! 

We also wrote readable code so in the event that our customer comes back for additional analysis we can reuse the code we have already written with some minor changes to fit a separate dataset.

## Results

### The Analysis
In general, 2017 was a strong year for the 12 green stocks we evaluated - all but one had a positive return, with four stocks having a returns over 100%. DQ and SEDG performed the best in 2017 with 199.4% and 184.5% returns, respectively - a very solid investment! However, we have the benefit of year-over-year data and things changed quite drastically in 2018 with DQ and SEDG both seeing negative returns. In fact, 2018 was a bad year for almost all of the twelve stocks we analyzed with only two seeing positive returns. The only two stocks that saw positive returns two years in a row were ENPH and RUN. These two stocks also saw a more than two-fold increase in trading volume from 2017 to 2018, indicating a greater interest in these two companies. The ENPH stock did dip between 2017 and 2018, but still showed solid returns,  with RUN seeing a 1427% increase in returns, year-over-year. 

[Returns Year-over-Year](LINK)

Based on this two-year analysis, the ENPH and RUN stocks seem like the safest investments with RUN having the biggest upside. Depending on Steve's clients risk tolerance, we would recommend staying away from all of the other stocks until more information about their performance is known. 


## Summary

### Avantages and disadvantages of refactoring code
Refactored code is typically more efficient and potentially more logical than a first attempt at code. 

Some of th disadvantages is that it introduces the potential for human/keystroke errors. If you have code that is well written, runs well and accomplishes it's goal there may not be much of a reason to refactor the code because you may end up breaking it and spending more time trying to fix it. It is worth considering *why* you want to refactor your code before actually doing it - for example; is a 5% increase in efficiency worth the time and testing it takes to refactor the code?

### Advantages and disadvantages of the original and refactored VBA script
In this case, our refactored code ran faster (82% faster!) so when used with a larger data set this could save our clients a lot of time. While this code is more efficient, for a novice coder intoducing indices and arrays can be a bit difficult to comprehend at first. 

