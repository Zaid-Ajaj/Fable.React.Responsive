module Program

open Elmish
open Elmish.React
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props

importAll "highlight.js/styles/ocean.css"

type State = int

let init() = 0, Cmd.none

let update msg state = state, Cmd.none

let introduction = 
    div [ ]  
        [ h1 [ Style [ FontSize 30 ] ] [ str "Fable.React.Responsive" ]
          p  [ ] [ str "Fable binding for react-responsive that is ready to use within Elmish applications" ]  
          Common.highlight """let view state dispatch = 
    div [ Style [ Padding 20 ] ]  
        [ introduction
          div [ Style [ Border "2px solid black"; Padding 20 ] ] 
              [ MediaQuery.mediaQuery 
                    [ MediaQuery.MaxWidth 400 ] 
                    [ h1 [ ] [ str "You are on mobile" ] ]
                
                MediaQuery.mediaQuery
                    [ MediaQuery.MinWidth 401; MediaQuery.MaxWidth 680 ]
                    [ h1 [ ] [ str "You are on a tablet (probably)" ]  ]
                
                MediaQuery.mediaQuery
                    [ MediaQuery.MinWidth 681 ]
                    [ h1 [ ] [ str "You are on desktop" ] ] ] ]"""
          br [ ] ]


let render (state: State) dispatch = 
    div [ Style [ Padding 20 ] ]  
        [ introduction
          h1 [ Style [ FontSize 30 ] ] [ str "Resize the screen to change the following view:" ]
          div [ Style [ Border "2px solid black"; Padding 20; BorderRadius 20 ] ] 
              [ MediaQuery.mediaQuery 
                    [ MediaQuery.MaxWidth 400 ] 
                    [ h1 [ ] [ str "You are on mobile" ] ]
                
                MediaQuery.mediaQuery
                    [ MediaQuery.MinWidth 401; MediaQuery.MaxWidth 680 ]
                    [ h1 [ ] [ str "You are on a tablet (probably)" ]  ]
                
                MediaQuery.mediaQuery
                    [ MediaQuery.MinWidth 681 ]
                    [ h1 [ ] [ str "You are on desktop" ] ] ] ]

           
Program.mkProgram init update render
|> Program.withReact "elmish-app"
|> Program.run