# AndroidCheckBoxSampleApp
This is a simple app to demonstrate how to interact with an Android CheckBox from a UITest.

To interact with an Android CheckBox from a UITest, you must use the [Invoke](https://developer.xamarin.com/api/member/Xamarin.UITest.Queries.AppQuery.Invoke/p/System.String/) method to access the methods in the [native Java Android API](https://developer.android.com/reference/android/widget/CheckBox.html). In our `Invoke` statements, we can take advantage of `performClick()` to toggle the CheckBox, `setChecked(boolean checked)` to set the value of the CheckBox, and `isChecked()` to return a bool that is `true` when the CheckBox is checked and `false` when it is unchecked.

In the UITest project, I created a [ToggleCheckBox](https://github.com/brminnick/AndroidCheckBoxSampleApp/blob/master/CheckBoxSampleApp.UITest/Tests.cs#L101) method to toggle an individual CheckBox, a [IsCheckBoxChecked](https://github.com/brminnick/AndroidCheckBoxSampleApp/blob/master/CheckBoxSampleApp.UITest/Tests.cs#L107) method to return the CheckBox current status, and a [SetCheckBox](https://github.com/brminnick/AndroidCheckBoxSampleApp/blob/master/CheckBoxSampleApp.UITest/Tests.cs#L112) method to set the CheckBox status.

All tests were validated via [Xamarin Test Cloud](https://www.xamarin.com/test-cloud). The test report is viewable [here](https://testcloud.xamarin.com/test/checkboxsampleapp_198eddc7-356c-46db-b88b-7e82ce7af2f6/).

Author
===
Brandon Minnick

Xamarin Customer Success Engineer

### Licensing
MIT License

Copyright (c) 2016 Brandon Minnick

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
