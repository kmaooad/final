# Final Quiz

## Q1

**What is the issue with this code:**

```csharp
public class Order {
    public virtual ShippingInfo Ship() {
        ...
    }
}

public class DigitalOrder: Order {
    public override ShippingInfo Ship() {
        throw new NotSupportedException();
    }
}
```

a. LSP violation

b. DIP violation

c. Low cohesion

d. Loose coupling

e. Strong dependency

## Q2

**LSP helps to maintain proper ... :**

a. Inheritance and abstractions

b. Dependencies direction

c. Interface cohesion

d. DI

e. Rigidity

## Q3

**Uncontrolled access to _server_ state is caused by:**

a. ISP violation

b. Poor encapsulation

c. Loose coupling

d. Wrong DI container

e. Viscose client

## Q4

**Necessity of cascade changes in _clients_ after changes in _server_ is caused by:**

a. Polymorphism

b. OCP violation

c. Low cohesion

d. Poor abstraction

e. Opaque code

## Q5

**DIP helps to maintain ... :**

a. Good encapsulation

b. Tight coupling

c. Dependencies quality

d. Small and specific interfaces

e. High cohesion

## Q6

**Dependency of _client_ on methods it does not need is caused by:**

a. ISP violation

b. Poor encapsulation

c. Loose coupling

d. Wrong DI container

e. Design smell

## Q7

**OCP helps to ... :**

a. Have small interfaces

b. Maintain loose coupling

c. Extend behavior with new use cases without touching old ones

d. Maintain loose dependencies

e. Get more viscose design

## Q8

**Proper abstrations can be maintained with these principles (choose multiple):**

a. SRP

b. OCP

c. LSP

d. ISP

e. DIP

## Q9

**Different behavior depending on the concrete type with a common interface is called ... :**

a. Encapsulation

b. Polymorphism

c. Dependency

d. Rigidity

e. Pattern

## Q10

**Protection of internal state of an object with a limited access through a well-defined interface is called:**

a. Cohesion

b. Immobility

c. Opacity

d. DI

e. Encapsulation

## Q11

**What is the issue with this code:**

```csharp
public class Invoice {
    ...
    public decimal Total { get; set; }
    public void CalculateTotal() { ... }
    ...
}
```

a. DIP violation

b. LSP violation

c. Low cohesion

d. OCP violation

e. Bad encapsulation

## Q12

**What dependency is better:**

```csharp
public class Customer { ... }
public class CustomerService { ... }
```

a. Customer -> CustomerService

b. CustomerService -> Customer

c. Both are ok

d. None

## Q13

**What cohesion quality is preferred:**

a. High

b. Low

c. Both are ok

## Q14

**What is the _server_ in this code:**

```csharp
public class OrderService: IOrderService {
    public OrderService(OrderContext db) { ... }
}

public class DigitalOrderService: OrderService {
    ...
}
```

a. OrderService

b. IOrderService

c. OrderContext

d. All of the above

e. None of the above

## Q15

**What issues are present in this code (choose all that apply):**

```csharp
public class Customer {
    public void Activate() {
        using (var db = new CustomerContext()){
            var socialAccounts = db.Socials.Where(...).ToList();
            foreach (var sa in socialAccounts) {
                var sas = new SocialAccountService();
                var r = sas.CheckSocialAccount(sa);

                if (!r) return;
            }

            Status = "Active";
        }
    }
}
```

a. SRP violation

b. OCP violation

c. LSP violation

d. ISP violation

e. DIP violation

## Q16

**Which one is _method_ DI:**

a. `public OrderService(OrderContext db) { ... }`

b. `public void Calculate(OrderContext db) { ... }`

c. `using (var db = new OrderContext()) { ... }`

d. `public class OrderContext: DbContext { ... }`

e. `public class OrderContext: IOrderContext { ... }`

f. All

g. None

## Q17

**Which class is the _client_ in this fragment:**

```csharp
public class FailedInvoice: Invoice {
    public Reason FailReason { get; }
    public Invoice Reprocess(User initiator) { ... }
    ...
}
```

a. FailedInvoice

b. Invoice

c. Reason

d. User

e. All

f. None

## Q18

**How many dependencies does FailedInvoice have:**

```csharp
public class FailedInvoice: Invoice {
    public Reason FailReason { get; }
    public Invoice Reprocess(User initiator) { ... }
    ...
}
```

a. 0

b. 1

c. 3

d. 5

e. 7

## Q19

**Does this code meet DIP requirements:**

```csharp
public class CustomerService: ICustomerService {
    private readonly ISocialAccountsAdapter _adt;
    public CustomerService(ISocialAccountsAdapter adt) { ... }
    public virtual Customer Activate(Customer c){ ... }
}
```

a. Yes

b. No

c. This is not a proper example for DIP

## Q20

**Is this code loosely coupled:**

```csharp
public class CustomerService: ICustomerService {
    private readonly ISocialAccountsAdapter _adt;
    public CustomerService(ISocialAccountsAdapter adt) { ... }
    public virtual Customer Activate(Customer c){ ... }
}
```

a. Yes

b. No

c. This is not a proper example for coupling
