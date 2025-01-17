namespace FS.FluentUI

open Fable.Core
open Feliz

type DataTabster = {
    ``data-tabster``: string
}

type [<RequireQualifiedAccess>] InputDefaultAppearance = | ``outline`` | ``filled-darker`` | ``filled-lighter``
type OverridesContextValue_unstable = {
    inputDefaultAppearance: InputDefaultAppearance
}

type TagGroupDismissData = {
    dismissedTagValue: string
}

type FieldControlProps = {
    id: string
    ``aria-labelledby`` : string
    ``aria-describedby`` : string
    ``aria-invalid`` : bool
    ``aria-required`` : bool
}

type PartitionBreadcrumbItemsOptions<'T> = {
    items: array<'T>
    maxDisplayedItems: int
    overflowIndex: int
}

type PartitionBreadcrumbItems<'T> = {
    endDisplayedItems: array<'T>
    overflowItems: array<'T>
    startDisplayedItems: array<'T>
}

module FieldControlProps =
    let toReactProperties (props: FieldControlProps): IReactProperty list =
        [
            prop.id props.id
            prop.ariaLabelledBy props.``aria-labelledby``
            prop.ariaDescribedBy props.``aria-describedby``
            prop.ariaInvalid props.``aria-invalid``
            prop.ariaRequired props.``aria-required``
        ]

type IgnoreKeyDown = {
    Tab: bool
    Escape: bool
    Enter: bool
    ArrowUp: bool
    ArrowDown: bool
    ArrowLeft: bool
    ArrowRight: bool
    PageUp: bool
    PageDown: bool
    Home: bool
    End: bool
}

type ModalAttributes = {
    modalAttributes: IReactProperty
    triggerAttributes: IReactProperty
}

type ModalTabsters = {
    modalAttributes: DataTabster
    triggerAttributes: DataTabster
}

type SyntheticEvent = {
    nativeEvent: Browser.Types.MouseEvent
    currentTarget: Browser.Types.HTMLElement
    target: Browser.Types.HTMLElement
    bubbles: bool
    cancelable: bool
    defaultPrevented: bool
    eventPhase: int
    isTrusted: bool
    preventDefault: unit -> unit
    isDefaultPrevented: unit -> bool
    stopPropagation: unit -> unit
    isPropagationStopped: unit -> bool
    persist: unit -> unit
    timeStamp: int
    ``type``: string
}

type RefObject<'T> = {
    current: 'T option
}

/// Render function interface for providing overrideable render callbacks.
type [<Erase>] IRenderFunction<'P> = 'P -> ('P -> ReactElement) -> ReactElement

type ValueProp<'t> = { value: 't }

type OpenProp = { ``open``: bool }

type SelectedProp = { selected: bool }

type MenuCheckedValueChangeData = {
    /// The items for this value that are checked
    checkedItems: string array
    /// The name of the value
    name: string
}

type MenuOpenChangeData = {
    /// indicates whether the request for the open state was bubbled from a nested menu
    bubble: bool option
    /// Indicates whether the change of state was a keyboard interaction
    /// @deprecated
    /// This should not be used, since `Enter`, `Space` and click should be interpreted as the same thing as a click
    keyboard: bool option
    ``open``: bool
}

type MenuTriggerChildProps = {
    ``aria-haspopup``: string option
    ``aria-expanded``: bool option
    id: string
    ref: IRefValue<obj>
    onMouseEnter: Browser.Types.MouseEvent -> unit
    onMouseLeave: Browser.Types.MouseEvent -> unit
    onMouseMove: Browser.Types.MouseEvent -> unit
    onContextMenu: Browser.Types.MouseEvent -> unit
}

type PopoverTriggerChildProps = {
    ``aria-expanded``: bool
    ref: IRefValue<obj>
    onMouseEnter: Browser.Types.MouseEvent -> unit
    onMouseLeave: Browser.Types.MouseEvent -> unit
    onContextMenu: Browser.Types.MouseEvent -> unit
}

type OffsetObject = {
    crossAxis: int option
    mainAxis: int
}

type OverflowBoundaryPadding = {
    top: int
    ``end``: int
    bottom: int
    start: int
}

type PositioningImperativeRef = {
    /// Updates the position imperatively.
    /// Useful when the position of the target changes from other factors than scrolling of window resize.
    updatePosition: unit -> unit
    /// Sets the target and updates positioning imperatively.
    /// Useful for avoiding double renders with the target option.
    setTarget: Browser.Types.HTMLElement option -> unit
}

type OnVisibleChangeData = {
    visible: bool
}

type MountNode = {
    element: Browser.Types.HTMLElement option
    className: string
}

type ChangeEvent = {
    target: Browser.Types.EventTarget
}

type CheckState = | Checked | Unchecked | Mixed

module CheckState =
    let fromData (arg: {| ``checked``: U2<string, bool> |}) =
        match arg.``checked`` with
        | U2.Case1 _ -> Mixed
        | U2.Case2 b -> if b then Checked else Unchecked

module Checkbox =
    let toBool (arg: {| ``checked``: U2<string, bool> |}) =
        match arg.``checked`` with
        | U2.Case1 _ -> true
        | U2.Case2 b -> b

type SwitchOnChangeData = {
    ``checked``: bool
}

type SpinButtonOnChangeData = {
    value: int option
    displayValue: string
}

type OptionOnSelectData = {
    optionValue: string option
    optionText: string option
    selectedOptions: string array
}

type ToolbarCheckedValueChangeData = {
    /// The items for this value that are checked
    checkedItems: string array
    /// The name of the value
    name: string
}

type PartitionAvatarGroupItems<'T> = {
    inlineItems: array<'T>
    overflowItems: array<'T>
}

