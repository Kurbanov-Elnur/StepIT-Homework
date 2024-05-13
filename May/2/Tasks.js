function IsNumber(value) {
    return typeof value === 'number' && !isNaN(value);
}

function IsCorrectTime(hours, minutes = 0, seconds = 0) {
    if (IsNumber(hours) && IsNumber(minutes) && IsNumber(seconds)) {
        if (hours < 0 || minutes < 0 || seconds < 0) {
            return false;
        }
        return true;
    }
    throw new Error("Invalid values!");
}

//Task1

function CompareNumbers(num1, num2) {
    if (IsNumber(num1) && IsNumber(num2)) {
        if (num1 < num2) {
            return -1;
        } else if (num1 > num2) {
            return 1;
        } else {
            return 0;
        }
    }
    throw new Error("Invalid values!");
}

//Task2

function Factorial(num) {
    if (IsNumber(num)) {
        if (num === 0 || num === 1) {
            return 1;
        } else {
            return num * Factorial(num - 1);
        }
    }
    throw new Error("Invalid value!");
}

//Task3

function CombineDigits(num1, num2, num3) {
    if (IsNumber(num1) && IsNumber(num2) && IsNumber(num3)) {
        return parseInt(num1.toString() + num2.toString() + num3.toString());
    }
    throw new Error("Invalid values!");
}

//Task4

function CalculateArea(length, width) {
    if (IsNumber(length) && IsNumber(width)) {
        if (width === undefined) {
            return length * length;
        } else {
            return length * width;
        }
    }
    throw new Error("Invalid values!");
}

//Task5

function IsPerfectNumber(num) {
    if (IsNumber(num) && num < 0) {
        let sum = 0;
        for (let i = 1; i < num; i++) {
            if (num % i === 0) {
                sum += i;
            }
        }
        return sum === num;
    }
    throw new Error("Invalid value");
}

//Task6

function FunctionindPerfectNumbers(min, max) {
    if (IsNumber(min) && IsNumber(max)) {
        if (min > max) {
            let buffer = min;
            min = max;
            max = buffer;
        }

        let perfectNumbers = [];
        for (let i = min; i <= max; i++) {
            if (IsPerfectNumber(i)) {
                perfectNumbers.push(i);
            }
        }
        return perfectNumbers;
    }
    throw new Error("Invalid values");
}

//Task7

function FormatTime(hours, minutes = 0, seconds = 0) {
    if (IsCorrectTime(hours, minutes, seconds)) {
        if (seconds > 59) {
            minutes += Math.floor(seconds / 60);
            seconds %= 60;
            if (minutes > 59) {
                hours += Math.floor(minutes / 60);
                minutes %= 60;
            }
        }
        let formattedHours = String(hours).padStart(2, '0');
        let formattedMinutes = String(minutes).padStart(2, '0');
        let formattedSeconds = String(seconds).padStart(2, '0');

        return `${formattedHours}:${formattedMinutes}:${formattedSeconds}`;
    }
    throw new Error("Invalid values");
}

//Task8

function TimeToSeconds(hours, minutes = 0, seconds = 0) {
    if (IsCorrectTime(hours, minutes, seconds)) {
        let totalSeconds = 0;
        totalSeconds += hours * 3600;
        totalSeconds += minutes * 60;
        totalSeconds += seconds;

        return totalSeconds;
    }
    throw new Error("Invalid values");
}

//Task9

function SecondsToTime(totalSeconds) {
    if (IsNumber(totalSeconds) && totalSeconds > 0) {
        let hours = Math.floor(totalSeconds / 3600);
        let minutes = Math.floor((totalSeconds % 3600) / 60);
        let seconds = totalSeconds % 60;

        let formattedHours = String(hours).padStart(2, '0');
        let formattedMinutes = String(minutes).padStart(2, '0');
        let formattedSeconds = String(seconds).padStart(2, '0');

        return `${formattedHours}:${formattedMinutes}:${formattedSeconds}`;
    }
    throw new Error("Invalid value");
}

console.log(SecondsToTime(3020));

//Task10

function DateDifference(hours1, minutes1, seconds1, hours2, minutes2, seconds2) {
    let totalSeconds1 = TimeToSeconds(hours1, minutes1, seconds1);
    let totalSeconds2 = TimeToSeconds(hours2, minutes2, seconds2);

    let differenceSeconds = Math.abs(totalSeconds1 - totalSeconds2);

    let differenceTime = SecondsToTime(differenceSeconds);

    return differenceTime;
}