﻿(*

Copyright 2013 Jack Pappas

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

*)

/// Unit tests for the ExtCore.Collections.Bimap type and module.
module ExtCore.Collections.Bimap.Tests

open NUnit.Framework
open FsUnit
//open FsCheck

// TODO : Implement tests for equality/comparison.

[<TestCase>]
let singleton () : unit =
    Bimap.singleton "Hello" "World!"
    |> should equal (
        Bimap.empty
        |> Bimap.add "Hello" "World!")

[<TestCase>]
let isEmpty () : unit =
    Bimap.empty
    |> Bimap.isEmpty
    |> should be True

    Bimap.singleton 5 'f'
    |> Bimap.isEmpty
    |> should be False

[<TestCase>]
let count () : unit =
    Bimap.empty
    |> Bimap.count
    |> should equal 0

    Bimap.singleton 'F' 123
    |> Bimap.count
    |> should equal 1

    Bimap.empty
    |> Bimap.add "foo" 5
    |> Bimap.add "bar" 8
    |> Bimap.add "baz" 2
    |> Bimap.add "cdr" 9
    |> Bimap.add "car" 6
    |> Bimap.count
    |> should equal 5

[<TestCase>]
let containsKey () : unit =
    Assert.Fail ()

[<TestCase>]
let containsValue () : unit =
    Assert.Fail ()

[<TestCase>]
let paired () : unit =
    Assert.Fail ()

[<TestCase>]
let tryFind () : unit =
    Assert.Fail ()

[<TestCase>]
let tryFindValue () : unit =
    Assert.Fail ()

[<TestCase>]
let find () : unit =
    Assert.Fail ()

[<TestCase>]
let findValue () : unit =
    Assert.Fail ()

[<TestCase>]
let remove () : unit =
    Assert.Fail ()

[<TestCase>]
let removeValue () : unit =
    Assert.Fail ()

[<TestCase>]
let add () : unit =
    Assert.Fail ()

[<TestCase>]
let tryAdd () : unit =
    Assert.Fail ()

[<TestCase>]
let iter () : unit =
    Assert.Fail ()

[<TestCase>]
let fold () : unit =
    Assert.Fail ()

[<TestCase>]
let foldBack () : unit =
    Assert.Fail ()

[<TestCase>]
let filter () : unit =
    Assert.Fail ()

[<TestCase>]
let partition () : unit =
    Assert.Fail ()

[<TestCase>]
let ofList () : unit =
    Assert.Fail ()

[<TestCase>]
let toList () : unit =
    Assert.Fail ()

[<TestCase>]
let ofArray () : unit =
    Assert.Fail ()

[<TestCase>]
let toArray () : unit =
    Assert.Fail ()

