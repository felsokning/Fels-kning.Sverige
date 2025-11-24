# Felsökning.Sverige

The `Felsökning.Sverige` NuGet package provides utilities and classes specific to Sweden, such as retrieving train schedules for the Arlanda Express and weather-related data from SMHI.

## Installation

Install the package via NuGet Package Manager:

```bash
dotnet add package Felsökning.Sverige
```

## API Reference

### Namespace: `Felsökning.Sverige.ArlandaExpress`

#### `ArlandaExpressWrapper` Class

Helper class for retrieving Arlanda Express departure information.

**Constructor:**
- `ArlandaExpressWrapper()` — Creates a new instance configured to query the Arlanda Express API.

**Methods:**

- **`Task<List<Departure>> GetDeparturesAsync(City city)`**
  - **Description:** Retrieves upcoming departures for the specified city.
  - **Parameters:**
    - `city` (`City`): The city to query. Valid values: `City.Arlanda` or `City.Stockholm`.
  - **Returns:** `Task<List<Departure>>` — A task that resolves to a list of `Departure` objects. Returns an empty list if no departures are available.
  - **Exceptions:** May throw `StatusException` if an HTTP error occurs.

---

#### `City` Enumeration

Represents the city/station for Arlanda Express queries.

**Members:**
- `Arlanda` — Arlanda Airport station
- `Stockholm` — Stockholm Centralstation

---

#### `Departure` Class

Represents a single Arlanda Express departure record.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `TimeLeft` | `int` | Minutes until departure |
| `DepartureDate` | `string` | Departure date (format: varies by API) |
| `DepartureTime` | `string` | Departure time (format: varies by API) |
| `DepartureDayOfWeek` | `string` | Day of week for departure (e.g., "Monday") |
| `ArrivalDate` | `string` | Arrival date (format: varies by API) |
| `ArrivalTime` | `string` | Arrival time (format: varies by API) |
| `ArrivalDayOfWeek` | `string` | Day of week for arrival (e.g., "Monday") |

---

#### `IArlandaExpressWrapper` Interface

Interface for the Arlanda Express wrapper.

**Methods:**

- **`Task<List<Departure>> GetDeparturesAsync(City city)`** — See `ArlandaExpressWrapper.GetDeparturesAsync` above.

---

### Namespace: `Felsökning.Sverige.SMHI`

#### `WarningsWrapper` Class

Helper class for retrieving SMHI weather warnings.

**Constructor:**
- `WarningsWrapper(string apiVersion = "1")` — Creates a new instance configured to query the SMHI Warnings API.
  - **Parameters:**
    - `apiVersion` (`string`, optional, default: `"1"`): The API version to use. Note: This does not conform to semantic versioning.

**Methods:**

- **`Task<List<WarningsResult>> GetRecentWarningsAsync()`**
  - **Description:** Retrieves the most recently published weather warnings from SMHI.
  - **Returns:** `Task<List<WarningsResult>>` — A task that resolves to a list of `WarningsResult` objects.
  - **Exceptions:** Throws `StatusException` if an HTTP error occurs.

---

#### `ObservationsWrapper` Class

Helper class for retrieving SMHI meteorological observations.

**Constructor:**
- `ObservationsWrapper(string apiVersion = "1.0")` — Creates a new instance configured to query the SMHI Observations API.
  - **Parameters:**
    - `apiVersion` (`string`, optional, default: `"1.0"`): The API version to use.

**Methods:**

- **`Task<List<Resource>> GetParameterResourcesAsync()`**
  - **Description:** Retrieves available parameter resources (measurement types) from the SMHI observations API.
  - **Returns:** `Task<List<Resource>>` — A task that resolves to a list of `Resource` objects.
  - **Exceptions:** Throws `StatusException` if an HTTP error occurs.

- **`Task<List<Station>> GetStationsBasedOnResourceAsync(Resource resource)`**
  - **Description:** Retrieves weather stations that report data for the specified resource/parameter.
  - **Parameters:**
    - `resource` (`Resource`): The resource/parameter to query.
  - **Returns:** `Task<List<Station>>` — A task that resolves to a list of `Station` objects.
  - **Exceptions:** Throws `StatusException` if an HTTP error occurs.

