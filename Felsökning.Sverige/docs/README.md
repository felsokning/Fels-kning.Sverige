# Felsökning.Sverige

The `Felsökning.Sverige` NuGet package provides utilities and classes specific to Sweden, such as retrieving train schedules for the Arlanda Express and weather-related data from SMHI.

## Installation

Install the package via NuGet Package Manager:

```bash
dotnet add package Felsökning.Sverige
```

## Available Methods

### Namespace: `Felsökning.Sverige.ArlandaExpress`

#### Class: `ArlandaExpressWrapper`

- **`GetDepartures(city: City): List<Departure>`**
  - **Description**: Retrieves a list of upcoming departures for the specified city.
  - **Parameters**:
    - `city` (`City`): The city for which to retrieve departures. Possible values are `City.Arlanda` or `City.Stockholm`.
  - **Returns**: A list of `Departure` objects, each containing details about a specific departure.

- **`GetNextDeparture(city: City): Departure`**
  - **Description**: Retrieves the next departure for the specified city.
  - **Parameters**:
    - `city` (`City`): The city for which to retrieve the next departure.
  - **Returns**: A `Departure` object containing details about the next departure.

#### Class: `City`

- **`City.Arlanda`**
  - Represents the Arlanda city station.
- **`City.Stockholm`**
  - Represents the Stockholm city station.

#### Class: `Departure`

- **Properties**:
  - `Time` (`DateTime`): The scheduled departure time.
  - `Destination` (`string`): The destination of the train.
  - `IsDelayed` (`bool`): Indicates whether the departure is delayed.

---

### Namespace: `Felsökning.Sverige.SMHI`

#### Class: `SMHIWrapper`

- **`GetAffectedAreas(): List<AffectedArea>`**
  - **Description**: Retrieves a list of areas affected by weather warnings.
  - **Returns**: A list of `AffectedArea` objects.

#### Class: `AffectedArea`

- **Properties**:
  - `Name` (`string`): The name of the affected area.
  - `Severity` (`string`): The severity of the weather warning.
  - `Description` (`string`): A description of the weather warning.

---

## Usage Example

```csharp
using Felsökning.Sverige.ArlandaExpress;
using Felsökning.Sverige.SMHI;

// Example: Arlanda Express
var wrapper = new ArlandaExpressWrapper();
var departures = wrapper.GetDepartures(City.Stockholm);
foreach (var departure in departures)
{
    Console.WriteLine($"Departure at {departure.Time} to {departure.Destination}, Delayed: {departure.IsDelayed}");
}

// Example: SMHI Affected Areas
var smhi = new SMHIWrapper();
var affectedAreas = smhi.GetAffectedAreas();
foreach (var area in affectedAreas)
{
    Console.WriteLine($"Area: {area.Name}, Severity: {area.Severity}, Description: {area.Description}");
}
```

## Contributing

Contributions are welcome! Please see the [repository](https://github.com/felsokning/Fels-kning.Sverige) for details.

---

For more information, visit the [NuGet package page](https://www.nuget.org/packages/Fels%C3%B6kning.Sverige).