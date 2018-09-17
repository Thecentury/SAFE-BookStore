module Client.Pages

open Elmish.Browser.UrlParser

/// The different pages of the application. If you add a new page, then add an entry here.
[<RequireQualifiedAccess>]
type Page =
    | Home
    | Login
    | WishList
    | Tomato
    
let toPath =
    function
    | Page.Home -> "/"
    | Page.Login -> "/login"
    | Page.WishList -> "/wishlist"
    | Page.Tomato -> "/tomato"


/// The URL is turned into a Result.
let pageParser : Parser<Page -> Page,_> =
    oneOf
        [ map Page.Home (s "")
          map Page.Login (s "login")
          map Page.WishList (s "wishlist") 
          map Page.Tomato (s "tomato")]

let urlParser location = parsePath pageParser location
