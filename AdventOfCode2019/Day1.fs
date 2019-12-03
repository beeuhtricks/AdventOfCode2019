module Day1

open System.IO

let modules = Seq.map (fun line -> line |> int) (File.ReadLines("Day1.txt"))

let fuelForMass mass = mass / 3 - 2

let totalFuel moduleMass = 
    let rec loop remainingMass totalMass = 
        if remainingMass <= 0 
        then totalMass
        else loop (fuelForMass remainingMass) (totalMass + remainingMass)
    loop (fuelForMass moduleMass) 0

let problem1 : int = Seq.map fuelForMass modules |> Seq.sum

let problem2 : int = Seq.map totalFuel modules |> Seq.sum