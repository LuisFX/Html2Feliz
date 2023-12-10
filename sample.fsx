Html.div [
    prop.className "column"
    prop.children [
        Html.section [
            prop.className "section"
            prop.id "typography"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Typography "
                ]
                Html.hr []
                Html.div [
                    prop.className "columns"
                    prop.children [
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.h1 [
                                    prop.classes [ "title"; "is-1" ]
                                    prop.text "Title 1 "
                                ]
                                Html.h2 [
                                    prop.classes [ "title"; "is-2" ]
                                    prop.text " Title 2 "
                                ]
                                Html.h3 [
                                    prop.classes [ "title"; "is-3" ]
                                    prop.text " Title 3 "
                                ]
                                Html.h4 [
                                    prop.classes [ "title"; "is-4" ]
                                    prop.text " Title 4 "
                                ]
                                Html.h5 [
                                    prop.classes [ "title"; "is-5" ]
                                    prop.text " Title 5 "
                                ]
                                Html.h6 [
                                    prop.classes [ "title"; "is-6" ]
                                    prop.text " Title 6"
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.h1 [
                                    prop.classes [ "subtitle"; "is-1" ]
                                    prop.text "Subtitle 1 "
                                ]
                                Html.h2 [
                                    prop.classes [ "subtitle"; "is-2" ]
                                    prop.text " Subtitle 2 "
                                ]
                                Html.h3 [
                                    prop.classes [ "subtitle"; "is-3" ]
                                    prop.text " Subtitle 3 "
                                ]
                                Html.h4 [
                                    prop.classes [ "subtitle"; "is-4" ]
                                    prop.text " Subtitle 4 "
                                ]
                                Html.h5 [
                                    prop.classes [ "subtitle"; "is-5" ]
                                    prop.text " Subtitle 5 "
                                ]
                                Html.h6 [
                                    prop.classes [ "subtitle"; "is-6" ]
                                    prop.text " Subtitle 6"
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.h1 [
                                    prop.className "title"
                                    prop.text "Title "
                                ]
                                Html.h2 [
                                    prop.className "subtitle"
                                    prop.text " Subtitle "
                                ]
                                Html.p [
                                    prop.classes [ "title"; "is-1" ]
                                    prop.text " Title 1 "
                                ]
                                Html.p [
                                    prop.classes [ "subtitle"; "is-3" ]
                                    prop.text " Subtitle 3 "
                                ]
                                Html.p [
                                    prop.classes [ "title"; "is-2" ]
                                    prop.text " Title 2 "
                                ]
                                Html.p [
                                    prop.classes [ "subtitle"; "is-4" ]
                                    prop.text " Subtitle 4 "
                                ]
                                Html.p [
                                    prop.classes [ "title"; "is-3" ]
                                    prop.text " Title 3 "
                                ]
                                Html.p [
                                    prop.classes [ "subtitle"; "is-5" ]
                                    prop.text " Subtitle 5"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "box"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Box "
                ]
                Html.hr []
                Html.div [
                    prop.className "box"
                    prop.children [
                        Html.article [
                            prop.className "media"
                            prop.children [
                                Html.div [
                                    prop.className "media-left"
                                    prop.children [
                                        Html.figure [
                                            prop.classes [ "image"; "is-64x64" ]
                                            prop.children [
                                                Html.img [
                                                    prop.alt "Image"
                                                    prop.src "https://s3.amazonaws.com/uifaces/faces/twitter/zeldman/128.jpg"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "media-content"
                                    prop.children [
                                        Html.div [
                                            prop.className "content"
                                            prop.children [
                                                Html.p [
                                                    Html.strong "John Smith "
                                                    Html.small " @johnsmith "
                                                    Html.small " 31m "
                                                    Html.text " "
                                                    Html.text " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean efficitur sit amet massa fringilla egestas. Nullam condimentum luctus turpis."
                                                ]
                                            ]
                                        ]
                                        Html.nav [
                                            prop.className "level"
                                            prop.children [
                                                Html.div [
                                                    prop.className "level-left"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "level-item"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.classes [ "icon"; "is-small" ]
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-reply" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "level-item"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.classes [ "icon"; "is-small" ]
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-retweet" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "level-item"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.classes [ "icon"; "is-small" ]
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-heart" ]
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
        Html.section [
            prop.className "section"
            prop.id "button"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Button "
                ]
                Html.hr []
                Html.div [
                    prop.className "columns"
                    prop.children [
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.className "button"
                                            prop.text "Button "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-white" ]
                                            prop.text " White "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-light" ]
                                            prop.text " Light "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-dark" ]
                                            prop.text " Dark "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-black" ]
                                            prop.text " Black "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-link" ]
                                            prop.text " Link "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-text" ]
                                            prop.text " Link"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-primary" ]
                                            prop.text "Primary "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info" ]
                                            prop.text " Info "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success" ]
                                            prop.text " Success "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-warning" ]
                                            prop.text " Warning "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger" ]
                                            prop.text " Danger"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-focused" ]
                                            prop.text "Focus "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-focused" ]
                                            prop.text " Focus "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-focused" ]
                                            prop.text " Focus "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-focused" ]
                                            prop.text " Focus "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-warning"; "is-focused" ]
                                            prop.text " Focus "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-focused" ]
                                            prop.text " Focus"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-hovered" ]
                                            prop.text "Hover "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-hovered" ]
                                            prop.text " Hover "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-hovered" ]
                                            prop.text " Hover "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-hovered" ]
                                            prop.text " Hover "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-warning"; "is-hovered" ]
                                            prop.text " Hover "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-hovered" ]
                                            prop.text " Hover"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-active" ]
                                            prop.text "Active "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-active" ]
                                            prop.text " Active "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-active" ]
                                            prop.text " Active "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-active" ]
                                            prop.text " Active "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-warning"; "is-active" ]
                                            prop.text " Active "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-active" ]
                                            prop.text " Active"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-loading" ]
                                            prop.text "Loading "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-loading" ]
                                            prop.text " Loading "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-loading" ]
                                            prop.text " Loading "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-loading" ]
                                            prop.text " Loading "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-warning"; "is-loading" ]
                                            prop.text " Loading "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-loading" ]
                                            prop.text " Loading"
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "field"
                                    prop.children [
                                        Html.a [
                                            prop.className "button"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-bold" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.className "button"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-italic" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.className "button"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-underline" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.className "button"
                                            prop.children [
                                                Html.span [
                                                    prop.className "icon"
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fab"; "fa-github" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span " GitHub"
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-primary" ]
                                            prop.children [
                                                Html.span [
                                                    prop.className "icon"
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fab"; "fa-twitter" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span " Twitter"
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span " Save"
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-outlined" ]
                                            prop.children [
                                                Html.span "Delete "
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-times" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "has-addons" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-bold" ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span "Bold"
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-italic" ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span "Italic"
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-underline" ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span "Underline"
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "has-addons" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-align-left" ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span "Left"
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-align-center" ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span "Center"
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-align-right" ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span "Right"
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-rounded" ]
                                            prop.text "Rounded"
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-rounded" ]
                                            prop.text "Rounded"
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-link"; "is-rounded" ]
                                            prop.text "Rounded"
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-rounded" ]
                                            prop.text "Rounded"
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-rounded" ]
                                            prop.text "Rounded"
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-rounded" ]
                                            prop.text "Rounded"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-small" ]
                                            prop.text "Small "
                                        ]
                                        Html.a [
                                            prop.className "button"
                                            prop.text " Normal "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-medium" ]
                                            prop.text " Medium "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-large" ]
                                            prop.text " Large"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-outlined" ]
                                            prop.text "Outlined "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-outlined" ]
                                            prop.text " Outlined "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-outlined" ]
                                            prop.text " Outlined "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-outlined" ]
                                            prop.text " Outlined "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-outlined" ]
                                            prop.text " Outlined"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "buttons"; "notification"; "is-primary" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-inverted"; "is-outlined" ]
                                            prop.text "Invert Outlined "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-inverted"; "is-outlined" ]
                                            prop.text " Invert Outlined "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-inverted"; "is-outlined" ]
                                            prop.text " Invert Outlined "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-inverted"; "is-outlined" ]
                                            prop.text " Invert Outlined"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "buttons"; "notification"; "is-primary" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                            prop.text "Inverted "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-info"; "is-inverted" ]
                                            prop.text " Inverted "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-success"; "is-inverted" ]
                                            prop.text " Inverted "
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-danger"; "is-inverted" ]
                                            prop.text " Inverted"
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "buttons"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-small" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fab"; "fa-github" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span " GitHub"
                                            ]
                                        ]
                                        Html.a [
                                            prop.className "button"
                                            prop.children [
                                                Html.span [
                                                    prop.className "icon"
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fab"; "fa-github" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span " GitHub"
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-medium" ]
                                            prop.children [
                                                Html.span [
                                                    prop.className "icon"
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fab"; "fa-github" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span " GitHub"
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-large" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-medium" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fab"; "fa-github" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span " GitHub"
                                            ]
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "field"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-small" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "field"
                                    prop.children [
                                        Html.a [
                                            prop.className "button"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.className "button"
                                            prop.children [
                                                Html.span [
                                                    prop.className "icon"
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading"; "fa-lg" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "field"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-medium" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-medium" ]
                                            prop.children [
                                                Html.span [
                                                    prop.className "icon"
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading"; "fa-lg" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-medium" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-medium" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading"; "fa-2x" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "field"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-large" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-large" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-medium" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading"; "fa-lg" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.a [
                                            prop.classes [ "button"; "is-large" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "icon"; "is-large" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-heading"; "fa-2x" ]
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
        Html.section [
            prop.className "section"
            prop.id "content"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Content "
                ]
                Html.hr []
                Html.div [
                    prop.className "content"
                    prop.children [
                        Html.h1 "Hello World "
                        Html.p " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla accumsan, metus ultrices eleifend gravida, nulla nunc varius lectus, nec rutrum justo nibh eu lectus. Ut vulputate semper dui. Fusce erat odio, sollicitudin vel erat vel, interdum mattis neque. "
                        Html.h2 " Second level "
                        Html.p [
                            Html.text "Curabitur accumsan turpis pharetra "
                            Html.strong " augue tincidunt "
                            Html.text " blandit. Quisque condimentum maximus mi, sit amet commodo arcu rutrum id. Proin pretium urna vel cursus venenatis. Suspendisse potenti. Etiam mattis sem rhoncus lacus dapibus facilisis. Donec at dignissim dui. Ut et neque nisl."
                        ]
                        Html.ul [
                            Html.li "In fermentum leo eu lectus mollis, quis dictum mi aliquet. "
                            Html.li " Morbi eu nulla lobortis, lobortis est in, fringilla felis. "
                            Html.li " Aliquam nec felis in sapien venenatis viverra fermentum nec lectus. "
                            Html.li " Ut non enim metus."
                        ]
                        Html.h3 " Third level "
                        Html.p [
                            Html.text "Quisque ante lacus, malesuada ac auctor vitae, congue "
                            Html.a [
                                prop.href "#"
                                prop.text " non ante "
                            ]
                            Html.text ". Phasellus lacus ex, semper ac tortor nec, fringilla condimentum orci. Fusce eu rutrum tellus."
                        ]
                        Html.ol [
                            Html.li "Donec blandit a lorem id convallis. "
                            Html.li " Cras gravida arcu at diam gravida gravida. "
                            Html.li " Integer in volutpat libero. "
                            Html.li " Donec a diam tellus. "
                            Html.li " Aenean nec tortor orci. "
                            Html.li " Quisque aliquam cursus urna, non bibendum massa viverra eget. "
                            Html.li " Vivamus maximus ultricies pulvinar."
                        ]
                        Html.blockquote " Ut venenatis, nisl scelerisque sollicitudin fermentum, quam libero hendrerit ipsum, ut blandit est tellus sit amet turpis. "
                        Html.p [
                            Html.text "Quisque at semper enim, eu hendrerit odio. Etiam auctor nisl et "
                            Html.em " justo sodales "
                            Html.text " elementum. Maecenas ultrices lacus quis neque consectetur, et lobortis nisi molestie."
                        ]
                        Html.p " Sed sagittis enim ac tortor maximus rutrum. Nulla facilisi. Donec mattis vulputate risus in luctus. Maecenas vestibulum interdum commodo. "
                        Html.p " Suspendisse egestas sapien non felis placerat elementum. Morbi tortor nisl, suscipit sed mi sit amet, mollis malesuada nulla. Nulla facilisi. Nullam ac erat ante. "
                        Html.h4 " Fourth level "
                        Html.p " Nulla efficitur eleifend nisi, sit amet bibendum sapien fringilla ac. Mauris euismod metus a tellus laoreet, at elementum ex efficitur. "
                        Html.p " Maecenas eleifend sollicitudin dui faucibus sollicitudin augue cursus non. Ut finibus eleifend arcu ut vehicula. Mauris eu est maximus est porta condimentum in eu justo. Nulla id iaculis sapien. "
                        Html.table [
                            Html.thead [
                                Html.tr [
                                    Html.th "One "
                                    Html.th " Two"
                                ]
                            ]
                            Html.tbody [
                                Html.tr [
                                    Html.td "Three "
                                    Html.td " Four"
                                ]
                                Html.tr [
                                    Html.td "Five "
                                    Html.td " Six"
                                ]
                                Html.tr [
                                    Html.td "Seven "
                                    Html.td " Eight"
                                ]
                                Html.tr [
                                    Html.td "Nine "
                                    Html.td " Ten"
                                ]
                                Html.tr [
                                    Html.td "Eleven "
                                    Html.td " Twelve"
                                ]
                            ]
                        ]
                        Html.p " Phasellus porttitor enim id metus volutpat ultricies. Ut nisi nunc, blandit sed dapibus at, vestibulum in felis. Etiam iaculis lorem ac nibh bibendum rhoncus. Nam interdum efficitur ligula sit amet ullamcorper. Etiam tristique, leo vitae porta faucibus, mi lacus laoreet metus, at cursus leo est vel tellus. Sed ac posuere est. Nunc ultricies nunc neque, vitae ultricies ex sodales quis. Aliquam eu nibh in libero accumsan pulvinar. Nullam nec nisl placerat, pretium metus vel, euismod ipsum. Proin tempor cursus nisl vel condimentum. Nam pharetra varius metus non pellentesque. "
                        Html.h5 " Fifth level "
                        Html.p " Aliquam sagittis rhoncus vulputate. Cras non luctus sem, sed tincidunt ligula. Vestibulum at nunc elit. Praesent aliquet ligula mi, in luctus elit volutpat porta. Phasellus molestie diam vel nisi sodales, a eleifend augue laoreet. Sed nec eleifend justo. Nam et sollicitudin odio. "
                        Html.h6 " Sixth level "
                        Html.p " Cras in nibh lacinia, venenatis nisi et, auctor urna. Donec pulvinar lacus sed diam dignissim, ut eleifend eros accumsan. Phasellus non tortor eros. Ut sed rutrum lacus. Etiam purus nunc, scelerisque quis enim vitae, malesuada ultrices turpis. Nunc vitae maximus purus, nec consectetur dui. Suspendisse euismod, elit vel rutrum commodo, ipsum tortor maximus dui, sed varius sapien odio vitae est. Etiam at cursus metus."
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "delete"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Delete "
                ]
                Html.hr []
                Html.div [
                    prop.className "block"
                    prop.children [
                        Html.span [
                            prop.classes [ "tag"; "is-success" ]
                            prop.children [
                                Html.text "Hello World "
                                Html.button [
                                    prop.classes [ "delete"; "is-small" ]
                                ]
                            ]
                        ]
                        Html.a [
                            prop.classes [ "delete"; "is-small" ]
                        ]
                        Html.a [
                            prop.className "delete"
                        ]
                        Html.a [
                            prop.classes [ "delete"; "is-medium" ]
                        ]
                        Html.a [
                            prop.classes [ "delete"; "is-large" ]
                        ]
                    ]
                ]
                Html.div [
                    prop.classes [ "notification"; "is-danger" ]
                    prop.children [
                        Html.button [
                            prop.className "delete"
                        ]
                        Html.text " Lorem ipsum dolor sit amet, consectetur adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                    ]
                ]
                Html.article [
                    prop.classes [ "message"; "is-info" ]
                    prop.children [
                        Html.div [
                            prop.className "message-header"
                            prop.children [
                                Html.text "Info "
                                Html.button [
                                    prop.className "delete"
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "message-body"
                            prop.text " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque risus mi, tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum felis venenatis efficitur. Aenean ac eleifend lacus, in mollis lectus. Donec sodales, arcu et sollicitudin porttitor, tortor urna tempor ligula, id porttitor mi magna a neque. Donec dui urna, vehicula et sem eget, facilisis sodales sem."
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "form"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Form "
                ]
                Html.hr []
                Html.div [
                    prop.className "columns"
                    prop.children [
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.className "label"
                                            prop.text "Name"
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "text"
                                                    prop.placeholder "Text input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.className "label"
                                            prop.text "Username"
                                        ]
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-success" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Text input"
                                                    prop.value true
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-user" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.classes [ "help"; "is-success" ]
                                            prop.text "This username is available"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.className "label"
                                            prop.text "Email"
                                        ]
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-danger" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Email input"
                                                    prop.value true
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-warning" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.classes [ "help"; "is-danger" ]
                                            prop.text "This email is invalid"
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.className "label"
                                            prop.text "Subject"
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.className "select"
                                                    prop.children [
                                                        Html.select [
                                                            Html.option "Select dropdown"
                                                            Html.option "With options"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.className "label"
                                            prop.text "Files to join"
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "select"; "is-multiple" ]
                                                    prop.children [
                                                        Html.select [
                                                            prop.multiple true
                                                            prop.children [
                                                                Html.option "Select dropdown"
                                                                Html.option "With options"
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.className "label"
                                            prop.text "Message"
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.textarea [
                                                    prop.className "textarea"
                                                    prop.placeholder "Textarea"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.label [
                                                    prop.className "checkbox"
                                                    prop.children [
                                                        Html.input [
                                                            prop.type' "checkbox"
                                                        ]
                                                        Html.text " I agree to the "
                                                        Html.a [
                                                            prop.href "#"
                                                            prop.text "terms and conditions"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.label [
                                                    prop.className "radio"
                                                    prop.children [
                                                        Html.input [
                                                            prop.type' "radio"
                                                            prop.name "question"
                                                        ]
                                                        Html.text " Yes"
                                                    ]
                                                ]
                                                Html.label [
                                                    prop.className "radio"
                                                    prop.children [
                                                        Html.input [
                                                            prop.type' "radio"
                                                            prop.name "question"
                                                        ]
                                                        Html.text " No"
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "is-grouped" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "button"; "is-primary" ]
                                                    prop.text "Submit"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "button"; "is-link" ]
                                                    prop.text "Cancel"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.text " "
                                Html.h4 [
                                    prop.className "subtitle"
                                    prop.text " Disabled "
                                ]
                                Html.hr []
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.disabled true
                                                    prop.placeholder "Disabled input"
                                                    prop.type' "text"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.textarea [
                                                    prop.className "textarea"
                                                    prop.disabled true
                                                    prop.placeholder "Disabled textarea"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.label [
                                                    prop.classes [ "checkbox"; "is-disabled" ]
                                                    prop.children [
                                                        Html.input [
                                                            prop.disabled true
                                                            prop.type' "checkbox"
                                                        ]
                                                        Html.text " Remember me"
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.label [
                                                    prop.classes [ "radio"; "is-disabled" ]
                                                    prop.children [
                                                        Html.input [
                                                            prop.disabled true
                                                            prop.name "question"
                                                            prop.type' "radio"
                                                        ]
                                                        Html.text " Yes"
                                                    ]
                                                ]
                                                Html.label [
                                                    prop.classes [ "radio"; "is-disabled" ]
                                                    prop.children [
                                                        Html.input [
                                                            prop.disabled true
                                                            prop.name "question"
                                                            prop.type' "radio"
                                                        ]
                                                        Html.text " No"
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "is-grouped" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "button"; "is-primary" ]
                                                    prop.disabled true
                                                    prop.text "Submit"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.button [
                                                    prop.className "button"
                                                    prop.disabled true
                                                    prop.text "Cancel"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.text " "
                                Html.h3 [
                                    prop.className "title"
                                    prop.text " Horizontal Form "
                                ]
                                Html.hr []
                                Html.div [
                                    prop.classes [ "field"; "is-horizontal" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "field-label"; "is-normal" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "label"
                                                    prop.text "From"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "field-body"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "control"; "is-expanded"; "has-icons-left" ]
                                                            prop.children [
                                                                Html.input [
                                                                    prop.className "input"
                                                                    prop.type' "text"
                                                                    prop.placeholder "Name"
                                                                ]
                                                                Html.span [
                                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-user" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "field"
                                                    prop.children [
                                                        Html.p [
                                                            prop.classes [ "control"; "is-expanded"; "has-icons-left"; "has-icons-right" ]
                                                            prop.children [
                                                                Html.input [
                                                                    prop.classes [ "input"; "is-success" ]
                                                                    prop.type' "email"
                                                                    prop.placeholder "Email"
                                                                    prop.value true
                                                                ]
                                                                Html.span [
                                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.classes [ "icon"; "is-small"; "is-right" ]
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-check" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.classes [ "help"; "is-success" ]
                                                            prop.text "This email is correct"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "is-horizontal" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "field-label"; "is-normal" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "label"
                                                    prop.text "Department"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "field-body"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-narrow" ]
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "select"; "is-fullwidth" ]
                                                                    prop.children [
                                                                        Html.select [
                                                                            Html.option "Business development"
                                                                            Html.option "Marketing"
                                                                            Html.option "Sales"
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
                                    prop.classes [ "field"; "is-horizontal" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "field-label"; "is-normal" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "label"
                                                    prop.text "Skills"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "field-body"
                                            prop.children [
                                                Html.p [
                                                    prop.className "control"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "select"; "is-multiple" ]
                                                            prop.children [
                                                                Html.select [
                                                                    prop.multiple true
                                                                    prop.children [
                                                                        Html.option "Science computer"
                                                                        Html.option "Development"
                                                                        Html.option "Management"
                                                                        Html.option "Relationship"
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
                                    prop.classes [ "field"; "is-horizontal" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "field-label"
                                            prop.children [
                                                Html.label [
                                                    prop.className "label"
                                                    prop.text "Already a member?"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "field-body"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-narrow" ]
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.label [
                                                                    prop.className "radio"
                                                                    prop.children [
                                                                        Html.input [
                                                                            prop.type' "radio"
                                                                            prop.name "member"
                                                                        ]
                                                                        Html.text " Yes"
                                                                    ]
                                                                ]
                                                                Html.label [
                                                                    prop.className "radio"
                                                                    prop.children [
                                                                        Html.input [
                                                                            prop.type' "radio"
                                                                            prop.name "member"
                                                                        ]
                                                                        Html.text " No"
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
                                    prop.classes [ "field"; "is-horizontal" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "field-label"; "is-normal" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "label"
                                                    prop.text "Subject"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "field-body"
                                            prop.children [
                                                Html.div [
                                                    prop.className "field"
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.input [
                                                                    prop.classes [ "input"; "is-danger" ]
                                                                    prop.type' "text"
                                                                    prop.placeholder "e.g. Partnership opportunity"
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.classes [ "help"; "is-danger" ]
                                                            prop.text " This field is required"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "is-horizontal" ]
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "field-label"; "is-normal" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "label"
                                                    prop.text "Question"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "field-body"
                                            prop.children [
                                                Html.div [
                                                    prop.className "field"
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.textarea [
                                                                    prop.className "textarea"
                                                                    prop.placeholder "Explain how we can help you"
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
                                    prop.classes [ "field"; "is-horizontal" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "field-label"
                                        ]
                                        Html.div [
                                            prop.className "field-body"
                                            prop.children [
                                                Html.div [
                                                    prop.className "field"
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.button [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.text "Send message"
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.text " "
                                Html.h3 [
                                    prop.className "title"
                                    prop.text "File"
                                ]
                                Html.hr []
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.div [
                                            prop.className "file"
                                            prop.children [
                                                Html.label [
                                                    prop.className "file-label"
                                                    prop.children [
                                                        Html.input [
                                                            prop.className "file-input"
                                                            prop.type' "file"
                                                            prop.name "resume"
                                                        ]
                                                        Html.span [
                                                            prop.className "file-cta"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.className "file-icon"
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-upload" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.className "file-label"
                                                                    prop.text " Choose a file…"
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
                                    prop.className "field"
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "file"; "has-name" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "file-label"
                                                    prop.children [
                                                        Html.input [
                                                            prop.className "file-input"
                                                            prop.type' "file"
                                                            prop.name "resume"
                                                        ]
                                                        Html.span [
                                                            prop.className "file-cta"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.className "file-icon"
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-upload" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.className "file-label"
                                                                    prop.text " Choose a file…"
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span [
                                                            prop.className "file-name"
                                                            prop.text " Screen Shot 2017-07-29 at 15.54.25.png"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "file"; "is-primary" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "file-label"
                                                    prop.children [
                                                        Html.input [
                                                            prop.className "file-input"
                                                            prop.type' "file"
                                                            prop.name "resume"
                                                        ]
                                                        Html.span [
                                                            prop.className "file-cta"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.className "file-icon"
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-upload" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.className "file-label"
                                                                    prop.text " Primary file…"
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
                                    prop.className "field"
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "file"; "is-info"; "has-name" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "file-label"
                                                    prop.children [
                                                        Html.input [
                                                            prop.className "file-input"
                                                            prop.type' "file"
                                                            prop.name "resume"
                                                        ]
                                                        Html.span [
                                                            prop.className "file-cta"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.className "file-icon"
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-upload" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.className "file-label"
                                                                    prop.text " Info file…"
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span [
                                                            prop.className "file-name"
                                                            prop.text " Screen Shot 2017-07-29 at 15.54.25.png"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "file"; "is-warning"; "is-boxed" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "file-label"
                                                    prop.children [
                                                        Html.input [
                                                            prop.className "file-input"
                                                            prop.type' "file"
                                                            prop.name "resume"
                                                        ]
                                                        Html.span [
                                                            prop.className "file-cta"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.className "file-icon"
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-cloud-upload-alt" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.className "file-label"
                                                                    prop.text " Warning file…"
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
                                    prop.className "field"
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "file"; "is-danger"; "has-name"; "is-boxed" ]
                                            prop.children [
                                                Html.label [
                                                    prop.className "file-label"
                                                    prop.children [
                                                        Html.input [
                                                            prop.className "file-input"
                                                            prop.type' "file"
                                                            prop.name "resume"
                                                        ]
                                                        Html.span [
                                                            prop.className "file-cta"
                                                            prop.children [
                                                                Html.span [
                                                                    prop.className "file-icon"
                                                                    prop.children [
                                                                        Html.i [
                                                                            prop.classes [ "fa"; "fa-cloud-upload-alt" ]
                                                                        ]
                                                                    ]
                                                                ]
                                                                Html.span [
                                                                    prop.className "file-label"
                                                                    prop.text " Danger file…"
                                                                ]
                                                            ]
                                                        ]
                                                        Html.span [
                                                            prop.className "file-name"
                                                            prop.text " Screen Shot 2017-07-29 at 15.54.25.png"
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
                            prop.className "column"
                            prop.children [
                                Html.text ""
                                Html.h3 [
                                    prop.className "subtitle"
                                    prop.text " Styles "
                                ]
                                Html.hr []
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-rounded" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Rounded input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.text " "
                                Html.h3 [
                                    prop.className "subtitle"
                                    prop.text " Colors "
                                ]
                                Html.hr []
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-primary" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Primary input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-info" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Info input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-success" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Success input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-warning" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Warning input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-danger" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Danger input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.text " "
                                Html.h3 [
                                    prop.className "subtitle"
                                    prop.text " Sizes "
                                ]
                                Html.hr []
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-small" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Small input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "text"
                                                    prop.placeholder "Normal input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-medium" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Medium input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-large" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Large input"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "select"; "is-small" ]
                                                    prop.children [
                                                        Html.select [
                                                            Html.option "Select dropdown"
                                                            Html.option "With options"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.className "select"
                                                    prop.children [
                                                        Html.select [
                                                            Html.option "Select dropdown"
                                                            Html.option "With options"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "select"; "is-medium" ]
                                                    prop.children [
                                                        Html.select [
                                                            Html.option "Select dropdown"
                                                            Html.option "With options"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "select"; "is-large" ]
                                                    prop.children [
                                                        Html.select [
                                                            Html.option "Select dropdown"
                                                            Html.option "With options"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.classes [ "label"; "is-small" ]
                                            prop.text "Small input"
                                        ]
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-small" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.className "label"
                                            prop.text "Normal input"
                                        ]
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.classes [ "label"; "is-medium" ]
                                            prop.text "Medium input"
                                        ]
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-medium" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-medium" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-medium" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-medium"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-medium"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.label [
                                            prop.classes [ "label"; "is-large" ]
                                            prop.text "Large input"
                                        ]
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-large" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-large" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-large" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-medium"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-medium"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left"; "has-icons-right" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-large" ]
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-large"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-large"; "is-right" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-check" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.text " "
                                Html.h4 [
                                    prop.className "subtitle"
                                    prop.text " With Font Awesome icons "
                                ]
                                Html.hr []
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left" ]
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "email"
                                                    prop.placeholder "Email"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-envelope" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left" ]
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "password"
                                                    prop.placeholder "Password"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-lock" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "button"; "is-success" ]
                                                    prop.text "Login"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.text " "
                                Html.h3 [
                                    prop.className "title"
                                    prop.text " Form addons "
                                ]
                                Html.hr []
                                Html.div [
                                    prop.classes [ "field"; "has-addons" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "text"
                                                    prop.placeholder "Find a repository"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "button"; "is-info" ]
                                                    prop.text "Search"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "has-addons" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-large" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Find a repository"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "button"; "is-info"; "is-large" ]
                                                    prop.text "Search"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "has-addons" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.className "select"
                                                    prop.children [
                                                        Html.select [
                                                            Html.option "$"
                                                            Html.option "£"
                                                            Html.option "€"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "text"
                                                    prop.placeholder "Amount of money"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.text "Transfer"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "has-addons" ]
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.span [
                                                    prop.className "select"
                                                    prop.children [
                                                        Html.select [
                                                            Html.option "$"
                                                            Html.option "£"
                                                            Html.option "€"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.classes [ "control"; "is-expanded" ]
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "text"
                                                    prop.placeholder "Amount of money"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.className "button"
                                                    prop.text "Transfer"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "has-addons" ]
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "is-expanded" ]
                                            prop.children [
                                                Html.span [
                                                    prop.classes [ "select"; "is-fullwidth" ]
                                                    prop.children [
                                                        Html.select [
                                                            prop.name "country"
                                                            prop.children [
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Argentina"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Bolivia"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Brazil"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Chile"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Colombia"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Ecuador"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Guyana"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Paraguay"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Peru"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Suriname"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Uruguay"
                                                                ]
                                                                Html.option [
                                                                    prop.value true
                                                                    prop.text "Venezuela"
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.button [
                                                    prop.classes [ "button"; "is-primary" ]
                                                    prop.type' "submit"
                                                    prop.text "Choose"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "field"; "is-grouped" ]
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "is-expanded" ]
                                            prop.children [
                                                Html.input [
                                                    prop.className "input"
                                                    prop.type' "text"
                                                    prop.placeholder "Find a repository"
                                                ]
                                            ]
                                        ]
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "button"; "is-info" ]
                                                    prop.text "Search"
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
        Html.section [
            prop.className "section"
            prop.id "icon"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Icons "
                ]
                Html.hr []
                Html.span [
                    prop.className "icon"
                    prop.children [
                        Html.i [
                            prop.classes [ "fas"; "fa-home" ]
                        ]
                    ]
                ]
                Html.span [
                    prop.classes [ "icon"; "is-medium" ]
                    prop.children [
                        Html.i [
                            prop.classes [ "fas"; "fa-lg"; "fa-home" ]
                        ]
                    ]
                ]
                Html.span [
                    prop.classes [ "icon"; "is-large" ]
                    prop.children [
                        Html.i [
                            prop.classes [ "fas"; "fa-2x"; "fa-home" ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "images"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Images "
                ]
                Html.hr []
                Html.figure [
                    prop.classes [ "image"; "is-128x128" ]
                    prop.children [
                        Html.img [
                            prop.src "https://s3.amazonaws.com/uifaces/faces/twitter/zeldman/128.jpg"
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "notifications"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Notifications "
                ]
                Html.hr []
                Html.div [
                    prop.classes [ "columns"; "is-multiline" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "notification"; "" ]
                                    prop.children [
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                        Html.text " Lorem ipsum dolor sit amet, "
                                        Html.a [
                                            prop.href "#"
                                            prop.text "consectetur"
                                        ]
                                        Html.text " adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "notification"; "is-primary" ]
                                    prop.children [
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                        Html.text " Lorem ipsum dolor sit amet, "
                                        Html.a [
                                            prop.href "#"
                                            prop.text "consectetur"
                                        ]
                                        Html.text " adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "notification"; "is-link" ]
                                    prop.children [
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                        Html.text " Lorem ipsum dolor sit amet, "
                                        Html.a [
                                            prop.href "#"
                                            prop.text "consectetur"
                                        ]
                                        Html.text " adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "notification"; "is-info" ]
                                    prop.children [
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                        Html.text " Lorem ipsum dolor sit amet, "
                                        Html.a [
                                            prop.href "#"
                                            prop.text "consectetur"
                                        ]
                                        Html.text " adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "notification"; "is-success" ]
                                    prop.children [
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                        Html.text " Lorem ipsum dolor sit amet, "
                                        Html.a [
                                            prop.href "#"
                                            prop.text "consectetur"
                                        ]
                                        Html.text " adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "notification"; "is-warning" ]
                                    prop.children [
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                        Html.text " Lorem ipsum dolor sit amet, "
                                        Html.a [
                                            prop.href "#"
                                            prop.text "consectetur"
                                        ]
                                        Html.text " adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.div [
                                    prop.classes [ "notification"; "is-danger" ]
                                    prop.children [
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                        Html.text " Lorem ipsum dolor sit amet, "
                                        Html.a [
                                            prop.href "#"
                                            prop.text "consectetur"
                                        ]
                                        Html.text " adipiscing elit lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "progress"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Progress bars "
                ]
                Html.hr []
                Html.progress [
                    prop.classes [ "progress"; "" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-primary" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-link" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-info" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-success" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-warning" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-danger" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-small" ]
                    prop.max 100
                    prop.value true
                    prop.text " 15% "
                ]
                Html.progress [
                    prop.className "progress"
                    prop.max 100
                    prop.value true
                    prop.text " 30% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-medium" ]
                    prop.max 100
                    prop.value true
                    prop.text " 45% "
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-large" ]
                    prop.max 100
                    prop.value true
                    prop.text " 60% "
                ]
                Html.h2 [
                    prop.classes [ "title"; "is-2" ]
                    prop.text "Indeterminate"
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-small"; "is-primary" ]
                    prop.max 100
                    prop.text "15%"
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-danger" ]
                    prop.max 100
                    prop.text "30%"
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-medium"; "is-dark" ]
                    prop.max 100
                    prop.text "45%"
                ]
                Html.progress [
                    prop.classes [ "progress"; "is-large"; "is-info" ]
                    prop.max 100
                    prop.text "60%"
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "table"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Table "
                ]
                Html.hr []
                Html.table [
                    prop.className "table"
                    prop.children [
                        Html.thead [
                            Html.tr [
                                Html.th [
                                    Html.abbr [
                                        prop.title "Position"
                                        prop.text "Pos"
                                    ]
                                ]
                                Html.th " Team "
                                Html.th [
                                    Html.abbr [
                                        prop.title "Played"
                                        prop.text "Pld"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Won"
                                        prop.text "W"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Drawn"
                                        prop.text "D"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Lost"
                                        prop.text "L"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Goals for"
                                        prop.text "GF"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Goals against"
                                        prop.text "GA"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Goal difference"
                                        prop.text "GD"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Points"
                                        prop.text "Pts"
                                    ]
                                ]
                                Html.th " Qualification or relegation"
                            ]
                        ]
                        Html.tfoot [
                            Html.tr [
                                Html.th [
                                    Html.abbr [
                                        prop.title "Position"
                                        prop.text "Pos"
                                    ]
                                ]
                                Html.th " Team "
                                Html.th [
                                    Html.abbr [
                                        prop.title "Played"
                                        prop.text "Pld"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Won"
                                        prop.text "W"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Drawn"
                                        prop.text "D"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Lost"
                                        prop.text "L"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Goals for"
                                        prop.text "GF"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Goals against"
                                        prop.text "GA"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Goal difference"
                                        prop.text "GD"
                                    ]
                                ]
                                Html.th [
                                    Html.abbr [
                                        prop.title "Points"
                                        prop.text "Pts"
                                    ]
                                ]
                                Html.th " Qualification or relegation"
                            ]
                        ]
                        Html.tbody [
                            Html.tr [
                                Html.th "1 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Leicester_City_F.C."
                                        prop.title "Leicester City F.C."
                                        prop.text "Leicester City "
                                    ]
                                    Html.strong " (C)"
                                ]
                                Html.td " 38 "
                                Html.td " 23 "
                                Html.td " 12 "
                                Html.td " 3 "
                                Html.td " 68 "
                                Html.td " 36 "
                                Html.td " +32 "
                                Html.td " 81 "
                                Html.td [
                                    Html.text "Qualification for the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Champions_League#Group_stage"
                                        prop.title "2016–17 UEFA Champions League"
                                        prop.text " Champions League group stage"
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "2 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Arsenal_F.C."
                                        prop.title "Arsenal F.C."
                                        prop.text "Arsenal"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 20 "
                                Html.td " 11 "
                                Html.td " 7 "
                                Html.td " 65 "
                                Html.td " 36 "
                                Html.td " +29 "
                                Html.td " 71 "
                                Html.td [
                                    Html.text "Qualification for the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Champions_League#Group_stage"
                                        prop.title "2016–17 UEFA Champions League"
                                        prop.text " Champions League group stage"
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "3 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Tottenham_Hotspur_F.C."
                                        prop.title "Tottenham Hotspur F.C."
                                        prop.text "Tottenham Hotspur"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 19 "
                                Html.td " 13 "
                                Html.td " 6 "
                                Html.td " 69 "
                                Html.td " 35 "
                                Html.td " +34 "
                                Html.td " 70 "
                                Html.td [
                                    Html.text "Qualification for the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Champions_League#Group_stage"
                                        prop.title "2016–17 UEFA Champions League"
                                        prop.text " Champions League group stage"
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "4 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Manchester_City_F.C."
                                        prop.title "Manchester City F.C."
                                        prop.text "Manchester City"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 19 "
                                Html.td " 9 "
                                Html.td " 10 "
                                Html.td " 71 "
                                Html.td " 41 "
                                Html.td " +30 "
                                Html.td " 66 "
                                Html.td [
                                    Html.text "Qualification for the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Champions_League#Play-off_round"
                                        prop.title "2016–17 UEFA Champions League"
                                        prop.text " Champions League play-off round"
                                    ]
                                ]
                            ]
                            Html.tr [
                                prop.className "is-selected"
                                prop.children [
                                    Html.th "5 "
                                    Html.td [
                                        Html.a [
                                            prop.href "https://en.wikipedia.org/wiki/Manchester_United_F.C."
                                            prop.title "Manchester United F.C."
                                            prop.text "Manchester United"
                                        ]
                                    ]
                                    Html.td " 38 "
                                    Html.td " 19 "
                                    Html.td " 9 "
                                    Html.td " 10 "
                                    Html.td " 49 "
                                    Html.td " 35 "
                                    Html.td " +14 "
                                    Html.td " 66 "
                                    Html.td [
                                        Html.text "Qualification for the "
                                        Html.a [
                                            prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Europa_League#Group_stage"
                                            prop.title "2016–17 UEFA Europa League"
                                            prop.text " Europa League group stage"
                                        ]
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "6 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Southampton_F.C."
                                        prop.title "Southampton F.C."
                                        prop.text "Southampton"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 18 "
                                Html.td " 9 "
                                Html.td " 11 "
                                Html.td " 59 "
                                Html.td " 41 "
                                Html.td " +18 "
                                Html.td " 63 "
                                Html.td [
                                    Html.text "Qualification for the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Europa_League#Group_stage"
                                        prop.title "2016–17 UEFA Europa League"
                                        prop.text " Europa League group stage"
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "7 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/West_Ham_United_F.C."
                                        prop.title "West Ham United F.C."
                                        prop.text "West Ham United"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 16 "
                                Html.td " 14 "
                                Html.td " 8 "
                                Html.td " 65 "
                                Html.td " 51 "
                                Html.td " +14 "
                                Html.td " 62 "
                                Html.td [
                                    Html.text "Qualification for the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Europa_League#Third_qualifying_round"
                                        prop.title "2016–17 UEFA Europa League"
                                        prop.text " Europa League third qualifying round"
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "8 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Liverpool_F.C."
                                        prop.title "Liverpool F.C."
                                        prop.text "Liverpool"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 16 "
                                Html.td " 12 "
                                Html.td " 10 "
                                Html.td " 63 "
                                Html.td " 50 "
                                Html.td " +13 "
                                Html.td " 60 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "9 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Stoke_City_F.C."
                                        prop.title "Stoke City F.C."
                                        prop.text "Stoke City"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 14 "
                                Html.td " 9 "
                                Html.td " 15 "
                                Html.td " 41 "
                                Html.td " 55 "
                                Html.td " −14 "
                                Html.td " 51 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "10 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Chelsea_F.C."
                                        prop.title "Chelsea F.C."
                                        prop.text "Chelsea"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 12 "
                                Html.td " 14 "
                                Html.td " 12 "
                                Html.td " 59 "
                                Html.td " 53 "
                                Html.td " +6 "
                                Html.td " 50 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "11 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Everton_F.C."
                                        prop.title "Everton F.C."
                                        prop.text "Everton"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 11 "
                                Html.td " 14 "
                                Html.td " 13 "
                                Html.td " 59 "
                                Html.td " 55 "
                                Html.td " +4 "
                                Html.td " 47 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "12 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Swansea_City_A.F.C."
                                        prop.title "Swansea City A.F.C."
                                        prop.text "Swansea City"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 12 "
                                Html.td " 11 "
                                Html.td " 15 "
                                Html.td " 42 "
                                Html.td " 52 "
                                Html.td " −10 "
                                Html.td " 47 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "13 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Watford_F.C."
                                        prop.title "Watford F.C."
                                        prop.text "Watford"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 12 "
                                Html.td " 9 "
                                Html.td " 17 "
                                Html.td " 40 "
                                Html.td " 50 "
                                Html.td " −10 "
                                Html.td " 45 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "14 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/West_Bromwich_Albion_F.C."
                                        prop.title "West Bromwich Albion F.C."
                                        prop.text "West Bromwich Albion"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 10 "
                                Html.td " 13 "
                                Html.td " 15 "
                                Html.td " 34 "
                                Html.td " 48 "
                                Html.td " −14 "
                                Html.td " 43 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "15 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Crystal_Palace_F.C."
                                        prop.title "Crystal Palace F.C."
                                        prop.text "Crystal Palace"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 11 "
                                Html.td " 9 "
                                Html.td " 18 "
                                Html.td " 39 "
                                Html.td " 51 "
                                Html.td " −12 "
                                Html.td " 42 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "16 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/A.F.C._Bournemouth"
                                        prop.title "A.F.C. Bournemouth"
                                        prop.text "AFC Bournemouth"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 11 "
                                Html.td " 9 "
                                Html.td " 18 "
                                Html.td " 45 "
                                Html.td " 67 "
                                Html.td " −22 "
                                Html.td " 42 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "17 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Sunderland_A.F.C."
                                        prop.title "Sunderland A.F.C."
                                        prop.text "Sunderland"
                                    ]
                                ]
                                Html.td " 38 "
                                Html.td " 9 "
                                Html.td " 12 "
                                Html.td " 17 "
                                Html.td " 48 "
                                Html.td " 62 "
                                Html.td " −14 "
                                Html.td " 39 "
                                Html.td []
                            ]
                            Html.tr [
                                Html.th "18 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Newcastle_United_F.C."
                                        prop.title "Newcastle United F.C."
                                        prop.text "Newcastle United "
                                    ]
                                    Html.strong " (R)"
                                ]
                                Html.td " 38 "
                                Html.td " 9 "
                                Html.td " 10 "
                                Html.td " 19 "
                                Html.td " 44 "
                                Html.td " 65 "
                                Html.td " −21 "
                                Html.td " 37 "
                                Html.td [
                                    Html.text "Relegation to the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_Football_League_Championship"
                                        prop.title "2016–17 Football League Championship"
                                        prop.text " Football League Championship"
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "19 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Norwich_City_F.C."
                                        prop.title "Norwich City F.C."
                                        prop.text "Norwich City "
                                    ]
                                    Html.strong " (R)"
                                ]
                                Html.td " 38 "
                                Html.td " 9 "
                                Html.td " 7 "
                                Html.td " 22 "
                                Html.td " 39 "
                                Html.td " 67 "
                                Html.td " −28 "
                                Html.td " 34 "
                                Html.td [
                                    Html.text "Relegation to the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_Football_League_Championship"
                                        prop.title "2016–17 Football League Championship"
                                        prop.text " Football League Championship"
                                    ]
                                ]
                            ]
                            Html.tr [
                                Html.th "20 "
                                Html.td [
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/Aston_Villa_F.C."
                                        prop.title "Aston Villa F.C."
                                        prop.text "Aston Villa "
                                    ]
                                    Html.strong " (R)"
                                ]
                                Html.td " 38 "
                                Html.td " 3 "
                                Html.td " 8 "
                                Html.td " 27 "
                                Html.td " 27 "
                                Html.td " 76 "
                                Html.td " −49 "
                                Html.td " 17 "
                                Html.td [
                                    Html.text "Relegation to the "
                                    Html.a [
                                        prop.href "https://en.wikipedia.org/wiki/2016%E2%80%9317_Football_League_Championship"
                                        prop.title "2016–17 Football League Championship"
                                        prop.text " Football League Championship"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.table [
                    prop.classes [ "table"; "is-striped" ]
                    prop.children [
                        Html.thead [
                            Html.tr [
                                Html.th "One "
                                Html.th " Two"
                            ]
                        ]
                        Html.tbody [
                            Html.tr [
                                Html.td "Three "
                                Html.td " Four"
                            ]
                            Html.tr [
                                Html.td "Five "
                                Html.td " Six"
                            ]
                            Html.tr [
                                Html.td "Seven "
                                Html.td " Eight"
                            ]
                            Html.tr [
                                Html.td "Nine "
                                Html.td " Ten"
                            ]
                            Html.tr [
                                Html.td "Eleven "
                                Html.td " Twelve"
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.table [
                    prop.classes [ "table"; "is-bordered" ]
                    prop.children [
                        Html.thead [
                            Html.tr [
                                Html.th "One "
                                Html.th " Two"
                            ]
                        ]
                        Html.tbody [
                            Html.tr [
                                Html.td "Three "
                                Html.td " Four"
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.table [
                    prop.classes [ "table"; "is-narrow" ]
                    prop.children [
                        Html.thead [
                            Html.tr [
                                Html.th "One "
                                Html.th " Two"
                            ]
                        ]
                        Html.tbody [
                            Html.tr [
                                Html.td "Three "
                                Html.td " Four"
                            ]
                            Html.tr [
                                Html.td "Five "
                                Html.td " Six"
                            ]
                            Html.tr [
                                Html.td "Seven "
                                Html.td " Eight"
                            ]
                            Html.tr [
                                Html.td "Nine "
                                Html.td " Ten"
                            ]
                            Html.tr [
                                Html.td "Eleven "
                                Html.td " Twelve"
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.table [
                    prop.classes [ "table"; "is-bordered"; "is-striped"; "is-narrow" ]
                    prop.children [
                        Html.thead [
                            Html.tr [
                                Html.th "One "
                                Html.th " Two"
                            ]
                        ]
                        Html.tbody [
                            Html.tr [
                                Html.td "Three "
                                Html.td " Four"
                            ]
                            Html.tr [
                                Html.td "Five "
                                Html.td " Six"
                            ]
                            Html.tr [
                                Html.td "Seven "
                                Html.td " Eight"
                            ]
                            Html.tr [
                                Html.td "Nine "
                                Html.td " Ten"
                            ]
                            Html.tr [
                                Html.td "Eleven "
                                Html.td " Twelve"
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "tag"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Tag "
                ]
                Html.hr []
                Html.div [
                    prop.className "tags"
                    prop.children [
                        Html.span [
                            prop.classes [ "tag"; "is-primary" ]
                            prop.text "Primary "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-link" ]
                            prop.text " Link "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-info" ]
                            prop.text " Info "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-success" ]
                            prop.text " Success "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-warning" ]
                            prop.text " Warning "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-danger" ]
                            prop.text " Danger "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-white" ]
                            prop.text " White "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-black" ]
                            prop.text " Black "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-light" ]
                            prop.text " Light "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-dark" ]
                            prop.text " Dark "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-primary"; "is-medium" ]
                            prop.text " Medium "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-info"; "is-large" ]
                            prop.text " Large "
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-success" ]
                            prop.children [
                                Html.text "Bar "
                                Html.button [
                                    prop.classes [ "delete"; "is-small" ]
                                ]
                            ]
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-warning"; "is-medium" ]
                            prop.children [
                                Html.text "Hello "
                                Html.button [
                                    prop.classes [ "delete"; "is-small" ]
                                ]
                            ]
                        ]
                        Html.span [
                            prop.classes [ "tag"; "is-danger"; "is-large" ]
                            prop.children [
                                Html.text "World "
                                Html.button [
                                    prop.className "delete"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.div [
                    prop.classes [ "field"; "is-grouped"; "is-grouped-multiline" ]
                    prop.children [
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.span [
                                            prop.classes [ "tag"; "is-dark" ]
                                            prop.text "npm"
                                        ]
                                        Html.span [
                                            prop.classes [ "tag"; "is-info" ]
                                            prop.text "0.5.0"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.span [
                                            prop.classes [ "tag"; "is-dark" ]
                                            prop.text "build"
                                        ]
                                        Html.span [
                                            prop.classes [ "tag"; "is-success" ]
                                            prop.text "passing"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.span [
                                            prop.classes [ "tag"; "is-dark" ]
                                            prop.text "chat"
                                        ]
                                        Html.span [
                                            prop.classes [ "tag"; "is-primary" ]
                                            prop.text "on gitter"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.div [
                    prop.classes [ "field"; "is-grouped"; "is-grouped-multiline" ]
                    prop.children [
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "tag"; "is-link" ]
                                            prop.text "Technology"
                                        ]
                                        Html.a [
                                            prop.classes [ "tag"; "is-delete" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "tag"; "is-link" ]
                                            prop.text "CSS"
                                        ]
                                        Html.a [
                                            prop.classes [ "tag"; "is-delete" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "tag"; "is-link" ]
                                            prop.text "Flexbox"
                                        ]
                                        Html.a [
                                            prop.classes [ "tag"; "is-delete" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "tag"; "is-link" ]
                                            prop.text "Web Design"
                                        ]
                                        Html.a [
                                            prop.classes [ "tag"; "is-delete" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "tag"; "is-link" ]
                                            prop.text "Open Source"
                                        ]
                                        Html.a [
                                            prop.classes [ "tag"; "is-delete" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "tag"; "is-link" ]
                                            prop.text "Community"
                                        ]
                                        Html.a [
                                            prop.classes [ "tag"; "is-delete" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "control"
                            prop.children [
                                Html.div [
                                    prop.classes [ "tags"; "has-addons" ]
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "tag"; "is-link" ]
                                            prop.text "Documentation"
                                        ]
                                        Html.a [
                                            prop.classes [ "tag"; "is-delete" ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "breadcrumb"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Breadcrumb"
                ]
                Html.hr []
                Html.nav [
                    prop.className "breadcrumb"
                    prop.children [
                        Html.ul [
                            Html.li [
                                Html.a "Bulma"
                            ]
                            Html.li [
                                Html.a "Documentation"
                            ]
                            Html.li [
                                Html.a "Components"
                            ]
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a "Breadcrumb"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "hero"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Hero"
                ]
                Html.hr []
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero1"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero1"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-primary" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero2"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero2"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-primary" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-link" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero3"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero3"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-link" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-info" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero4"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero4"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-info" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-success" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero5"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero5"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-success" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-warning" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero6"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero6"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-warning" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-danger" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero7"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero7"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-danger" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-white" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero8"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero8"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-white" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-black" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero9"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero9"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-black" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-light" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero10"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero10"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-light" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text " "
                Html.section [
                    Html.div [
                        Html.nav [
                            prop.classes [ "navbar"; "is-dark" ]
                            prop.children [
                                Html.div [
                                    prop.className "container"
                                    prop.children [
                                        Html.div [
                                            prop.className "navbar-brand"
                                            prop.children [
                                                Html.a [
                                                    prop.className "navbar-item"
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/bulma-type-white.png"
                                                            prop.alt "Logo"
                                                        ]
                                                    ]
                                                ]
                                                Html.span [
                                                    prop.classes [ "navbar-burger"; "burger" ]
                                                    prop.dataTarget "navbarMenuHero11"
                                                    prop.children [
                                                        Html.span []
                                                        Html.span []
                                                        Html.span []
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "navbar-menu"
                                            prop.id "navbarMenuHero11"
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-end"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.text "Home "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Examples "
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.text " Documentation "
                                                        ]
                                                        Html.div [
                                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-link"
                                                                    prop.text "More "
                                                                ]
                                                                Html.div [
                                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                                    prop.id "moreDropdown"
                                                                    prop.children [
                                                                        Html.a [
                                                                            prop.classes [ "navbar-item"; "" ]
                                                                            prop.href "#"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-left"
                                                                                            prop.children [
                                                                                                Html.div [
                                                                                                    prop.className "level-item"
                                                                                                    prop.children [
                                                                                                        Html.p [
                                                                                                            Html.strong "Extensions"
                                                                                                            Html.text " "
                                                                                                            Html.small "Side projects to enhance Bulma"
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
                                                        Html.span [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary"; "is-inverted" ]
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fab"; "fa-github" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                        prop.classes [ "hero"; "is-dark" ]
                        prop.children [
                            Html.div [
                                prop.className "hero-body"
                                prop.children [
                                    Html.div [
                                        prop.classes [ "container"; "has-text-centered" ]
                                        prop.children [
                                            Html.h1 [
                                                prop.className "title"
                                                prop.text "Title "
                                            ]
                                            Html.h2 [
                                                prop.className "subtitle"
                                                prop.text " Subtitle"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "hero-foot"
                                prop.children [
                                    Html.nav [
                                        prop.className "tabs"
                                        prop.children [
                                            Html.div [
                                                prop.className "container"
                                                prop.children [
                                                    Html.ul [
                                                        Html.li [
                                                            prop.className "is-active"
                                                            prop.children [
                                                                Html.a "Overview"
                                                            ]
                                                        ]
                                                        Html.li [
                                                            Html.a "Modifiers"
                                                        ]
                                                        Html.li [
                                                            Html.a "Grid"
                                                        ]
                                                        Html.li [
                                                            Html.a "Elements"
                                                        ]
                                                        Html.li [
                                                            Html.a "Components"
                                                        ]
                                                        Html.li [
                                                            Html.a "Layout"
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
                Html.text ""
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "card"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Cards"
                ]
                Html.hr []
                Html.div [
                    prop.className "columns"
                    prop.children [
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.div [
                                    prop.className "card"
                                    prop.children [
                                        Html.div [
                                            prop.className "card-image"
                                            prop.children [
                                                Html.figure [
                                                    prop.classes [ "image"; "is-4by3" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://source.unsplash.com/random/800x600"
                                                            prop.alt "Image"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "card-content"
                                            prop.children [
                                                Html.div [
                                                    prop.className "media"
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "media-left"
                                                            prop.children [
                                                                Html.figure [
                                                                    prop.className "image"
                                                                    prop.style "height: 40px; width: 40px;"
                                                                    prop.children [
                                                                        Html.img [
                                                                            prop.src "https://source.unsplash.com/random/96x96"
                                                                            prop.alt "Image"
                                                                        ]
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.div [
                                                            prop.className "media-content"
                                                            prop.children [
                                                                Html.p [
                                                                    prop.classes [ "title"; "is-4" ]
                                                                    prop.text "John Smith"
                                                                ]
                                                                Html.p [
                                                                    prop.classes [ "subtitle"; "is-6" ]
                                                                    prop.text "@johnsmith"
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.div [
                                                    prop.className "content"
                                                    prop.children [
                                                        Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec iaculis mauris. "
                                                        Html.a "@bulmaio"
                                                        Html.text ". "
                                                        Html.a "#css"
                                                        Html.a "#responsive"
                                                        Html.text " "
                                                        Html.small "11:09 PM - 1 Jan 2016"
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.div [
                                    prop.className "card"
                                    prop.children [
                                        Html.header [
                                            prop.className "card-header"
                                            prop.children [
                                                Html.p [
                                                    prop.className "card-header-title"
                                                    prop.text "Component "
                                                ]
                                                Html.a [
                                                    prop.className "card-header-icon"
                                                    prop.children [
                                                        Html.span [
                                                            prop.className "icon"
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-angle-down" ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "card-content"
                                            prop.children [
                                                Html.div [
                                                    prop.className "content"
                                                    prop.children [
                                                        Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec iaculis mauris. "
                                                        Html.a "@bulmaio"
                                                        Html.text ". "
                                                        Html.a "#css"
                                                        Html.a "#responsive"
                                                        Html.text " "
                                                        Html.small "11:09 PM - 1 Jan 2016"
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.footer [
                                            prop.className "card-footer"
                                            prop.children [
                                                Html.a [
                                                    prop.className "card-footer-item"
                                                    prop.text "Save"
                                                ]
                                                Html.a [
                                                    prop.className "card-footer-item"
                                                    prop.text "Edit"
                                                ]
                                                Html.a [
                                                    prop.className "card-footer-item"
                                                    prop.text "Delete"
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
        Html.section [
            prop.className "section"
            prop.id "dropdown"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Dropdown"
                ]
                Html.hr []
                Html.div [
                    prop.className "columns"
                    prop.children [
                        Html.div [
                            prop.className "column"
                            prop.children [
                                Html.div [
                                    prop.classes [ "dropdown"; "is-active" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "dropdown-trigger"
                                            prop.children [
                                                Html.button [
                                                    prop.ariaControls "dropdown-menu"
                                                    prop.ariaHaspopup "true"
                                                    prop.className "button"
                                                    prop.children [
                                                        Html.span "Dropdown button"
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-angle-down" ]
                                                                    prop.ariaHidden "true"
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "dropdown-menu"
                                            prop.id "dropdown-menu"
                                            prop.role "menu"
                                            prop.children [
                                                Html.div [
                                                    prop.className "dropdown-content"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "dropdown-item"
                                                            prop.href "#"
                                                            prop.text "Dropdown item "
                                                        ]
                                                        Html.a [
                                                            prop.className "dropdown-item"
                                                            prop.text " Other dropdown item "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "dropdown-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Active dropdown item "
                                                        ]
                                                        Html.a [
                                                            prop.className "dropdown-item"
                                                            prop.href "#"
                                                            prop.text " Other dropdown item "
                                                        ]
                                                        Html.hr [
                                                            prop.className "dropdown-divider"
                                                        ]
                                                        Html.a [
                                                            prop.className "dropdown-item"
                                                            prop.href "#"
                                                            prop.text " With a divider"
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
                            prop.className "column"
                            prop.children [
                                Html.div [
                                    prop.classes [ "dropdown"; "is-active" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "dropdown-trigger"
                                            prop.children [
                                                Html.button [
                                                    prop.ariaControls "dropdown-menu2"
                                                    prop.ariaHaspopup "true"
                                                    prop.classes [ "button"; "is-info" ]
                                                    prop.children [
                                                        Html.span "Content"
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-angle-down" ]
                                                                    prop.ariaHidden "true"
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "dropdown-menu"
                                            prop.id "dropdown-menu2"
                                            prop.role "menu"
                                            prop.children [
                                                Html.div [
                                                    prop.className "dropdown-content"
                                                    prop.children [
                                                        Html.div [
                                                            prop.className "dropdown-item"
                                                            prop.children [
                                                                Html.p [
                                                                    Html.text "You can insert "
                                                                    Html.strong "any type of content"
                                                                    Html.text " within the dropdown menu."
                                                                ]
                                                            ]
                                                        ]
                                                        Html.hr [
                                                            prop.className "dropdown-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "dropdown-item"
                                                            prop.children [
                                                                Html.p [
                                                                    Html.text "You simply need to use a "
                                                                    Html.code [
                                                                        Html.text "<"
                                                                        Html.text "div"
                                                                        Html.text ">"
                                                                    ]
                                                                    Html.text " instead."
                                                                ]
                                                            ]
                                                        ]
                                                        Html.hr [
                                                            prop.className "dropdown-divider"
                                                        ]
                                                        Html.a [
                                                            prop.className "dropdown-item"
                                                            prop.href "#"
                                                            prop.text " This is a link"
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
        Html.section [
            prop.className "section"
            prop.id "level"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Level"
                ]
                Html.hr []
                Html.nav [
                    prop.className "level"
                    prop.children [
                        Html.div [
                            prop.className "level-left"
                            prop.children [
                                Html.div [
                                    prop.className "level-item"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "subtitle"; "is-5" ]
                                            prop.children [
                                                Html.strong "123"
                                                Html.text " posts"
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "level-item"
                                    prop.children [
                                        Html.div [
                                            prop.classes [ "field"; "has-addons" ]
                                            prop.children [
                                                Html.p [
                                                    prop.className "control"
                                                    prop.children [
                                                        Html.input [
                                                            prop.className "input"
                                                            prop.type' "text"
                                                            prop.placeholder "Find a post"
                                                        ]
                                                    ]
                                                ]
                                                Html.p [
                                                    prop.className "control"
                                                    prop.children [
                                                        Html.button [
                                                            prop.className "button"
                                                            prop.text "Search"
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
                            prop.className "level-right"
                            prop.children [
                                Html.p [
                                    prop.className "level-item"
                                    prop.children [
                                        Html.strong "All"
                                    ]
                                ]
                                Html.p [
                                    prop.className "level-item"
                                    prop.children [
                                        Html.a "Published"
                                    ]
                                ]
                                Html.p [
                                    prop.className "level-item"
                                    prop.children [
                                        Html.a "Drafts"
                                    ]
                                ]
                                Html.p [
                                    prop.className "level-item"
                                    prop.children [
                                        Html.a "Deleted"
                                    ]
                                ]
                                Html.p [
                                    prop.className "level-item"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-success" ]
                                            prop.text "New"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.hr []
                Html.nav [
                    prop.className "level"
                    prop.children [
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Tweets"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "3,456"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Following"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "123"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Followers"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "456K"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Likes"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "789"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.hr []
                Html.nav [
                    prop.className "level"
                    prop.children [
                        Html.p [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.a [
                                    prop.classes [ "link"; "is-info" ]
                                    prop.text "Home"
                                ]
                            ]
                        ]
                        Html.p [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.a [
                                    prop.classes [ "link"; "is-info" ]
                                    prop.text "Menu"
                                ]
                            ]
                        ]
                        Html.p [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.img [
                                    prop.src "https://bulma.io/images/bulma-type.png"
                                    prop.alt ""
                                    prop.style "height: 30px;"
                                ]
                            ]
                        ]
                        Html.p [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.a [
                                    prop.classes [ "link"; "is-info" ]
                                    prop.text "Reservations"
                                ]
                            ]
                        ]
                        Html.p [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.a [
                                    prop.classes [ "link"; "is-info" ]
                                    prop.text "Contact"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.hr []
                Html.nav [
                    prop.classes [ "level"; "is-mobile" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Tweets"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "3,456"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Following"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "123"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Followers"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "456K"
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "level-item"; "has-text-centered" ]
                            prop.children [
                                Html.div [
                                    Html.p [
                                        prop.className "heading"
                                        prop.text "Likes"
                                    ]
                                    Html.p [
                                        prop.className "title"
                                        prop.text "789"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.hr []
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "media"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Media Object"
                ]
                Html.hr []
                Html.article [
                    prop.className "media"
                    prop.children [
                        Html.figure [
                            prop.className "media-left"
                            prop.children [
                                Html.p [
                                    prop.classes [ "image"; "is-64x64" ]
                                    prop.children [
                                        Html.img [
                                            prop.src "https://s3.amazonaws.com/uifaces/faces/twitter/zeldman/128.jpg"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "media-content"
                            prop.children [
                                Html.div [
                                    prop.className "content"
                                    prop.children [
                                        Html.p [
                                            Html.strong "John Smith"
                                            Html.small "@johnsmith"
                                            Html.small "31m"
                                            Html.text " "
                                            Html.text " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare magna eros, eu pellentesque tortor vestibulum ut. Maecenas non massa sem. Etiam finibus odio quis feugiat facilisis."
                                        ]
                                    ]
                                ]
                                Html.nav [
                                    prop.className "level"
                                    prop.children [
                                        Html.div [
                                            prop.className "level-left"
                                            prop.children [
                                                Html.a [
                                                    prop.className "level-item"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-reply" ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.className "level-item"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-retweet" ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.a [
                                                    prop.className "level-item"
                                                    prop.children [
                                                        Html.span [
                                                            prop.classes [ "icon"; "is-small" ]
                                                            prop.children [
                                                                Html.i [
                                                                    prop.classes [ "fa"; "fa-heart" ]
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
                            prop.className "media-right"
                            prop.children [
                                Html.button [
                                    prop.className "delete"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.hr []
                Html.article [
                    prop.className "media"
                    prop.children [
                        Html.figure [
                            prop.className "media-left"
                            prop.children [
                                Html.p [
                                    prop.classes [ "image"; "is-64x64" ]
                                    prop.children [
                                        Html.img [
                                            prop.src "https://s3.amazonaws.com/uifaces/faces/twitter/zeldman/128.jpg"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "media-content"
                            prop.children [
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.textarea [
                                                    prop.className "textarea"
                                                    prop.placeholder "Add a comment..."
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.nav [
                                    prop.className "level"
                                    prop.children [
                                        Html.div [
                                            prop.className "level-left"
                                            prop.children [
                                                Html.div [
                                                    prop.className "level-item"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "button"; "is-info" ]
                                                            prop.text "Post comment"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "level-right"
                                            prop.children [
                                                Html.div [
                                                    prop.className "level-item"
                                                    prop.children [
                                                        Html.label [
                                                            prop.className "checkbox"
                                                            prop.children [
                                                                Html.input [
                                                                    prop.type' "checkbox"
                                                                ]
                                                                Html.text " Press enter to submit"
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
                Html.hr []
                Html.h4 [
                    prop.className "subtitle"
                    prop.text "Nesting"
                ]
                Html.article [
                    prop.className "media"
                    prop.children [
                        Html.figure [
                            prop.className "media-left"
                            prop.children [
                                Html.p [
                                    prop.classes [ "image"; "is-64x64" ]
                                    prop.children [
                                        Html.img [
                                            prop.src "https://s3.amazonaws.com/uifaces/faces/twitter/zeldman/128.jpg"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "media-content"
                            prop.children [
                                Html.div [
                                    prop.className "content"
                                    prop.children [
                                        Html.p [
                                            Html.strong "Barbara Middleton"
                                            Html.text " "
                                            Html.text " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis porta eros lacus, nec ultricies elit blandit non. Suspendisse pellentesque mauris sit amet dolor blandit rutrum. Nunc in tempus turpis. "
                                            Html.text " "
                                            Html.small [
                                                Html.a "Like"
                                                Html.text " · "
                                                Html.a "Reply"
                                                Html.text " · 3 hrs"
                                            ]
                                        ]
                                    ]
                                ]
                                Html.article [
                                    prop.className "media"
                                    prop.children [
                                        Html.figure [
                                            prop.className "media-left"
                                            prop.children [
                                                Html.p [
                                                    prop.classes [ "image"; "is-48x48" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/placeholders/96x96.png"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "media-content"
                                            prop.children [
                                                Html.div [
                                                    prop.className "content"
                                                    prop.children [
                                                        Html.p [
                                                            Html.strong "Sean Brown"
                                                            Html.text " "
                                                            Html.text " Donec sollicitudin urna eget eros malesuada sagittis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam blandit nisl a nulla sagittis, a lobortis leo feugiat. "
                                                            Html.text " "
                                                            Html.small [
                                                                Html.a "Like"
                                                                Html.text " · "
                                                                Html.a "Reply"
                                                                Html.text " · 2 hrs"
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                                Html.article [
                                                    prop.className "media"
                                                    prop.text " Vivamus quis semper metus, non tincidunt dolor. Vivamus in mi eu lorem cursus ullamcorper sit amet nec massa. "
                                                ]
                                                Html.article [
                                                    prop.className "media"
                                                    prop.text " Morbi vitae diam et purus tincidunt porttitor vel vitae augue. Praesent malesuada metus sed pharetra euismod. Cras tellus odio, tincidunt iaculis diam non, porta aliquet tortor."
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.article [
                                    prop.className "media"
                                    prop.children [
                                        Html.figure [
                                            prop.className "media-left"
                                            prop.children [
                                                Html.p [
                                                    prop.classes [ "image"; "is-48x48" ]
                                                    prop.children [
                                                        Html.img [
                                                            prop.src "https://bulma.io/images/placeholders/96x96.png"
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "media-content"
                                            prop.children [
                                                Html.div [
                                                    prop.className "content"
                                                    prop.children [
                                                        Html.p [
                                                            Html.strong "Kayli Eunice "
                                                            Html.text " "
                                                            Html.text " Sed convallis scelerisque mauris, non pulvinar nunc mattis vel. Maecenas varius felis sit amet magna vestibulum euismod malesuada cursus libero. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Phasellus lacinia non nisl id feugiat. "
                                                            Html.text " "
                                                            Html.small [
                                                                Html.a "Like"
                                                                Html.text " · "
                                                                Html.a "Reply"
                                                                Html.text " · 2 hrs"
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
                Html.article [
                    prop.className "media"
                    prop.children [
                        Html.figure [
                            prop.className "media-left"
                            prop.children [
                                Html.p [
                                    prop.classes [ "image"; "is-64x64" ]
                                    prop.children [
                                        Html.img [
                                            prop.src "https://s3.amazonaws.com/uifaces/faces/twitter/zeldman/128.jpg"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "media-content"
                            prop.children [
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.textarea [
                                                    prop.className "textarea"
                                                    prop.placeholder "Add a comment..."
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.className "field"
                                    prop.children [
                                        Html.p [
                                            prop.className "control"
                                            prop.children [
                                                Html.button [
                                                    prop.className "button"
                                                    prop.text "Post comment"
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
        Html.section [
            prop.className "section"
            prop.id "menu"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Menu"
                ]
                Html.hr []
                Html.div [
                    prop.classes [ "column"; "is-3" ]
                    prop.children [
                        Html.aside [
                            prop.className "menu"
                            prop.children [
                                Html.p [
                                    prop.className "menu-label"
                                    prop.text "General "
                                ]
                                Html.ul [
                                    prop.className "menu-list"
                                    prop.children [
                                        Html.li [
                                            Html.a "Dashboard"
                                        ]
                                        Html.li [
                                            Html.a "Customers"
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "menu-label"
                                    prop.text " Administration "
                                ]
                                Html.ul [
                                    prop.className "menu-list"
                                    prop.children [
                                        Html.li [
                                            Html.a "Team Settings"
                                        ]
                                        Html.li [
                                            Html.a [
                                                prop.className "is-active"
                                                prop.text "Manage Your Team"
                                            ]
                                            Html.ul [
                                                Html.li [
                                                    Html.a "Members"
                                                ]
                                                Html.li [
                                                    Html.a "Plugins"
                                                ]
                                                Html.li [
                                                    Html.a "Add a member"
                                                ]
                                            ]
                                        ]
                                        Html.li [
                                            Html.a "Invitations"
                                        ]
                                        Html.li [
                                            Html.a "Cloud Storage Environment Settings"
                                        ]
                                        Html.li [
                                            Html.a "Authentication"
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "menu-label"
                                    prop.text " Transactions "
                                ]
                                Html.ul [
                                    prop.className "menu-list"
                                    prop.children [
                                        Html.li [
                                            Html.a "Payments"
                                        ]
                                        Html.li [
                                            Html.a "Transfers"
                                        ]
                                        Html.li [
                                            Html.a "Balance"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "message"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Message"
                ]
                Html.hr []
                Html.div [
                    prop.classes [ "columns"; "is-multiline" ]
                    prop.children [
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Message "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-primary" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Primary "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-link" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Link "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-info" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Info "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-success" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Success "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-warning" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Warning "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-danger" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Danger "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-white" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "White "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-black" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Black "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-light" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Light "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.classes [ "column"; "is-half" ]
                            prop.children [
                                Html.article [
                                    prop.classes [ "message"; "is-dark" ]
                                    prop.children [
                                        Html.div [
                                            prop.className "message-header"
                                            prop.children [
                                                Html.p "Dark "
                                                Html.button [
                                                    prop.className "delete"
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "message-body"
                                            prop.children [
                                                Html.text "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                                                Html.strong "Pellentesque risus mi"
                                                Html.text ", tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum "
                                                Html.a "felis venenatis"
                                                Html.text " efficitur. Aenean ac "
                                                Html.em "eleifend lacus"
                                                Html.text "."
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
        Html.section [
            prop.className "section"
            prop.id "modal"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Modal"
                ]
                Html.hr []
                Html.a [
                    prop.classes [ "button"; "is-primary"; "is-large" ]
                    prop.dataTarget "#myModal"
                    prop.onclick "$('#myModal').toggleClass('is-active')"
                    prop.text "Launch example modal"
                ]
                Html.div [
                    prop.className "modal"
                    prop.id "myModal"
                    prop.children [
                        Html.div [
                            prop.className "modal-background"
                        ]
                        Html.div [
                            prop.className "modal-card"
                            prop.children [
                                Html.header [
                                    prop.className "modal-card-head"
                                    prop.children [
                                        Html.p [
                                            prop.className "modal-card-title"
                                            prop.text "Modal title"
                                        ]
                                        Html.button [
                                            prop.className "delete"
                                        ]
                                    ]
                                ]
                                Html.section [
                                    prop.className "modal-card-body"
                                    prop.text " Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. "
                                ]
                                Html.footer [
                                    prop.className "modal-card-foot"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "button"; "is-primary" ]
                                            prop.text "Save changes"
                                        ]
                                        Html.a [
                                            prop.className "button"
                                            prop.text "Cancel"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "navbar"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Navbar"
                ]
                Html.hr []
                Html.nav [
                    prop.classes [ "navbar"; "" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample1"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample1"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-primary" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample2"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample2"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-link" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample3"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample3"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-info" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample4"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample4"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-success" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample5"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample5"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-warning" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample6"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample6"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-danger" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample7"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample7"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-white" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample8"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample8"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-black" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample9"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample9"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-light" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample10"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample10"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.nav [
                    prop.classes [ "navbar"; "is-dark" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExample11"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExample11"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Modifiers "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Grid "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Form "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Elements "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "is-active" ]
                                                            prop.href "#"
                                                            prop.text " Components "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Layout "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; "" ]
                                                    prop.href "#blog/"
                                                    prop.text "Blog "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.dataStyle "width: 18rem;"
                                                    prop.id "blogDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2017/03/10/new-field-element/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "10 Mar 2017"
                                                                            ]
                                                                        ]
                                                                        Html.p "New field element (for better controls)"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/04/11/metro-ui-css-grid-with-bulma-tiles/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "11 Apr 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Metro UI CSS grid with Bulma tiles"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "/2016/02/09/blog-launched-new-responsive-columns-new-helpers/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.p [
                                                                            Html.small [
                                                                                prop.className "has-text-info"
                                                                                prop.text "09 Feb 2016"
                                                                            ]
                                                                        ]
                                                                        Html.p "Blog launched, new responsive columns, new helpers"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.a [
                                                            prop.className "navbar-item"
                                                            prop.href "#blog/"
                                                            prop.text " More posts "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "navbar-content"
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.classes [ "level"; "is-mobile" ]
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-left"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.strong "Stay up to date!"
                                                                                            ]
                                                                                        ]
                                                                                    ]
                                                                                ]
                                                                                Html.div [
                                                                                    prop.className "level-right"
                                                                                    prop.children [
                                                                                        Html.div [
                                                                                            prop.className "level-item"
                                                                                            prop.children [
                                                                                                Html.a [
                                                                                                    prop.classes [ "button"; "is-rss"; "is-small" ]
                                                                                                    prop.href "#atom.xml"
                                                                                                    prop.children [
                                                                                                        Html.span [
                                                                                                            prop.classes [ "icon"; "is-small" ]
                                                                                                            prop.children [
                                                                                                                Html.i [
                                                                                                                    prop.classes [ "fa"; "fa-rss" ]
                                                                                                                ]
                                                                                                            ]
                                                                                                        ]
                                                                                                        Html.span "Subscribe"
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
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.div [
                                                    prop.className "navbar-link"
                                                    prop.text "More "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "" ]
                                                    prop.id "moreDropdown"
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#extensions/"
                                                            prop.children [
                                                                Html.div [
                                                                    prop.classes [ "level"; "is-mobile" ]
                                                                    prop.children [
                                                                        Html.div [
                                                                            prop.className "level-left"
                                                                            prop.children [
                                                                                Html.div [
                                                                                    prop.className "level-item"
                                                                                    prop.children [
                                                                                        Html.p [
                                                                                            Html.strong "Extensions"
                                                                                            Html.text " "
                                                                                            Html.small "Side projects to enhance Bulma"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://twitter.com/jgthms"
                                            prop.target "_blank"
                                            prop.text " Twitter "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
                Html.text " "
                Html.h2 [
                    prop.className "subtitle"
                    prop.text "Transparent"
                ]
                Html.nav [
                    prop.classes [ "navbar"; "is-transparent" ]
                    prop.children [
                        Html.div [
                            prop.className "navbar-brand"
                            prop.children [
                                Html.a [
                                    prop.className "navbar-item"
                                    prop.href "https://bulma.io"
                                    prop.children [
                                        Html.img [
                                            prop.src "https://bulma.io/images/bulma-logo.png"
                                            prop.alt "Bulma: a modern CSS framework based on Flexbox"
                                            prop.width 112
                                            prop.height 28
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://github.com/jgthms/bulma"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #333;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-github" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "navbar-item"; "is-hidden-desktop" ]
                                    prop.href "https://twitter.com/jgthms"
                                    prop.target "_blank"
                                    prop.children [
                                        Html.span [
                                            prop.className "icon"
                                            prop.style "color: #55acee;"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fab"; "fa-twitter" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.div [
                                    prop.classes [ "navbar-burger"; "burger" ]
                                    prop.dataTarget "navMenuExamplet"
                                    prop.children [
                                        Html.span []
                                        Html.span []
                                        Html.span []
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className "navbar-menu"
                            prop.id "navMenuExamplet"
                            prop.children [
                                Html.div [
                                    prop.className "navbar-start"
                                    prop.children [
                                        Html.a [
                                            prop.classes [ "navbar-item"; "" ]
                                            prop.href "#"
                                            prop.text "Home "
                                        ]
                                        Html.div [
                                            prop.classes [ "navbar-item"; "has-dropdown"; "is-hoverable" ]
                                            prop.children [
                                                Html.a [
                                                    prop.classes [ "navbar-link"; ""; "is-active" ]
                                                    prop.href "#"
                                                    prop.text "Docs "
                                                ]
                                                Html.div [
                                                    prop.classes [ "navbar-dropdown"; "is-boxed" ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text "Overview "
                                                        ]
                                                        Html.a [
                                                            prop.classes [ "navbar-item"; "" ]
                                                            prop.href "#"
                                                            prop.text " Discover "
                                                        ]
                                                        Html.hr [
                                                            prop.className "navbar-divider"
                                                        ]
                                                        Html.div [
                                                            prop.className "navbar-item"
                                                            prop.children [
                                                                Html.div [
                                                                    Html.text "version "
                                                                    Html.p [
                                                                        prop.classes [ "has-text-info"; "is-size-6-desktop" ]
                                                                        prop.text "0.4.3"
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
                                    prop.className "navbar-end"
                                    prop.children [
                                        Html.a [
                                            prop.className "navbar-item"
                                            prop.href "https://github.com/jgthms/bulma"
                                            prop.target "_blank"
                                            prop.text "Github "
                                        ]
                                        Html.div [
                                            prop.className "navbar-item"
                                            prop.children [
                                                Html.div [
                                                    prop.classes [ "field"; "is-grouped" ]
                                                    prop.children [
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.className "button"
                                                                    prop.id "twitter"
                                                                    prop.children [
                                                                        Html.span "Tweet"
                                                                    ]
                                                                ]
                                                            ]
                                                        ]
                                                        Html.p [
                                                            prop.className "control"
                                                            prop.children [
                                                                Html.a [
                                                                    prop.classes [ "button"; "is-primary" ]
                                                                    prop.href "https://github.com/jgthms/bulma/archive/0.4.3.zip"
                                                                    prop.children [
                                                                        Html.span [
                                                                            prop.className "icon"
                                                                            prop.children [
                                                                                Html.i [
                                                                                    prop.classes [ "fa"; "fa-download" ]
                                                                                ]
                                                                            ]
                                                                        ]
                                                                        Html.span "Download"
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
        Html.section [
            prop.className "section"
            prop.id "pagination"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Pagination"
                ]
                Html.hr []
                Html.nav [
                    prop.className "pagination"
                    prop.children [
                        Html.a [
                            prop.classes [ "pagination-previous"; "is-disabled" ]
                            prop.text "Previous"
                        ]
                        Html.a [
                            prop.className "pagination-next"
                            prop.text "Next page"
                        ]
                        Html.ul [
                            prop.className "pagination-list"
                            prop.children [
                                Html.li [
                                    Html.a [
                                        prop.className "pagination-link"
                                        prop.text "1"
                                    ]
                                ]
                                Html.li [
                                    Html.span [
                                        prop.className "pagination-ellipsis"
                                        prop.text "…"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.className "pagination-link"
                                        prop.text "45"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.classes [ "pagination-link"; "is-current" ]
                                        prop.text "46"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.className "pagination-link"
                                        prop.text "47"
                                    ]
                                ]
                                Html.li [
                                    Html.span [
                                        prop.className "pagination-ellipsis"
                                        prop.text "…"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.className "pagination-link"
                                        prop.text "86"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.nav [
                    prop.ariaLabel "pagination"
                    prop.classes [ "pagination"; "is-rounded" ]
                    prop.role "navigation"
                    prop.children [
                        Html.a [
                            prop.className "pagination-previous"
                            prop.text "Previous"
                        ]
                        Html.a [
                            prop.className "pagination-next"
                            prop.text "Next page"
                        ]
                        Html.ul [
                            prop.className "pagination-list"
                            prop.children [
                                Html.li [
                                    Html.a [
                                        prop.ariaLabel "Goto page 1"
                                        prop.className "pagination-link"
                                        prop.text "1"
                                    ]
                                ]
                                Html.li [
                                    Html.span [
                                        prop.className "pagination-ellipsis"
                                        prop.text "…"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.ariaLabel "Goto page 45"
                                        prop.className "pagination-link"
                                        prop.text "45"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.ariaCurrent "page"
                                        prop.ariaLabel "Page 46"
                                        prop.classes [ "pagination-link"; "is-current" ]
                                        prop.text "46"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.ariaLabel "Goto page 47"
                                        prop.className "pagination-link"
                                        prop.text "47"
                                    ]
                                ]
                                Html.li [
                                    Html.span [
                                        prop.className "pagination-ellipsis"
                                        prop.text "…"
                                    ]
                                ]
                                Html.li [
                                    Html.a [
                                        prop.ariaLabel "Goto page 86"
                                        prop.className "pagination-link"
                                        prop.text "86"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "panel"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Panel"
                ]
                Html.hr []
                Html.div [
                    prop.classes [ "column"; "is-4" ]
                    prop.children [
                        Html.nav [
                            prop.className "panel"
                            prop.children [
                                Html.p [
                                    prop.className "panel-heading"
                                    prop.text "Repositories "
                                ]
                                Html.div [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.p [
                                            prop.classes [ "control"; "has-icons-left" ]
                                            prop.children [
                                                Html.input [
                                                    prop.classes [ "input"; "is-small" ]
                                                    prop.type' "text"
                                                    prop.placeholder "Search"
                                                ]
                                                Html.span [
                                                    prop.classes [ "icon"; "is-small"; "is-left" ]
                                                    prop.children [
                                                        Html.i [
                                                            prop.classes [ "fa"; "fa-search" ]
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.p [
                                    prop.className "panel-tabs"
                                    prop.children [
                                        Html.a [
                                            prop.className "is-active"
                                            prop.text "All"
                                        ]
                                        Html.a "Public"
                                        Html.a "Private"
                                        Html.a "Sources"
                                        Html.a "Forks"
                                    ]
                                ]
                                Html.a [
                                    prop.classes [ "panel-block"; "is-active" ]
                                    prop.children [
                                        Html.span [
                                            prop.className "panel-icon"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-book" ]
                                                ]
                                            ]
                                        ]
                                        Html.text " bulma"
                                    ]
                                ]
                                Html.a [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.span [
                                            prop.className "panel-icon"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-book" ]
                                                ]
                                            ]
                                        ]
                                        Html.text " marksheet"
                                    ]
                                ]
                                Html.a [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.span [
                                            prop.className "panel-icon"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-book" ]
                                                ]
                                            ]
                                        ]
                                        Html.text " minireset.css"
                                    ]
                                ]
                                Html.a [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.span [
                                            prop.className "panel-icon"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-book" ]
                                                ]
                                            ]
                                        ]
                                        Html.text " jgthms.github.io"
                                    ]
                                ]
                                Html.a [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.span [
                                            prop.className "panel-icon"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-code-branch" ]
                                                ]
                                            ]
                                        ]
                                        Html.text " daniellowtw/infBoard"
                                    ]
                                ]
                                Html.a [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.span [
                                            prop.className "panel-icon"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-code-branch" ]
                                                ]
                                            ]
                                        ]
                                        Html.text " mojs"
                                    ]
                                ]
                                Html.label [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.input [
                                            prop.type' "checkbox"
                                        ]
                                        Html.text " Remember me"
                                    ]
                                ]
                                Html.div [
                                    prop.className "panel-block"
                                    prop.children [
                                        Html.button [
                                            prop.classes [ "button"; "is-primary"; "is-outlined"; "is-fullwidth" ]
                                            prop.text "Reset all filters"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.section [
            prop.className "section"
            prop.id "tabs"
            prop.children [
                Html.h1 [
                    prop.className "title"
                    prop.text "Tabs"
                ]
                Html.hr []
                Html.div [
                    prop.className "tabs"
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a "Pictures"
                                ]
                            ]
                            Html.li [
                                Html.a "Music"
                            ]
                            Html.li [
                                Html.a "Videos"
                            ]
                            Html.li [
                                Html.a "Documents"
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-centered" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a [
                                        Html.span [
                                            prop.classes [ "icon"; "is-small" ]
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-image" ]
                                                ]
                                            ]
                                        ]
                                        Html.span "Pictures"
                                    ]
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-music" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Music"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-film" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Videos"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-file-alt" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Documents"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-small" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a "Pictures"
                                ]
                            ]
                            Html.li [
                                Html.a "Music"
                            ]
                            Html.li [
                                Html.a "Videos"
                            ]
                            Html.li [
                                Html.a "Documents"
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-medium" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a "Pictures"
                                ]
                            ]
                            Html.li [
                                Html.a "Music"
                            ]
                            Html.li [
                                Html.a "Videos"
                            ]
                            Html.li [
                                Html.a "Documents"
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-large" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a "Pictures"
                                ]
                            ]
                            Html.li [
                                Html.a "Music"
                            ]
                            Html.li [
                                Html.a "Videos"
                            ]
                            Html.li [
                                Html.a "Documents"
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-boxed" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a [
                                        Html.span [
                                            prop.classes [ "icon"; "is-small" ]
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-image" ]
                                                ]
                                            ]
                                        ]
                                        Html.span "Pictures"
                                    ]
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-music" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Music"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-film" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Videos"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-file-alt" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Documents"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-toggle" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a [
                                        Html.span [
                                            prop.classes [ "icon"; "is-small" ]
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-image" ]
                                                ]
                                            ]
                                        ]
                                        Html.span "Pictures"
                                    ]
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-music" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Music"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-film" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Videos"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-file-alt" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Documents"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-toggle"; "is-toggle-rounded" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a [
                                        Html.span [
                                            prop.classes [ "icon"; "is-small" ]
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-image" ]
                                                ]
                                            ]
                                        ]
                                        Html.span "Pictures"
                                    ]
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-music" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Music"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-film" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Videos"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-file-alt" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Documents"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-fullwidth" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.className "icon"
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-angle-left" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Left"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.className "icon"
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-angle-up" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Up"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span "Right"
                                    Html.span [
                                        prop.className "icon"
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-angle-right" ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-centered"; "is-boxed" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a [
                                        Html.span [
                                            prop.classes [ "icon"; "is-small" ]
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-image" ]
                                                ]
                                            ]
                                        ]
                                        Html.span "Pictures"
                                    ]
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-music" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Music"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-film" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Videos"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.classes [ "icon"; "is-small" ]
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-file-alt" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Documents"
                                ]
                            ]
                        ]
                    ]
                ]
                Html.text " "
                Html.div [
                    prop.classes [ "tabs"; "is-toggle"; "is-fullwidth"; "is-large" ]
                    prop.children [
                        Html.ul [
                            Html.li [
                                prop.className "is-active"
                                prop.children [
                                    Html.a [
                                        Html.span [
                                            prop.className "icon"
                                            prop.children [
                                                Html.i [
                                                    prop.classes [ "fa"; "fa-image" ]
                                                ]
                                            ]
                                        ]
                                        Html.span "Pictures"
                                    ]
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.className "icon"
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-music" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Music"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.className "icon"
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-film" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Videos"
                                ]
                            ]
                            Html.li [
                                Html.a [
                                    Html.span [
                                        prop.className "icon"
                                        prop.children [
                                            Html.i [
                                                prop.classes [ "fa"; "fa-file-alt" ]
                                            ]
                                        ]
                                    ]
                                    Html.span "Documents"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
]