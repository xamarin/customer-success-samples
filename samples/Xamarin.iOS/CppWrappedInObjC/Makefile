XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=C++WrappedInObjC/C++WrappedInObjective-C/
PROJECT=$(PROJECT_ROOT)/C++WrappedInObjective-C.xcodeproj
TARGET=C++WrappedInObjective-C

all: libCppWrappedInObjC.a

libCppWrappedInObjC-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libCppWrappedInObjC-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libCppWrappedInObjC-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libCppWrappedInObjC-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libCppWrappedInObjC.a: libCppWrappedInObjC-i386.a libCppWrappedInObjC-armv7.a libCppWrappedInObjC-armv7s.a libCppWrappedInObjC-arm64.a
	xcrun -sdk iphoneos lipo -create -output $@ $^
	mv libCppWrappedInObjC.a ./Archive
	-rm -f *.a *.dll
	
clean:
	-rm -f *.a *.dll