cmake_minimum_required(VERSION 3.10)
project(yoga-native)
set(YOGA_ROOT yoga/)
set(CMAKE_CXX_STANDARD 20)

file(GLOB SOURCES CONFIGURE_DEPENDS
    ${YOGA_ROOT}/yoga/*.cpp
    ${YOGA_ROOT}/yoga/**/*.cpp)

add_library(yoga SHARED ${SOURCES})

target_include_directories(yoga PRIVATE ${YOGA_ROOT})