[![Build Status](https://www.myget.org/BuildSource/Badge/ribbles?identifier=5ce5511b-c4a4-4be0-b4e9-910d7e3df36b)](https://www.myget.org/feed/ribbles/package/nuget/RecurringInterval)

# RecurringInterval
C# PCL Library for representing and managing recurring intervals, suitable for calendaring functions.  

# Forked From https://github.com/ribbles/RecurringInterval
Forked ribbles project to make it PCL Profile7 compatible for Xamarin Shared PCL projects and simplified the number of periods implementing SkipIntervals to hand biweekly, bimonthly and quarterly periods

## Supported Intervals

* [Daily](#daily) (+days)
* [Weekly](#weekly) (+dayOfWeek)
* [Monthly](#monthly) (+dayOfMonth)
* [Annually](#annually) (+dayOfYear)


## Usage

```csharp
var interval = Interval.Create(<Period>, <Date>, <skip interval>);
var nextInterval = interval.Next();
```

## Daily 

```csharp
Interval.Create(Period.Daily, <start date>, <skip interval>);
```

## Weekly 

```csharp
Interval.Create(Period.Weekly, <start date>, <skip interval>);
```

## Monthly

```csharp
Interval.Create(Period.Monthly, <start date>, <skip interval>);
```

## Annually

```csharp
Interval.Create(Period.Annual, <start date>, <skip interval>);
```
