cmake_minimum_required(VERSION 3.1)
project(RakNetStatic)

FILE(GLOB ALL_HEADER_SRCS ${RakNet_SOURCE_DIR}/Source/*.h)
FILE(GLOB ALL_CPP_SRCS ${RakNet_SOURCE_DIR}/Source/*.cpp)

include_directories(${RakNet_SOURCE_DIR}/Source) 
IF(WIN32 AND NOT UNIX)
	add_library(RakNetStatic STATIC ${ALL_CPP_SRCS} ${ALL_HEADER_SRCS} readme.txt)
ELSE(WIN32 AND NOT UNIX)
	add_library(RakNetStatic STATIC ${ALL_CPP_SRCS} ${ALL_HEADER_SRCS} readme.txt)
ENDIF(WIN32 AND NOT UNIX)

IF(WIN32 AND NOT UNIX)
	IF(NOT ${CMAKE_GENERATOR} STREQUAL "MSYS Makefiles")
		SET( CMAKE_CXX_FLAGS "/D WIN32 /D _RAKNET_LIB /D _CRT_NONSTDC_NO_DEPRECATE /D _CRT_SECURE_NO_DEPRECATE ")
	ELSE(NOT ${CMAKE_GENERATOR} STREQUAL "MSYS Makefiles")
		SET( CMAKE_CXX_FLAGS "-D WIN32 -D _RAKNET_LIB -D _CRT_NONSTDC_NO_DEPRECATE -D _CRT_SECURE_NO_DEPRECATE ")
	ENDIF(NOT ${CMAKE_GENERATOR} STREQUAL "MSYS Makefiles")
ENDIF(WIN32 AND NOT UNIX)

IF(WIN32 AND NOT UNIX)
	target_link_libraries (RakNetStatic ${RAKNET_LIBRARY_LIBS})
	IF(NOT ${CMAKE_GENERATOR} STREQUAL "MSYS Makefiles")
        IF(MSVC_VERSION LESS 1600)
            set_target_properties(RakNetStatic PROPERTIES STATIC_LIBRARY_FLAGS "/NODEFAULTLIB:&quot;LIBCD.lib LIBCMTD.lib MSVCRT.lib&quot;" )
        ELSE(MSVC_VERSION LESS 1600)
            set_target_properties(RakNetStatic PROPERTIES STATIC_LIBRARY_FLAGS "/NODEFAULTLIB:\"LIBCD.lib LIBCMTD.lib MSVCRT.lib\"" )    
        ENDIF(MSVC_VERSION LESS 1600)
	ENDIF(NOT ${CMAKE_GENERATOR} STREQUAL "MSYS Makefiles")

ELSE(WIN32 AND NOT UNIX)
	target_link_libraries (RakNetStatic ${RAKNET_LIBRARY_LIBS})
	INSTALL(TARGETS RakNetStatic DESTINATION ${RakNet_SOURCE_DIR}/Lib/LibStatic)
	INSTALL(FILES ${ALL_HEADER_SRCS} DESTINATION ${RakNet_SOURCE_DIR}/include/raknet)
ENDIF(WIN32 AND NOT UNIX)


