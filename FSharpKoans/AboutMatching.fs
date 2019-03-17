namespace FSharpKoans
open NUnit.Framework

(*
What's a match expression?  It's a construct that uses the power of patterns
to conditionally execute code.  The first pattern (going from top to bottom) that
matches causes the associated code to be executed.  All non-matching patterns,
and any patterns after the first matching pattern, are ignored.  If no pattern
matches, then you get a MatchFailureException at runtime and you turn into a
Sad Panda.
*)

module ``04: Match expressions`` = 
    [<Test>]
    let ``01 Basic match expression`` () =
        match 8000 with
        | 8000 -> "Insufficient power-level"
        ()

    [<Test>]
    let ``02 Match expressions are expressions, not statements`` () =
        let result =
            match 9001 with
<<<<<<< HEAD
            | aa -> // <-- use an identifier pattern here!
                match aa + 1000 with
=======
            | a -> // <-- use an identifier pattern here!
                match a + 1000 with
>>>>>>> 788dc9726328927ca5077267d20171b944a97a5d
                | 10001 -> "Hah! It's a palindromic number!"
                | x -> "Some number."
            | x -> "I should have matched the other expression."
        result |> should equal "Hah! It's a palindromic number!"

    [<Test>]
    let ``03 Shadowing in match expressions`` () =
        let x = 213
        let y = 19
        match x with
        | 100 -> ()
        | 19 -> ()
        | y ->
            y |> should equal 213
            x |> should equal 213
        y |> should equal 19
        x |> should equal 213

    [<Test>]
    let ``04 Match order in match expressions`` () =
        let x = 213
        let y = 19
        let z =
            match x with
            | 100 -> "Kite"
            | 19 -> "Smite"
            | 213 -> "Bite"
            | y -> "Light"
        let a = 
            match x with
            | 100 -> "Kite"
            | 19 -> "Smite"
            | y -> "Trite"
            | 213 -> "Light"
        x |> should equal 213
        y |> should equal 19
<<<<<<< HEAD
        z |> should equal "Bite"
        a |> should equal"Trite"
=======
        z |> should equal "Light"
        a |> should equal "Trite"
>>>>>>> 788dc9726328927ca5077267d20171b944a97a5d

    [<Test>]
    let ``05 Using a mapping function`` () =
        let mapper = function
            | 3 -> "Joey" // write the cases for this function!
            | 8 -> "Bingo" // write the cases for this function!
            | 11 -> "Kelvin" // write the cases for this function!
            | _ -> "Kelvin" // write the cases for this function!
        mapper 3 |> should equal "Joey"
        mapper 8 |> should equal "Bingo"
        mapper 11 |> should equal "Kelvin"
        mapper 15 |> should equal "Kelvin"

