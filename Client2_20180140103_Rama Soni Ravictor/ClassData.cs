﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Client2_20180140103_Rama_Soni_Ravictor.Form1;

namespace Client2_20180140103_Rama_Soni_Ravictor
{
    class ClassData
    {
        string baseUrl = "http://localhost:1907/";

        public Mahasiswa search(string nim)
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa/" + nim);
            var data = JsonConvert.DeserializeObject<Mahasiswa>(json);
            return data;
        }


        public List<Mahasiswa> getAllData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            return data;
        }

        public bool updateDatabase(Mahasiswa mhs)
        {
            bool updated = false;
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("UpdateMahasiswaByNIM", Method.PUT);
                request.AddJsonBody(mhs);
                client.Execute(request);
            }
            catch (Exception ex)
            {

            }
            return updated;
        }

        public bool deleteMahasiswa(string nim)
        {
            bool deleted = false;
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("DeleteMahasiswa/" + nim, Method.DELETE);
                client.Execute(request);
            }
            catch (Exception ex)
            {

            }
            return deleted;
        }
    }
}