type [<RequireQualifiedAccess>] DialogChange = | ``escapeKeyDown`` | ``backdropClick`` | ``triggerClick``

type DialogOpenChangeEvent = | MouseEvent | KeyboardEvent

type DialogOpenChangeData = {
    ``type``: DialogChange
    ``open``: bool
    event: DialogOpenChangeEvent
}

type [<RequireQualifiedAccess>] DialogTriggerAction = ``open`` | ``close``


type FocusProp = {
    focus: unit -> unit
}

type OverflowMenuOptions<'Element> = {
    ref: IRefValue<'Element option>
    overflowCount: int
    isOverflowing: bool
}

type [<RequireQualifiedAccess>] OverflowGroupState = visible | hidden | overflow

type VirtualizerContextProps = {
    contextIndex:  int
    setContextIndex: int -> unit
}

type VirtualizerDataRef = {
    progressiveSizes: RefObject<int array>
    nodeSizes: RefObject<int array>
    setFlaggedIndex: int option -> unit
    currentIndex: RefObject<int>
}

type VirtualizerMeasure = {
    virtualizerLength: int
    bufferItems: int
    bufferSize: int
    scrollRef: Browser.Types.Element -> unit
}
type MutableRefObject<'T> = {
    current: 'T
}

type [<RequireQualifiedAccess>] ScrollBehavior = ``auto`` | ``instant`` | ``smooth``

type ScrollToInterface = {
    scrollTo: int -> ScrollBehavior -> (int -> unit) -> unit
    virtualizerLength: RefObject<int>
    currentIndex: RefObject<int> option
}

type [<RequireQualifiedAccess>] AriaLivePoliteness = ``polite`` | ``assertive``

type AnnounceOptions = {
    politeness: AriaLivePoliteness
}

//-------------------------------------------------------------------------- DataGrid / Table Types ---------------------------------------------------------------

type TempSeq<'T> = { selectedItems: seq<'T> }

type OnSelectionChangeData<'T> = { selectedItems: list<'T> }
module TempSeq =
    let mkOnChangeData (v: TempSeq<'T>)=
        { selectedItems = v.selectedItems |> List.ofSeq }

type [<RequireQualifiedAccess>] SortDirection = | ``ascending`` | ``descending``

type SortState<'TKeyType> = {
    sortColumn: 'TKeyType option
    sortDirection: SortDirection
}

type TableColumnSizingOptions = {
    minWidth: int
    idealWidth: int
    padding: int
    defaultWidth: int
}

type ColumnResizeData<'TKeyType> = {
    columnId: 'TKeyType
    width: int
}


type [<RequireQualifiedAccess>] TableSelectionMode = | single | multiselect

type TableRowData<'T, 'TKeyType> = {
    /// User provided data
    item: 'T
    /// The row id, defaults to index position in the collection
    rowId: 'TKeyType
}

type TableColumnDefinition<'T, 'TKeyType> = {
    columnId: 'TKeyType
    compare: ('T * 'T) -> int
    renderHeaderCell: unit -> ReactElement
    renderCell: 'T -> ReactElement
}


type [<RequireQualifiedAccess>] DataGridFocusMode = ``none`` | ``cell`` | ``row_unstable`` | ``composite``

type [<RequireQualifiedAccess>] Appearance = ``brand`` | ``neutral`` | ``none``

type TableRowProps = {
    /// A table row can have different variants. These appearances are
    /// intended to be used with selection.
    appearance: Appearance
}

type FocusFinders = {
    findAllFocusable: Browser.Types.HTMLElement -> ((Browser.Types.HTMLElement -> bool) option) -> Browser.Types.HTMLElement array
    findFirstFocusable: Browser.Types.HTMLElement -> Browser.Types.HTMLElement option
    findLastFocusable: Browser.Types.HTMLElement -> Browser.Types.HTMLElement option
    findNextFocusable: Browser.Types.HTMLElement  -> Browser.Types.HTMLElement -> Browser.Types.HTMLElement option
    findPrevFocusable: Browser.Types.HTMLElement -> Browser.Types.HTMLElement -> Browser.Types.HTMLElement
}

type DataGridContextValue = {
    /// How focus navigation will work in the datagrid
    focusMode: DataGridFocusMode
    /// Lets child components know if rows selection is enabled
    /// selectionMode prop enables row selection on the component
    selectableRows: bool
    /// Enables subtle selection style
    subtleSelection: bool
    /// Row appearance when selected
    selectionAppearance: TableRowProps
    /// Enables column resizing
    resizableColumns: bool option
    compositeRowTabsterAttribute: obj
}

// --------------------------------------------------------------------- Toast Types -----------------------------------------------------------------------------------

type ToasterShortcuts = {
    focus: Browser.Types.KeyboardEvent -> bool
}

type ToastOffset = {
    horizontal: int
    vertical: int
}

type [<RequireQualifiedAccess>] ToastPosition = ``top-end`` | ``top-start`` | ``bottom-end`` | ``bottom-start``

type [<RequireQualifiedAccess>] ToastPoliteness = ``assertive`` | ``polite``

type [<RequireQualifiedAccess>] ToastIntent = ``info`` | ``success`` | ``error`` | ``warning``

type [<RequireQualifiedAccess>] ToastStatus = ``queued`` | ``visible`` | ``dismissed`` | ``unmounted``

