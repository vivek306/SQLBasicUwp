using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleDatabaseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SampleTableService : ISampleTableService
    {
        SampleTableDataContext context;

        public SampleTableService()
        {
            context = new SampleTableDataContext();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<SampleTable> GetSampleData()
        {
            return context.SampleTables.Where(m => m.Id >= 0).ToList();
        }

        public SampleTable InsertSampleData(SampleTable sample)
        {
            context.SampleTables.InsertOnSubmit(sample);

            try
            {
                context.SubmitChanges();
                return sample;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        public SampleTable DeleteSampleData(SampleTable sample)
        {
            context.SampleTables.Attach(sample);
            context.SampleTables.DeleteOnSubmit(sample);

            try
            {
                context.SubmitChanges();
                return sample;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
