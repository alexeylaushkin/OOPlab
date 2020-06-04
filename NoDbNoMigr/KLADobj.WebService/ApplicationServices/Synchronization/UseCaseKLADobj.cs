using System;
using System.Collections.Generic;
using System.Net;
using KLADobj.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

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

        public string Address { get; set; }

        public string ChillType { get; set; }

        public string Free { get; set; }
    }


    public class UseCaseKLADobj
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/607/rows?api_key=8bfc7826622256c9ca5832eed51e81bb";

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


            for (int i = 0; i < kladobj_cells.Count; i++)
            {
                kladobjs.Add(new kladobj()
                {
                    Name = kladobj_cells[i].Cells.Name,
                    Id = kladobj_cells[i].Number,
                    Address = kladobj_cells[i].Cells.Address,
                    ChillType = kladobj_cells[i].Cells.ChillType,
                    Free = kladobj_cells[i].Cells.Free
                });
            }
        }

    }
}