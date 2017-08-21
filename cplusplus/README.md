### C++14 variant

The wordlist file is expected to be in the current working directory, so you need to run the binaries from this root directory.

#### Setup
The repository contains the [Google Mock](https://github.com/google/googletest) framework.

To build the project, you need either
* [Boost.Build](http://www.boost.org/build/index.html) or
* [CMake](http://www.cmake.org/)

##### Using Boost.Build
Simply call ```b2``` in the project root directory. Unit-tests are built and automatically executed.

##### Using CMake
Generate your project files with
```
mkdir build
cd build
cmake ..
```
Then run your build tool with the generated files. The unit-tests need to be run manually.