- **`Task<T> GetResourceDataFromStationAsync<T>(Resource resource, Station station)`**
  - **Description:** Retrieves the latest hour of data for a specific resource from a specific station.
  - **Type Parameters:**
    - `T` — The type to deserialize the response into (e.g., `Temperatures`, custom class, etc.).
  - **Parameters:**
    - `resource` (`Resource`): The resource/parameter to retrieve.
    - `station` (`Station`): The station to query.
  - **Returns:** `Task<T>` — A task that resolves to an instance of type `T` containing the observation data.
  - **Exceptions:** Throws `StatusException` if an HTTP error occurs.

---

#### `IObservationsWrapper` Interface

Interface for the Observations wrapper.

**Methods:**

- **`Task<List<Resource>> GetParameterResourcesAsync()`** — See `ObservationsWrapper.GetParameterResourcesAsync` above.
- **`Task<List<Station>> GetStationsBasedOnResourceAsync(Resource resource)`** — See `ObservationsWrapper.GetStationsBasedOnResourceAsync` above.
- **`Task<T> GetResourceDataFromStationAsync<T>(Resource resource, Station station)`** — See `ObservationsWrapper.GetResourceDataFromStationAsync` above.

---

#### `WarningsResult` Class

Represents a single weather warning result from SMHI.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `Id` | `int` | Unique warning identifier |
| `NormalProbability` | `bool` | Whether this represents normal probability conditions |
| `Event` | `Event` | The type of weather event (see `Event` class) |
| `Descriptions` | `List<object>` | List of descriptions |
| `WarningAreas` | `List<WarningArea>` | List of affected warning areas (see `WarningArea` class) |

---

#### `WarningArea` Class

Represents a geographic area affected by a weather warning.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `Id` | `int` | Unique warning area identifier |
| `ApproximateStart` | `DateTime` | When the warning approximately starts |
| `ApproximateEnd` | `DateTime?` | When the warning approximately ends (nullable) |
| `Published` | `DateTime` | When the warning was published |
| `NormalProbability` | `bool` | Whether this represents normal probability conditions |
| `AreaName` | `AreaName` | The name/code of the area |
| `WarningLevel` | `WarningLevel` | The severity level of the warning |
| `EventDescription` | `EventDescription` | Description of the weather event |
| `AffectedAreas` | `List<AffectedArea>` | List of specific affected regions |
| `Descriptions` | `List<Description>` | Detailed descriptions of the warning |
| `Area` | `Area` | Additional area information |

---

#### `AffectedArea` Class

Represents a specific geographic area affected by a warning.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `Id` | `int` | Unique area identifier |
| `Svenska` | `string` | Name of the affected area in Swedish |
| `English` | `string` | Name of the affected area in English |

---

#### `Event` Class

Represents a weather event type.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `Svenska` | `string` | Swedish translation of the event type |
| `English` | `string` | English translation of the event type |
| `Code` | `string` | Event code identifier |
| `MhoClassification` | `MhoClassification` | Meteorological classification of the event |

---

#### `Resource` Class

Represents a measurable parameter/resource in the SMHI observations API.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `Key` | `string` | Unique resource identifier key |
| `Updated` | `object` | When the resource was last updated |
| `Title` | `string` | Human-readable title of the resource |
| `Summary` | `string` | Summary description of the resource |
| `Link` | `List<Link>` | Related links to resource data |
| `Unit` | `string` | Unit of measurement (e.g., "°C", "mm/h") |
| `GeoBox` | `GeoBox` | Geographic bounding box of coverage area |

---

#### `Station` Class

Represents a weather observation station operated by SMHI.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `Key` | `string` | Unique station identifier key |
| `Updated` | `object` | When the station's data was last updated |
| `Title` | `string` | Station title/name |
| `Summary` | `string` | Station description |
| `Link` | `List<Link>` | Related links to station data |
| `Name` | `string` | Station name |
| `Owner` | `string` | Organization that owns the station (e.g., "SMHI", "Swedavia") |
| `OwnerCategory` | `string` | Category of the owner |
| `MeasuringStations` | `string` | Network the station belongs to: `"CORE"` (quality-checked) or `"ADDITIONAL"` (not quality-checked) |
| `Id` | `int` | Numeric station identifier |
| `Height` | `double` | Elevation of the station in meters |
| `Latitude` | `double` | Station latitude coordinate |
| `Longitude` | `double` | Station longitude coordinate |
| `Active` | `bool` | Whether the station is currently active |
| `From` | `object` | Start date of station operations |
| `To` | `object` | End date of station operations (if decommissioned) |

