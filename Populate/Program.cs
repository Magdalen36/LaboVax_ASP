﻿using System;

namespace Populate
{
    class Program
    {
        static void Main(string[] args)
        {

            //RAJOUTER DES ADRESSES
            //PopulateAdress pa = new PopulateAdress();

            //for (int i = 1; i < 200; i++)
            //{
            //    pa.InsertRandomUser(i);
            //    Console.WriteLine(i);
            //}


            //RAJOUTER DU PERSONNEL
            //PopulatePersonnel pp = new PopulatePersonnel();

            //for (int i = 0; i < 30 ; i++)
            //{
            //    pp.InsertRandomUser();
            //    Console.WriteLine(i);
            //}


            //RAJOUTER DES PATIENTS
            PopulatePatient pp = new PopulatePatient();

            for (int i = 0; i < 100; i++)
            {
                pp.InsertRandomUser();
                Console.WriteLine(i);
            }


        }
    }
}