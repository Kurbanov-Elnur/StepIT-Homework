//Task1 

var car = {
    brand: "Toyota",
    model: "Camry",
    year: 2022,
    color: "silver",
    transmission: "automatic",
    features: ["GPS", "Bluetooth", "Keyless Entry"],
    averageSpeed: 150,

    display: function () {
        console.log(`Brand: ${this.brand}`);
        console.log(`Model: ${this.model}`);
        console.log(`Year: ${this.year}`);
        console.log(`Color: ${this.color}`);
        console.log(`Transmission: ${this.transmission}`);

        for (let index = 0; index < this.features.length; index++) {
            console.log(`Features: ${this.features[index]}`);
        }
        console.log(`Average speed: ${this.averageSpeed}`);
    },
    calculateTravelTime: function(distance) {
        var timeWithoutBreaks = distance / this.averageSpeed;

        var breaks = Math.floor(timeWithoutBreaks / 4);

        var totalTime = timeWithoutBreaks + breaks;

        console.log(`Total time: ${totalTime}`);
    }
}

//Task2


