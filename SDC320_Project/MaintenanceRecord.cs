/*
 * Developer: Ayana Aiken
 * Date:November 30, 2025
 * Assignment: SDC320 Course Project – Class Implementation
 * Description:
 *   Represents a single maintenance entry for a vehicle.
 *   Will be stored in the SQLite database (Week 4).
 */

public class MaintenanceRecord
{
    public int RecordID { get; set; }          // DB-generated
    public int VehicleID { get; set; }         // Foreign Key
    public string ServiceType { get; set; }
    public DateTime ServiceDate { get; set; }
    public int Mileage { get; set; }
    public decimal Cost { get; set; }

    public MaintenanceRecord(int vehicleID, string serviceType, DateTime date, int mileage, decimal cost)
    {
        VehicleID = vehicleID;
        ServiceType = serviceType;
        ServiceDate = date;
        Mileage = mileage;
        Cost = cost;
    }

    public override string ToString()
    {
        return $"Maintenance Record:\n" +
               $"Service Type: {ServiceType}\n" +
               $"Date: {ServiceDate.ToShortDateString()}\n" +
               $"Mileage: {Mileage}\n" +
               $"Cost: ${Cost}";
    }
}
