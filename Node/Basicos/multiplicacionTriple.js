function Multiplicate(firstNumber, secondNumber, thirdNumber) {
    var result = (firstNumber * secondNumber) * thirdNumber;
    return result;
}

var myReceivedArgs = process.argv.slice(2);
var numberOne = myReceivedArgs[0];
var numberTwo = myReceivedArgs[1];
var numberThree = myReceivedArgs[2];

var operationResult = Multiplicate(numberOne, numberTwo, numberThree);
console.log('Your result is:', operationResult);

