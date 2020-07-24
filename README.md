# System.Diagnostics.DiagnosticSource.Activity bug

`Activity.Current.AddTag` can be used to add custom properties to request telemetry. This setup works fine as long version `4.6.0` of `System.Diagnostics.DiagnosticSource.Activity` is used. If another package uses version `4.7.1` like this repro, then `Activity.Current` is `null`, notice that when inspecting the value in the debugger it is actually not null.

## How to run this sample
- Add guid for application insights
- Start function
