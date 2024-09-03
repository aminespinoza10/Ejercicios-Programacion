def GetMultiples():
    firstList = []
    finalList = []
    finalValue = 0

    for counter in range(1000):
        if((counter % 3) == 0):
            firstList.append(counter)
        if((counter % 5) == 0):
            firstList.append(counter)

    finalList = list(set(firstList))

    print(finalList)

    for value in finalList:
        finalValue += value

    print(finalValue)


        
