module X =
  let func x = x + 1

let testval = FileTwo.NewObjectType()

let val2 = X.func 2

let val3 = testval.Terrific val2

let val4 : FileTwo.NewObjectType = testval

type Dummy = Foo | Bar

let val5:Dummy = Foo

[<EntryPoint>]
let main args =
    printfn "Hello %d" val2
    0
