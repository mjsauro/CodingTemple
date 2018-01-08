function Car(make, model, year) {
    this.make = make;
    this.model = model;
    this.year = year;
}

var car1 = new Car("Honda", "Civic", 2003);

var car2 = new Car("Geo", "Prism", 1991);

Car.prototype.fuelTank = 100;

Car.prototype.refuel = function() {
    this.fuelTank = 100;
};



Car.prototype.drive = function() {
    
    this.fuelTank = this.fuelTank - 10;
    
    if (this.fuelTank == 0) {
        alert("Out of gas");
    }
}
