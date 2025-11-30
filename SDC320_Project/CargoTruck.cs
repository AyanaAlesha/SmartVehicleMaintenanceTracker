/*
 * Developer: Ayana Aiken
 * Date: November 30, 2025
 * Assignment: SDC320 Course Project – Class Implementation
 * Description:
 *   CargoTruck class implementing the Vehicle interface.
 *   Includes additional CargoCapacity property.
 */

public class CargoTruck : IVehicle
{
    public string m_make { get; set; }
    public string m_model { get; set; }
    public bool m_running { get; set; }
    public string m_destination { get; set; }

    public string CargoCapacity { get; set; }

    public CargoTruck(string make, string model, string cargoCapacity)
    {
        m_make = make;
        m_model = model;
        CargoCapacity = cargoCapacity;

        m_running = false;
        m_destination = "Nowhere yet";
    }

    public string GetMake() => m_make;
    public string GetModel() => m_model;

    public void Start() => m_running = true;
    public void Stop() => m_running = false;

    public void Drive(string destination)
    {
        m_destination = destination;
        m_running = true;
    }

    public override string ToString()
    {
        string runningStatus = m_running ? "running" : "not running";

        return $"Vehicle Type: Cargo Truck\n" +
               $"Make: {m_make}\n" +
               $"Model: {m_model}\n" +
               $"Cargo Capacity: {CargoCapacity}\n" +
               $"The truck is {runningStatus} and hauling {CargoCapacity} of cargo to {m_destination}.";
    }
}
