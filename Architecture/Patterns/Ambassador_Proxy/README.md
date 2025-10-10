# Introduction

* Lightweight proxy (ambassador) deployed **co-located** with a client (same host/pod) that forwards requests to remote services.
* Acts as a local adapter: hides network, auth, resiliency and observability logic from the client.
* Commonly implemented as a sidecar container, local daemon, or per-host proxy.

![ambassador_diagram](./ambassador_diagram.webp)

# Problem that it tries to solve

* Keeps client code simple by **offloading cross-cutting network concerns** (retries, timeouts, TLS, logging).
* Avoids scattering duplicate network/telemetry/auth logic across many clients.
* Reduces client’s coupling to remote service APIs and changes.
* Improves latency and reliability by making client→proxy calls local (intra-host) while proxy handles remote calls.

# Scenarios when to use it
- **When the client code is legacy or hard to modify**  
  - The client cannot easily be updated to include modern networking, security, or telemetry features.  
  - The ambassador acts as a *shim* that transparently adds this functionality.  

- **When you need consistent networking behavior across multiple clients**  
  - Centralize logic like retries, timeouts, connection pooling, and backoff in one proxy layer.  

- **When you want to offload cross-cutting concerns from application logic**  
  - Keep business logic clean while the ambassador manages routing, TLS, authentication, and retries.  

- **When per-client isolation or resilience is required**  
  - Each client has its own proxy, so network issues in one service don’t affect others.  

- **When running in a containerized or service mesh environment**  
  - Well-suited for Kubernetes sidecars or as part of a service mesh (e.g., Envoy, Istio, Linkerd).  

- **When you need fine-grained observability and telemetry**  
  - Collect logs, metrics, and distributed traces per service without changing client code.  

- **When gradual rollout or migration is needed**  
  - Ambassador can handle new endpoints, authentication, or API versions while clients transition.  

- **When protocol or security translation is required**  
  - Convert between communication protocols (HTTP ↔ gRPC, plaintext ↔ mTLS).  

- **When the external system is unstable or slow**  
  - Ambassador applies circuit breakers, caching, and retry logic to protect the client.  

- **When integrating with third-party APIs or during modernization**  
  - Acts as a façade or compatibility layer while decoupling clients from external changes.

# Issues and considerations with this pattern

* **Duplication / resource overhead:** many ambassador instances consume CPU/memory; manage with automation or lighter proxies.
* **Operational complexity:** need tooling for consistent config, updates, and visibility across many proxies.
* **Blast radius vs. central control trade-off:** sidecars isolate failures but make enforcing a single global policy (e.g., global API quota) harder.
* **Configuration drift:** per-instance configs can diverge unless managed (use config distribution or service mesh control plane).
* **Latency / hop overhead:** local calls are low cost, but proxy adds one extra hop before the remote call; weigh against benefits.
* **Security handling:** secrets injection and trust boundaries must be designed (sidecars share pod trust; host daemons share node trust).
* **When not suitable:** if you need strict centralized quota enforcement, deduplication, or single-point caching, a centralized gateway/façade may be a better fit.

# Ambassador Pattern vs. Centralized Gateway

| Aspect                     | **Ambassador Pattern (co-located)**                               | **Centralized Gateway (shared service)**               |
| -------------------------- | ----------------------------------------------------------------- | ------------------------------------------------------ |
| **Deployment**             | Deployed *with each client* (same pod/host, e.g., sidecar)        | Single shared service between clients and remote APIs  |
| **Communication**          | Client → **local** ambassador → remote service                    | Client → **remote** gateway → external service         |
| **Latency**                | Very low (local IPC or loopback)                                  | Slightly higher (extra network hop)                    |
| **Fault Isolation**        | Failure affects only one client                                   | Gateway failure can affect many clients                |
| **Scalability**            | Scales automatically with each client                             | Must scale centrally for all clients                   |
| **Config Independence**    | Each client can have custom retry, timeout, routing               | All clients share centralized config                   |
| **Cross-cutting Concerns** | Handled locally (per service)                                     | Handled globally (once in gateway)                     |
| **Security Boundary**      | Ambassador shares host/pod trust boundary                         | Gateway enforces org-wide policies                     |
| **Use When**               | You need per-client resiliency, local observability, or isolation | You need global authentication, rate limiting, caching |
| **Typical Implementation** | Sidecar proxy (e.g., Envoy, Linkerd, Consul Connect)              | API gateway or edge proxy (e.g., Kong, NGINX, Apigee)  |


# Diagrams

![ambassador_example](./ambassador_example.png)


# References

## 📚 Official Documentation
- [Microsoft Learn – Ambassador pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/ambassador)

---

## 🧩 Related Patterns and References
- [Microsoft Learn – API Gateway pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/api-gateway)  
- [Microsoft Learn – Gateway Aggregation pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-aggregation)  
- [Microsoft Learn – Gateway Offloading pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-offloading)

---

## ⚙️ Service Mesh / Sidecar Implementations (Ambassador-style)
- [Envoy Proxy – Official site](https://www.envoyproxy.io/)  
- [Istio – Service mesh with sidecar proxies](https://istio.io/)  
- [Linkerd – Lightweight service mesh](https://linkerd.io/)  
- [Consul Connect – HashiCorp service mesh](https://developer.hashicorp.com/consul/docs/connect)

