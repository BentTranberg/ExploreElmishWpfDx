namespace ExploreElmishWpfDx.Models

module MainWindow =

    open System
    open System.Windows
    open Elmish
    open Elmish.WPF

    type Message =
        | ButtonClick

    type Model =
        {
            LabelText: string
        }

    let init () =
        {
            LabelText = "Anybody here?"
        }, Cmd.none

    let update message model =
        match message with
        | ButtonClick -> { model with LabelText = "Oh, hello!" }, Cmd.none

    let bindings (model: Model) dispatch : Binding<Model, Message> list =
        [
            "ButtonClick" |> Binding.cmd (fun _ -> ButtonClick)
            "LabelContent" |> Binding.oneWay (fun m -> m.LabelText)
        ]

    let entryPoint (_: string[], mainWindow: Window) =
        Program.mkProgram init update bindings
        |> Program.runWindowWithConfig
            { ElmConfig.Default with LogTrace = true; Measure = true; MeasureLimitMs = 1 }
            mainWindow
