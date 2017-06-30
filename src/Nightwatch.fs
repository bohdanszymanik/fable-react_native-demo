module Nightwatch

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.ReactNative

Program.mkProgram App.init App.update App.view
|> Program.withSubscription App.subscribe
#if DEBUG
|> Program.withConsoleTrace
|> Program.withDebugger
#endif
|> Program.withReactNative "nightwatch"
|> Program.run