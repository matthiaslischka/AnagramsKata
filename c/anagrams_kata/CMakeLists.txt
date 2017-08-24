include_directories(".")

### Unity
include_directories("../Unity/src")
set(UNITY_SRCS "../Unity/src/unity.c")

### SDS
include_directories("../sds/")
set(SDS_SRCS "../sds/sds.c")

### AnagramsKata
set(KATA_SRCS anagrams_finder.c)

### Main
set(MAIN_SRCS main.c ${KATA_SRCS} ${SDS_SRCS})
add_executable(anagrams_kata ${MAIN_SRCS})
install(TARGETS anagrams_kata RUNTIME DESTINATION bin)

### Testapp
set(TEST_SRCS tests.c ${UNITY_SRCS} ${KATA_SRCS} ${SDS_SRCS})
add_executable(anagrams_kata_test ${TEST_SRCS})

