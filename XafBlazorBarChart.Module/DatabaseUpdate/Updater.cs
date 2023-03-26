using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using XafBlazorBarChart.Module.BusinessObjects;

namespace XafBlazorBarChart.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        using (var session = ((XPObjectSpace)ObjectSpace).Session)
        {
            // Check if records already exist
            if (Convert.ToInt32(session.Evaluate<SaleInfo>("Count()",null)) == 0)
            {
                // Insert records if they don't exist
                session.ExecuteNonQuery(
                    @"INSERT INTO SaleInfo (Oid, Region, Country, City, Amount, Date)
VALUES
  (NEWID(), 'North', 'USA', 'New York', 100, '2022-01-01'),
  (NEWID(), 'North', 'USA', 'New York', 200, '2022-01-02'),
  (NEWID(), 'North', 'USA', 'Boston', 150, '2022-01-03'),
  (NEWID(), 'North', 'USA', 'Boston', 300, '2022-01-04'),
  (NEWID(), 'North', 'USA', 'Chicago', 250, '2022-01-05'),
  (NEWID(), 'North', 'Canada', 'Toronto', 175, '2022-01-06'),
  (NEWID(), 'North', 'Canada', 'Toronto', 225, '2022-01-07'),
  (NEWID(), 'North', 'Canada', 'Montreal', 275, '2022-01-08'),
  (NEWID(), 'North', 'Canada', 'Montreal', 350, '2022-01-09'),
  (NEWID(), 'North', 'Canada', 'Vancouver', 125, '2022-01-10'),
  (NEWID(), 'South', 'Brazil', 'Rio de Janeiro', 400, '2022-01-11'),
  (NEWID(), 'South', 'Brazil', 'Rio de Janeiro', 500, '2022-01-12'),
  (NEWID(), 'South', 'Brazil', 'Sao Paulo', 450, '2022-01-13'),
  (NEWID(), 'South', 'Brazil', 'Sao Paulo', 550, '2022-01-14'),
  (NEWID(), 'South', 'Argentina', 'Buenos Aires', 350, '2022-01-15'),
  (NEWID(), 'South', 'Argentina', 'Buenos Aires', 250, '2022-01-16'),
  (NEWID(), 'South', 'Argentina', 'Cordoba', 150, '2022-01-17'),
  (NEWID(), 'South', 'Argentina', 'Cordoba', 200, '2022-01-18'),
  (NEWID(), 'South', 'Chile', 'Santiago', 300, '2022-01-19'),
  (NEWID(), 'South', 'Chile', 'Santiago', 250, '2022-01-20'),
  (NEWID(), 'East', 'China', 'Beijing', 200, '2022-01-21'),
  (NEWID(), 'East', 'China', 'Beijing', 300, '2022-01-22'),
  (NEWID(), 'East', 'China', 'Shanghai', 250, '2022-01-23'),
  (NEWID(), 'East', 'China', 'Shanghai', 400, '2022-01-24'),
  (NEWID(), 'East', 'China', 'Hong Kong', 350, '2022-01-25'),
  (NEWID(), 'East', 'Japan', 'Tokyo', 150, '2022-01-26'),
  (NEWID(), 'East', 'Japan', 'Tokyo', 250, '2022-01-27'),
   (NEWID(), 'East', 'Japan', 'Osaka', 400, '2022-01-29'),
  (NEWID(), 'East', 'Korea', 'Seoul', 250, '2022-01-30'),
  (NEWID(), 'East', 'Korea', 'Seoul', 350, '2022-01-31'),
  (NEWID(), 'East', 'Korea', 'Busan', 450, '2022-02-01'),
  (NEWID(), 'East', 'Korea', 'Busan', 550, '2022-02-02'),
  (NEWID(), 'West', 'USA', 'San Francisco', 350, '2022-02-03'),
  (NEWID(), 'West', 'USA', 'San Francisco', 450, '2022-02-04'),
  (NEWID(), 'West', 'USA', 'Los Angeles', 550, '2022-02-05'),
  (NEWID(), 'West', 'USA', 'Los Angeles', 650, '2022-02-06'),
  (NEWID(), 'West', 'USA', 'Seattle', 250, '2022-02-07'),
  (NEWID(), 'West', 'Canada', 'Vancouver', 300, '2022-02-08'),
  (NEWID(), 'West', 'Canada', 'Vancouver', 400, '2022-02-09'),
  (NEWID(), 'West', 'Canada', 'Calgary', 450, '2022-02-10'),
  (NEWID(), 'West', 'Canada', 'Calgary', 550, '2022-02-11'),
  (NEWID(), 'West', 'Mexico', 'Mexico City', 650, '2022-02-12'),
  (NEWID(), 'West', 'Mexico', 'Mexico City', 750, '2022-02-13'),
  (NEWID(), 'West', 'Mexico', 'Guadalajara', 350, '2022-02-14'),
  (NEWID(), 'West', 'Mexico', 'Guadalajara', 450, '2022-02-15'),
  (NEWID(), 'West', 'Mexico', 'Monterrey', 550, '2022-02-16'),
  (NEWID(), 'West', 'Mexico', 'Monterrey', 650, '2022-02-17'),
  (NEWID(), 'Central', 'Brazil', 'Brasilia', 250, '2022-02-18'),
  (NEWID(), 'Central', 'Brazil', 'Brasilia', 350, '2022-02-19'),
  (NEWID(), 'Central', 'Brazil', 'Salvador', 450, '2022-02-20'),
  (NEWID(), 'Central', 'Brazil', 'Salvador', 550, '2022-02-21'),
  (NEWID(), 'Central', 'Argentina', 'Mendoza', 650, '2022-02-22'),
  (NEWID(), 'Central', 'Argentina', 'Mendoza', 750, '2022-02-23'),
  (NEWID(), 'Central', 'Argentina', 'Rosario', 350, '2022-02-24')"
);
            }
        }
    }
    public override void UpdateDatabaseBeforeUpdateSchema() {
        base.UpdateDatabaseBeforeUpdateSchema();
        //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
        //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
        //}
    }
}