type DispatchToastOptions = {
    /// Uniquely identifies a toast, used for update and dismiss operations
    toastId: string
    /// The position the toast should render to
    position: ToastPosition
    /// Toast content
    content: ReactElement
    /// Auto dismiss timeout in milliseconds
    timeout: int
    /// Toast timeout pauses while focus is on another window
    pauseOnWindowBlur: bool
    /// Toast timeout pauses while user cursor is on the toast
    pauseOnHover: bool
    /// Higher priority toasts will be rendered before lower priority toasts
    priority: int
    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    politeness: ToastPoliteness
    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    intent: ToastIntent
    /// Additional data that needs to be passed to the toast
    data: obj
    /// Reports changes to the Toast lifecycle
    onStatusChange: (unit ->  ToastChangeData -> unit) option
}
and ToastChangeData = {
    root: IReactProperty list option
    /// Uniquely identifies a toast, used for update and dismiss operations
    toastId: string
    /// The position the toast should render to
    position: ToastPosition
    /// Toast content
    content: ReactElement
    /// Auto dismiss timeout in milliseconds
    /// @default 3000
    timeout: int
    /// Toast timeout pauses while focus is on another window
    /// @default false
    pauseOnWindowBlur: bool
    /// Toast timeout pauses while user cursor is on the toast
    /// @default false
    pauseOnHover: bool
    /// Toast belongs to a specific toaster
    toasterId: string
    /// Higher priority toasts will be rendered before lower priority toasts
    priority: int
    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    politeness: ToastPoliteness
    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    /// @default info
    intent: ToastIntent
    /// Additional data that needs to be passed to the toast
    data: obj //TODO
    /// Reports changes to the Toast lifecycle
    onStatusChange: ToastChangeHandler option
    status: ToastStatus
    updateId: int
}
and ToastChangeHandler = Browser.Types.MouseEvent -> ToastChangeData -> unit //TODO the first of the tuple is "null" in the docs

type UpdateToastOptions = {
    root: IReactProperty list
    /// Uniquely identifies a toast, used for update and dismiss operations
    toastId: string
    /// The position the toast should render to
    position: ToastPosition
    /// Toast content
    content: ReactElement
    /// Auto dismiss timeout in milliseconds
    /// @default 3000
    timeout: int
    /// Toast timeout pauses while focus is on another window
    /// @default false
    pauseOnWindowBlur: bool
    /// Toast timeout pauses while user cursor is on the toast
    /// @default false
    pauseOnHover: bool
    /// Toast belongs to a specific toaster
    toasterId: string
    /// Higher priority toasts will be rendered before lower priority toasts
    priority: int
    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    politeness: ToastPoliteness
    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    /// @default info
    intent: ToastIntent
    /// Additional data that needs to be passed to the toast
    data: obj
    /// Reports changes to the Toast lifecycle
    onStatusChange: ToastChangeHandler option
}

type [<Erase>] IUpdateToastOptionsProp = interface end
type [<Erase>] IDispatchToastOptionsProp = interface end

type ToastController = {
    dispatchToast: ReactElement * IDispatchToastOptionsProp list -> unit
    /// Takes a `toastId`
    dismissToast: string -> unit
    dismissAllToasts: unit -> unit
    updateToast: IUpdateToastOptionsProp list -> unit
    /// Takes a `toastId`
    pauseToast: string -> unit
    /// Takes a `toastId`
    playToast: string -> unit
}

// --------------------------------------------------------------------------------- Calendar / Date Types ------------------------------------------------------------------

type DateRangeType = | Day | Week | Month | WorkWeek

type [<RequireQualifiedAccess>] DatePickerErrorType = | ``invalid-input`` | ``out-of-bounds`` | ``required-input``

type DatePickerValidationResultData = {
    /// The error found when validating the input.
    error: DatePickerErrorType option
}

module DatePickerValidationResultData =
    let fromString (result: {| error: string option |}) =
        match result.error with
        | Some "invalid-input" -> { error= Some DatePickerErrorType.``invalid-input`` }
        | Some "out-of-bounds" -> { error= Some DatePickerErrorType.``out-of-bounds`` }
        | Some "required-input" -> { error= Some DatePickerErrorType.``required-input`` }
        | _ -> { error = None }

type DatePickerErrorStrings = {
    ``invalid-input`` : string
    ``out-of-bounds`` : string
    ``required-input``: string
}

module DatePickerErrorStrings =
    let default' = {
        ``invalid-input`` = "Invalid date format"
        ``out-of-bounds`` = "Date is out of bounds"
        ``required-input``= "Field is required"
    }

    let fromErrorTypeOption (error: DatePickerErrorType option) =
        match error with
        | Some DatePickerErrorType.``invalid-input`` -> "Invalid date format"
        | Some DatePickerErrorType.``out-of-bounds`` -> "Date is out of bounds"
        | Some DatePickerErrorType.``required-input`` -> "Field is required"
        | _ -> ""

type DateGridStrings = {
    /// An array of strings for the full names of months.
    /// The array is 0-based, so months[0] should be the full name of January.
    months: string array
    /// An array of strings for the short names of months.
    /// The array is 0-based, so shortMonths[0] should be the short name of January.
    shortMonths: string array
    /// An array of strings for the full names of days of the week.
    /// The array is 0-based, so days[0] should be the full name of Sunday.
    days: string array
    /// An array of strings for the initials of the days of the week.
    /// The array is 0-based, so days[0] should be the initial of Sunday.
    shortDays: string array
}

type DateFormatting = {
    /// Get a localized string for a day.
    /// The text for each day of the month
    formatDay: System.DateTime -> string
    /// Get a localized string for a month.
    formatMonth: System.DateTime -> DateGridStrings -> string
    /// Get a localized string for a year.
    /// The "2023" text at top of month picker
    formatYear: System.DateTime -> string
    /// Get a localized string for a month, day, and year.
    formatMonthDayYear: System.DateTime -> DateGridStrings -> string
    /// Get a localized string for a month and year.
    /// The "September 2023" text at top of calendar
    formatMonthYear: System.DateTime -> DateGridStrings -> string
}