---

#### `Link` Class

Represents a hyperlink to a related resource.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `Href` | `string` | URL of the target resource |
| `Rel` | `string` | Relationship type or media type of the resource |
| `Type` | `string` | XSD type of the target resource |

---

#### `GeoBox` Class

Represents a geographic bounding box defined by latitude and longitude bounds.

**Properties:**

| Property | Type | Description |
|----------|------|-------------|
| `MinLatitude` | `double` | Minimum latitude of the box |
| `MinLongitude` | `double` | Minimum longitude of the box |
| `MaxLatitude` | `double` | Maximum latitude of the box |
| `MaxLongitude` | `double` | Maximum longitude of the box |

---

## Usage Examples

### Arlanda Express: Get Departures

```csharp
using Felsökning.Sverige.ArlandaExpress;

var wrapper = new ArlandaExpressWrapper();

// Retrieve departures from Stockholm
var departures = await wrapper.GetDeparturesAsync(City.Stockholm);

foreach (var departure in departures)
{
    Console.WriteLine($"Departure: {departure.DepartureTime}");
    Console.WriteLine($"  Arrival:  {departure.ArrivalTime}");
    Console.WriteLine($"  Time left: {departure.TimeLeft} minutes");
}
```

### SMHI Warnings: Get Recent Weather Warnings

```csharp
using Felsökning.Sverige.SMHI;

var warningsWrapper = new WarningsWrapper();

// Retrieve recent weather warnings
var warnings = await warningsWrapper.GetRecentWarningsAsync();

foreach (var warning in warnings)
{
    Console.WriteLine($"Warning ID: {warning.Id}");
    Console.WriteLine($"Event: {warning.Event.English} ({warning.Event.Code})");
    
    foreach (var area in warning.WarningAreas)
    {
        Console.WriteLine($"  Affected Area: {area.AreaName}");
        Console.WriteLine($"  Warning Level: {area.WarningLevel}");
        Console.WriteLine($"  Start: {area.ApproximateStart}");
        Console.WriteLine($"  End: {area.ApproximateEnd}");
    }
}
```

### SMHI Observations: Query Weather Station Data

```csharp
using Felsökning.Sverige.SMHI;

var observationsWrapper = new ObservationsWrapper();

// Get available parameters
var parameters = await observationsWrapper.GetParameterResourcesAsync();
var temperatureResource = parameters.First(p => p.Title.Contains("temperature", StringComparison.OrdinalIgnoreCase));

// Get stations that report temperature data
var stations = await observationsWrapper.GetStationsBasedOnResourceAsync(temperatureResource);
var firstStation = stations.First(s => s.Active);

Console.WriteLine($"Station: {firstStation.Name}");
Console.WriteLine($"Location: {firstStation.Latitude}, {firstStation.Longitude}");
Console.WriteLine($"Elevation: {firstStation.Height}m");
Console.WriteLine($"Owner: {firstStation.Owner}");
Console.WriteLine($"Measuring Network: {firstStation.MeasuringStations}");

// Get the latest temperature data from the station
// Note: Specify the correct type for your data; this example is generic
var temperatureData = await observationsWrapper.GetResourceDataFromStationAsync<Temperatures>(
    temperatureResource,
    firstStation
);
```

---

## Error Handling

All async methods may throw the following exceptions:

- **`StatusException`** — Thrown when an HTTP error occurs while communicating with external APIs. Handle this when making API calls:

```csharp
try
{
    var departures = await wrapper.GetDeparturesAsync(City.Arlanda);
}
catch (StatusException ex)
{
    Console.WriteLine($"API Error: {ex.Message}");
}
```

---

## Best Practices

- **Caching:** Consider caching results from API calls to avoid excessive network requests and improve application performance.
- **Error Handling:** Always wrap API calls in try-catch blocks to handle potential network and service errors gracefully.
- **Rate Limiting:** Respect API rate limits by implementing appropriate delays between consecutive requests to the same service.
- **Async/Await:** All wrapper methods are asynchronous (`async`/`await`). Use them with proper async context in your application.

---

## Contributing

Contributions are welcome! Please see the [repository](https://github.com/felsokning/Fels-kning.Sverige) for details.

---

For more information and the latest release notes, visit the [NuGet package page](https://www.nuget.org/packages/Fels%C3%B6kning.Sverige).