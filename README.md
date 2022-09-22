# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app. (total time: 1m 38s)
```mermaid
  graph LR;
      buildweb[Build web service 15s]-->buildwebservice[Build website 15s]-->test[Unit Tests 3s]-->test[Integration Tests 3s]-->deploy[Deploy 25s];
```

Using parallel workflows
```mermaid
  graph LR;
      build[Build 15s]-->deploy[Deploy 25s]
      test[Test 30s]-->deploy[Deploy 25s];
```