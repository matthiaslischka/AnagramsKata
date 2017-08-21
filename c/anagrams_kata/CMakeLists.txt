include_directories(".")

### Main
set(MAIN_SRCS main.c anagrams_finder.c)
add_executable(anagrams_kata ${MAIN_SRCS})
install(TARGETS anagrams_kata RUNTIME DESTINATION bin)

### Unity
include_directories("../Unity/src")
set(UNITY_SRCS "../Unity/src/unity.c")

### Testapp
set(TEST_SRCS tests.c ${UNITY_SRCS})
add_executable(anagrams_kata_test ${TEST_SRCS})

