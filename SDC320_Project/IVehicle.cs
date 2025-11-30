/*
 * Developer: Ayana Aiken
 * Date: November 30 2025
 * Assignment: SDC320 Course Project – Class Implementation
 * Description:
 *   Interface defining core behaviors for all vehicle types.
 */

public interface IVehicle
{
    string GetMake();
    string GetModel();
    void Start();
    void Stop();
    void Drive(string destination);
}