type CalendarStrings = {
    /// String to render for button to direct the user to today's date.
    goToToday: string
    /// Aria-label for the "previous month" button in day picker.
    prevMonthAriaLabel: string option
    /// Aria-label for the "next month" button in day picker.
    nextMonthAriaLabel: string option
    /// Aria-label for the "previous year" button in month picker.
    prevYearAriaLabel: string option
    /// Aria-label for the "next year" button in month picker.
    nextYearAriaLabel: string option
    /// Aria-label for the "previous year range" button in year picker.
    prevYearRangeAriaLabel: string option
    /// Aria-label for the "next year range" button in year picker.
    nextYearRangeAriaLabel: string option
    /// Aria-label format string for the header button in the month picker. Should have 1 string param, e.g. "`{0}`,
    /// select to change the year". This aria-label will only be applied if the year picker is enabled; otherwise
    /// the label will default to the header string, e.g. "2019".
    monthPickerHeaderAriaLabel: string option
    /// Aria-label format string for the header button in the year picker.
    /// Should have 1 string param, e.g. "`{0}`, select to change the month"
    yearPickerHeaderAriaLabel: string option
    /// Aria-label for the "close" button.
    closeButtonAriaLabel: string option
    /// Aria-label format string for the week number header. Should have 1 string param, e.g. "week number `{0}`"
    weekNumberFormatString: string option
    /// Aria-label format string for the currently selected date. Should have 1 string param, e.g. "Selected date `{0}`"
    selectedDateFormatString: string option
    /// Aria-label format string for today's date. Should have 1 string param, e.g. "Today's date `{0}`"
    todayDateFormatString: string option
    /// Aria-label for when a date is marked
    dayMarkedAriaLabel: string option
    months: string array
    shortMonths: string array
    days: string array
    shortDays: string array
}

type CalendarDayGridStyles = {
    /// The style for the root div
    wrapper: string
    /// The style for the table containing the grid
    table: string
    /// The style to apply to the grid cells for days
    dayCell: string
    /// The style to apply to grid cells for days in the selected range
    daySelected: string
    /// The style to apply to row around weeks
    weekRow: string
    /// The style to apply to the column headers above the weeks
    weekDayLabelCell: string
    /// The style to apply to grid cells for week numbers
    weekNumberCell: string
    /// The style to apply to individual days that are outside the min/max date range
    dayOutsideBounds: string
    /// The style to apply to individual days that are outside the current month
    dayOutsideNavigatedMonth: string
    /// The style to apply to the button element within the day cells
    dayButton: string
    /// The style to apply to the individual button element that matches the "today" parameter
    dayIsToday: string
    /// The style applied to the first placeholder week used during transitions
    firstTransitionWeek: string
    /// The style applied to the last placeholder week used during transitions
    lastTransitionWeek: string
    /// The style applied to the marker on days to mark as important
    dayMarker: string
}

type  FirstWeekOfYear = | FirstDay  | FirstFullWeek | FirstFourDayWeek
// ----------------------------------------------------------------------------- Theme Types ---------------------------------------------------------------------------
type [<AllowNullLiteral>] StylesClassMapping<'TStyleSet> = interface end

type MakeStyle = { displayName: string; styles: IStyleAttribute list }

type BrandVariants = {
    ``10``: string
    ``20``: string
    ``30``: string
    ``40``: string
    ``50``: string
    ``60``: string
    ``70``: string
    ``80``: string
    ``90``: string
    ``100``: string
    ``110``: string
    ``120``: string
    ``130``: string
    ``140``: string
    ``150``: string
    ``160``: string
}

