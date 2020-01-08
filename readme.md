# mxcd.dbContextExtended
Extens Entity framework core with Delete(expression) and Update(newObjectValue, expression)
This actions will executed in SaveChanges

## Update & Delete
### 1.Create DbContext
Just inherited from DbContextExtended
```csharp
using mxcd.dbContextExtended;
...

public partial class SampleContext : DbContextExtended
{
...
}
```
### 2.Use
Just call methodos like following
#### Example1
```csharp
///Remove&Update by expression
using (var context = new SampleContext())
{
    ...

    context.Update(new { FirstName = "Prueba" }, (Customer c) => c.Id < 5);
    context.Remove((Product c) => c.Id > 5 && c.Id < 20);

    ...

    context.SaveChanges();
}
```
#### Example2
```csharp
///Remove&Update All 
using (var context = new SampleContext())
{
    ...

    context.Update(new { OrderNumber = "Prueba" }, (Order o) => 1 == 1);
    context.Remove<Product>();

    ...

    context.SaveChanges();
}
```
#### Example3
```csharp
///Remove&Update All 
using (var context = new SampleContext())
{
    ...
    var data = new Customer()
    {
    ...
    };

    context.Update<Customer>(data);
    context.Remove<Product>();

    ...

    context.SaveChanges();
}
```

<hr/>

Learn more in https://muxocode.com

<p align="center">
  <img src="https://muxocode.com/branding.png">
</p>