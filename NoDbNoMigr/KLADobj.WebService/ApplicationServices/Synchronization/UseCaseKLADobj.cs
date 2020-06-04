using System;
using System.Collections.Generic;
using System.Net;
using KLADobj.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using KLADobj.InfrastructureServices.Gateways.Database;

namespace KLADobj.ApplicationServices.Synchronization
{
    public class KLADobj_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public KLADobj_inf Cells { get; set; }   
    }

    public class KLADobj_inf
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string PaidService { get; set; }

        public string CloseFlag { get; set; }
    }

    public class UseCaseKLADobj
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/842/rows?api_key=7eae4d11264f948688a3da27d8cdfc9c";

        string path = @".\update_database\kladobj-";
        
        List<KLADobj_Cell> kladobj_cells;

        public List<kladobj> kladobjs = new List<kladobj>();

        public UseCaseKLADobj()
        {
            
            WebRequest request = WebRequest.Create(remoteUri);
            WebResponse response = request.GetResponse();
           
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();
            
            JArray jsonArray = JArray.Parse(line);
            
            kladobj_cells = JsonConvert.DeserializeObject<List<KLADobj_Cell>>(jsonArray.ToString());
         
            DateTime Date_update = DateTime.Now;
            string date_update = Date_update.ToShortDateString();

            path = path + date_update + @".json";
            
            using (FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate))
            {
                
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                
                string text = "[";
                byte[] input = Encoding.Default.GetBytes(text);
               
                fs2.Write(input, 0, input.Length);
                text = ",";

                for (int i = 0; i < kladobj_cells.Count; i++)
                {
                    kladobjs.Add(new kladobj()
                    {
                        Name = kladobj_cells[i].Cells.Name,
                        Id = kladobj_cells[i].Number,
                        Location = kladobj_cells[i].Cells.Location,
                        PaidService = kladobj_cells[i].Cells.PaidService,
                        CloseFlag = kladobj_cells[i].Cells.CloseFlag
                    });

                    System.Text.Json.JsonSerializer.SerializeAsync<kladobj>(fs2, kladobjs[i], options).GetAwaiter().GetResult();

                    if (i != kladobj_cells.Count - 1)
                    {
                        input = Encoding.Default.GetBytes(text);
                        fs2.Write(input, 0, input.Length);
                    }
                }

                text = "]";
                input = Encoding.Default.GetBytes(text);
                fs2.Write(input, 0, input.Length);
            }   
        }
    }
}

