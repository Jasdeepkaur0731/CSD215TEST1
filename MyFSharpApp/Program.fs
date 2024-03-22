open System

// Mapping, Filtering through Lists
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

//Function that uses salary to determine federal income tax
let calculateTax salary =
    match salary with
    | s when s <= 49020 -> float s * 0.15
    | s when s <= 98040 -> float s * 0.205
    | s when s <= 151978 -> float s * 0.26
    | s when s <= 216511 -> float s * 0.29
    | _ -> float salary * 0.33

// Filter high-income salaries
let highIncomeSalaries = salaries |> List.filter (fun s -> s > 100000)

// Calculation of  tax for all salaries
let taxes = salaries |> List.map calculateTax

// Add $20,000 to salaries less than $49,020
let adjustedSalaries = salaries |> List.map (fun s -> if s < 49020 then s + 20000 else s)

// Sum salaries between $50,000 and $100,000
let totalSalarySum = salaries |> List.filter (fun s -> s >= 50000 && s <= 100000) |> List.sum

// Tail Recursion
let rec sumMultiplesOfThree n acc =
    if n = 0 then acc
    else sumMultiplesOfThree (n - 3) (acc + n)

// Testing the Tail Recursion function
let result = sumMultiplesOfThree 27 0

// Output results
printfn "High-Income Salaries: %A" highIncomeSalaries
printfn "Taxes for each salary: %A" taxes
printfn "Adjusted Salaries: %A" adjustedSalaries
printfn "Total Salary Sum between $50,000 and $100,000: %d" totalSalarySum
printfn "Sum of Multiples of Three up to 27: %d" result