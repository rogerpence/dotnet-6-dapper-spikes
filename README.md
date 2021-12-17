### Dapper spikes

* **AnonymousResult** -- Fetch anonymous objects with Dapper. 

    This method shows that there is little point in try to fetch an anonymous object with Dapper. Yes, you can do it, but fetching its data pretty much puts you right back to the old DataReader/DataTable days. 

* **StronglyTypedResult** -- Fetch a list of strongly-typed objects. 

    Dapper shines when you give it a strongly-typed query. I'm starting to think a project should include a place for "query models." These models can be either very simple classes or records (records seem lighter but I don't think it is under the covers). This example uses a record. 

* **StronglyTypedResultWithWhere** -- Fetch a list of strongly-typed objects with a `where` clause.

    This is the `StronglyTypedResult` method with a `where` clause added. 