type Tokens = {
    borderRadiusCircular: string
    borderRadiusLarge: string
    borderRadiusMedium: string
    borderRadiusNone: string
    borderRadiusSmall: string
    borderRadiusXLarge: string
    colorBackgroundOverlay: string
    colorBrandBackground: string
    colorBrandBackground2: string
    colorBrandBackground2Hover: string
    colorBrandBackground2Pressed: string
    colorBrandBackgroundHover: string
    colorBrandBackgroundInverted: string
    colorBrandBackgroundInvertedHover: string
    colorBrandBackgroundInvertedPressed: string
    colorBrandBackgroundInvertedSelected: string
    colorBrandBackgroundPressed: string
    colorBrandBackgroundSelected: string
    colorBrandBackgroundStatic: string
    colorBrandForeground1: string
    colorBrandForeground2: string
    colorBrandForeground2Hover: string
    colorBrandForeground2Pressed: string
    colorBrandForegroundInverted: string
    colorBrandForegroundInvertedHover: string
    colorBrandForegroundInvertedPressed: string
    colorBrandForegroundLink: string
    colorBrandForegroundLinkHover: string
    colorBrandForegroundLinkPressed: string
    colorBrandForegroundLinkSelected: string
    colorBrandForegroundOnLight: string
    colorBrandForegroundOnLightHover: string
    colorBrandForegroundOnLightPressed: string
    colorBrandForegroundOnLightSelected: string
    colorBrandShadowAmbient: string
    colorBrandShadowKey: string
    colorBrandStroke1: string
    colorBrandStroke2: string
    colorBrandStroke2Hover: string
    colorBrandStroke2Pressed: string
    colorCompoundBrandBackground: string
    colorCompoundBrandBackgroundHover: string
    colorCompoundBrandBackgroundPressed: string
    colorCompoundBrandForeground1: string
    colorCompoundBrandForeground1Hover: string
    colorCompoundBrandForeground1Pressed: string
    colorCompoundBrandStroke: string
    colorCompoundBrandStrokeHover: string
    colorCompoundBrandStrokePressed: string
    colorNeutralBackground1: string
    colorNeutralBackground1Hover: string
    colorNeutralBackground1Pressed: string
    colorNeutralBackground1Selected: string
    colorNeutralBackground2: string
    colorNeutralBackground2Hover: string
    colorNeutralBackground2Pressed: string
    colorNeutralBackground2Selected: string
    colorNeutralBackground3: string
    colorNeutralBackground3Hover: string
    colorNeutralBackground3Pressed: string
    colorNeutralBackground3Selected: string
    colorNeutralBackground4: string
    colorNeutralBackground4Hover: string
    colorNeutralBackground4Pressed: string
    colorNeutralBackground4Selected: string
    colorNeutralBackground5: string
    colorNeutralBackground5Hover: string
    colorNeutralBackground5Pressed: string
    colorNeutralBackground5Selected: string
    colorNeutralBackground6: string
    colorNeutralBackgroundAlpha: string
    colorNeutralBackgroundAlpha2: string
    colorNeutralBackgroundDisabled: string
    colorNeutralBackgroundInverted: string
    colorNeutralBackgroundInvertedDisabled: string
    colorNeutralBackgroundStatic: string
    colorNeutralForeground1: string
    colorNeutralForeground1Hover: string
    colorNeutralForeground1Pressed: string
    colorNeutralForeground1Selected: string
    colorNeutralForeground1Static: string
    colorNeutralForeground2: string
    colorNeutralForeground2BrandHover: string
    colorNeutralForeground2BrandPressed: string
    colorNeutralForeground2BrandSelected: string
    colorNeutralForeground2Hover: string
    colorNeutralForeground2Link: string
    colorNeutralForeground2LinkHover: string
    colorNeutralForeground2LinkPressed: string
    colorNeutralForeground2LinkSelected: string
    colorNeutralForeground2Pressed: string
    colorNeutralForeground2Selected: string
    colorNeutralForeground3: string
    colorNeutralForeground3BrandHover: string
    colorNeutralForeground3BrandPressed: string
    colorNeutralForeground3BrandSelected: string
    colorNeutralForeground3Hover: string
    colorNeutralForeground3Pressed: string
    colorNeutralForeground3Selected: string
    colorNeutralForeground4: string
    colorNeutralForegroundDisabled: string
    colorNeutralForegroundInverted: string
    colorNeutralForegroundInverted2: string
    colorNeutralForegroundInvertedDisabled: string
    colorNeutralForegroundInvertedHover: string
    colorNeutralForegroundInvertedLink: string
    colorNeutralForegroundInvertedLinkHover: string
    colorNeutralForegroundInvertedLinkPressed: string
    colorNeutralForegroundInvertedLinkSelected: string
    colorNeutralForegroundInvertedPressed: string
    colorNeutralForegroundInvertedSelected: string
    colorNeutralForegroundOnBrand: string
    colorNeutralForegroundStaticInverted: string
    colorNeutralShadowAmbient: string
    colorNeutralShadowAmbientDarker: string
    colorNeutralShadowAmbientLighter: string
    colorNeutralShadowKey: string
    colorNeutralShadowKeyDarker: string
    colorNeutralShadowKeyLighter: string
    colorNeutralStencil1: string
    colorNeutralStencil1Alpha: string
    colorNeutralStencil2: string
    colorNeutralStencil2Alpha: string
    colorNeutralStroke1: string
    colorNeutralStroke1Hover: string
    colorNeutralStroke1Pressed: string
    colorNeutralStroke1Selected: string
    colorNeutralStroke2: string
    colorNeutralStroke3: string
    colorNeutralStrokeAccessible: string
    colorNeutralStrokeAccessibleHover: string
    colorNeutralStrokeAccessiblePressed: string
    colorNeutralStrokeAccessibleSelected: string
    colorNeutralStrokeAlpha: string
    colorNeutralStrokeDisabled: string
    colorNeutralStrokeInvertedDisabled: string
    colorNeutralStrokeOnBrand: string
    colorNeutralStrokeOnBrand2: string
    colorNeutralStrokeOnBrand2Hover: string
    colorNeutralStrokeOnBrand2Pressed: string
    colorNeutralStrokeOnBrand2Selected: string
    colorNeutralStrokeSubtle: string
    colorPaletteAnchorBackground2: string
    colorPaletteAnchorBorderActive: string
    colorPaletteAnchorForeground2: string
    colorPaletteBeigeBackground2: string
    colorPaletteBeigeBorderActive: string
    colorPaletteBeigeForeground2: string
    colorPaletteBerryBackground1: string
    colorPaletteBerryBackground2: string
    colorPaletteBerryBackground3: string
    colorPaletteBerryBorder1: string
    colorPaletteBerryBorder2: string
    colorPaletteBerryBorderActive: string
    colorPaletteBerryForeground1: string
    colorPaletteBerryForeground2: string
    colorPaletteBerryForeground3: string
    colorPaletteBlueBackground2: string
    colorPaletteBlueBorderActive: string
    colorPaletteBlueForeground2: string
    colorPaletteBrassBackground2: string
    colorPaletteBrassBorderActive: string
    colorPaletteBrassForeground2: string
    colorPaletteBrownBackground2: string
    colorPaletteBrownBorderActive: string
    colorPaletteBrownForeground2: string
    colorPaletteCornflowerBackground2: string
    colorPaletteCornflowerBorderActive: string
    colorPaletteCornflowerForeground2: string
    colorPaletteCranberryBackground2: string
    colorPaletteCranberryBorderActive: string
    colorPaletteCranberryForeground2: string
    colorPaletteDarkGreenBackground2: string
    colorPaletteDarkGreenBorderActive: string
    colorPaletteDarkGreenForeground2: string
    colorPaletteDarkOrangeBackground1: string
    colorPaletteDarkOrangeBackground2: string
    colorPaletteDarkOrangeBackground3: string
    colorPaletteDarkOrangeBorder1: string
    colorPaletteDarkOrangeBorder2: string
    colorPaletteDarkOrangeBorderActive: string
    colorPaletteDarkOrangeForeground1: string
    colorPaletteDarkOrangeForeground2: string
    colorPaletteDarkOrangeForeground3: string
    colorPaletteDarkRedBackground2: string
    colorPaletteDarkRedBorderActive: string
    colorPaletteDarkRedForeground2: string
    colorPaletteForestBackground2: string
    colorPaletteForestBorderActive: string
    colorPaletteForestForeground2: string
    colorPaletteGoldBackground2: string
    colorPaletteGoldBorderActive: string
    colorPaletteGoldForeground2: string
    colorPaletteGrapeBackground2: string
    colorPaletteGrapeBorderActive: string
    colorPaletteGrapeForeground2: string
    colorPaletteGreenBackground1: string
    colorPaletteGreenBackground2: string
    colorPaletteGreenBackground3: string
    colorPaletteGreenBorder1: string
    colorPaletteGreenBorder2: string
    colorPaletteGreenBorderActive: string
    colorPaletteGreenForeground1: string
    colorPaletteGreenForeground2: string
    colorPaletteGreenForeground3: string
    colorPaletteGreenForegroundInverted: string
    colorPaletteLavenderBackground2: string
    colorPaletteLavenderBorderActive: string
    colorPaletteLavenderForeground2: string
    colorPaletteLightGreenBackground1: string
    colorPaletteLightGreenBackground2: string
    colorPaletteLightGreenBackground3: string
    colorPaletteLightGreenBorder1: string
    colorPaletteLightGreenBorder2: string
    colorPaletteLightGreenBorderActive: string
    colorPaletteLightGreenForeground1: string
    colorPaletteLightGreenForeground2: string
    colorPaletteLightGreenForeground3: string
    colorPaletteLightTealBackground2: string
    colorPaletteLightTealBorderActive: string
    colorPaletteLightTealForeground2: string
    colorPaletteLilacBackground2: string
    colorPaletteLilacBorderActive: string
    colorPaletteLilacForeground2: string
    colorPaletteMagentaBackground2: string
    colorPaletteMagentaBorderActive: string
    colorPaletteMagentaForeground2: string
    colorPaletteMarigoldBackground1: string
    colorPaletteMarigoldBackground2: string
    colorPaletteMarigoldBackground3: string
    colorPaletteMarigoldBorder1: string
    colorPaletteMarigoldBorder2: string
    colorPaletteMarigoldBorderActive: string
    colorPaletteMarigoldForeground1: string
    colorPaletteMarigoldForeground2: string
    colorPaletteMarigoldForeground3: string
    colorPaletteMinkBackground2: string
    colorPaletteMinkBorderActive: string
    colorPaletteMinkForeground2: string
    colorPaletteNavyBackground2: string
    colorPaletteNavyBorderActive: string
    colorPaletteNavyForeground2: string
    colorPalettePeachBackground2: string
    colorPalettePeachBorderActive: string
    colorPalettePeachForeground2: string
    colorPalettePinkBackground2: string
    colorPalettePinkBorderActive: string
    colorPalettePinkForeground2: string
    colorPalettePlatinumBackground2: string
    colorPalettePlatinumBorderActive: string
    colorPalettePlatinumForeground2: string
    colorPalettePlumBackground2: string
    colorPalettePlumBorderActive: string
    colorPalettePlumForeground2: string
    colorPalettePumpkinBackground2: string
    colorPalettePumpkinBorderActive: string
    colorPalettePumpkinForeground2: string
    colorPalettePurpleBackground2: string
    colorPalettePurpleBorderActive: string
    colorPalettePurpleForeground2: string
    colorPaletteRedBackground1: string
    colorPaletteRedBackground2: string
    colorPaletteRedBackground3: string
    colorPaletteRedBorder1: string
    colorPaletteRedBorder2: string
    colorPaletteRedBorderActive: string
    colorPaletteRedForeground1: string
    colorPaletteRedForeground2: string
    colorPaletteRedForeground3: string
    colorPaletteRedForegroundInverted: string
    colorPaletteRoyalBlueBackground2: string
    colorPaletteRoyalBlueBorderActive: string
    colorPaletteRoyalBlueForeground2: string
    colorPaletteSeafoamBackground2: string
    colorPaletteSeafoamBorderActive: string
    colorPaletteSeafoamForeground2: string
    colorPaletteSteelBackground2: string
    colorPaletteSteelBorderActive: string
    colorPaletteSteelForeground2: string
    colorPaletteTealBackground2: string
    colorPaletteTealBorderActive: string
    colorPaletteTealForeground2: string
    colorPaletteYellowBackground1: string
    colorPaletteYellowBackground2: string
    colorPaletteYellowBackground3: string
    colorPaletteYellowBorder1: string
    colorPaletteYellowBorder2: string
    colorPaletteYellowBorderActive: string
    colorPaletteYellowForeground1: string
    colorPaletteYellowForeground2: string
    colorPaletteYellowForeground3:string
    colorPaletteYellowForegroundInverted:string
    colorScrollbarOverlay:string
    colorStrokeFocus1:string
    colorStrokeFocus2:string
    colorSubtleBackground:string
    colorSubtleBackgroundHover: string
    colorSubtleBackgroundInverted: string
    colorSubtleBackgroundInvertedHover: string
    colorSubtleBackgroundInvertedPressed: string
    colorSubtleBackgroundInvertedSelected: string
    colorSubtleBackgroundLightAlphaHover: string
    colorSubtleBackgroundLightAlphaPressed: string
    colorSubtleBackgroundLightAlphaSelected: string
    colorSubtleBackgroundPressed: string
    colorSubtleBackgroundSelected: string
    colorTransparentBackground: string
    colorTransparentBackgroundHover: string
    colorTransparentBackgroundPressed: string
    colorTransparentBackgroundSelected: string
    colorTransparentStroke: string
    colorTransparentStrokeDisabled: string
    colorTransparentStrokeInteractive: string
    curveAccelerateMax: string
    curveAccelerateMid: string
    curveAccelerateMin: string
    curveDecelerateMax: string
    curveDecelerateMid: string
    curveDecelerateMin: string
    curveEasyEase: string
    curveEasyEaseMax: string
    curveLinear: string
    durationFast: string
    durationFaster: string
    durationNormal: string
    durationSlow: string
    durationSlower: string
    durationUltraFast: string
    durationUltraSlow: string
    fontFamilyBase: string
    fontFamilyMonospace: string
    fontFamilyNumeric: string
    fontSizeBase100: string
    fontSizeBase200: string
    fontSizeBase300: string
    fontSizeBase400: string
    fontSizeBase500: string
    fontSizeBase600: string
    fontSizeHero700: string
    fontSizeHero800: string
    fontSizeHero900: string
    fontSizeHero1000: string
    fontWeightBold: string
    fontWeightMedium: string
    fontWeightRegular: string
    fontWeightSemibold: string
    lineHeightBase100: string
    lineHeightBase200: string
    lineHeightBase300: string
    lineHeightBase400: string
    lineHeightBase500: string
    lineHeightBase600: string
    lineHeightHero700: string
    lineHeightHero800: string
    lineHeightHero900: string
    lineHeightHero1000: string
    shadow2: string
    shadow2Brand: string
    shadow4: string
    shadow4Brand: string
    shadow8: string
    shadow8Brand: string
    shadow16: string
    shadow16Brand: string
    shadow28: string
    shadow28Brand: string
    shadow64: string
    shadow64Brand: string
    spacingHorizontalL: string
    spacingHorizontalM: string
    spacingHorizontalMNudge: string
    spacingHorizontalNone: string
    spacingHorizontalS: string
    spacingHorizontalSNudge: string
    spacingHorizontalXL: string
    spacingHorizontalXS: string
    spacingHorizontalXXL: string
    spacingHorizontalXXS: string
    spacingHorizontalXXXL: string
    spacingVerticalL: string
    spacingVerticalM: string
    spacingVerticalMNudge: string
    spacingVerticalNone: string
    spacingVerticalS: string
    spacingVerticalSNudge: string
    spacingVerticalXL: string
    spacingVerticalXS: string
    spacingVerticalXXL: string
    spacingVerticalXXS: string
    spacingVerticalXXXL: string
    strokeWidthThick: string
    strokeWidthThicker: string
    strokeWidthThickest: string
    strokeWidthThin: string
}

