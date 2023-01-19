
```mermaid
graph TD
 linkStyle default interpolate basis
 home((GitHub Actions))
 home---firewall[<center>Customer firewall</center>]
 home---hosted1
 home---hosted2
 subgraph Hosted-Runners
 hosted1(<center>Hosted runners</center>)
 hosted2(<center>Larger Hosted runners</center>)
 end
 subgraph "Customer Network________"
 firewall---self3(<center>Standalone Virtual Machines</center>)
 firewall---self1(<center>Action Runner Controller ARC</center>)
 firewall---self2(<center>Elastic Machines</center>)
 end
 ```
 
 ```mermaid
  graph LR;
      root((GitHub Runners))-->hosted([Hosted]);
      root((GitHub Runners))-->selfhosted([Self-hosted]);
      hosted([Hosted])-->hostedRunners[Hosted runners];
      hosted([Hosted])-->largerHostedRunners[Larger hosted runners];
      selfhosted([Self-hosted])-->selfHostedRunnersVM[Standalone virtual machine];
      selfhosted([Self-hosted])-->selfHostedRunnersARC[ARC/Action runners controller];
      selfhosted([Self-hosted])-->selfHostedRunnersEM[Elastic machines];
```

 ```mermaid
  graph TD;
      foundation(Foundation)-->identity(Identity);
      identity(Identity)-->remediation(Remediation);
      identity(Identity)-->prevention(Prevention);
```
