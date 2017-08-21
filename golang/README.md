### [Go](https://golang.org) variant

The wordlist file is expected to be in the current working directory, so the following commands must be run from the ```AnagramsKata``` subdirectory.

Running tests:
```
.../AnagramsKata/golang/AnagramsKata> go test ./...
```


Running the main application:
```
.../AnagramsKata/golang/AnagramsKata> go run main.go AnagramsFinder.go
```

#### Offline help

If you are stuck and/or can't recall the function or package you are looking for, remember you can run the package documentation offline:

```
> godoc -http=:6060
```
And then point the browser of your preference to ```http://localhost:6060/pkg```.