type TypographyStyle = {
    fontFamily: string
    fontSize: string
    fontWeight: string
    lineHeight: string
}

type TypographyStyles = {
    body1: TypographyStyle
    body1Strong: TypographyStyle
    body1Stronger: TypographyStyle
    body2: TypographyStyle
    caption1: TypographyStyle
    caption1Strong: TypographyStyle
    caption1Stronger: TypographyStyle
    caption2: TypographyStyle
    caption2Strong: TypographyStyle
    subtitle1: TypographyStyle
    subtitle2: TypographyStyle
    subtitle2Stronger: TypographyStyle
    title1: TypographyStyle
    title2: TypographyStyle
    title3: TypographyStyle
    largeTitle: TypographyStyle
    display: TypographyStyle
}

//---------------------------------------------------------------------- Tree/ FlatTree Type -----------------------------------------------------------------------------


type TreeOpen = | ExpandIconClick | Click | Enter | ArrowRight | ArrowLeft

type TreeOpenChangeData<'T, 'TEvent> = {
    ``open``: bool
    openItems: seq<'T>
    value: 'T
    target: Browser.Types.HTMLElement
    event: 'TEvent
    ``type``: TreeOpen
}

type TreeNavigationData_unstable<'T, 'TEvent> = {
    target: Browser.Types.HTMLElement
    value: 'T
    event: 'TEvent
    type': TreeOpen
}

