"use strict";
var i = 15;
var nom = '"pie\'rre"' + i + 'eric';
var j = "20";
var z = parseInt("12 lapins");
var u = parseFloat("12.6");
console.log(z);
console.log(i / 0);
console.log(j + i);
console.log(nom);

var h = 10;
function f1(f, g, h) {
    if (typeof (f) == 'number')//string, object, function, boolean
        f += 1;
    if (h == undefined) h = window.h;
    g = typeof (g) == 'undefined' ? "" : g;
    console.log(f + g + h);
}

f1(12, 45, 10);
f1("12", 45, 10);
f1("hello", "world");

var t = new Array();
var t1 = [];
console.log(t instanceof Array);
console.log(t1 instanceof Array);
console.log(Array.prototype);
console.log(Object.prototype);

var o1 = {
    nom: "Jean",
    age: 12,
    affiche: function () {
        console.log(this.toString());
    },
    toString: function () {
        return this.nom + ' a ' + this.age + ' ans.'
    }
};
console.log(o1.nom);
o1.affiche();
console.log(o1.toString());
o1.prenom = "paul";
o1.toString = function () {
    return this.nom + ' ' + this.prenom + ' a ' + this.age + ' ans.'
};
o1.affiche();
var o2 = o1;
o1.prenom = "john";
o2.affiche();

var Chien = function (nom = "RTP") {
    this.setNom(nom);
};
Chien.prototype.setNom = function (nom) {
    this.nom = nom;
};
Chien.prototype.getNom = function () {
    return this.nom;
};
var milou = new Chien();
console.log(milou.getNom());
milou.setNom("milou");
console.log(milou.getNom());
console.log(milou.constructor);
var bill = new Chien("Bill");
console.log(bill.getNom());
var Bulldog = function (nom = "RTP", dangereux = false) {
    Chien.call(this, nom);
    this.setDangereux(dangereux);
};
Bulldog.prototype = Object.create(Chien.prototype);
Bulldog.prototype.constructor = Bulldog;
Bulldog.prototype.setDangereux = function (dangereux) {
    this.dangereux = dangereux;
};
Bulldog.prototype.getDangereux = function () {
    return this.dangereux;
};
var french = new Bulldog("Marcel");
console.log(french.getNom());
console.log(french.getDangereux());
console.log(french instanceof Chien);
var product = {
    name: "pommes",
    price: 4
};
function afficher(tva) {
    if (typeof (tva) == 'undefined')
        console.log(this.name + " vaut " + this.price);
    else
        console.log(this.name + " vaut " + this.price * (1 + tva));
}
afficher.call(product);
afficher.call(product, 0.20);
afficher.apply(product, [0.10]);
french.dangereux = "maman";//!!!
console.log(french.getDangereux());
console.clear();
var Personne = function (nom) {
    var _nom = nom;
    return {
        getNom: function () {
            return _nom;
        }
    };
};
var lui = new Personne("lui");
console.log(lui.getNom());
console.log(lui instanceof Personne);//false!!

var Lapin = (function () {
    var _nom;
    function Lapin(nom) {
        this.setNom(nom);
    }
    Lapin.prototype.getNom = function () {
        return _nom;
    }
    Lapin.prototype.setNom = function (nom) {
        if (typeof (nom) == "string")
            _nom = nom;
        else
            throw "un joli nom svp";
    }
    return Lapin;
}());
var pin = new Lapin("pin");
console.log(pin.getNom());//pin

//pin.setNom(); Exception

console.log(pin instanceof Lapin);

console.clear();

var tab = ["A", "B"];
var tabo = { 0: "A", 1: "B" }
console.log(tab[0]);
console.log(tabo[0]);
tabo[2] = "C";
console.log(tabo[2]);
tab[4] = "F";
tab["lapin"] = "Lapin";
console.log(tab);
console.log(tab.lapin);
console.log("+++++++++++++++++++");
for (var i = 0; i < tab.length; i++) {
    console.log(tab[i]);
}
console.log("-----------------------");
for (var i in tab) {
    console.log(tab[i]);
}
console.log(tab.push("G", "H"));
console.log(tab.shift());
console.log(tab.pop());
tab.splice(1, 2, "C")
console.log(tab);
