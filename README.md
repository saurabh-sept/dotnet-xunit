# This is a very light weight API test framework using latest dotnet8, xUnit and utilizes minimal packages

## Author: *Saurabh Sinha*

## Pre-requisites
One should have a recent version of the following installed:
- [.NET SDK 8.x](https://dotnet.microsoft.com/en-us/download)

## Running the tests
One needs to have `Git` installed and then the repo needs to be cloned.
To run the tests execute `dotnet test` from the project root.

## Tests automated
It covers test requirements as listed on the (https://github.com/Terri14/Cocktail) for the Cocktail API's below two endpoints:
- [Search Ingredient by Name](http://www.thecocktaildb.com/api/json/v1/1/search.php?i=vodka)
- [Search Cocktail by Name](http://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita)

It covers extra necessary tests not listed in the requirements too.

### API response validation
API response schema validation for required properties is done using NewtonSoft.Json's attribute `[JsonProperty(Required = Required.Always)]`.
Any response returning null values on not nullable fields fails.
However, some spec bugs have identified in the model as comments.

## Non functional tests

### Following performance tests can done using `Apache JMeter` or `Gatling` or `Postman`.
- [Perform multiple GET requests on two endpoints, load can be gradually increased to specific level](Load Testing: Analyze the two endpoints performance under specific load)
- [Continuously keep making GET requests for a long duration of few days](Soak Test)

### Some Penetration testing `SQL Injection` can be done to find security vulnerabilitites in the code.
- [Query param `i=margarita` is obviously used in the SQL where clause in the code]
(This can be tested by passing `SQL` conditions in query params: `i=margarita AND i=mojito order by 1,2`, things like this can be exploited and let give control of application behaviour to someone else)
- [SQLMap](https://github.com/sqlmapproject/sqlmap), [Acunetix](https://www.acunetix.com/) are few tools which can be used to identify these vulnerabilities.