type [<RequireQualifiedAccess>] TreeItemType = | leaf | branch

type HeadlessTreeItemProps<'T> = {
    value: 'T
    itemType: TreeItemType
    parentValue: 'T option
    ``aria-level``: int
    ``aria-setsize``: int
    ``aria-posinset``: int
}

type TreeCheckedChangeData<'T, 'TEvent> = {
    value: 'T
    checkedItems: 'T list //TODO
    target: Browser.Types.HTMLElement
    event: 'TEvent
    ``type``: TreeOpen
    selectionMode: string
    ``checked``: string
}

type FlatTreeProps<'T, 'TEvent, 'K> = {
    // This refers to a list of ids of opened tree items.
    // Controls the state of the open tree items.
    // These property is ignored for subtrees.
    openItems: seq<'T>
    //  Callback fired when the component changes value from open state.
    //  These property is ignored for subtrees.
    //  Event - a React's Synthetic event
    //  Data - A data object with relevant information, such as open value and type of interaction that created the event.
    onOpenChange: 'TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit
    //  Callback fired when navigation happens inside the component.
    //  These property is ignored for subtrees.
    //  FIXME: This method is not ideal, as navigation should be handled internally by tabster.
    //  Event - a React's Synthetic event
    //  Data - A data object with relevant information,

    onNavigation: 'TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit
    // This refers to the selection mode of the tree.
    // - undefined: No selection can be done.
    // - 'single': Only one tree item can be selected, radio buttons are rendered.
    // - 'multiselect': Multiple tree items can be selected, checkboxes are rendered.
    selectionMode: string
    //  This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    //  Controls the state of the checked tree items.
    //  These property is ignored for subtrees.
    checkedItems: seq<'K>
    onCheckedChange: 'TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit
    ref: IRefValue<Browser.Types.HTMLDivElement>
}

