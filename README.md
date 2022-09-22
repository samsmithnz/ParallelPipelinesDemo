# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app. (total time: 1m 38s)
```mermaid
  graph LR;
      buildWeb[Build web service 15s]-->buildWebService[Build website 15s]-->unitTest[Unit Tests 3s]-->integrationTest[Integration Tests 3s]-->deploy[Deploy 25s];
```

Using parallel workflows
```mermaid
  graph LR;
      build[Build 15s]-->deploy[Deploy 25s]
      test[Test 30s]-->deploy[Deploy 25s];
```