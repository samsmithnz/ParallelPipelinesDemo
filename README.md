# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app. (total time: 1m 38s)
```mermaid
  graph LR;
      build[Build 15s]-->test[Test 30s]-->deploy[Deploy 25s];
```

Using parallel workflows