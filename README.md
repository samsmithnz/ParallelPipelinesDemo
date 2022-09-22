# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app. (total time: 1m 38s)
```mermaid
  graph TD;
      buildweb[Build website 30s]-->buildwebservice[Build web service 30s]-->testsWeb[Test website 30s]-->testsWebservice[Test webservice 30s]-->codeAnalysis[Code analysis 30s]-->securityAnalysis[Security analysis 30s]-->deployApp[Deploy app 30s]-->smoke[Smoke test 30s]-->swap[Swap blue/green 30s];
```

Using parallel workflows
```mermaid
  graph TD;
      buildweb[Build website 30s]-->testWebsite[Test website 30s]-->deployWebsite[Deploy website 30s]-->smoke[Smoke test 30s];
      buildwebservice[Build web service 30s]-->testsWebservice[Test webservice 30s]-->deployWebService[Deploy web service 30s]-->smoke[Smoke test 30s];
      smoke[Smoke test 30s]-->swap[Swap blue/green 30s];
```
