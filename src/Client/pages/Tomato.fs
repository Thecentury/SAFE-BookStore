module Client.Tomato

open Style
open Fable.Helpers.React
open Fable.Helpers.React.Props

type Model = {
    Color: string
}

let init() = {
    Color = "red"
}

type Msg =
    | ChangeColor of string

let view model dispatch = [
    words 60 "Tomatoes taste VERY good!"
    words 20 (sprintf "The color of a tomato is %s" model.Color)
    br []
    button [
        ClassName ("btn btn-primary")
        OnClick (fun _ -> dispatch (ChangeColor "green"))
    ] [
        str "No, my tomatoes are green!"
    ]
]