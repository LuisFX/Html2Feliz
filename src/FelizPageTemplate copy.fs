
namespace FelizPage

open Feliz

module rec Page =

    [<ReactComponent>]
    let Page () =
        React.fragment [
            Html.html [
                prop.lang "en"
                prop.children [
                    Html.head [
                        Html.meta [
                            prop.charset "utf-8"
                        ]
                        Html.meta [
                            prop.name "viewport"
                            prop.content "width=device-width, initial-scale=1, shrink-to-fit=no"
                        ]
                        Html.meta [
                            //prop.ariaHaspopup "x-ua-compatible"
                            prop.content "ie=edge"
                        ]
                        Html.title "Huro :: ActionPage"
                        Html.link [
                            prop.rel "icon"
                            prop.type' "image/png"
                            prop.href "assets/img/favicon.png"
                        ]
                        //Html.script " ; (function(w, d, s, l, i) { w[l] = w[l] || [] w[l].push({ 'gtm.start': new Date().getTime(), event: 'gtm.js' }) var f = d.getElementsByTagName(s)[0], j = d.createElement(s), dl = l != 'dataLayer' ? '&l=' + l : '' j.async = true j.src = 'https://www.googletagmanager.com/gtm.js?id=' + i + dl f.parentNode.insertBefore(j, f) })(window, document, 'script', 'dataLayer', 'GTM-N8ZNRQ9') "
                        Html.link [
                            prop.rel "stylesheet"
                            prop.href "assets/css/app.css"
                        ]
                        Html.link [
                            prop.rel "stylesheet"
                            prop.href "assets/css/main.css"
                        ]
                        Html.link [
                            prop.href "https://fonts.googleapis.com/css2?family=Montserrat:wght@500;600;700;800;900&display=swap"
                            prop.rel "stylesheet"
                        ]
                        Html.link [
                            prop.href "https://fonts.googleapis.com/css?family=Roboto:300,400,500,600,700"
                            prop.rel "stylesheet"
                        ]
                    ]
                    Html.body [
                        Html.noscript [
                            Html.iframe [
                                prop.src "https://www.googletagmanager.com/ns.html?id=GTM-N8ZNRQ9"
                                prop.height 0
                                prop.width 0
                                prop.style [ style.display none; style.visibility hidden ]
                            ]
                        ]
                        Html.div [
                            prop.className "app-wrapper"
                            prop.id "huro-app"
                            prop.children [
                                Html.div [
                                    prop.className "app-overlay"
                                ]
                                Html.div [
                                    prop.classes [ "pageloader"; "is-full" ]
                                ]
                                Html.div [
                                    prop.classes [ "infraloader"; "is-full"; "is-active" ]
                                ]
                                Html.nav [
                                    prop.ariaLabel "main navigation"
                                    prop.classes [ "navbar"; "mobile-navbar"; "no-shadow"; "is-hidden-desktop"; "is-hidden-tablet" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "container"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-brand"
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "brand-start"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-burger"
                                                                    prop.children [
                                                                        Html.span []
                                                                        Html.span []
                                                                        Html.span []
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-brand" ]
                                                            prop.href "index.html"
                                                            prop.children [
                                                                Html.img [
                                                                    prop.className "light-image"
                                                                    prop.src "assets/img/logos/logo/logo.svg"
                                                                    prop.alt ""
                                                                ]
                                                                Html.img [
                                                                    prop.className "dark-image"
                                                                    prop.src "assets/img/logos/logo/logo-light.svg"
                                                                    prop.alt ""
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "brand-end"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "navbar-item"; "has-dropdown"; "is-notification"; "is-hidden-tablet"; "is-hidden-desktop" ]
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-link"; "is-arrowless" ]
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    //prop.dataFeather "bell"
                                                                                ]
                                                                                Html.span [
                                                                                    prop.classes [ "new-indicator"; "pulsate" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.classes [ "navbar-dropdown"; "is-boxed"; "is-right" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "heading"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "heading-left"
                                                                                            prop.children [
                                                                                                Html.h6 [
                                                                                                    prop.className "heading-title"
                                                                                                    prop.text "Notifications"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "heading-right"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.className "notification-link"
                                                                                                    prop.href "#"
                                                                                                    prop.text "See all"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.classes [ "inner"; "has-slimscroll" ]
                                                                                    prop.children [
                                                                                        Html.ul [
                                                                                            prop.className "notification-list"
                                                                                            prop.children [
                                                                                                Html.li [
                                                                                                    Html.a [
                                                                                                        prop.className "notification-item"
                                                                                                        prop.children [
                                                                                                            Html.div [
                                                                                                                prop.className "img-left"
                                                                                                                prop.children [
                                                                                                                    Html.img [
                                                                                                                        prop.className "user-photo"
                                                                                                                        prop.alt ""
                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/7.jpg"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                            Html.div [
                                                                                                                prop.className "user-content"
                                                                                                                prop.children [
                                                                                                                    Html.p [
                                                                                                                        prop.className "user-info"
                                                                                                                        prop.children [
                                                                                                                            Html.span [
                                                                                                                                prop.className "name"
                                                                                                                                prop.text "Alice C."
                                                                                                                            ]
                                                                                                                            Html.text " left a comment."
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.p [
                                                                                                                        prop.className "time"
                                                                                                                        prop.text "1 hour ago"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.li [
                                                                                                    Html.a [
                                                                                                        prop.className "notification-item"
                                                                                                        prop.children [
                                                                                                            Html.div [
                                                                                                                prop.className "img-left"
                                                                                                                prop.children [
                                                                                                                    Html.img [
                                                                                                                        prop.className "user-photo"
                                                                                                                        prop.alt ""
                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/12.jpg"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                            Html.div [
                                                                                                                prop.className "user-content"
                                                                                                                prop.children [
                                                                                                                    Html.p [
                                                                                                                        prop.className "user-info"
                                                                                                                        prop.children [
                                                                                                                            Html.span [
                                                                                                                                prop.className "name"
                                                                                                                                prop.text "Joshua S."
                                                                                                                            ]
                                                                                                                            Html.text " uploaded a file."
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.p [
                                                                                                                        prop.className "time"
                                                                                                                        prop.text "2 hours ago"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.li [
                                                                                                    Html.a [
                                                                                                        prop.className "notification-item"
                                                                                                        prop.children [
                                                                                                            Html.div [
                                                                                                                prop.className "img-left"
                                                                                                                prop.children [
                                                                                                                    Html.img [
                                                                                                                        prop.className "user-photo"
                                                                                                                        prop.alt ""
                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/13.jpg"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                            Html.div [
                                                                                                                prop.className "user-content"
                                                                                                                prop.children [
                                                                                                                    Html.p [
                                                                                                                        prop.className "user-info"
                                                                                                                        prop.children [
                                                                                                                            Html.span [
                                                                                                                                prop.className "name"
                                                                                                                                prop.text "Tara S."
                                                                                                                            ]
                                                                                                                            Html.text " sent you a message."
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.p [
                                                                                                                        prop.className "time"
                                                                                                                        prop.text "2 hours ago"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.li [
                                                                                                    Html.a [
                                                                                                        prop.className "notification-item"
                                                                                                        prop.children [
                                                                                                            Html.div [
                                                                                                                prop.className "img-left"
                                                                                                                prop.children [
                                                                                                                    Html.img [
                                                                                                                        prop.className "user-photo"
                                                                                                                        prop.alt ""
                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/25.jpg"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                            Html.div [
                                                                                                                prop.className "user-content"
                                                                                                                prop.children [
                                                                                                                    Html.p [
                                                                                                                        prop.className "user-info"
                                                                                                                        prop.children [
                                                                                                                            Html.span [
                                                                                                                                prop.className "name"
                                                                                                                                prop.text "Melany W."
                                                                                                                            ]
                                                                                                                            Html.text " left a comment."
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.p [
                                                                                                                        prop.className "time"
                                                                                                                        prop.text "3 hours ago"
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "dropdown"; "is-right"; "is-spaced"; "dropdown-trigger"; "user-dropdown" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            //prop.ariaHaspopup "true"
                                                                            prop.className "is-trigger"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "profile-avatar"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/8.jpg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.className "dropdown-menu"
                                                                            prop.role "menu"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "dropdown-content"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "dropdown-head"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.classes [ "h-avatar"; "is-large" ]
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "avatar"
                                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/8.jpg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "meta"
                                                                                                    prop.children [
                                                                                                        Html.span "Erik Kovalsky"
                                                                                                        Html.span "Product Manager"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.classes [ "dropdown-item"; "is-media" ]
                                                                                            prop.href "#"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "icon"
                                                                                                    prop.children [
                                                                                                        Html.i [
                                                                                                            prop.classes [ "lnil"; "lnil-user-alt" ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "meta"
                                                                                                    prop.children [
                                                                                                        Html.span "Profile"
                                                                                                        Html.span "View your profile"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.classes [ "dropdown-item"; "is-media"; "layout-switcher" ]
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "icon"
                                                                                                    prop.children [
                                                                                                        Html.i [
                                                                                                            prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "meta"
                                                                                                    prop.children [
                                                                                                        Html.span "Layout"
                                                                                                        Html.span "Switch to admin/webapp"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.hr [
                                                                                            prop.className "dropdown-divider"
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.classes [ "dropdown-item"; "is-media" ]
                                                                                            prop.href "#"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "icon"
                                                                                                    prop.children [
                                                                                                        Html.i [
                                                                                                            prop.classes [ "lnil"; "lnil-briefcase" ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "meta"
                                                                                                    prop.children [
                                                                                                        Html.span "Projects"
                                                                                                        Html.span "All my projects"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.classes [ "dropdown-item"; "is-media" ]
                                                                                            prop.href "#"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "icon"
                                                                                                    prop.children [
                                                                                                        Html.i [
                                                                                                            prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "meta"
                                                                                                    prop.children [
                                                                                                        Html.span "Team"
                                                                                                        Html.span "Manage your team"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.hr [
                                                                                            prop.className "dropdown-divider"
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.classes [ "dropdown-item"; "is-media" ]
                                                                                            prop.href "#"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "icon"
                                                                                                    prop.children [
                                                                                                        Html.i [
                                                                                                            prop.classes [ "lnil"; "lnil-cog" ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "meta"
                                                                                                    prop.children [
                                                                                                        Html.span "Settings"
                                                                                                        Html.span "Account settings"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.hr [
                                                                                            prop.className "dropdown-divider"
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "dropdown-item"; "is-button" ]
                                                                                            prop.children [
                                                                                                Html.button [
                                                                                                    prop.classes [ "button"; "h-button"; "is-primary"; "is-raised"; "is-fullwidth"; "logout-button" ]
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "log-out"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Logout"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "mobile-main-sidebar"
                                    prop.children [
                                        Html.div [
                                            prop.className "inner"
                                            prop.children [
                                                Html.ul [
                                                    prop.className "icon-side-menu"
                                                    prop.children [
                                                        Html.li [
                                                            Html.a [
                                                                prop.href "/admin-dashboards-personal-1.html"
                                                                prop.id "home-sidebar-menu-mobile"
                                                                prop.children [
                                                                    Html.i [
                                                                        //prop.dataFeather "activity"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a [
                                                                prop.href "/admin-grid-users-1.html"
                                                                prop.id "layouts-sidebar-menu-mobile"
                                                                prop.children [
                                                                    Html.i [
                                                                        //prop.dataFeather "grid"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a [
                                                                prop.href "/elements-hub.html"
                                                                prop.id "elements-sidebar-menu-mobile"
                                                                prop.children [
                                                                    Html.i [
                                                                        //prop.dataFeather "box"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a [
                                                                prop.href "/components-hub.html"
                                                                prop.id "components-sidebar-menu-mobile"
                                                                prop.children [
                                                                    Html.i [
                                                                        //prop.dataFeather "cpu"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a [
                                                                prop.href "/messaging-chat.html"
                                                                prop.id "open-messages-mobile"
                                                                prop.children [
                                                                    Html.i [
                                                                        //prop.dataFeather "message-circle"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.ul [
                                                    prop.className "bottom-icon-side-menu"
                                                    prop.children [
                                                        Html.li [
                                                            Html.a [
                                                                prop.className "right-panel-trigger"
                                                                //prop.dataPanel "search-panel"
                                                                prop.href "javascript:"
                                                                prop.children [
                                                                    Html.i [
                                                                        //prop.dataFeather "search"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a [
                                                                prop.href "#"
                                                                prop.children [
                                                                    Html.i [
                                                                        //prop.dataFeather "settings"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "webapp-navbar"
                                    prop.children [
                                        Html.div [
                                            prop.className "webapp-navbar-inner"
                                            prop.children [
                                                Html.div [
                                                    prop.className "left"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "brand"
                                                            prop.href "/"
                                                            prop.children [
                                                                Html.img [
                                                                    prop.className "light-image"
                                                                    prop.src "assets/img/logos/logo/logo.svg"
                                                                    prop.alt ""
                                                                ]
                                                                Html.img [
                                                                    prop.className "dark-image"
                                                                    prop.src "assets/img/logos/logo/logo-light.svg"
                                                                    prop.alt ""
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "separator"
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "dropdown"; "project-dropdown"; "dropdown-trigger"; "is-spaced" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "h-avatar"; "is-small" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.classes [ "avatar"; "is-fake"; "is-h-green" ]
                                                                            prop.children [
                                                                                Html.span "H"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.className "status-indicator"
                                                                ]
                                                                Html.div [
                                                                    prop.className "dropdown-menu"
                                                                    prop.role "menu"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "dropdown-content"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "dropdown-block"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.classes [ "avatar"; "is-fake"; "is-warning" ]
                                                                                                    prop.children [
                                                                                                        Html.span "D"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.className "dark-inverted"
                                                                                                    prop.text "Delivery App Project"
                                                                                                ]
                                                                                                Html.span "Food For Good"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "dropdown-block"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.classes [ "avatar"; "is-fake"; "is-h-green" ]
                                                                                                    prop.children [
                                                                                                        Html.span "H"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.className "dark-inverted"
                                                                                                    prop.text "Health and Fitness Dashboard"
                                                                                                ]
                                                                                                Html.span "Fit'n'Dance"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "dropdown-block"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.classes [ "avatar"; "is-fake"; "is-info" ]
                                                                                                    prop.children [
                                                                                                        Html.span "L"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.className "dark-inverted"
                                                                                                    prop.text "Learning Tracker Dashboard"
                                                                                                ]
                                                                                                Html.span "Fit'n'Dance"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "dropdown-block"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.classes [ "avatar"; "is-fake"; "is-h-purple" ]
                                                                                                    prop.children [
                                                                                                        Html.span "B"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.className "dark-inverted"
                                                                                                    prop.text "Banking and Finance Dashboard"
                                                                                                ]
                                                                                                Html.span "H Bank"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.h1 [
                                                            prop.classes [ "title"; "is-5" ]
                                                            prop.id "webapp-page-title"
                                                            prop.text "Welcome"
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "center"
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "centered-links"
                                                            prop.id "webapp-navbar-menu"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "centered-link"; "centered-link-toggle" ]
                                                                    //prop.dataMenuId "dashboards-webapp-menu"
                                                                    prop.id "dashboards-navbar-menu"
                                                                    prop.children [
                                                                        Html.i [
                                                                            //prop.dataFeather "activity"
                                                                        ]
                                                                        Html.span "Dashboards"
                                                                    ]
                                                                ]
                                                                Html.a [
                                                                    prop.classes [ "centered-link"; "centered-link-toggle" ]
                                                                    //prop.dataMenuId "layouts-webapp-menu"
                                                                    prop.id "layouts-navbar-menu"
                                                                    prop.children [
                                                                        Html.i [
                                                                            //prop.dataFeather "grid"
                                                                        ]
                                                                        Html.span "Layouts"
                                                                    ]
                                                                ]
                                                                Html.a [
                                                                    prop.classes [ "centered-link"; "centered-link-toggle" ]
                                                                    //prop.dataMenuId "elements-webapp-menu"
                                                                    prop.id "elements-navbar-menu"
                                                                    prop.children [
                                                                        Html.i [
                                                                            //prop.dataFeather "box"
                                                                        ]
                                                                        Html.span "Elements"
                                                                    ]
                                                                ]
                                                                Html.a [
                                                                    prop.classes [ "centered-link"; "centered-link-toggle" ]
                                                                    //prop.dataMenuId "components-webapp-menu"
                                                                    prop.id "components-navbar-menu"
                                                                    prop.children [
                                                                        Html.i [
                                                                            //prop.dataFeather "cpu"
                                                                        ]
                                                                        Html.span "Components"
                                                                    ]
                                                                ]
                                                                Html.a [
                                                                    prop.className "centered-link"
                                                                    prop.href "/webapp-messaging-chat.html"
                                                                    prop.children [
                                                                        Html.i [
                                                                            //prop.dataFeather "message-circle"
                                                                        ]
                                                                        Html.span "Chat"
                                                                    ]
                                                                ]
                                                                Html.a [
                                                                    prop.classes [ "centered-link"; "centered-link-search" ]
                                                                    prop.children [
                                                                        Html.i [
                                                                            //prop.dataFeather "search"
                                                                        ]
                                                                        Html.span "Search"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "centered-search"; "is-hidden" ]
                                                            prop.id "webapp-navbar-search"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "field"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "control"; "has-icon" ]
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "text"
                                                                                    prop.classes [ "input"; "is-rounded"; "search-input" ]
                                                                                    prop.placeholder "Search records..."
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "form-icon"
                                                                                    prop.children [
                                                                                        Html.i [
                                                                                            //prop.dataFeather "search"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.classes [ "form-icon"; "is-right" ]
                                                                                    prop.id "webapp-navbar-search-close"
                                                                                    prop.children [
                                                                                        Html.i [
                                                                                            //prop.dataFeather "x"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.classes [ "search-results"; "has-slimscroll" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "right"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "toolbar"; "ml-auto" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "toolbar-link"
                                                                    prop.children [
                                                                        Html.label [
                                                                            prop.classes [ "dark-mode"; "ml-auto" ]
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "checkbox"
                                                                                    prop.isChecked true
                                                                                ]
                                                                                Html.span []
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.a [
                                                                    prop.classes [ "toolbar-link"; "right-panel-trigger" ]
                                                                    //prop.dataPanel "languages-panel"
                                                                    prop.children [
                                                                        Html.img [
                                                                            prop.src "assets/img/icons/flags/united-states-of-america.svg"
                                                                            prop.alt ""
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "toolbar-notifications"; "is-hidden-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "dropdown"; "is-spaced"; "is-dots"; "is-right"; "dropdown-trigger" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    //prop.ariaHaspopup "true"
                                                                                    prop.className "is-trigger"
                                                                                    prop.children [
                                                                                        Html.i [
                                                                                            //prop.dataFeather "bell"
                                                                                        ]
                                                                                        Html.span [
                                                                                            prop.classes [ "new-indicator"; "pulsate" ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "dropdown-menu"
                                                                                    prop.role "menu"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "dropdown-content"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "heading"
                                                                                                    prop.children [
                                                                                                        Html.div [
                                                                                                            prop.className "heading-left"
                                                                                                            prop.children [
                                                                                                                Html.h6 [
                                                                                                                    prop.className "heading-title"
                                                                                                                    prop.text "Notifications"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.div [
                                                                                                            prop.className "heading-right"
                                                                                                            prop.children [
                                                                                                                Html.a [
                                                                                                                    prop.className "notification-link"
                                                                                                                    prop.href "/admin-profile-notifications.html"
                                                                                                                    prop.text "See all"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    prop.className "notification-list"
                                                                                                    prop.children [
                                                                                                        Html.li [
                                                                                                            Html.a [
                                                                                                                prop.className "notification-item"
                                                                                                                prop.children [
                                                                                                                    Html.div [
                                                                                                                        prop.className "img-left"
                                                                                                                        prop.children [
                                                                                                                            Html.img [
                                                                                                                                prop.className "user-photo"
                                                                                                                                prop.alt ""
                                                                                                                                prop.src "https://via.placeholder.com/150x150"
                                                                                                                                //prop.dataDemoSrc "assets/img/avatars/photos/7.jpg"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.div [
                                                                                                                        prop.className "user-content"
                                                                                                                        prop.children [
                                                                                                                            Html.p [
                                                                                                                                prop.className "user-info"
                                                                                                                                prop.children [
                                                                                                                                    Html.span [
                                                                                                                                        prop.className "name"
                                                                                                                                        prop.text "Alice C."
                                                                                                                                    ]
                                                                                                                                    Html.text " left a comment."
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.p [
                                                                                                                                prop.className "time"
                                                                                                                                prop.text "1 hour ago"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.li [
                                                                                                            Html.a [
                                                                                                                prop.className "notification-item"
                                                                                                                prop.children [
                                                                                                                    Html.div [
                                                                                                                        prop.className "img-left"
                                                                                                                        prop.children [
                                                                                                                            Html.img [
                                                                                                                                prop.className "user-photo"
                                                                                                                                prop.alt ""
                                                                                                                                prop.src "https://via.placeholder.com/150x150"
                                                                                                                                //prop.dataDemoSrc "assets/img/avatars/photos/12.jpg"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.div [
                                                                                                                        prop.className "user-content"
                                                                                                                        prop.children [
                                                                                                                            Html.p [
                                                                                                                                prop.className "user-info"
                                                                                                                                prop.children [
                                                                                                                                    Html.span [
                                                                                                                                        prop.className "name"
                                                                                                                                        prop.text "Joshua S."
                                                                                                                                    ]
                                                                                                                                    Html.text " uploaded a file."
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.p [
                                                                                                                                prop.className "time"
                                                                                                                                prop.text "2 hours ago"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.li [
                                                                                                            Html.a [
                                                                                                                prop.className "notification-item"
                                                                                                                prop.children [
                                                                                                                    Html.div [
                                                                                                                        prop.className "img-left"
                                                                                                                        prop.children [
                                                                                                                            Html.img [
                                                                                                                                prop.className "user-photo"
                                                                                                                                prop.alt ""
                                                                                                                                prop.src "https://via.placeholder.com/150x150"
                                                                                                                                //prop.dataDemoSrc "assets/img/avatars/photos/13.jpg"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.div [
                                                                                                                        prop.className "user-content"
                                                                                                                        prop.children [
                                                                                                                            Html.p [
                                                                                                                                prop.className "user-info"
                                                                                                                                prop.children [
                                                                                                                                    Html.span [
                                                                                                                                        prop.className "name"
                                                                                                                                        prop.text "Tara S."
                                                                                                                                    ]
                                                                                                                                    Html.text " sent you a message."
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.p [
                                                                                                                                prop.className "time"
                                                                                                                                prop.text "2 hours ago"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.li [
                                                                                                            Html.a [
                                                                                                                prop.className "notification-item"
                                                                                                                prop.children [
                                                                                                                    Html.div [
                                                                                                                        prop.className "img-left"
                                                                                                                        prop.children [
                                                                                                                            Html.img [
                                                                                                                                prop.className "user-photo"
                                                                                                                                prop.alt ""
                                                                                                                                prop.src "https://via.placeholder.com/150x150"
                                                                                                                                //prop.dataDemoSrc "assets/img/avatars/photos/25.jpg"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                    Html.div [
                                                                                                                        prop.className "user-content"
                                                                                                                        prop.children [
                                                                                                                            Html.p [
                                                                                                                                prop.className "user-info"
                                                                                                                                prop.children [
                                                                                                                                    Html.span [
                                                                                                                                        prop.className "name"
                                                                                                                                        prop.text "Melany W."
                                                                                                                                    ]
                                                                                                                                    Html.text " left a comment."
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.p [
                                                                                                                                prop.className "time"
                                                                                                                                prop.text "3 hours ago"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.a [
                                                                    prop.classes [ "toolbar-link"; "right-panel-trigger" ]
                                                                    //prop.dataPanel "activity-panel"
                                                                    prop.children [
                                                                        Html.i [
                                                                            //prop.dataFeather "grid"
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "dropdown"; "profile-dropdown"; "dropdown-trigger"; "is-spaced"; "is-right" ]
                                                            prop.children [
                                                                Html.img [
                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/8.jpg"
                                                                    prop.alt ""
                                                                ]
                                                                Html.span [
                                                                    prop.className "status-indicator"
                                                                ]
                                                                Html.div [
                                                                    prop.className "dropdown-menu"
                                                                    prop.role "menu"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "dropdown-content"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "dropdown-head"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "h-avatar"; "is-large" ]
                                                                                            prop.children [
                                                                                                Html.img [
                                                                                                    prop.className "avatar"
                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/8.jpg"
                                                                                                    prop.alt ""
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Erik Kovalsky"
                                                                                                Html.span "Product Manager"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.a [
                                                                                    prop.classes [ "dropdown-item"; "is-media" ]
                                                                                    prop.href "/admin-profile-view.html"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    prop.classes [ "lnil"; "lnil-user-alt" ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Profile"
                                                                                                Html.span "View your profile"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.a [
                                                                                    prop.classes [ "dropdown-item"; "is-media"; "layout-switcher" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Layout"
                                                                                                Html.span "Switch to admin/webapp"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.hr [
                                                                                    prop.className "dropdown-divider"
                                                                                ]
                                                                                Html.a [
                                                                                    prop.classes [ "dropdown-item"; "is-media" ]
                                                                                    prop.href "#"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    prop.classes [ "lnil"; "lnil-briefcase" ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Projects"
                                                                                                Html.span "All my projects"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.a [
                                                                                    prop.classes [ "dropdown-item"; "is-media" ]
                                                                                    prop.href "#"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Team"
                                                                                                Html.span "Manage your team"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.hr [
                                                                                    prop.className "dropdown-divider"
                                                                                ]
                                                                                Html.a [
                                                                                    prop.classes [ "dropdown-item"; "is-media" ]
                                                                                    prop.href "#"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    prop.classes [ "lnil"; "lnil-cog" ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Settings"
                                                                                                Html.span "Account settings"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.hr [
                                                                                    prop.className "dropdown-divider"
                                                                                ]
                                                                                Html.div [
                                                                                    prop.classes [ "dropdown-item"; "is-button" ]
                                                                                    prop.children [
                                                                                        Html.button [
                                                                                            prop.classes [ "button"; "h-button"; "is-primary"; "is-raised"; "is-fullwidth"; "logout-button" ]
                                                                                            prop.children [
                                                                                                Html.span [
                                                                                                    prop.classes [ "icon"; "is-small" ]
                                                                                                    prop.children [
                                                                                                        Html.i [
                                                                                                            //prop.dataFeather "log-out"
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.span "Logout"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "webapp-subnavbar"
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "webapp-subnavbar-inner"; "tabs-wrapper" ]
                                            prop.id "dashboards-webapp-menu"
                                            prop.children [
                                                Html.div [
                                                    prop.className "tabs-inner"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tabs"; "is-centered"; "is-3" ]
                                                            prop.children [
                                                                Html.ul [
                                                                    Html.li [
                                                                        prop.className "is-active"
                                                                        //prop.dataTab "dashboard-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "Dashboards" ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        //prop.dataTab "templates-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "Templates" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "container"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tab-content"; "is-active" ]
                                                            prop.id "dashboard-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Personal"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-personal-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-analytics-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Personal V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-personal-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-pie-chart" ]
                                                                                                                ]
                                                                                                                Html.span "Personal V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-personal-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-stats-up" ]
                                                                                                                ]
                                                                                                                Html.span "Personal V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-lifestyle-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cardiology" ]
                                                                                                                ]
                                                                                                                Html.span "Influencer"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-lifestyle-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cloud-sun" ]
                                                                                                                ]
                                                                                                                Html.span "Hobbies"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-lifestyle-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-hospital-alt-3" ]
                                                                                                                ]
                                                                                                                Html.span "Health"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-lifestyle-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-books" ]
                                                                                                                ]
                                                                                                                Html.span "Writer"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-lifestyle-5.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-video-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Video"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-lifestyle-6.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-tshirt" ]
                                                                                                                ]
                                                                                                                Html.span "Soccer"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Finance"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-finance-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-analytics-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Analytics"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-finance-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-stats-up" ]
                                                                                                                ]
                                                                                                                Html.span "Stocks"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-finance-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-credit-card" ]
                                                                                                                ]
                                                                                                                Html.span "Sales"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-banking-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-bank" ]
                                                                                                                ]
                                                                                                                Html.span "Banking V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-banking-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-bank" ]
                                                                                                                ]
                                                                                                                Html.span "Banking V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-banking-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-bank" ]
                                                                                                                ]
                                                                                                                Html.span "Banking V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Business"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-business-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-plane-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Flights Booking"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-business-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-apartment" ]
                                                                                                                ]
                                                                                                                Html.span "Company Board"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-business-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                                                ]
                                                                                                                Html.span "HR Board"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-business-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-graduate" ]
                                                                                                                ]
                                                                                                                Html.span "Course Board"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-ecommerce-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cart" ]
                                                                                                                ]
                                                                                                                Html.span "Ecommerce V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-map-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-map" ]
                                                                                                                ]
                                                                                                                Html.span "Map V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-map-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-map" ]
                                                                                                                ]
                                                                                                                Html.span "Map V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-business-5.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-briefcase" ]
                                                                                                                ]
                                                                                                                Html.span "Jobs"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Apps"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-apps-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-pizza" ]
                                                                                                                ]
                                                                                                                Html.span "Food Delivery"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-apps-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-envelope" ]
                                                                                                                ]
                                                                                                                Html.span "Inbox"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/admin-messaging-chat.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-bubble" ]
                                                                                                                ]
                                                                                                                Html.span "Messaging V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-messaging-chat.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-bubble" ]
                                                                                                                ]
                                                                                                                Html.span "Messaging V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "tab-content"
                                                            prop.id "templates-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Sidebars"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "admin-blank-page-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Regular Sidebar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "admin-blank-page-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Curved Sidebar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "admin-blank-page-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Colored Sidebar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "admin-blank-page-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Curved Colored"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "admin-blank-page-5.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Sidebar Labels"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "admin-blank-page-6.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Hover Labels"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "admin-blank-page-7.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Floating Sidebar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Navbars"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Regular Navbar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Fading Navbar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Colored Navbar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Drop Navbar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-5.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Colored Drop"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-6.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Clean Navbar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-7.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Clean Centered"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "webapp-blank-page-8.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Clean Trans."
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Widgets"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-charts-apex.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-pie-chart-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Apex Charts"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-charts-billboardjs.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-bar-chart" ]
                                                                                                                ]
                                                                                                                Html.span "Billboard JS"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-widgets-ui.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "UI Widgets"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-widgets-creative.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-2" ]
                                                                                                                ]
                                                                                                                Html.span "Creative Widgets"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-widgets-list.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "List Widgets"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-dashboards-widgets-stats.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Stat Widgets"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Wizard"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/wizard-v1.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Wizard V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.className "/webapp-form-layouts-1.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Form V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.className "/webapp-form-layouts-2.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Form V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.className "/webapp-form-layouts-3.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Form V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.className "/webapp-form-layouts-4.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Form V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.className "/webapp-form-layouts-5.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Form V5"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "webapp-subnavbar-inner"; "tabs-wrapper"; "is-active" ]
                                            prop.id "layouts-webapp-menu"
                                            prop.children [
                                                Html.div [
                                                    prop.className "tabs-inner"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tabs"; "is-centered"; "is-4" ]
                                                            prop.children [
                                                                Html.ul [
                                                                    Html.li [
                                                                        prop.className "is-active"
                                                                        //prop.dataTab "list-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "List Views" ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        //prop.dataTab "grid-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "Grid Views" ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        //prop.dataTab "app-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "Pages" ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        //prop.dataTab "utility-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "Utility" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "container"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tab-content"; "is-active" ]
                                                            prop.id "list-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Lists"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-view-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                                                ]
                                                                                                                Html.span "List View V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-view-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                                                ]
                                                                                                                Html.span "List View V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-view-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                                                ]
                                                                                                                Html.span "List View V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-view-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                                                ]
                                                                                                                Html.span "List View V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Flex Lists"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-flex-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-list-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Flex List V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-flex-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-list-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Flex List V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-flex-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-list-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Flex List V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Datatables"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-datatable-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Datatable V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-datatable-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Datatable V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-datatable-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Datatable V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-list-datatable-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Datatable V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Support"
                                                                                                    ]
                                                                                                ]
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://docs.huro.cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/docs.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/docs-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Documentation"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "tab-content"
                                                            prop.id "grid-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Cards"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-cards-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Card Grid V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-cards-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Card Grid V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-cards-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Card Grid V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-cards-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Card Grid V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Tiles"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-tiles-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-2" ]
                                                                                                                ]
                                                                                                                Html.span "Tile Grid V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-tiles-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-2" ]
                                                                                                                ]
                                                                                                                Html.span "Tile Grid V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-tiles-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-2" ]
                                                                                                                ]
                                                                                                                Html.span "Tile Grid V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Users"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-users-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                                                ]
                                                                                                                Html.span "User Grid V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-users-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                                                ]
                                                                                                                Html.span "User Grid V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-users-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                                                ]
                                                                                                                Html.span "User Grid V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-grid-users-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                                                ]
                                                                                                                Html.span "User Grid V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Support"
                                                                                                    ]
                                                                                                ]
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://docs.huro.cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/docs.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/docs-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Documentation"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "tab-content"
                                                            prop.id "app-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Personal"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-profile-view.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-user-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Profile"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-profile-edit-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-pencil" ]
                                                                                                                ]
                                                                                                                Html.span "Edit Profile"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-profile-notifications.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-notification" ]
                                                                                                                ]
                                                                                                                Html.span "Notifications"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-profile-settings.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cog" ]
                                                                                                                ]
                                                                                                                Html.span "Settings"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Pages"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/auth-login-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-pointer-right" ]
                                                                                                                ]
                                                                                                                Html.span "Login v1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/auth-login-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-pointer-right" ]
                                                                                                                ]
                                                                                                                Html.span "Login v2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/auth-login-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-pointer-right" ]
                                                                                                                ]
                                                                                                                Html.span "Login v3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/auth-signup-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-crown" ]
                                                                                                                ]
                                                                                                                Html.span "Signup v1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/auth-signup-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-crown" ]
                                                                                                                ]
                                                                                                                Html.span "Signup v2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/auth-signup-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-crown" ]
                                                                                                                ]
                                                                                                                Html.span "Signup Flow"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Subpages"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-saas-billing.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-credit-card" ]
                                                                                                                ]
                                                                                                                Html.span "Saas Billing"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-welcome.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-door-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Welcome"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-action-page-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-thunderbolt" ]
                                                                                                                ]
                                                                                                                Html.span "Action Page V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-action-page-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-thunderbolt" ]
                                                                                                                ]
                                                                                                                Html.span "Action Page V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-search-results.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-search-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Search Results"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-search-empty.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-search-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Empty Search"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Projects"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-projects-projects.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Projects V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-projects-projects-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Projects V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-projects-projects-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Projects V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-projects-project.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                                                ]
                                                                                                                Html.span "Project Details"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-kanban-board.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-1" ]
                                                                                                                ]
                                                                                                                Html.span "Project Board"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "tab-content"
                                                            prop.id "utility-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Utility"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-utility-account-confirm.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-thunderbolt" ]
                                                                                                                ]
                                                                                                                Html.span "Confirm Account"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-utility-promotion.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-magnet" ]
                                                                                                                ]
                                                                                                                Html.span "Promotion Page"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-utility-invoice.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-calculator-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Invoice"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/admin-utility-status.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-checkmark-circle" ]
                                                                                                                ]
                                                                                                                Html.span "App Status"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Onboarding"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-onboarding-page-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-train" ]
                                                                                                                ]
                                                                                                                Html.span "Onboarding V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-onboarding-page-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-train-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Onboarding V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-onboarding-page-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-car" ]
                                                                                                                ]
                                                                                                                Html.span "Onboarding V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-onboarding-page-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-car-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Onboarding V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-onboarding-page-5.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-train-alt" ]
                                                                                                                ]
                                                                                                                Html.span "Onboarding V5"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Error"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/error-page-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                                                ]
                                                                                                                Html.span "Error Page V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/error-page-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                                                ]
                                                                                                                Html.span "Error Page V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/error-page-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                                                ]
                                                                                                                Html.span "Error Page V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/error-page-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                                                ]
                                                                                                                Html.span "Error Page V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/error-page-5.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                                                ]
                                                                                                                Html.span "Error Page V5"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Placeload"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-placeload-1.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                                                ]
                                                                                                                Html.span "Placeload V1"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-placeload-2.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                                                ]
                                                                                                                Html.span "Placeload V2"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-placeload-3.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                                                ]
                                                                                                                Html.span "Placeload V3"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/webapp-placeload-4.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                                                ]
                                                                                                                Html.span "Placeload V4"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "webapp-subnavbar-inner"; "tabs-wrapper" ]
                                            prop.id "elements-webapp-menu"
                                            prop.children [
                                                Html.div [
                                                    prop.className "tabs-inner"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tabs"; "is-centered"; "is-2" ]
                                                            prop.children [
                                                                Html.ul [
                                                                    Html.li [
                                                                        prop.className "is-active"
                                                                        //prop.dataTab "elements-basic-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "Basic UI" ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        //prop.dataTab "elements-forms-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "Form Controls" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "container"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tab-content"; "is-active" ]
                                                            prop.id "elements-basic-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "General"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-hub.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-home" ]
                                                                                                                ]
                                                                                                                Html.span "Elements Hub"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-colors.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-color-palette" ]
                                                                                                                ]
                                                                                                                Html.span "Colors"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-helpers.html"
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "lnil"; "lnil-help" ]
                                                                                                                ]
                                                                                                                Html.span "Helpers"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Icons"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-icons-lnil.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Line Icons Light"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-icons-lnir.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Line Icons Regular"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-icons-fa.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Font Awesome 5"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-icons-feather.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Feather Icons"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Base"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-buttons.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Buttons"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-blocks.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Blocks"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-content.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Content"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-tags.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Tags"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Advanced"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-cards-basic.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Basic Cards"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-cards-advanced.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Advanced Cards"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-cards-bulma.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Bulma Cards"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-table.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Table"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-tooltips.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Tooltips"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "tab-content"
                                                            prop.id "elements-forms-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Input"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-inputs.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Inputs"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-addons.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Input Addons"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-textarea.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Textarea"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Selects"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-selects.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Regular"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-custom.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Custom"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-file.html"
                                                                                                            prop.children [
                                                                                                                Html.span "File Input"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Toggles"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-checkboxes.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Checkboxes"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-radios.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Radio Buttons"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/elements-forms-switch.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Switches"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Support"
                                                                                                    ]
                                                                                                ]
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://docs.huro.cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/docs.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/docs-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Documentation"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "webapp-subnavbar-inner"; "tabs-wrapper" ]
                                            prop.id "components-webapp-menu"
                                            prop.children [
                                                Html.div [
                                                    prop.className "tabs-inner"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tabs"; "is-centered"; "is-2" ]
                                                            prop.children [
                                                                Html.ul [
                                                                    Html.li [
                                                                        prop.className "is-active"
                                                                        //prop.dataTab "components-basic-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "UI Components" ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        //prop.dataTab "components-plugins-pages-tab"
                                                                        prop.children [
                                                                            Html.a [ prop.text "JS Plugins" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "container"
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "tab-content"; "is-active" ]
                                                            prop.id "components-basic-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "General"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-avatars.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Avatars"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-accordion-basic.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Accordion"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-accordion-collapse.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Collapse"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-calendar.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Calendar"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-accordion-images.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Image Accordion"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-breadcrumb.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Breadcrumb"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Interaction"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-loader.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Loader"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-dropdown.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Dropdown"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-modal.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Modal Dialogs"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-tabs-regular.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Regular Tabs"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-tabs-slider.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Slider Tabs"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Presentation"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-icon-box.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Icon Box"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-messages.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Message"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-progress.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Progress"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-snacks.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Snacks"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.h4 [
                                                                                                    prop.className "column-heading"
                                                                                                    prop.text "Flex Table"
                                                                                                ]
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-table-flex.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Base Table"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-table-flex-compact.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Compact Table"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-table-flex-media.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Media Table"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-table-flex-advanced.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Advanced Table"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "tab-content"
                                                            prop.id "components-plugins-pages-tab"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tab-content-inner"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "center"; "has-slimscroll" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "columns"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-alertify.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Alertify"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-autocomplete.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Autocomplete"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-datepicker.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Datepicker"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-choices.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Choices JS"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-filepond.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Filepond"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-lightgallery.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Light Gallery"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-videogallery.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Video Gallery"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-video-player.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Video Player"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.ul [
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-toasts.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Toast Messages"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-webuipopover.html"
                                                                                                            prop.children [
                                                                                                                Html.span "WebUI Popovers"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-nouislider.html"
                                                                                                            prop.children [
                                                                                                                Html.span "NoUI Slider"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-editor-summernote.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Summernote"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                    Html.li [
                                                                                                        Html.a [
                                                                                                            prop.href "/components-plugins-editor-sun.html"
                                                                                                            prop.children [
                                                                                                                Html.span "Sun Editor"
                                                                                                                Html.i [
                                                                                                                    //prop.dataFeather "circle"
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.classes [ "column"; "is-3" ]
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/buoy-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Support"
                                                                                                    ]
                                                                                                ]
                                                                                                Html.a [
                                                                                                    prop.className "column-placeholder"
                                                                                                    prop.href "https://docs.huro.cssninja.io"
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "light-image"
                                                                                                            prop.src "assets/img/icons/misc/docs.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "dark-image"
                                                                                                            prop.src "assets/img/icons/misc/docs-dark.svg"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                        Html.h3 "Documentation"
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "right-panel-wrapper"; "is-languages" ]
                                    prop.id "languages-panel"
                                    prop.children [
                                        Html.div [
                                            prop.className "panel-overlay"
                                        ]
                                        Html.div [
                                            prop.className "right-panel"
                                            prop.children [
                                                Html.div [
                                                    prop.className "right-panel-head"
                                                    prop.children [
                                                        Html.h3 "Select Language"
                                                        Html.a [
                                                            prop.className "close-panel"
                                                            prop.children [
                                                                Html.i [
                                                                    //prop.dataFeather "chevron-right"
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.classes [ "right-panel-body"; "has-slimscroll" ]
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "languages-boxes"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "language-box"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "language-option"
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "radio"
                                                                                    prop.name "language_selection"
                                                                                    prop.isChecked true
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "language-option-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.src "assets/img/icons/flags/united-states-of-america.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "indicator"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "check"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.className "language-box"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "language-option"
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "radio"
                                                                                    prop.name "language_selection"
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "language-option-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.src "assets/img/icons/flags/france.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "indicator"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "check"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.className "language-box"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "language-option"
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "radio"
                                                                                    prop.name "language_selection"
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "language-option-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.src "assets/img/icons/flags/spain.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "indicator"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "check"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.className "language-box"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "language-option"
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "radio"
                                                                                    prop.name "language_selection"
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "language-option-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.src "assets/img/icons/flags/germany.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "indicator"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "check"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.className "language-box"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "language-option"
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "radio"
                                                                                    prop.name "language_selection"
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "language-option-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.src "assets/img/icons/flags/mexico.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "indicator"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "check"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.className "language-box"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "language-option"
                                                                            prop.children [
                                                                                Html.input [
                                                                                    prop.type' "radio"
                                                                                    prop.name "language_selection"
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "language-option-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.src "assets/img/icons/flags/china.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "indicator"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "check"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "img-wrap"; "has-text-centered" ]
                                                            prop.children [
                                                                Html.img [
                                                                    prop.className "light-image"
                                                                    prop.src "assets/img/illustrations/right-panel/languages.svg"
                                                                    prop.alt ""
                                                                ]
                                                                Html.img [
                                                                    prop.className "dark-image"
                                                                    prop.src "assets/img/illustrations/right-panel/languages-dark.svg"
                                                                    prop.alt ""
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "right-panel-wrapper"; "is-activity" ]
                                    prop.id "activity-panel"
                                    prop.children [
                                        Html.div [
                                            prop.className "panel-overlay"
                                        ]
                                        Html.div [
                                            prop.className "right-panel"
                                            prop.children [
                                                Html.div [
                                                    prop.className "right-panel-head"
                                                    prop.children [
                                                        Html.h3 "Activity"
                                                        Html.a [
                                                            prop.className "close-panel"
                                                            prop.children [
                                                                Html.i [
                                                                    //prop.dataFeather "chevron-right"
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.classes [ "tabs-wrapper"; "is-triple-slider"; "is-squared" ]
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "tabs-inner"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "tabs"
                                                                    prop.children [
                                                                        Html.ul [
                                                                            Html.li [
                                                                                prop.className "is-active"
                                                                                //prop.dataTab "team-side-tab"
                                                                                prop.children [
                                                                                    Html.a [
                                                                                        Html.span "Team"
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                            Html.li [
                                                                                //prop.dataTab "projects-side-tab"
                                                                                prop.children [
                                                                                    Html.a [
                                                                                        Html.span "Projects"
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                            Html.li [
                                                                                //prop.dataTab "schedule-side-tab"
                                                                                prop.children [
                                                                                    Html.a [
                                                                                        Html.span "Schedule"
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                            Html.li [
                                                                                prop.className "tab-naver"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "right-panel-body"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "tab-content"; "is-active" ]
                                                                    prop.id "team-side-tab"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "team-card"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "h-avatar"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/12.jpg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.img [
                                                                                            prop.className "badge"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/icons/flags/united-states-of-america.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "meta"
                                                                                    prop.children [
                                                                                        Html.span "Joshua S."
                                                                                        Html.span [
                                                                                            Html.i [
                                                                                                //prop.dataFeather "map-pin"
                                                                                            ]
                                                                                            Html.text " Las Vegas, NV"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.a [
                                                                                    prop.className "link"
                                                                                    prop.children [
                                                                                        Html.i [
                                                                                            //prop.dataFeather "arrow-right"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.className "team-card"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "h-avatar"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/25.jpg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.img [
                                                                                            prop.className "badge"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/icons/flags/united-states-of-america.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "meta"
                                                                                    prop.children [
                                                                                        Html.span "Melany W."
                                                                                        Html.span [
                                                                                            Html.i [
                                                                                                //prop.dataFeather "map-pin"
                                                                                            ]
                                                                                            Html.text " San Jose, CA"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.a [
                                                                                    prop.className "link"
                                                                                    prop.children [
                                                                                        Html.i [
                                                                                            //prop.dataFeather "arrow-right"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.className "team-card"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "h-avatar"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/18.jpg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.img [
                                                                                            prop.className "badge"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/icons/flags/united-states-of-america.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "meta"
                                                                                    prop.children [
                                                                                        Html.span "Esteban C."
                                                                                        Html.span [
                                                                                            Html.i [
                                                                                                //prop.dataFeather "map-pin"
                                                                                            ]
                                                                                            Html.text " Miami, FL"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.a [
                                                                                    prop.className "link"
                                                                                    prop.children [
                                                                                        Html.i [
                                                                                            //prop.dataFeather "arrow-right"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.className "team-card"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "h-avatar"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/13.jpg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.img [
                                                                                            prop.className "badge"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/icons/flags/united-states-of-america.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "meta"
                                                                                    prop.children [
                                                                                        Html.span "Tara S."
                                                                                        Html.span [
                                                                                            Html.i [
                                                                                                //prop.dataFeather "map-pin"
                                                                                            ]
                                                                                            Html.text " New York, NY"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.a [
                                                                                    prop.className "link"
                                                                                    prop.children [
                                                                                        Html.i [
                                                                                            //prop.dataFeather "arrow-right"
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.className "tab-content"
                                                                    prop.id "projects-side-tab"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "project-card"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "project-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "project-avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/icons/logos/slicer.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "The slicer project"
                                                                                                Html.span "getslicer.io"
                                                                                            ]
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.className "link"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "arrow-right"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "project-foot"
                                                                                    prop.children [
                                                                                        Html.progress [
                                                                                            prop.classes [ "progress"; "is-primary"; "is-tiny" ]
                                                                                            prop.max 100
                                                                                            prop.value true
                                                                                            prop.text "31% "
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "foot-stats"
                                                                                            prop.children [
                                                                                                Html.span "5 / 24"
                                                                                                Html.div [
                                                                                                    prop.className "avatar-stack"
                                                                                                    prop.children [
                                                                                                        Html.div [
                                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.img [
                                                                                                                    prop.className "avatar"
                                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/7.jpg"
                                                                                                                    prop.alt ""
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.div [
                                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.img [
                                                                                                                    prop.className "avatar"
                                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/5.jpg"
                                                                                                                    prop.alt ""
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.div [
                                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.img [
                                                                                                                    prop.className "avatar"
                                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/8.jpg"
                                                                                                                    prop.alt ""
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.className "project-card"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "project-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "project-avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/icons/logos/metamovies.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Metamovies reworked"
                                                                                                Html.span "metamovies.co"
                                                                                            ]
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.className "link"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "arrow-right"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "project-foot"
                                                                                    prop.children [
                                                                                        Html.progress [
                                                                                            prop.classes [ "progress"; "is-primary"; "is-tiny" ]
                                                                                            prop.max 100
                                                                                            prop.value true
                                                                                            prop.text "84% "
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "foot-stats"
                                                                                            prop.children [
                                                                                                Html.span "28 / 31"
                                                                                                Html.div [
                                                                                                    prop.className "avatar-stack"
                                                                                                    prop.children [
                                                                                                        Html.div [
                                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.img [
                                                                                                                    prop.className "avatar"
                                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/13.jpg"
                                                                                                                    prop.alt ""
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.div [
                                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.img [
                                                                                                                    prop.className "avatar"
                                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/18.jpg"
                                                                                                                    prop.alt ""
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.className "project-card"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "project-inner"
                                                                                    prop.children [
                                                                                        Html.img [
                                                                                            prop.className "project-avatar"
                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                            //prop.dataDemoSrc "assets/img/icons/logos/fastpizza.svg"
                                                                                            prop.alt ""
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "meta"
                                                                                            prop.children [
                                                                                                Html.span "Fast Pizza redesign"
                                                                                                Html.span "fastpizza.com"
                                                                                            ]
                                                                                        ]
                                                                                        Html.a [
                                                                                            prop.className "link"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "arrow-right"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "project-foot"
                                                                                    prop.children [
                                                                                        Html.progress [
                                                                                            prop.classes [ "progress"; "is-primary"; "is-tiny" ]
                                                                                            prop.max 100
                                                                                            prop.value true
                                                                                            prop.text "60% "
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "foot-stats"
                                                                                            prop.children [
                                                                                                Html.span "25 / 39"
                                                                                                Html.div [
                                                                                                    prop.className "avatar-stack"
                                                                                                    prop.children [
                                                                                                        Html.div [
                                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.img [
                                                                                                                    prop.className "avatar"
                                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/7.jpg"
                                                                                                                    prop.alt ""
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.div [
                                                                                                            prop.classes [ "h-avatar"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.img [
                                                                                                                    prop.className "avatar"
                                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/25.jpg"
                                                                                                                    prop.alt ""
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.className "tab-content"
                                                                    prop.id "schedule-side-tab"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "icon-timeline"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "timeline-item"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "timeline-icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "phone-call"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "timeline-content"
                                                                                            prop.children [
                                                                                                Html.p "Call Danny at Colby's"
                                                                                                Html.span "Today - 11:30am"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "timeline-item"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "timeline-icon"
                                                                                            prop.children [
                                                                                                Html.img [
                                                                                                    prop.className "avatar"
                                                                                                    prop.src "https://via.placeholder.com/150x150"
                                                                                                    //prop.dataDemoSrc "assets/img/avatars/photos/7.jpg"
                                                                                                    prop.alt ""
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "timeline-content"
                                                                                            prop.children [
                                                                                                Html.p "Meeting with Alice"
                                                                                                Html.span "Today - 01:00pm"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "timeline-item"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "timeline-icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "message-circle"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "timeline-content"
                                                                                            prop.children [
                                                                                                Html.p "Answer Annie's message"
                                                                                                Html.span "Today - 01:45pm"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "timeline-item"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "timeline-icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "mail"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "timeline-content"
                                                                                            prop.children [
                                                                                                Html.p "Send new campaign"
                                                                                                Html.span "Today - 02:30pm"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "timeline-item"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "timeline-icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "smile"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "timeline-content"
                                                                                            prop.children [
                                                                                                Html.p "Project review"
                                                                                                Html.span "Today - 03:30pm"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "timeline-item"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "timeline-icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "phone-call"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "timeline-content"
                                                                                            prop.children [
                                                                                                Html.p "Call Trisha Jackson"
                                                                                                Html.span "Today - 05:00pm"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "timeline-item"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "timeline-icon"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "feather"
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "timeline-content"
                                                                                            prop.children [
                                                                                                Html.p "Write proposal for Don"
                                                                                                Html.span "Today - 06:00pm"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "mobile-subsidebar"
                                    prop.children [
                                        Html.div [
                                            prop.className "inner"
                                            prop.children [
                                                Html.div [
                                                    prop.className "sidebar-title"
                                                    prop.children [
                                                        Html.h3 "Layouts"
                                                    ]
                                                ]
                                                Html.ul [
                                                    prop.className "submenu"
                                                    prop.children [
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Lists "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-view-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                ]
                                                                                Html.span "List View V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-view-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                ]
                                                                                Html.span "List View V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-view-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                ]
                                                                                Html.span "List View V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-view-4.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-list-alt" ]
                                                                                ]
                                                                                Html.span "List View V4"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Flex Lists "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-flex-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-list-alt-1" ]
                                                                                ]
                                                                                Html.span "Flex List V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-flex-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-list-alt-1" ]
                                                                                ]
                                                                                Html.span "Flex List V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-flex-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-list-alt-1" ]
                                                                                ]
                                                                                Html.span "Flex List V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Datatable "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-datatable-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                ]
                                                                                Html.span "Datatable V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-datatable-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                ]
                                                                                Html.span "Datatable V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-datatable-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                ]
                                                                                Html.span "Datatable V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-list-datatable-4.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt" ]
                                                                                ]
                                                                                Html.span "Datatable V4"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Placeload "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-placeload-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                ]
                                                                                Html.span "Placeload V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-placeload-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                ]
                                                                                Html.span "Placeload V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-placeload-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                ]
                                                                                Html.span "Placeload V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-placeload-4.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-reload" ]
                                                                                ]
                                                                                Html.span "Placeload V4"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "divider"
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Card Grid "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-cards-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                ]
                                                                                Html.span "Card Grid V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-cards-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                ]
                                                                                Html.span "Card Grid V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-cards-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                ]
                                                                                Html.span "Card Grid V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-cards-4.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                ]
                                                                                Html.span "Card Grid V4"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Tile Grid "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-tiles-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-2" ]
                                                                                ]
                                                                                Html.span "Tile Grid V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-tiles-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-2" ]
                                                                                ]
                                                                                Html.span "Tile Grid V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-tiles-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-2" ]
                                                                                ]
                                                                                Html.span "Tile Grid V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "User Grid "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-users-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                ]
                                                                                Html.span "User Grid V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-users-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                ]
                                                                                Html.span "User Grid V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-users-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                ]
                                                                                Html.span "User Grid V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-grid-users-4.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-users-alt" ]
                                                                                ]
                                                                                Html.span "User Grid V4"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "divider"
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Personal "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-profile-view.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-user-alt" ]
                                                                                ]
                                                                                Html.span "Profile"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-profile-edit-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-pencil" ]
                                                                                ]
                                                                                Html.span "Edit Profile"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-profile-notifications.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-notification" ]
                                                                                ]
                                                                                Html.span "Notifications"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-profile-settings.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-cog" ]
                                                                                ]
                                                                                Html.span "Settings"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Pages "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/auth-login-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-pointer-right" ]
                                                                                ]
                                                                                Html.span "Login v1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/auth-login-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-pointer-right" ]
                                                                                ]
                                                                                Html.span "Login v2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/auth-login-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-pointer-right" ]
                                                                                ]
                                                                                Html.span "Login v3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/auth-signup-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-crown" ]
                                                                                ]
                                                                                Html.span "Signup v1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/auth-signup-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-crown" ]
                                                                                ]
                                                                                Html.span "Signup v2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/auth-signup-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-crown" ]
                                                                                ]
                                                                                Html.span "Signup Flow"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-search-results.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-search-alt" ]
                                                                                ]
                                                                                Html.span "Search Results"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-search-empty.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-search-alt" ]
                                                                                ]
                                                                                Html.span "Empty Search"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Subpages "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-saas-billing.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-credit-card" ]
                                                                                ]
                                                                                Html.span "SaaS Billing"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-welcome.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-door-alt" ]
                                                                                ]
                                                                                Html.span "Welcome"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-action-page-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-thunderbolt" ]
                                                                                ]
                                                                                Html.span "Action Page V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-action-page-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-thunderbolt" ]
                                                                                ]
                                                                                Html.span "Action Page V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Projects "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-projects-projects.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                ]
                                                                                Html.span "Projects V1"
                                                                                Html.i [
                                                                                    prop.className "is-auto"
                                                                                    //prop.dataFeather "map-pin"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-projects-projects-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                ]
                                                                                Html.span "Projects V2"
                                                                                Html.i [
                                                                                    prop.className "is-auto"
                                                                                    //prop.dataFeather "map-pin"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-projects-projects-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-grid-alt" ]
                                                                                ]
                                                                                Html.span "Projects V3"
                                                                                Html.i [
                                                                                    prop.className "is-auto"
                                                                                    //prop.dataFeather "map-pin"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-projects-project.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout" ]
                                                                                ]
                                                                                Html.span "Project Details"
                                                                                Html.i [
                                                                                    prop.className "is-auto"
                                                                                    //prop.dataFeather "map-pin"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-kanban-board.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-layout-alt-1" ]
                                                                                ]
                                                                                Html.span "Kanban Board"
                                                                                Html.i [
                                                                                    prop.className "is-auto"
                                                                                    //prop.dataFeather "map-pin"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "divider"
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Utility "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-utility-account-confirm.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-thunderbolt" ]
                                                                                ]
                                                                                Html.span "Confirm Account"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-utility-promotion.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-magnet" ]
                                                                                ]
                                                                                Html.span "Promotion Page"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-utility-invoice.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-calculator-alt" ]
                                                                                ]
                                                                                Html.span "Invoice"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-utility-status.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-checkmark-circle" ]
                                                                                ]
                                                                                Html.span "App Status"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Onboarding "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-onboarding-page-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-train" ]
                                                                                ]
                                                                                Html.span "Onboarding V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-onboarding-page-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-train-alt" ]
                                                                                ]
                                                                                Html.span "Onboarding V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-onboarding-page-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-car" ]
                                                                                ]
                                                                                Html.span "Onboarding V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-onboarding-page-4.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-car-alt" ]
                                                                                ]
                                                                                Html.span "Onboarding V4"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/admin-onboarding-page-5.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-train" ]
                                                                                ]
                                                                                Html.span "Onboarding V5"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.li [
                                                            prop.className "has-children"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "collapse-wrap"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.className "parent-link"
                                                                            prop.href "javascript:void(0);"
                                                                            prop.children [
                                                                                Html.text "Error Pages "
                                                                                Html.i [
                                                                                    //prop.dataFeather "chevron-right"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.ul [
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/error-page-1.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                ]
                                                                                Html.span "Error 404 V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/error-page-2.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                ]
                                                                                Html.span "Error 404 V2"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/error-page-3.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                ]
                                                                                Html.span "Error 404 V3"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/error-page-4.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                ]
                                                                                Html.span "Error 404 V4"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                    Html.li [
                                                                        Html.a [
                                                                            prop.className "is-submenu"
                                                                            prop.href "/error-page-5.html"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "lnil"; "lnil-cross-circle" ]
                                                                                ]
                                                                                Html.span "Error 500 V1"
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "view-wrapper"; "is-webapp" ]
                                    //prop.dataMenuItem "#layouts-navbar-menu"
                                    //prop.dataMobileItem "#home-sidebar-menu-mobile"
                                    //prop.dataNaverOffset "214"
                                    //prop.dataPageTitle "Action Page"
                                    prop.id "app-onboarding"
                                    prop.children [
                                        Html.div [
                                            prop.className "page-content-wrapper"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "page-content"; "is-relative" ]
                                                    prop.children [
                                                        Html.div [
                                                            prop.classes [ "page-title"; "has-text-centered"; "is-webapp" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "title-wrap"
                                                                    prop.children [
                                                                        Html.h1 [
                                                                            prop.classes [ "title"; "is-4" ]
                                                                            prop.text "Action Page"
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "toolbar"; "ml-auto" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "toolbar-link"
                                                                            prop.children [
                                                                                Html.label [
                                                                                    prop.classes [ "dark-mode"; "ml-auto" ]
                                                                                    prop.children [
                                                                                        Html.input [
                                                                                            prop.type' "checkbox"
                                                                                            prop.isChecked true
                                                                                        ]
                                                                                        Html.span []
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.a [
                                                                            prop.classes [ "toolbar-link"; "right-panel-trigger" ]
                                                                            //prop.dataPanel "languages-panel"
                                                                            prop.children [
                                                                                Html.img [
                                                                                    prop.src "assets/img/icons/flags/united-states-of-america.svg"
                                                                                    prop.alt ""
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.div [
                                                                            prop.classes [ "toolbar-notifications"; "is-hidden-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "dropdown"; "is-spaced"; "is-dots"; "is-right"; "dropdown-trigger" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            //prop.ariaHaspopup "true"
                                                                                            prop.className "is-trigger"
                                                                                            prop.children [
                                                                                                Html.i [
                                                                                                    //prop.dataFeather "bell"
                                                                                                ]
                                                                                                Html.span [
                                                                                                    prop.classes [ "new-indicator"; "pulsate" ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                        Html.div [
                                                                                            prop.className "dropdown-menu"
                                                                                            prop.role "menu"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "dropdown-content"
                                                                                                    prop.children [
                                                                                                        Html.div [
                                                                                                            prop.className "heading"
                                                                                                            prop.children [
                                                                                                                Html.div [
                                                                                                                    prop.className "heading-left"
                                                                                                                    prop.children [
                                                                                                                        Html.h6 [
                                                                                                                            prop.className "heading-title"
                                                                                                                            prop.text "Notifications"
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                                Html.div [
                                                                                                                    prop.className "heading-right"
                                                                                                                    prop.children [
                                                                                                                        Html.a [
                                                                                                                            prop.className "notification-link"
                                                                                                                            prop.href "/admin-profile-notifications.html"
                                                                                                                            prop.text "See all"
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.ul [
                                                                                                            prop.className "notification-list"
                                                                                                            prop.children [
                                                                                                                Html.li [
                                                                                                                    Html.a [
                                                                                                                        prop.className "notification-item"
                                                                                                                        prop.children [
                                                                                                                            Html.div [
                                                                                                                                prop.className "img-left"
                                                                                                                                prop.children [
                                                                                                                                    Html.img [
                                                                                                                                        prop.className "user-photo"
                                                                                                                                        prop.alt ""
                                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/7.jpg"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.div [
                                                                                                                                prop.className "user-content"
                                                                                                                                prop.children [
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "user-info"
                                                                                                                                        prop.children [
                                                                                                                                            Html.span [
                                                                                                                                                prop.className "name"
                                                                                                                                                prop.text "Alice C."
                                                                                                                                            ]
                                                                                                                                            Html.text " left a comment."
                                                                                                                                        ]
                                                                                                                                    ]
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "time"
                                                                                                                                        prop.text "1 hour ago"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                                Html.li [
                                                                                                                    Html.a [
                                                                                                                        prop.className "notification-item"
                                                                                                                        prop.children [
                                                                                                                            Html.div [
                                                                                                                                prop.className "img-left"
                                                                                                                                prop.children [
                                                                                                                                    Html.img [
                                                                                                                                        prop.className "user-photo"
                                                                                                                                        prop.alt ""
                                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/12.jpg"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.div [
                                                                                                                                prop.className "user-content"
                                                                                                                                prop.children [
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "user-info"
                                                                                                                                        prop.children [
                                                                                                                                            Html.span [
                                                                                                                                                prop.className "name"
                                                                                                                                                prop.text "Joshua S."
                                                                                                                                            ]
                                                                                                                                            Html.text " uploaded a file."
                                                                                                                                        ]
                                                                                                                                    ]
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "time"
                                                                                                                                        prop.text "2 hours ago"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                                Html.li [
                                                                                                                    Html.a [
                                                                                                                        prop.className "notification-item"
                                                                                                                        prop.children [
                                                                                                                            Html.div [
                                                                                                                                prop.className "img-left"
                                                                                                                                prop.children [
                                                                                                                                    Html.img [
                                                                                                                                        prop.className "user-photo"
                                                                                                                                        prop.alt ""
                                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/13.jpg"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.div [
                                                                                                                                prop.className "user-content"
                                                                                                                                prop.children [
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "user-info"
                                                                                                                                        prop.children [
                                                                                                                                            Html.span [
                                                                                                                                                prop.className "name"
                                                                                                                                                prop.text "Tara S."
                                                                                                                                            ]
                                                                                                                                            Html.text " sent you a message."
                                                                                                                                        ]
                                                                                                                                    ]
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "time"
                                                                                                                                        prop.text "2 hours ago"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                                Html.li [
                                                                                                                    Html.a [
                                                                                                                        prop.className "notification-item"
                                                                                                                        prop.children [
                                                                                                                            Html.div [
                                                                                                                                prop.className "img-left"
                                                                                                                                prop.children [
                                                                                                                                    Html.img [
                                                                                                                                        prop.className "user-photo"
                                                                                                                                        prop.alt ""
                                                                                                                                        prop.src "https://via.placeholder.com/150x150"
                                                                                                                                        //prop.dataDemoSrc "assets/img/avatars/photos/25.jpg"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                            Html.div [
                                                                                                                                prop.className "user-content"
                                                                                                                                prop.children [
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "user-info"
                                                                                                                                        prop.children [
                                                                                                                                            Html.span [
                                                                                                                                                prop.className "name"
                                                                                                                                                prop.text "Melany W."
                                                                                                                                            ]
                                                                                                                                            Html.text " left a comment."
                                                                                                                                        ]
                                                                                                                                    ]
                                                                                                                                    Html.p [
                                                                                                                                        prop.className "time"
                                                                                                                                        prop.text "3 hours ago"
                                                                                                                                    ]
                                                                                                                                ]
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.a [
                                                                            prop.classes [ "toolbar-link"; "right-panel-trigger" ]
                                                                            //prop.dataPanel "activity-panel"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    //prop.dataFeather "grid"
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "page-content-inner"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "action-page-wrapper"; "action-page-v1" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "wrapper-inner"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "action-box"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "box-content"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.classes [ "h-avatar"; "is-big" ]
                                                                                                    prop.children [
                                                                                                        Html.img [
                                                                                                            prop.className "avatar"
                                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/16.jpg"
                                                                                                            prop.alt ""
                                                                                                            //prop.dataUserPopover "16"
                                                                                                        ]
                                                                                                        Html.img [
                                                                                                            prop.className "badge"
                                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                                            //prop.dataDemoSrc "assets/img/photo/demo/apps/9.png"
                                                                                                            prop.alt ""
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.h3 [
                                                                                                    prop.className "dark-inverted"
                                                                                                    prop.children [
                                                                                                        Html.text "Jason G. has invited you to the "
                                                                                                        Html.span [
                                                                                                            prop.className "is-dark-primary"
                                                                                                            prop.text "Banking Solution Website"
                                                                                                        ]
                                                                                                        Html.text " project."
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.classes [ "sender-message"; "is-dark-card-bordered"; "is-dark-bg-4" ]
                                                                                                    prop.children [
                                                                                                        Html.h4 [
                                                                                                            prop.className "dark-inverted"
                                                                                                            prop.text "Message from Jason"
                                                                                                        ]
                                                                                                        Html.p " Hey Erik, It would be really cool if you could give us a hand on this project. There are a lot of tasks popping out every day and I feel the team is getting a bit overwhelmed. We'd love to have you board."
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "people-wrap"
                                                                                                    prop.children [
                                                                                                        Html.div [
                                                                                                            prop.className "people"
                                                                                                            prop.children [
                                                                                                                Html.div [
                                                                                                                    prop.classes [ "h-avatar"; "is-small" ]
                                                                                                                    prop.children [
                                                                                                                        Html.img [
                                                                                                                            prop.className "avatar"
                                                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/21.jpg"
                                                                                                                            prop.alt ""
                                                                                                                            //prop.dataUserPopover "19"
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                                Html.div [
                                                                                                                    prop.classes [ "h-avatar"; "is-small" ]
                                                                                                                    prop.children [
                                                                                                                        Html.span [
                                                                                                                            prop.classes [ "avatar"; "is-fake"; "is-h-purple" ]
                                                                                                                            //prop.dataUserPopover "35"
                                                                                                                            prop.children [
                                                                                                                                Html.span "SC"
                                                                                                                            ]
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                                Html.div [
                                                                                                                    prop.classes [ "h-avatar"; "is-small" ]
                                                                                                                    prop.children [
                                                                                                                        Html.img [
                                                                                                                            prop.className "avatar"
                                                                                                                            prop.src "https://via.placeholder.com/150x150"
                                                                                                                            //prop.dataDemoSrc "assets/img/avatars/photos/39.jpg"
                                                                                                                            prop.alt ""
                                                                                                                            //prop.dataUserPopover "33"
                                                                                                                        ]
                                                                                                                    ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.div [
                                                                                                            prop.className "people-text"
                                                                                                            prop.children [
                                                                                                                Html.p "And 5 others are already members of this project"
                                                                                                            ]
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                                Html.div [
                                                                                                    prop.className "buttons"
                                                                                                    prop.children [
                                                                                                        Html.button [
                                                                                                            prop.classes [ "button"; "h-button"; "is-dark-outlined" ]
                                                                                                            prop.text "Decline "
                                                                                                        ]
                                                                                                        Html.button [
                                                                                                            prop.classes [ "button"; "h-button"; "is-primary"; "is-raised" ]
                                                                                                            prop.text " Accept"
                                                                                                        ]
                                                                                                    ]
                                                                                                ]
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.script [
                                    prop.src "assets/js/app.js"
                                ]
                                Html.script [
                                    prop.src "assets/js/functions.js"
                                ]
                                Html.script [
                                    prop.src "assets/js/main.js"
                                    prop.async true
                                ]
                                Html.script [
                                    prop.src "assets/js/components.js"
                                    prop.async true
                                ]
                                Html.script [
                                    prop.src "assets/js/popover.js"
                                    prop.async true
                                ]
                                Html.script [
                                    prop.src "assets/js/widgets.js"
                                    prop.async true
                                ]
                                Html.script [
                                    prop.src "assets/js/touch.js"
                                    prop.async true
                                ]
                                Html.script [
                                    prop.src "assets/js/syntax.js"
                                    prop.async true
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        