type HeadlessTreeItem<'T> = {
    level: int
    index: int
    position: int
    childrenValues: 'T array
    value: 'T
    parentValue: 'T
    itemType: TreeItemType
    getTreeItemProps: unit -> HeadlessTreeItemProps<'T>
}

type HeadlessFlatTree<'T, 'TEvent, 'K> = {
    /// returns the properties required for the Tree component to work properly.
    /// That includes:
    /// `openItems`, `onOpenChange`, `onNavigation_unstable` and `ref`
    getTreeProps: unit -> FlatTreeProps<'T, 'TEvent, 'K>
    /// internal method used to react to an `onNavigation` event.
    /// This method ensures proper navigation on keyboard and mouse interaction.
    /// In case of virtualization it might be required to cancel default provided `onNavigation`
    /// event and then call this method manually.
    /// const handleNavigation = (event, data) => {
    ///   event.preventDefault();
    ///   const nextItem = tree.getNextNavigableItem(data);
    ///   // scroll to item using virtualization scroll mechanism
    ///   if (nextItem && tree.getElementFromItem(nextItem)) {
    ///     listRef.current.scrollToItem(nextItem.index);
    ///   }
    ///   // wait for scrolling to happen and then invoke navigate method
    ///   requestAnimationFrame(() => {
    ///     tree.navigate(data);
    ///   });
    /// };
    navigate: TreeNavigationData_unstable<'T, 'TEvent> -> unit
    /// returns next item to be focused on a navigation.
    /// This method is provided to decouple the element that needs to be focused from
    ///  the action of focusing it itself.
    /// On the case of TypeAhead navigation this method returns the current item.
    getNextNavigableItem: HeadlessTreeItem<'T> array -> TreeNavigationData_unstable<'T, 'TEvent> -> HeadlessTreeItem<'T> option
    /// similar to getElementById but for FlatTreeItems
    getElementFromItem: HeadlessTreeItem<'T> -> Browser.Types.HTMLElement
    /// an iterable containing all visually available flat tree items
    items: unit -> seq<HeadlessTreeItem<'T>>
}


type [<AllowNullLiteral; Erase>] HeadlessFlatTreeOptions<'T, 'TEvent> =
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    /// @param event - a React's Synthetic event
    /// @param data - A data object with relevant information,
    /// such as open value and type of interaction that created the event.
    abstract onOpenChange: ('TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit) with get, set
    /// Callback fired when navigation happens inside the component.
    /// These property is ignored for subtrees.
    /// FIXME: This method is not ideal, as navigation should be handled internally by tabster.
    /// @param event - a React's Synthetic event
    /// @param data - A data object with relevant information,
    abstract onNavigation: ('TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit) with get, set
    /// This refers to the selection mode of the tree.
    /// - undefined: No selection can be done.
    /// - 'single': Only one tree item can be selected, radio buttons are rendered.
    /// - 'multiselect': Multiple tree items can be selected, checkboxes are rendered.
    /// @default undefined
    abstract selectionMode: string with get, set
    /// Callback fired when the component changes value from checked state.
    /// These property is ignored for subtrees.
    /// @param event - a React's Synthetic event
    /// @param data - A data object with relevant information,
    /// such as checked value and type of interaction that created the event.
    abstract onCheckedChange: ('TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit) with get, set
    /// This refers to a list of ids of opened tree items.
    /// Controls the state of the open tree items.
    /// These property is ignored for subtrees.
    abstract openItems: seq<'T> with get, set
    /// This refers to a list of ids of default opened items.
    /// This property is ignored for subtrees.
    abstract defaultOpenItems: seq<'T> with get, set
    /// This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    /// Controls the state of the checked tree items.
    /// These property is ignored for subtrees.
    abstract checkedItems: seq<'T * string> with get, set
    abstract defaultCheckedItems: seq<'T * string> with get, set

type HeadlessFlatTree<'T, 'TEvent> = {
    /// returns the properties required for the Tree component to work properly.
    /// That includes:
    /// `openItems`, `onOpenChange`, `onNavigation_unstable` and `ref`
    getTreeProps: unit -> HeadlessFlatTreeOptions<'T, 'TEvent>
    /// internal method used to react to an `onNavigation` event.
    /// This method ensures proper navigation on keyboard and mouse interaction.
    /// In case of virtualization it might be required to cancel default provided `onNavigation`
    /// event and then call this method manually.
    /// const handleNavigation = (event, data) => {
    ///   event.preventDefault();
    ///   const nextItem = tree.getNextNavigableItem(data);
    ///   // scroll to item using virtualization scroll mechanism
    ///   if (nextItem && tree.getElementFromItem(nextItem)) {
    ///     listRef.current.scrollToItem(nextItem.index);
    ///   }
    ///   // wait for scrolling to happen and then invoke navigate method
    ///   requestAnimationFrame(() => {
    ///     tree.navigate(data);
    ///   });
    /// };
    navigate: TreeNavigationData_unstable<'T, 'TEvent> -> unit
    /// returns next item to be focused on a navigation.
    /// This method is provided to decouple the element that needs to be focused from
    ///  the action of focusing it itself.
    /// On the case of TypeAhead navigation this method returns the current item.
    getNextNavigableItem: HeadlessTreeItem<'T> array -> TreeNavigationData_unstable<'T, 'TEvent> -> HeadlessTreeItem<'T> option
    /// similar to getElementById but for FlatTreeItems
    getElementFromItem: HeadlessTreeItem<'T> -> Browser.Types.HTMLElement
    /// an iterable containing all visually available flat tree items
    items: unit -> seq<HeadlessTreeItem<'T>>
}
