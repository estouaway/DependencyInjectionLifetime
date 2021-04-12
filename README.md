# DependencyInjectionLifetime
 
 Simple console app to demonstrate instance lifetimes registrations across different requests.
 
Scope 1

First Request
Singleton: a6bb0095-0935-40f3-996d-d91e801ad2b0
Scoped: 77a57b9c-a992-4b35-9c97-270217b32d32
Transient: 2bb6be93-ad2e-49e9-ac14-4d06d86d61b7

Second Request
Singleton: a6bb0095-0935-40f3-996d-d91e801ad2b0
Scoped: 77a57b9c-a992-4b35-9c97-270217b32d32
Transient: 12974c1e-5020-4a09-b22c-c573211bb395


Scope 2

First Request
Singleton: a6bb0095-0935-40f3-996d-d91e801ad2b0
Scoped: 9822b79e-62fb-4c83-92aa-8ca3bafccfab
Transient: 98f8c4b1-4122-4804-9866-914d10d31108
