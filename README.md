# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app
```mermaid
  graph LR;
      "Build (1)"-->"Test (1)"-->"Deploy (1)";
```

Using parallel 