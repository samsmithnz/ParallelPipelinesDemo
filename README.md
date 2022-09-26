# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app. (total time: ~4m)
```mermaid
  graph TD;
      ci((CI))-->buildweb[Build website 30s]-->buildwebservice[Build web service 30s]-->testWebsite[Test website 30s]-->testsWebservice[Test webservice 30s]-->cd((CD));
      cd((CD))-->deployDB[Deploy database 30s]-->deployWebsite[Deploy website 30s]-->deployWebService[Deploy web service 30s]-->smoke[Smoke test 30s]-->swap[Swap blue/green 30s];
```

Using parallel workflows
```mermaid
  graph TD;
      ci((CI))-->buildweb[Build website 30s]-->testWebsite[Test website 30s]-->cd((CD))-->deployDB[Deploy database 30s]-->deployWebsite[Deploy website 30s]-->smoke[Smoke test 30s];
      ci((CI))-->buildwebservice[Build web service 30s]-->testsWebservice[Test web service 30s]-->cd((CD))-->deployDB[Deploy database 30s]-->deployWebService[Deploy web service 30s]-->smoke[Smoke test 30s];
      smoke[Smoke test 30s]-->swap[Swap blue/green 30s];
```
