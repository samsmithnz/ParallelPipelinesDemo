# ParallelWorkflowsDemo
A demo to show parallel workflow benefits

Simple workflow to build, test, then deploy our app. (total time: ~4m)
```mermaid
  graph LR;
      ci((CI))-->buildAll[Build website, payment service, <br/>& inventory service 1m 30s]-->testAll[Test website, payment service, <br/>& inventory service 1m 30s]-->cd((CD));
      cd((CD))-->deployAll[Deploy website, payment service, <br/>& inventory service 1m 30s]-->smoke[Smoke test 30s]-->swap[Swap blue/green 30s];
```

Using parallel workflows
```mermaid
  graph LR;
      ci((CI))-->buildWeb[Build website 30s]-->testWeb[Test website 30s]-->cd((CD));
      ci((CI))-->buildPay[Build payment service 30s]-->testPay[Test payment service 30s]-->cd((CD));
      ci((CI))-->buildInv[Build inventory service 30s]-->testInv[Test inventory service 30s]-->cd((CD));
      cd((CD))-->deployWeb[Deploy website 30s]-->smoke[Smoke test 30s];
      cd((CD))-->deployPay[Deploy website 30s]-->smoke[Smoke test 30s];
      cd((CD))-->deployInv[Deploy website 30s]-->smoke[Smoke test 30s];
      smoke[Smoke test 30s]-->swap[Swap blue/green 30s];      
```
