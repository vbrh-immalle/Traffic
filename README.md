# Intro

Dit is een voorbeeld van OOP technieken in C#.

Het "verhaal" is:

- Er zijn `Vehicle`'s (`Car`'s, `Bike`'s en `Truck`'s)
- Elk `Vehicle` heeft een aantal `Tire`'s
- Er zijn garages waar je `Vehicle`'s kan kopen : `Dealership`'s
- Er zijn `ServiceGarage`'s waar je `Tire`'s kan laten controleren en vervangen

> Probeer zelf in de `Main`-method om nieuwe `Vehicle`'s te maken en de `Tire`
te checken en te vervangen.



# OOP technieken

De `Vehicle`'s demonstreren:

- met `nrOfTires`: het aanroepen van constructors v.d. base-class met een
literal
- met `description`: het aanroepen van constructors v.d. base-class d.m.v. het
doorgeven v.e. parameter

`Dealership` is een abstracte class.

De classes die overerven van `Dealership` demonstreren het overriden van een
abstracte method (`BuyVehicle()` en `BuyVehicle(string description)`).

De `Dealership`'s demonstreren met `BuyVehicle()` het overloaden van
methods. Er zijn namelijk 2 methods met dezelfde naam maar met andere parameters:

- `Vehicle BuyVehicle()`
- `Vehicle BuyVehicle(string description)`

De `Description` van een `Vehicle` demonstreert een property die publiek
gewijzigd kan worden. Het idee hierachter is dat de omschrijving v.e. auto
later kan worden aangepast, b.v. als de auto wordt verkocht. 
Voor het gemak maken we gebruik v.e. *auto property*.

De `List<Tire>` demonstreert *compositie* : een class die objecten van een
andere class als member heeft. Een `Vehicle` heeft nl. een `List<Tire>`.

De `ToString()`-method van `Tire` demonstreert overriden het van een method v.d.
base-class `Object`.

De `AmountOfKilometerRolled`-property van `Tire` demonstreert een get-property.
Ze wordt nuttig gebruikt in `CheckTires(...)` van `ServiceGarage`.

De method `Drive(...)` van `Vehicle` is **virtual**. Momenteel doen we hier nog
niets mee maar dit maakt het dus mogelijk dat `Drive(...)` wordt **overridden**
in `Car`, `Bike`, `Truck` of een ander toekomstig `Vehicle`.



# Code stijl

`CreateTires()` in `Vehicle` (en ook `ReplacesOneTire(...)` in `ServiceGarage`)
demonstreert het nut van compacte functies:

- zelf-documenterend
- goed leesbaar

> Een goede functie (of dus ook method/constructor/...) is zo klein mogelijk en
doet maar 1 ding (en doet dat 1 ding goed!). In deze voorbeelden worden deze
functies *private* gemaakt omdat ze niet van buiten uit beschikbaar moeten zijn.

`Description` is een (publiek toegankelijke) property van `Vehicle` en
schrijven we dus met een hoofdletter.

> Publiek toegankelijke members schrijven we (in navolging van de stijl van de
DotNet-library zelf) met hoofdletters.
> Private members schrijven we met een kleine letter (sommigen voegen zelfs nog
het prefix `_` toe).

Sommige methods zijn **private** omdat ze enkel binnen een class gebruikt
worden, b.v. 

- `ReplaceOneTire(...)` in `ServiceGarage`
- `CreateTires()` in `Vehicle`


# Opmerkingen

Bij het vervangen van een `Tire` zou de fout-afhandeling nog beter kunnen, b.v.
als de `ServiceGarage` geen banden meer heeft.
