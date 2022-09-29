# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app. (total time: ~6mins)
```mermaid
  graph LR;
      ci((CI))-->buildAll[Build store website, <br/>payment service, <br/>& inventory service <br/>1m 30s]-->testAll[Test store website, <br/>payment service, <br/>& inventory service <br/>1m 30s]-->cd((CD));
      cd((CD))-->deployAll[Deploy store website, <br/>payment service, <br/>& inventory service <br/>1m 30s]-->smoke[Smoke test 30s];
```

Using a parallel workflow on the same dataset (~3mins)
```mermaid
  graph LR;
      ci((CI))-->buildWeb[Build store website 30s]-->testWeb[Test store website 30s]-->cd((CD));
      ci((CI))-->buildPay[Build payment service 30s]-->testPay[Test payment service 30s]-->cd((CD));
      ci((CI))-->buildInv[Build inventory service 30s]-->testInv[Test inventory service 30s]-->cd((CD));
      cd((CD))-->deployWeb[Deploy store website 30s]-->smoke[Smoke test 30s];
      cd((CD))-->deployPay[Deploy payment service 30s]-->smoke[Smoke test 30s];
      cd((CD))-->deployInv[Deploy inventory service 30s]-->smoke[Smoke test 30s];    
```
