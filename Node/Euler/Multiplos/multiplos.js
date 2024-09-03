var arrayUtility = require("arraylist");

isNumberDivisible();

var multiples = new ArrayList;

function isNumberDivisible()
{
    for(i = 1; i < 1000; i++)
    {
        if (i % 3 == 0)
        {
            multiples.add(i);
        }
        if (i % 5 == 0)
        {
            multiples.add(i);
        }
    }
}

function GetFinalSum()
{
    var finalCleanList = multiples.unique();
    finalNumber = 0;

    finalCleanList.forEach(function (element)
    {
        finalNumber += element;
    });
}

