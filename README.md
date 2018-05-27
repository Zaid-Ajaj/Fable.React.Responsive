# Fable.React.Responsive

A Fable binding for [react-responsive](https://github.com/contra/react-responsive) that is ready to use within [Elmish](https://github.com/fable-elmish/elmish) applications

## Installation
- Install this binding from nuget
```
paket add Fable.React.Responsive --project /path/to/Project.fsproj
```
- Install the actual library from npm
```
npm install react-responsive --save
```

## Usage 

[Live Demo with examples](https://zaid-ajaj.github.io/Fable.React.Responsive/)

```fs
let view state dispatch = 
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
                    [ h1 [ ] [ str "You are on desktop" ] ] ] ]
```