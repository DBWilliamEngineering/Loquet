# Loquet (Low-Ket) - LINQ ORM parQuet Library 
>*Honestly, its named after my fiancé, Lauren*

**Entity-oriented data access for Apache Parquet and .NET.**

Loquet is a simple/ lightweight framework that helps C# software engineers and developers work with columnar data in Parquet files. It uses LINQ, which is a familiar way of accessing data for many developers. This means you can work with Parquet data in a way that feels natural, without needing a database server. Loquet doesn't treat Parquet like a relational database, instead, it lets you access data in a straightforward way. The goal is to make it easy for C# developers to work with columnar data, and Loquet achieves this by providing a lightweight and easy-to-use framework.

> **Project status:** We're still in the early stages of designing and developing this project. The features and capabilities mentioned below are what we're aiming for, but they're not yet up and running.

## Why Loquet?

Parquet is great for storing data in a columnar format, but most applications need more than just basic read and write functions. That's where Loquet comes in - it provides a simpler way to work with data by offering a set of tools to describe entities, find datasets, build queries, and manage data storage all through a single, easy-to-use .NET interface. This means developers can focus on building their application without having to worry about the low-level details of data storage.

The goal is to make Parquet approachable without hiding its underlying constraints.

## Design goals

- **Familiar C# experience:** Strongly typed entities, contexts, and entity sets.
- **LINQ-first querying:** Express filters and projections through idiomatic .NET APIs.
- **Make file paths clear**: Instead of using random strings all over the place, use a system to figure out where files and datasets are. This can be done through settings, common ways of doing things, or special notes on the files themselves.
- **Asynchronous data access:** Support async operations and streaming where practical.
- **Parquet-aware execution:** Respect columnar storage characteristics and pursue efficient projections and filtering where the storage engine supports them.
- **Predictable persistence:** Design write and replacement workflows around file-backed storage rather than pretending Parquet offers row-level transactional updates.
- **Modular architecture**: This means keeping the main parts of the system separate from the details of how data is stored in Parquet and from any extra features that can be added.

## Intended developer experience

This is just an idea for how an API could work, it's not actual code and hasn't been officially released yet.

```csharp
using Loquet;

public sealed class PeopleContext : ParquetContext
{
public ParquetSet<Person> People { get; set; } = default!;
}

// Conceptual use after the context has been configured:
var adults = await context. People
.Where(person => person. Age >= 18)
.ToListAsync();
```

Developers can focus on working with the main data entities, and Loquet will take care of how that data is mapped and queried from Parquet files or datasets. Right now, the team is still figuring out the details of how this will all work together - things like configuration settings, query operators, and how data is written.

## Scope and limitations

Loquet is not like a regular database that you can use with SQL. It doesn't work like a database where you can make changes to data and have it stored right away. Instead, Loquet stores data in a different way, using files. The people working on Loquet will focus on making sure it can handle things like multiple people accessing the data at the same time, changing the structure of the data, and replacing old data with new data, all without pretending to be a full database. They will make sure to document how it works and design it to handle these tasks, rather than trying to make it act like something it's not.

We might look into adding support for Entity Framework Core later on. If we do, the adapter or provider would have its own name and scope - it would be a separate thing. Loquet is its own independent project and isn't connected to Microsoft or Entity Framework Core in any way.

## Roadmap

These are proposed directions, not committed release features:

1. Context and entity-set abstractions (`ParquetContext`, `ParquetSet<TEntity>`).
2. Entity metadata, type mapping, and dataset/file resolution.
3. LINQ expression handling, projection, and materialization.
4. Asynchronous reading and controlled write workflows.
5. Parquet-aware optimization where supported and measurable.
6. Dependency injection and configuration extensions.
7. Evaluation of an optional Entity Framework Core adapter.

## Packages (proposed)

- `Loquet. Core` is about shared ideas, information, and rules for asking questions.
- `Loquet. Parquet` — Parquet-backed execution and persistence.
- `Loquet. Extensions. DependencyInjection` is used for optional registration and setup of Dependency Injection.

Please note that the names and boundaries of packages can be changed at any time. This doesn't mean that these packages will be available to the public.

## Source availability and licensing

**Loquet is source-available, not open-source under an OSI-approved license.**

You can review and test the source code on your own, and see how it works. The license also allows you to use the official Loquet releases without making any changes as part of your own projects, including ones you plan to sell, as long as you follow the rules outlined in the license.

The license doesn't give you the right to copy Loquet's code and use it in a different framework. You also can't modify it, rebrand it, or create a competing library based on Loquet. Just because you can view and fork Loquet on GitHub, doesn't mean you can redistribute it or use it in any way you want. Those actions are still restricted.

Before you use or share Loquet, make sure to read the entire [LICENSE](LICENSE) agreement. The actual license text is what matters, not this brief summary.

## Contributing

We're open to hearing your thoughts and ideas. If you have any issues or want to discuss a design, feel free to share. We also appreciate constructive feedback. Just a heads up: since Loquet has a special license that limits how its source code can be used, it's a good idea to talk to us before starting any major work. This way, we can make sure everything is okay with the permissions and ownership terms before we can merge your contributions.

## About the name

**Loquet** combines **LO** (Lauren Olivia) with a nod to **Parquet**. A personal name for a project built around making structured data access feel a little more human.

---

2026 Damon Bushong. All rights are owned by him. For more details, check the [LICENSE](LICENSE).
