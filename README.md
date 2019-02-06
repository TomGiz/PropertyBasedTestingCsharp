# PropertyBasedTestingCsharp

You can use the .NET Core CLI on this project:

```
dotnet restore
dotnet build 
dotnet test
```

# Property based testing in .NET
FsCheck

# Things that need explaining

* **shrinking**: a process that  allows FsCheck to work backwards through the series of random inputs it generated to determine what the minimal reproduction steps are for producing a test failure. This will come in handy once we start testing more complicated models.

# Things to show in slides
* Romeu's tweet
* Xunit Theory with loads of InlineData test cases
* "Forget about data, focus on behavior!"

## Links

* [https://www.codit.eu/blog/property-based-testing-with-c/](https://www.codit.eu/blog/property-based-testing-with-c/)
* [https://fsharpforfunandprofit.com/posts/property-based-testing-2/](https://fsharpforfunandprofit.com/posts/property-based-testing-2/)
* [https://blog.jonathanoliver.com/idempotency-patterns/](https://blog.jonathanoliver.com/idempotency-patterns/)
* [http://www.aaronstannard.com/fscheck-property-testing-csharp-part1/]()
* Romeu Moura - Domain Invariants & Property-Based Testing for the Masses 
    - [Video](https://www.youtube.com/watch?v=pX44CoRSIpg)
    - [Tweet](https://twitter.com/malk_zameth/status/834804532320276480)
* [code example](https://github.com/joaoasrosa/techorama-nl-property-based-testing)