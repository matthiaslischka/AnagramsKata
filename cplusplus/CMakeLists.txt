cmake_minimum_required (VERSION 2.6)
project (anagramskata)

if (WIN32)

else (WIN32) #linux

	SET(Runtime_LIBRARIES pthread)

endif (WIN32)

include_directories(${PROJECT_SOURCE_DIR}/src/main)

file(GLOB_RECURSE LIB_SOURCE src/main/kata/*.c*)
add_library(anagramskata-lib STATIC ${LIB_SOURCE})

add_executable(anagramskata src/main/main.cpp)
target_link_libraries(anagramskata anagramskata-lib ${Runtime_LIBRARIES})

include_directories(${PROJECT_SOURCE_DIR}/lib/gmock)

add_library(gmock STATIC lib/gmock/gmock-gtest-all.cc)

file(GLOB_RECURSE LIB_TEST_SOURCE src/test/*.c*)
add_executable(anagramskata-test ${LIB_TEST_SOURCE} lib/gmock/gmock_main.cc)
target_link_libraries(anagramskata-test anagramskata-lib gmock ${Runtime_LIBRARIES})
