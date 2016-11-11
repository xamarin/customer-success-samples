# Overview

Below are example Jenkins build steps for building a Xamarin.iOS application (thus a Mac-based jenkins installation is assumed), uploading to Test Cloud, and deploying to HockeyApp. Note that these steps may not be suitable for a production environment, but may be useful in getting started setting up a build.

# Steps

## Clean (example folders shown; actual folders may differ)
    rm -rf packages/ iOS/bin/ ios/obj/ Droid/bin/ Droid/obj/ UITests/bin/ UITests/obj/

## Restore NuGet packages
    /usr/local/bin/nuget restore <SLN_FILE>

## Update the build number to match the Jenkins build number
    /usr/libexec/PlistBuddy -c "Set CFBundleVersion $BUILD_NUMBER" <INFO_PLIST_FILE>

## Build the solution (all projects)
/Library/Frameworks/Mono.framework/Commands/xbuild /p:Configuration=<CONFIGURATION> /p:Platform=<PLATFORM> <SLN_FILE>

## Submit to Test Cloud; making use of Unix "find" command
    TEST_CLOUD_EXE=`find . -name test-cloud.exe
    /usr/local/bin/mono $TEST_CLOUD_EXE submit <IPA_FILE> <API_KEY> --devices <DEVICES_KEY> --series <SERIES> --locale <LOCALE> --app-name <APP_NAME> --user <USER_EMAIL> --assembly-dir <ASSEMBLY_DIR> --nunit-xml "$WORKSPACE/report.xml"`

## Zip up the dSYM file
    zip -r <ZIP_FILE_TO_CREATE> <PATH_TO_DSYM_FILE_FOR_IPA>

## Upload to HockeyApp
```
curl \
  -F "status=2" \
  -F "notify=1" \
  -F "notes=Some new features and fixed bugs." \
  -F "notes_type=0" \
  -F "ipa=@<IPA_FILE>" \
  -F "dsym=@<DSYM_ZIP_FILE>" \
  -H "X-HockeyAppToken: <HOCKEY_APP_TOKEN>" \
  https://rink.hockeyapp.net/api/2/apps/<HOCKEYAPP_APP_ID>/app_versions/upload
```
