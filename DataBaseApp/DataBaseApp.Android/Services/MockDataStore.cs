using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

using DataBaseApp.Models;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseApp.Services.MockDataStore))]
namespace DataBaseApp.Services
{
    [Serializable()]
    public class MockDataStore : IDataStore<Patient> //, IDataStore<Remedy>
    {
        public static List<Patient> itemsPatient;
        static string FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "banco.bin");

        public void GetHistorical()
        {

            Stream TestFileStream = File.OpenRead(FileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            itemsPatient = (List<Patient>)deserializer.Deserialize(TestFileStream);
            //Debug.Print(historicals.ToString());
            TestFileStream.Close();
        }

        public static void SaveHistorical()
        {
            Stream TestFileStream = File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, itemsPatient);
            TestFileStream.Close();
        }


        public MockDataStore()
        {
            try
            {
                GetHistorical();
            }
            catch (Exception e)
            {

                //Remedy remedy = new Remedy { Id = Guid.NewGuid().ToString(), HoraIntervalo = "10:00", RemedioNome = "Dorflex" };
                //Remedy remedy1 = new Remedy { Id = Guid.NewGuid().ToString(), HoraIntervalo = "12:00", RemedioNome = "Baby Drax" };
                //Remedy remedy2 = new Remedy { Id = Guid.NewGuid().ToString(), HoraIntervalo = "16:00", RemedioNome = "Bacfar" };

                itemsPatient = new List<Patient>();
                //itemsRemedy = new List<Remedy>();


                var mockItems = new List<Patient>
            {
                new Patient{Id = Guid.NewGuid().ToString(),Nome = "Mauricio",dataNascimento = "21/04/1940", tipoSangue = "A+", Peso = "74",Altura = "1.70" },
                new Patient{Id = Guid.NewGuid().ToString(),Nome = "Felipe",dataNascimento = "21/04/1940", tipoSangue = "A+", Peso = "74",Altura = "1.70"   },
                new Patient{Id = Guid.NewGuid().ToString(),Nome = "Tiago",dataNascimento = "21/04/1940", tipoSangue = "A+", Peso = "74",Altura = "1.70"      },

            };

                foreach (var item in mockItems)
                {
                    itemsPatient.Add(item);
                }
            }
        }

        public async Task<bool> AddItemAsync(Patient item)
        {
            itemsPatient.Add(item);
            SaveHistorical();
            return await Task.FromResult(true);
        }
        
        public async Task<bool> UpdateItemAsync(Patient item)
        {
            var _item = itemsPatient.Where((Patient arg) => arg.Id == item.Id).FirstOrDefault();
            itemsPatient.Remove(_item);
            itemsPatient.Add(item);

            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = itemsPatient.Where((Patient arg) => arg.Id == id).FirstOrDefault();
            itemsPatient.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Patient> GetItemAsync(string id)
        {
            GetHistorical();
            return await Task.FromResult(itemsPatient.FirstOrDefault(s => s.Id == id));
            
        }

        public async Task<IEnumerable<Patient>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(itemsPatient);
        }
        
    }
}